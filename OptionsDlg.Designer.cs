
namespace Hangman
{
    partial class OptionsDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbPrompts = new System.Windows.Forms.CheckBox();
            this.cbSounds = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWLFile = new System.Windows.Forms.TextBox();
            this.btnSelFN = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ttBtnFileSel = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.gbDifficulty = new System.Windows.Forms.GroupBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbEasiest = new System.Windows.Forms.RadioButton();
            this.gbDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPrompts
            // 
            this.cbPrompts.AutoSize = true;
            this.cbPrompts.Location = new System.Drawing.Point(12, 12);
            this.cbPrompts.Name = "cbPrompts";
            this.cbPrompts.Size = new System.Drawing.Size(81, 17);
            this.cbPrompts.TabIndex = 2;
            this.cbPrompts.Text = "&Prompts On";
            this.cbPrompts.UseVisualStyleBackColor = true;
            this.cbPrompts.CheckedChanged += new System.EventHandler(this.CbPrompts_CheckedChanged);
            // 
            // cbSounds
            // 
            this.cbSounds.AutoSize = true;
            this.cbSounds.Location = new System.Drawing.Point(12, 35);
            this.cbSounds.Name = "cbSounds";
            this.cbSounds.Size = new System.Drawing.Size(79, 17);
            this.cbSounds.TabIndex = 3;
            this.cbSounds.Text = "&Sounds On";
            this.cbSounds.UseVisualStyleBackColor = true;
            this.cbSounds.CheckedChanged += new System.EventHandler(this.CbSounds_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Word List Filename:";
            // 
            // tbWLFile
            // 
            this.tbWLFile.Location = new System.Drawing.Point(12, 71);
            this.tbWLFile.Name = "tbWLFile";
            this.tbWLFile.Size = new System.Drawing.Size(379, 20);
            this.tbWLFile.TabIndex = 5;
            // 
            // btnSelFN
            // 
            this.btnSelFN.Location = new System.Drawing.Point(392, 69);
            this.btnSelFN.Name = "btnSelFN";
            this.btnSelFN.Size = new System.Drawing.Size(27, 23);
            this.btnSelFN.TabIndex = 6;
            this.btnSelFN.Text = "...";
            this.ttBtnFileSel.SetToolTip(this.btnSelFN, "Select Word List File");
            this.btnSelFN.UseVisualStyleBackColor = true;
            this.btnSelFN.Click += new System.EventHandler(this.BtnSelFN_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(37, 148);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(118, 148);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ttBtnFileSel
            // 
            this.ttBtnFileSel.IsBalloon = true;
            // 
            // openFileDlg
            // 
            this.openFileDlg.AddExtension = false;
            this.openFileDlg.DefaultExt = "txt";
            this.openFileDlg.Filter = "Text Files (*.txt)|*.txt|Any File (*.*)|*.*";
            this.openFileDlg.Title = "Hangman: Select Word List File";
            // 
            // gbDifficulty
            // 
            this.gbDifficulty.Controls.Add(this.rbEasiest);
            this.gbDifficulty.Controls.Add(this.rbEasy);
            this.gbDifficulty.Controls.Add(this.rbNormal);
            this.gbDifficulty.Location = new System.Drawing.Point(12, 97);
            this.gbDifficulty.Name = "gbDifficulty";
            this.gbDifficulty.Size = new System.Drawing.Size(192, 44);
            this.gbDifficulty.TabIndex = 7;
            this.gbDifficulty.TabStop = false;
            this.gbDifficulty.Text = "Difficulty:";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(6, 17);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "&Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.RbNormal_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Location = new System.Drawing.Point(70, 17);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(48, 17);
            this.rbEasy.TabIndex = 1;
            this.rbEasy.Text = "&Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.RbEasy_CheckedChanged);
            // 
            // rbEasiest
            // 
            this.rbEasiest.AutoSize = true;
            this.rbEasiest.Location = new System.Drawing.Point(124, 17);
            this.rbEasiest.Name = "rbEasiest";
            this.rbEasiest.Size = new System.Drawing.Size(59, 17);
            this.rbEasiest.TabIndex = 2;
            this.rbEasiest.Text = "Eas&iest";
            this.rbEasiest.UseVisualStyleBackColor = true;
            this.rbEasiest.CheckedChanged += new System.EventHandler(this.RbEasiest_CheckedChanged);
            // 
            // OptionsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 182);
            this.Controls.Add(this.gbDifficulty);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSelFN);
            this.Controls.Add(this.tbWLFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSounds);
            this.Controls.Add(this.cbPrompts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hangman: Options";
            this.Load += new System.EventHandler(this.OptionsDlg_Load);
            this.gbDifficulty.ResumeLayout(false);
            this.gbDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPrompts;
        private System.Windows.Forms.CheckBox cbSounds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWLFile;
        private System.Windows.Forms.Button btnSelFN;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip ttBtnFileSel;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.GroupBox gbDifficulty;
        private System.Windows.Forms.RadioButton rbEasiest;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbNormal;
    }
}