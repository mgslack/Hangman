
namespace Hangman
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.IL_Gallows = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsedLetters = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbGallow = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWordToGuess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumWordsGuessed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumWordsMissed = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGallow)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // IL_Gallows
            // 
            this.IL_Gallows.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL_Gallows.ImageStream")));
            this.IL_Gallows.TransparentColor = System.Drawing.Color.Transparent;
            this.IL_Gallows.Images.SetKeyName(0, "Empty.BMP");
            this.IL_Gallows.Images.SetKeyName(1, "Hung.BMP");
            this.IL_Gallows.Images.SetKeyName(2, "W1Arm.BMP");
            this.IL_Gallows.Images.SetKeyName(3, "W1Leg.BMP");
            this.IL_Gallows.Images.SetKeyName(4, "WBody.BMP");
            this.IL_Gallows.Images.SetKeyName(5, "WBothA.BMP");
            this.IL_Gallows.Images.SetKeyName(6, "WHead.BMP");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUsedLetters);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 59);
            this.panel1.TabIndex = 0;
            // 
            // lblUsedLetters
            // 
            this.lblUsedLetters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedLetters.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedLetters.Location = new System.Drawing.Point(3, 31);
            this.lblUsedLetters.Name = "lblUsedLetters";
            this.lblUsedLetters.Size = new System.Drawing.Size(222, 20);
            this.lblUsedLetters.TabIndex = 1;
            this.lblUsedLetters.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Used Letters:";
            this.label1.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbGallow);
            this.panel2.Location = new System.Drawing.Point(12, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 214);
            this.panel2.TabIndex = 1;
            // 
            // pbGallow
            // 
            this.pbGallow.Location = new System.Drawing.Point(6, 6);
            this.pbGallow.Name = "pbGallow";
            this.pbGallow.Size = new System.Drawing.Size(120, 200);
            this.pbGallow.TabIndex = 2;
            this.pbGallow.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblWordToGuess);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(152, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 57);
            this.panel3.TabIndex = 2;
            // 
            // lblWordToGuess
            // 
            this.lblWordToGuess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWordToGuess.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordToGuess.Location = new System.Drawing.Point(3, 29);
            this.lblWordToGuess.Name = "lblWordToGuess";
            this.lblWordToGuess.Size = new System.Drawing.Size(182, 20);
            this.lblWordToGuess.TabIndex = 1;
            this.lblWordToGuess.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Word to Guess:";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Words Guessed:";
            this.label3.UseMnemonic = false;
            // 
            // lblNumWordsGuessed
            // 
            this.lblNumWordsGuessed.Location = new System.Drawing.Point(168, 190);
            this.lblNumWordsGuessed.Name = "lblNumWordsGuessed";
            this.lblNumWordsGuessed.Size = new System.Drawing.Size(86, 13);
            this.lblNumWordsGuessed.TabIndex = 4;
            this.lblNumWordsGuessed.Text = "0";
            this.lblNumWordsGuessed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumWordsGuessed.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Words Missed:";
            this.label4.UseMnemonic = false;
            // 
            // lblNumWordsMissed
            // 
            this.lblNumWordsMissed.Location = new System.Drawing.Point(168, 234);
            this.lblNumWordsMissed.Name = "lblNumWordsMissed";
            this.lblNumWordsMissed.Size = new System.Drawing.Size(86, 13);
            this.lblNumWordsMissed.TabIndex = 6;
            this.lblNumWordsMissed.Text = "0";
            this.lblNumWordsMissed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumWordsMissed.UseMnemonic = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(284, 163);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(284, 194);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 8;
            this.btnGuess.Text = "&Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(284, 225);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 9;
            this.btnOptions.Text = "&Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(284, 256);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 297);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNumWordsMissed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNumWordsGuessed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWin_FormClosed);
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGallow)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList IL_Gallows;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsedLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbGallow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblWordToGuess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumWordsGuessed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumWordsMissed;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnQuit;
    }
}

