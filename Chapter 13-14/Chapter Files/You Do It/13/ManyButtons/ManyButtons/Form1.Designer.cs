namespace ManyButtons
{
    partial class ManyButtonsForm
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
            this.redButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redButton.Location = new System.Drawing.Point(27, 43);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(75, 34);
            this.redButton.TabIndex = 0;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteButton.Location = new System.Drawing.Point(138, 43);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(75, 30);
            this.whiteButton.TabIndex = 1;
            this.whiteButton.Text = "White Button";
            this.whiteButton.UseVisualStyleBackColor = true;
            this.whiteButton.Click += new System.EventHandler(this.WhiteButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueButton.Location = new System.Drawing.Point(252, 43);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(75, 30);
            this.blueButton.TabIndex = 2;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // favoriteButton
            // 
            this.favoriteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoriteButton.Location = new System.Drawing.Point(357, 43);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(140, 29);
            this.favoriteButton.TabIndex = 3;
            this.favoriteButton.Text = "My Favorite Color";
            this.favoriteButton.UseVisualStyleBackColor = true;
            this.favoriteButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // ManyButtonsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(525, 127);
            this.Controls.Add(this.favoriteButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.redButton);
            this.Name = "ManyButtonsForm";
            this.Text = "Many Buttons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button favoriteButton;
    }
}

