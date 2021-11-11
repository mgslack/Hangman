
namespace Hangman
{
    partial class StartGameDlg
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
            this.cbUseWL = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWordToUse = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbUseWL
            // 
            this.cbUseWL.AutoSize = true;
            this.cbUseWL.Location = new System.Drawing.Point(12, 12);
            this.cbUseWL.Name = "cbUseWL";
            this.cbUseWL.Size = new System.Drawing.Size(148, 17);
            this.cbUseWL.TabIndex = 2;
            this.cbUseWL.Text = "&Use Word From Word List";
            this.cbUseWL.UseVisualStyleBackColor = true;
            this.cbUseWL.CheckedChanged += new System.EventHandler(this.CbUseWL_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Type in Word To Use:";
            // 
            // tbWordToUse
            // 
            this.tbWordToUse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbWordToUse.Location = new System.Drawing.Point(12, 48);
            this.tbWordToUse.MaxLength = 20;
            this.tbWordToUse.Name = "tbWordToUse";
            this.tbWordToUse.Size = new System.Drawing.Size(168, 20);
            this.tbWordToUse.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(22, 89);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(0, 76);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(202, 2);
            this.separator.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(105, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // StartGameDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 121);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbWordToUse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUseWL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartGameDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hangman: Word Selection";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StartGameDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbUseWL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWordToUse;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Button btnCancel;
    }
}