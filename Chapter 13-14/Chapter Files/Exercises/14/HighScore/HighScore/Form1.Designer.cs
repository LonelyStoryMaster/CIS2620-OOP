namespace HighScore
{
    partial class GuessingForm
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
            this.radioA = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioA.Location = new System.Drawing.Point(68, 71);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(74, 59);
            this.radioA.TabIndex = 0;
            this.radioA.TabStop = true;
            this.radioA.Text = "A";
            this.radioA.UseVisualStyleBackColor = true;
            this.radioA.CheckedChanged += new System.EventHandler(this.CheckLetter);
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB.Location = new System.Drawing.Point(180, 71);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(74, 59);
            this.radioB.TabIndex = 1;
            this.radioB.TabStop = true;
            this.radioB.Text = "B";
            this.radioB.UseVisualStyleBackColor = true;
            this.radioB.CheckedChanged += new System.EventHandler(this.CheckLetter);
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioC.Location = new System.Drawing.Point(300, 71);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(77, 59);
            this.radioC.TabIndex = 2;
            this.radioC.TabStop = true;
            this.radioC.Text = "C";
            this.radioC.UseVisualStyleBackColor = true;
            this.radioC.CheckedChanged += new System.EventHandler(this.CheckLetter);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(459, 20);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Try and guess the same letter as the computer 10 times in a row";
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerLabel.Location = new System.Drawing.Point(63, 184);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(252, 29);
            this.computerLabel.TabIndex = 4;
            this.computerLabel.Text = "Computer Chose:  ___";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.Location = new System.Drawing.Point(63, 275);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(258, 29);
            this.highScoreLabel.TabIndex = 5;
            this.highScoreLabel.Text = "Previous High Score: 0";
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.Location = new System.Drawing.Point(68, 330);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(179, 29);
            this.playerScoreLabel.TabIndex = 6;
            this.playerScoreLabel.Text = "Your score is: 0";
            // 
            // GuessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(486, 401);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.radioB);
            this.Controls.Add(this.radioA);
            this.Name = "GuessingForm";
            this.Text = "Guess The Letters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label playerScoreLabel;
    }
}

