namespace BedNBreakfast
{
    partial class LincolnRoom
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
            this.lincolnRoomDescriptionLabel = new System.Windows.Forms.Label();
            this.lincolnRoomPriceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lincolnRoomDescriptionLabel
            // 
            this.lincolnRoomDescriptionLabel.AutoSize = true;
            this.lincolnRoomDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lincolnRoomDescriptionLabel.Location = new System.Drawing.Point(53, 36);
            this.lincolnRoomDescriptionLabel.Name = "lincolnRoomDescriptionLabel";
            this.lincolnRoomDescriptionLabel.Size = new System.Drawing.Size(210, 40);
            this.lincolnRoomDescriptionLabel.TabIndex = 0;
            this.lincolnRoomDescriptionLabel.Text = "Return to the 1850s in this \r\nlovely room with private bath.";
            // 
            // lincolnRoomPriceLabel
            // 
            this.lincolnRoomPriceLabel.AutoSize = true;
            this.lincolnRoomPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lincolnRoomPriceLabel.Location = new System.Drawing.Point(192, 108);
            this.lincolnRoomPriceLabel.Name = "lincolnRoomPriceLabel";
            this.lincolnRoomPriceLabel.Size = new System.Drawing.Size(111, 20);
            this.lincolnRoomPriceLabel.TabIndex = 1;
            this.lincolnRoomPriceLabel.Text = "$110 per night";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BedNBreakfast.Properties.Resources.AbeLincoln;
            this.pictureBox1.Location = new System.Drawing.Point(21, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LincolnRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lincolnRoomPriceLabel);
            this.Controls.Add(this.lincolnRoomDescriptionLabel);
            this.Name = "LincolnRoom";
            this.Text = "LincolnRoom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lincolnRoomDescriptionLabel;
        private System.Windows.Forms.Label lincolnRoomPriceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}