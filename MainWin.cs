using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Reflection;
using System.IO;
using System.Media;
using System.Diagnostics;
using GameStatistics;

/*
 * Primary class defines the partial class for the main window of the game
 * of Hangman (classic guess the word game).
 * 
 * Game was originally written for OS/2 using Speedsoft Sybil on 1998-02-21.
 * Converted to .net C# for Windows and completed on 2021-11-04.
 * 
 * Author: Michael G. Slack
 * Written: 2021-11-03
 * Version: 1.0.0.1
 * 
 * ----------------------------------------------------------------------------
 * 
 * Updated: 2022-03-10 - Slight update to some option dialog event handlers.
 * 
 */
namespace Hangman
{
    public partial class MainWin : Form
    {
        #region Constants
        private const string HTML_HELP_FILE = "Hangman_help.html";

        private const string SOUND_NAMESPACE = "Hangman.sounds.";
        private const string SOUND_APPLAUSE = "applause.wav";
        private const string SOUND_BEEP = "beep.wav";
        private const string SOUND_CORRECT = "correct.wav";
        private const string SOUND_SWINGING = "swinging.wav";
        private const string SOUND_WRONG = "wrong.wav";

        private const string REG_NAME = @"HKEY_CURRENT_USER\Software\Slack and Associates\Games\Hangman";
        private const string REG_KEY1 = "PosX";
        private const string REG_KEY2 = "PosY";
        private const string REG_KEY3 = "Wordlist";
        private const string REG_KEY4 = "PromptsOn";
        private const string REG_KEY5 = "SoundsOn";
        private const string REG_KEY6 = "NumB4Draw"; // difficulty setting (1, +2 or +3)

        private const string DEF_WORDLIST_FN = "hm_words.txt";
        private const string DEF_USED_LETS = "                          ";
        private const int MAX_WORD_LEN = 20;
        private const int MIN_WORD_COUNT = 10;
        #endregion

        #region Private Variables
        private List<string> FWordList = new List<string>();
        private string WordListFN = "", HiddenWord = "";
        private bool PromptsOn = false, SoundsOn = false, NewWordFlg = false;
        private int NumB4Draw = 1, B4_Draw = 0, NumGuessed = 0, NumMissed = 0, CurPicNum = 0;
        private Statistics stats = new Statistics(REG_NAME);
        #endregion

        #region Sound Player Instances
        private SoundPlayer applauseSound = null;
        private bool aSoundLoaded = false;
        private SoundPlayer beepSound = null;
        private bool bSoundLoaded = false;
        private SoundPlayer correctSound = null;
        private bool cSoundLoaded = false;
        private SoundPlayer swingingSound = null;
        private bool sSoundLoaded = false;
        private SoundPlayer wrongSound = null;
        private bool wSoundLoaded = false;
        #endregion

        #region Gallow Picture Enum
        // picture order is i_Empty, i_WHead, i_WBody, i_W1Arm, i_WBothArm, i_W1Leg, i_Hung
        // order in enum is order in imagelist of pictures (match enum int value for IL index)
        public enum GallowPict { i_Empty, i_Hung, i_W1Arm, i_W1Leg, i_WBody, i_WBothArm, i_WHead };
        #endregion

        // --------------------------------------------------------------------

        public MainWin()
        {
            InitializeComponent();
        }

        // --------------------------------------------------------------------

        #region Private Methods
        private void LoadRegistryValues()
        {
            int winX = -1, winY = -1, chk;

            try
            {
                winX = (int)Registry.GetValue(REG_NAME, REG_KEY1, winX);
                winY = (int)Registry.GetValue(REG_NAME, REG_KEY2, winY);
                WordListFN = (string)Registry.GetValue(REG_NAME, REG_KEY3, DEF_WORDLIST_FN);
                if (DEF_WORDLIST_FN.Equals(WordListFN))
                {
                    var asm = Assembly.GetEntryAssembly();
                    var asmLocation = Path.GetDirectoryName(asm.Location);
                    WordListFN = Path.Combine(asmLocation, DEF_WORDLIST_FN);
                }
                chk = (int)Registry.GetValue(REG_NAME, REG_KEY4, 0);  // def = false
                PromptsOn = chk > 0;
                chk = (int)Registry.GetValue(REG_NAME, REG_KEY5, 0);  // def = false
                SoundsOn = chk > 0;
                NumB4Draw = (int)Registry.GetValue(REG_NAME, REG_KEY6, 1);  // def = 1
            }
            catch (Exception) { /* ignore, go with defaults, but could use MessageBox.Show(e.Message); */ }

            if ((winX != -1) && (winY != -1)) this.SetDesktopLocation(winX, winY);
        }

        private void WriteRegistryValues()
        {
            Registry.SetValue(REG_NAME, REG_KEY3, WordListFN, RegistryValueKind.String);
            Registry.SetValue(REG_NAME, REG_KEY4, PromptsOn, RegistryValueKind.DWord);
            Registry.SetValue(REG_NAME, REG_KEY5, SoundsOn, RegistryValueKind.DWord);
            Registry.SetValue(REG_NAME, REG_KEY6, NumB4Draw, RegistryValueKind.DWord);
        }

        private void SetupContextMenu()
        {
            ContextMenu mnu = new ContextMenu();
            MenuItem mnuStats = new MenuItem("Game Statistics");
            MenuItem sep = new MenuItem("-");
            MenuItem mnuHelp = new MenuItem("Help");
            MenuItem mnuAbout = new MenuItem("About");

            mnuStats.Click += new EventHandler(MnuStats_Click);
            mnuHelp.Click += new EventHandler(MnuHelp_Click);
            mnuAbout.Click += new EventHandler(MnuAbout_Click);
            mnu.MenuItems.AddRange(new MenuItem[] { mnuStats, sep, mnuHelp, mnuAbout });
            this.ContextMenu = mnu;
        }

        private Stream GetResourceStream(string path)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            return asm.GetManifestResourceStream(path);
        }

        private void LoadSoundPlayers()
        {
            string path = SOUND_NAMESPACE + SOUND_APPLAUSE;

            try
            {
                applauseSound = new SoundPlayer(GetResourceStream(path));
                aSoundLoaded = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Wav (" + path + "): " + e.Message, this.Text);
                applauseSound = null;
            }

            path = SOUND_NAMESPACE + SOUND_BEEP;
            try
            {
                beepSound = new SoundPlayer(GetResourceStream(path));
                bSoundLoaded = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Wav (" + path + "): " + e.Message, this.Text);
                beepSound = null;
            }

            path = SOUND_NAMESPACE + SOUND_CORRECT;
            try
            {
                correctSound = new SoundPlayer(GetResourceStream(path));
                cSoundLoaded = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Wav (" + path + "): " + e.Message, this.Text);
                correctSound = null;
            }

            path = SOUND_NAMESPACE + SOUND_SWINGING;
            try
            {
                swingingSound = new SoundPlayer(GetResourceStream(path));
                sSoundLoaded = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Wav (" + path + "): " + e.Message, this.Text);
                swingingSound = null;
            }

            path = SOUND_NAMESPACE + SOUND_WRONG;
            try
            {
                wrongSound = new SoundPlayer(GetResourceStream(path));
                wSoundLoaded = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Wav (" + path + "): " + e.Message, this.Text);
                wrongSound = null;
            }
        }

        private void LoadWordList()
        {
            FWordList.Clear();

            if (File.Exists(WordListFN))
            {
                // note: file needs to contain at least 10 words or list will not be used
                string[] lines = File.ReadAllLines(WordListFN);

                foreach (string line in lines)
                {
                    string tt = line.ToUpper().Trim();
                    int len = tt.Length;

                    if (len >= 4)
                    {
                        if (len > MAX_WORD_LEN) tt = tt.Substring(0, MAX_WORD_LEN);
                        if (!FWordList.Contains(tt)) FWordList.Add(tt);
                    }
                }
            }
        }

        private bool GetWordToUse()
        {
            bool ret;
            StartGameDlg dlg = new StartGameDlg();

            dlg.HaveWordList = FWordList.Count >= MIN_WORD_COUNT;
            if (SoundsOn && bSoundLoaded) dlg.Beep = beepSound;
            DialogResult res = dlg.ShowDialog(this);
            ret = (res == DialogResult.OK);
            if (ret)
            {
                if (dlg.UseWordList)
                {
                    int idx = SingleRandom.Instance.Next(FWordList.Count);
                    HiddenWord = FWordList[idx];
                }
                else
                {
                    HiddenWord = dlg.WordToUse;
                }
            }
            dlg.Dispose();

            return ret;
        }

        private bool CheckLetter(string lStr)
        {
            bool ret = false;
            char ltr = lStr[0];
            char[] chk = HiddenWord.ToCharArray();
            char[] gWord = lblWordToGuess.Text.ToCharArray();

            for (int i = 0; i < HiddenWord.Length; i++)
            { // check each letter, change in display from '_'
                if (ltr == chk[i])
                {
                    ret = true; gWord[i] = ltr;
                }
            }
            if (ret) lblWordToGuess.Text = new string(gWord);

            return ret;
        }

        private void ShowNextPic()
        {
            CurPicNum++;
            switch (CurPicNum)
            {
                case 1: pbGallow.Image = IL_Gallows.Images[(int)GallowPict.i_WHead];
                    break;
                case 2: pbGallow.Image = IL_Gallows.Images[(int)GallowPict.i_WBody];
                    break;
                case 3: pbGallow.Image = IL_Gallows.Images[(int)GallowPict.i_W1Arm];
                    break;
                case 4: pbGallow.Image = IL_Gallows.Images[(int)GallowPict.i_WBothArm];
                    break;
                case 5: pbGallow.Image = IL_Gallows.Images[(int)GallowPict.i_W1Leg];
                    break;
                case 6: pbGallow.Image = IL_Gallows.Images[(int)GallowPict.i_Hung];
                    break;
                default:
                    break;
            }
        }

        private void CheckDone(bool goodGuess, int guessType)
        {
            bool doneF = false;
            string tt = "";

            if (!goodGuess)
            {
                B4_Draw++;
                if (B4_Draw >= NumB4Draw)
                {
                    B4_Draw = 0;
                    ShowNextPic();
                }
                if (guessType == 1)
                    tt = "Not a letter in the word, try again.";
                else
                    tt = "Not the word, try again.";
                if (CurPicNum >= 6)
                {
                    tt = "Whoops, you are now swinging in the wind.";
                    doneF = true; NumMissed++;
                    lblWordToGuess.Text = HiddenWord;
                    stats.GameLost(0);
                }
            }
            else
            {
                if (HiddenWord.Equals(lblWordToGuess.Text))
                {
                    tt = "You've guessed the word!";
                    doneF = true; NumGuessed++;
                    stats.GameWon(0);
                }
                else
                {
                    tt = "Good letter, guess again.";
                }
            }
            if (SoundsOn)
            {
                if (doneF)
                {
                    if (goodGuess && aSoundLoaded)
                        applauseSound.Play();
                    else if (!goodGuess && sSoundLoaded)
                        swingingSound.Play();
                }
                else
                {
                    if (goodGuess && cSoundLoaded)
                        correctSound.Play();
                    else if (!goodGuess && wSoundLoaded)
                        wrongSound.Play();
                }
            }
            lblNumWordsGuessed.Text = "" + NumGuessed;
            lblNumWordsMissed.Text = "" + NumMissed;
            MessageBox.Show(this, tt, this.Text, MessageBoxButtons.OK, MessageBoxIcon.None);
            if (doneF)
            {
                btnStart.Focus();
                btnGuess.Enabled = false;
            }
        }
        #endregion

        // --------------------------------------------------------------------

        #region Event Handlers
        private void MainWin_Load(object sender, EventArgs e)
        {
            LoadRegistryValues();
            SetupContextMenu();
            LoadSoundPlayers();
            LoadWordList();
            pbGallow.Image = IL_Gallows.Images[(int)GallowPict.i_Empty];
            stats.GameName = this.Text;
        }

        private void MainWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PromptsOn)
            {
                if (SoundsOn && bSoundLoaded) beepSound.PlaySync();
                DialogResult res = MessageBox.Show(this, "Really quit?", this.Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (res == DialogResult.No) e.Cancel = true;
            }
        }

        private void MainWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Registry.SetValue(REG_NAME, REG_KEY1, this.Location.X);
                Registry.SetValue(REG_NAME, REG_KEY2, this.Location.Y);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.Yes;

            if (NewWordFlg && PromptsOn)
            {
                if (bSoundLoaded && SoundsOn) beepSound.PlaySync();
                res = MessageBox.Show(this, "Guess another word?", this.Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.None);
            }
            if (res == DialogResult.Yes && GetWordToUse())
            {
                string tt = "";

                pbGallow.Image = IL_Gallows.Images[(int)GallowPict.i_Empty];
                CurPicNum = 0; B4_Draw = 0;
                for (int i = 0; i < HiddenWord.Length; i++)
                {
                    tt += "-";
                }
                lblWordToGuess.Text = tt; lblUsedLetters.Text = DEF_USED_LETS;
                stats.StartGame(NewWordFlg);
                btnStart.Text = "&New"; NewWordFlg = true;
                btnGuess.Enabled = true; btnGuess.Focus();
            }
        }

        private void BtnGuess_Click(object sender, EventArgs e)
        {
            string t1 = "", t2 = "";
            bool ff = false;
            int typ = 1;
            GuessDlg dlg = new GuessDlg();

            dlg.UsedLetters = lblUsedLetters.Text;
            if (SoundsOn && bSoundLoaded) dlg.Beep = beepSound;
            DialogResult res = dlg.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                t1 = dlg.GuessLetter; t2 = dlg.GuessWord;
                lblUsedLetters.Text = dlg.UsedLetters;
            }
            dlg.Dispose();

            if (res == DialogResult.OK)
            {
                if (!"".Equals(t1))
                {
                    ff = CheckLetter(t1);
                }
                else
                {
                    typ = 2; ff = (HiddenWord.Equals(t2));
                    if (ff) lblWordToGuess.Text = t2;
                }
                CheckDone(ff, typ);
            }
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            OptionsDlg dlg = new OptionsDlg
            {
                Prompts = PromptsOn,
                Sounds = SoundsOn,
                Difficulty = NumB4Draw,
                WordListFN = WordListFN
            };

            if (SoundsOn && bSoundLoaded) dlg.Beep = beepSound;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                PromptsOn = dlg.Prompts;
                SoundsOn = dlg.Sounds;
                NumB4Draw = dlg.Difficulty;
                if (!WordListFN.Equals(dlg.WordListFN))
                { // reload word list file with new selected file
                    WordListFN = dlg.WordListFN;
                    LoadWordList();
                }
                WriteRegistryValues();
            }
            dlg.Dispose();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MnuStats_Click(object sender, EventArgs e)
        {
            stats.ShowStatistics(this);
        }

        private void MnuHelp_Click(object sender, EventArgs e)
        {
            var asm = Assembly.GetEntryAssembly();
            var asmLocation = Path.GetDirectoryName(asm.Location);
            var htmlPath = Path.Combine(asmLocation, HTML_HELP_FILE);

            try
            {
                Process.Start(htmlPath);
            }
            catch (Exception ex)
            {
                if (SoundsOn && bSoundLoaded) beepSound.PlaySync();
                MessageBox.Show(this, "Cannot load help: " + ex.Message, "Hangman: Help Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();

            about.ShowDialog(this);
            about.Dispose();
        }
        #endregion
    }
}
