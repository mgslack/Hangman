using System;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/*
 * Defines the partial class of the game start (word choice) dialog for the
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
    public partial class StartGameDlg : Form
    {
        #region Properties
        private SoundPlayer _beep = null;
        public SoundPlayer Beep { set { _beep = value; } }

        private bool _haveWordList = false;
        public bool HaveWordList { set { _haveWordList = value; } }

        private bool _useWordList = false;
        public bool UseWordList { get { return _useWordList; } }

        private string _wordToUse = "";
        public string WordToUse { get { return _wordToUse; } }
        #endregion

        public StartGameDlg()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void StartGameDlg_Load(object sender, EventArgs e)
        {
            if (!_haveWordList)
            {
                cbUseWL.Enabled = false; cbUseWL.Checked = false;
                tbWordToUse.Focus();
            }
            else
            {
                cbUseWL.Checked = true; btnOK.Focus();
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!cbUseWL.Checked)
            {
                string tt = tbWordToUse.Text.Trim();  // textbox casing is set to all upper...
                bool ff = false;

                if (!Regex.IsMatch(tt, @"^[A-Z]+$")) ff = true;
                if ("".Equals(tt) || tt.Length < 4 || ff)
                {
                    if (_beep != null) _beep.PlaySync();
                    MessageBox.Show(this, "Invalid word entered!", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                    tbWordToUse.Focus();
                }
                else
                {
                    _wordToUse = tt;
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                _wordToUse = "";
                DialogResult = DialogResult.OK;
            }
        }

        private void CbUseWL_CheckedChanged(object sender, EventArgs e)
        {
            _useWordList = cbUseWL.Checked;
        }
        #endregion
    }
}
