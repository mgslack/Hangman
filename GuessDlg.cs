using System;
using System.Media;
using System.Windows.Forms;

/*
 * Defines the partial class of the game guess (letter or word) dialog for the
 * Hangman game.
 * 
 * Author:  M. G. Slack
 * Written: 2021-11-03
 *
 * ----------------------------------------------------------------------------
 * 
 * Updated: yyyy-mm-dd - xxxxx.
 * 
 */
namespace Hangman
{
    public partial class GuessDlg : Form
    {
        #region Properties
        private SoundPlayer _beep = null;
        public SoundPlayer Beep { set { _beep = value; } }

        private string _usedLetters = "";
        public string UsedLetters { get { return _usedLetters; } set { _usedLetters = value; } }

        private string _guessLetter = "";
        public string GuessLetter { get { return _guessLetter; } }

        private string _guessWord = "";
        public string GuessWord { get { return _guessWord; } }
        #endregion

        public GuessDlg()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void GuessDlg_Load(object sender, EventArgs e)
        {
            tbLetter.Focus();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string t1 = tbLetter.Text.Trim();
            string t2 = tbWord.Text.Trim();
            bool ff = false;

            if ("".Equals(t1) && "".Equals(t2))
            {
                ff = true;
                if (_beep != null) _beep.PlaySync();
                MessageBox.Show(this, "Need to enter a guess (letter or word).", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                tbLetter.Focus();
            }
            else if (!"".Equals(t1) && !"".Equals(t2))
            {
                ff = true;
                if (_beep != null) _beep.PlaySync();
                MessageBox.Show(this, "Can only guess letter or word, not both.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                tbLetter.Focus();
            }
            else if (!"".Equals(t1))
            {
                char ltr = t1[0];
                int idx = (int)ltr - (int)'A';

                if (idx >= 0 && idx < 26 && ' ' != _usedLetters[idx])
                {
                    ff = true;
                    if (_beep != null) _beep.PlaySync();
                    MessageBox.Show(this, "Letter guessed already used or not valid, try again.",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
                    tbLetter.Focus();
                }
                else
                {
                    if (idx >= 0 && idx < 26)
                    {
                        char[] tempArr = _usedLetters.ToCharArray();
                        tempArr[idx] = ltr;
                        _usedLetters = new string(tempArr);
                    }
                }
            }
            if (!ff)
            {
                _guessLetter = t1;
                _guessWord = t2;
                DialogResult = DialogResult.OK;
            }
        }

        private void TbLetter_TextChanged(object sender, EventArgs e)
        {
            // set focus on ok button since entered 'char'
            if (tbLetter.Text.Length == 1) btnOK.Focus();
        }
        #endregion
    }
}
