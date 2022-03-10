using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

/*
 * Defines the partial class of the options (settings) dialog for the
 * Hangman game.
 * 
 * Author:  M. G. Slack
 * Written: 2021-11-04
 *
 * ----------------------------------------------------------------------------
 * 
 * Updated: yyyy-mm-dd - xxxxx.
 * 
 */
namespace Hangman
{
    public partial class OptionsDlg : Form
    {
        #region Properties
        private SoundPlayer _beep = null;
        public SoundPlayer Beep { set { _beep = value; } }

        private bool _prompts = false;
        public bool Prompts { get { return _prompts; } set { _prompts = value; } }

        private bool _sounds = false;
        public bool Sounds { get { return _sounds; } set { _sounds = value; } }

        private int _difficulty = 1;
        public int Difficulty { get { return _difficulty; } set { _difficulty = value; } }

        private string _wordListFN = "";
        public string WordListFN { get { return _wordListFN; } set { _wordListFN = value; } }
        #endregion

        public OptionsDlg()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void OptionsDlg_Load(object sender, EventArgs e)
        {
            cbPrompts.Checked = _prompts;
            cbSounds.Checked = _sounds;
            if (_difficulty == 2)
                rbEasy.Checked = true;
            else if (_difficulty == 3)
                rbEasiest.Checked = true;
            else
                rbNormal.Checked = true;
            tbWLFile.Text = _wordListFN;
        }

        private void CbPrompts_CheckedChanged(object sender, EventArgs e)
        {
            _prompts = cbPrompts.Checked;
        }

        private void CbSounds_CheckedChanged(object sender, EventArgs e)
        {
            _sounds = cbSounds.Checked;
        }

        private void RbNormal_CheckedChanged(object sender, EventArgs e)
        {
            _difficulty = 1;
        }

        private void RbEasy_CheckedChanged(object sender, EventArgs e)
        {
            _difficulty = 2;
        }

        private void RbEasiest_CheckedChanged(object sender, EventArgs e)
        {
            _difficulty = 3;
        }

        private void BtnSelFN_Click(object sender, EventArgs e)
        {
            if (!"".Equals(_wordListFN))
            {
                // openFileDlg.InitialDirectory = Path.GetDirectoryName(_wordListFN);
                // openFileDlg.FileName = Path.GetFileName(_wordListFN);
                openFileDlg.FileName = _wordListFN;
            }
            if (openFileDlg.ShowDialog(this) == DialogResult.OK)
            {
                _wordListFN = openFileDlg.FileName;
                tbWLFile.Text = _wordListFN;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!_wordListFN.Equals(tbWLFile.Text))
            {
                if (!File.Exists(tbWLFile.Text))
                {
                    if (_beep != null) _beep.PlaySync();
                    MessageBox.Show(this, "File entered does not exist. Please select a valid file.",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.None);
                    tbWLFile.Focus();
                }
                else
                {
                    _wordListFN = tbWLFile.Text;
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
        #endregion
    }
}
