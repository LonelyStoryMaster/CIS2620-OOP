namespace GuessANumber
{
    partial class GuessANumberForm
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
            this.radioOne = new System.Windows.Forms.RadioButton();
            this.radioTwo = new System.Windows.Forms.RadioButton();
            this.radioThree = new System.Windows.Forms.RadioButton();
            this.radioFour = new System.Windows.Forms.RadioButton();
            this.radioFive = new System.Windows.Forms.RadioButton();
            this.winLabel = new System.Windows.Forms.Label();
            this.numberButton = new System.Windows.Forms.Button();
            this.hintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioOne
            // 
            this.radioOne.AutoSize = true;
            this.radioOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOne.Location = new System.Drawing.Point(58, 84);
            this.radioOne.Name = "radioOne";
            this.radioOne.Size = new System.Drawing.Size(70, 59);
            this.radioOne.TabIndex = 0;
            this.radioOne.Text = "1";
            this.radioOne.UseVisualStyleBackColor = true;
            this.radioOne.CheckedChanged += new System.EventHandler(this.CheckWinner);
            // 
            // radioTwo
            // 
            this.radioTwo.AutoSize = true;
            this.radioTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTwo.Location = new System.Drawing.Point(151, 84);
            this.radioTwo.Name = "radioTwo";
            this.radioTwo.Size = new System.Drawing.Size(70, 59);
            this.radioTwo.TabIndex = 1;
            this.radioTwo.Text = "2";
            this.radioTwo.UseVisualStyleBackColor = true;
            this.radioTwo.CheckedChanged += new System.EventHandler(this.CheckWinner);
            // 
            // radioThree
            // 
            this.radioThree.AutoSize = true;
            this.radioThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioThree.Location = new System.Drawing.Point(232, 84);
            this.radioThree.Name = "radioThree";
            this.radioThree.Size = new System.Drawing.Size(70, 59);
            this.radioThree.TabIndex = 2;
            this.radioThree.Text = "3";
            this.radioThree.UseVisualStyleBackColor = true;
            this.radioThree.CheckedChanged += new System.EventHandler(this.CheckWinner);
            // 
            // radioFour
            // 
            this.radioFour.AutoSize = true;
            this.radioFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFour.Location = new System.Drawing.Point(309, 84);
            this.radioFour.Name = "radioFour";
            this.radioFour.Size = new System.Drawing.Size(70, 59);
            this.radioFour.TabIndex = 3;
            this.radioFour.Text = "4";
            this.radioFour.UseVisualStyleBackColor = true;
            this.radioFour.CheckedChanged += new System.EventHandler(this.CheckWinner);
            // 
            // radioFive
            // 
            this.radioFive.AutoSize = true;
            this.radioFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFive.Location = new System.Drawing.Point(386, 84);
            this.radioFive.Name = "radioFive";
            this.radioFive.Size = new System.Drawing.Size(70, 59);
            this.radioFive.TabIndex = 4;
            this.radioFive.Text = "5";
            this.radioFive.UseVisualStyleBackColor = true;
            this.radioFive.CheckedChanged += new System.EventHandler(this.CheckWinner);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Location = new System.Drawing.Point(150, 275);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 13);
            this.winLabel.TabIndex = 5;
            // 
            // numberButton
            // 
            this.numberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberButton.Location = new System.Drawing.Point(428, 235);
            this.numberButton.Name = "numberButton";
            this.numberButton.Size = new System.Drawing.Size(89, 53);
            this.numberButton.TabIndex = 6;
            this.numberButton.Text = "Generate Number";
            this.numberButton.UseVisualStyleBackColor = true;
            this.numberButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintLabel.Location = new System.Drawing.Point(29, 259);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(59, 29);
            this.hintLabel.TabIndex = 7;
            this.hintLabel.Text = "Hint";
            this.hintLabel.MouseHover += new System.EventHandler(this.GiveHint);
            // 
            // GuessANumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(529, 312);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.numberButton);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.radioFive);
            this.Controls.Add(this.radioFour);
            this.Controls.Add(this.radioThree);
            this.Controls.Add(this.radioTwo);
            this.Controls.Add(this.radioOne);
            this.Name = "GuessANumberForm";
            this.Text = "Guess A Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioOne;
        private System.Windows.Forms.RadioButton radioTwo;
        private System.Windows.Forms.RadioButton radioThree;
        private System.Windows.Forms.RadioButton radioFour;
        private System.Windows.Forms.RadioButton radioFive;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button numberButton;
        private System.Windows.Forms.Label hintLabel;
    }
}

