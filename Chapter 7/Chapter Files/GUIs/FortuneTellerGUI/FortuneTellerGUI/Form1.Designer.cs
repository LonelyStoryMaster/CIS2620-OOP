namespace FortuneTellerGUI
{
    partial class FortuneForm
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
            this.generateButton = new System.Windows.Forms.Button();
            this.fortuneLabelOne = new System.Windows.Forms.Label();
            this.fortuneLabelTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(79, 36);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(225, 51);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate Fortunes";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // fortuneLabelOne
            // 
            this.fortuneLabelOne.AutoSize = true;
            this.fortuneLabelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fortuneLabelOne.Location = new System.Drawing.Point(12, 134);
            this.fortuneLabelOne.MaximumSize = new System.Drawing.Size(375, 0);
            this.fortuneLabelOne.Name = "fortuneLabelOne";
            this.fortuneLabelOne.Size = new System.Drawing.Size(118, 24);
            this.fortuneLabelOne.TabIndex = 1;
            this.fortuneLabelOne.Text = "Fortune One";
            // 
            // fortuneLabelTwo
            // 
            this.fortuneLabelTwo.AutoSize = true;
            this.fortuneLabelTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fortuneLabelTwo.Location = new System.Drawing.Point(12, 197);
            this.fortuneLabelTwo.MaximumSize = new System.Drawing.Size(375, 0);
            this.fortuneLabelTwo.Name = "fortuneLabelTwo";
            this.fortuneLabelTwo.Size = new System.Drawing.Size(118, 24);
            this.fortuneLabelTwo.TabIndex = 2;
            this.fortuneLabelTwo.Text = "Fortune Two";
            // 
            // FortuneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.fortuneLabelTwo);
            this.Controls.Add(this.fortuneLabelOne);
            this.Controls.Add(this.generateButton);
            this.Name = "FortuneForm";
            this.Text = "Fortune Teller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label fortuneLabelOne;
        private System.Windows.Forms.Label fortuneLabelTwo;
    }
}

