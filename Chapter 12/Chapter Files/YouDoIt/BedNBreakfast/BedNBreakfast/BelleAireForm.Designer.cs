namespace BedNBreakfast
{
    partial class BelleAireForm
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
            this.belleAireDescriptionLabel = new System.Windows.Forms.Label();
            this.belleAirePriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // belleAireDescriptionLabel
            // 
            this.belleAireDescriptionLabel.AutoSize = true;
            this.belleAireDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belleAireDescriptionLabel.Location = new System.Drawing.Point(29, 30);
            this.belleAireDescriptionLabel.Name = "belleAireDescriptionLabel";
            this.belleAireDescriptionLabel.Size = new System.Drawing.Size(279, 40);
            this.belleAireDescriptionLabel.TabIndex = 0;
            this.belleAireDescriptionLabel.Text = "The BelleAire suite has two bedrooms,\r\n two baths, and a private balcony. ";
            // 
            // belleAirePriceLabel
            // 
            this.belleAirePriceLabel.AutoSize = true;
            this.belleAirePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belleAirePriceLabel.Location = new System.Drawing.Point(96, 129);
            this.belleAirePriceLabel.Name = "belleAirePriceLabel";
            this.belleAirePriceLabel.Size = new System.Drawing.Size(111, 20);
            this.belleAirePriceLabel.TabIndex = 1;
            this.belleAirePriceLabel.Text = "$199 per night";
            // 
            // BelleAireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.belleAirePriceLabel);
            this.Controls.Add(this.belleAireDescriptionLabel);
            this.Name = "BelleAireForm";
            this.Text = "BelleAireForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label belleAireDescriptionLabel;
        private System.Windows.Forms.Label belleAirePriceLabel;
    }
}