namespace MyFlix
{
    partial class MyFlix
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
            this.titlesList = new System.Windows.Forms.ListBox();
            this.titlesLabel = new System.Windows.Forms.Label();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.selectionCount = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlesList
            // 
            this.titlesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlesList.FormattingEnabled = true;
            this.titlesList.ItemHeight = 20;
            this.titlesList.Items.AddRange(new object[] {
            "Fast and the Furious",
            "2 Fast 2 Furious",
            "Tokyo Drift",
            "Hurricane Heist",
            "Captain America: The First Avenger",
            "NCIS: Los Angeles",
            "Mythbusters",
            "Kung Fu Panda",
            "Phineas and Ferb",
            "CSI",
            "Dark Knight Rises",
            "Highway through Hell"});
            this.titlesList.Location = new System.Drawing.Point(286, 12);
            this.titlesList.Name = "titlesList";
            this.titlesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.titlesList.Size = new System.Drawing.Size(167, 144);
            this.titlesList.TabIndex = 0;
            // 
            // titlesLabel
            // 
            this.titlesLabel.AutoSize = true;
            this.titlesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlesLabel.Location = new System.Drawing.Point(12, 12);
            this.titlesLabel.Name = "titlesLabel";
            this.titlesLabel.Size = new System.Drawing.Size(246, 160);
            this.titlesLabel.TabIndex = 1;
            this.titlesLabel.Text = "- Select movies or tv shows to\r\n   purchase for download.\r\n\r\n- To select more tha" +
    "n one, hold \r\n   down CTRL\r\n\r\n- To Finalize your purchase hit the\r\n   button bel" +
    "ow\r\n";
            // 
            // purchaseButton
            // 
            this.purchaseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.purchaseButton.FlatAppearance.BorderSize = 4;
            this.purchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseButton.Location = new System.Drawing.Point(74, 241);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(111, 56);
            this.purchaseButton.TabIndex = 2;
            this.purchaseButton.Text = "Finalize Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // selectionCount
            // 
            this.selectionCount.AutoSize = true;
            this.selectionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionCount.Location = new System.Drawing.Point(208, 241);
            this.selectionCount.Name = "selectionCount";
            this.selectionCount.Size = new System.Drawing.Size(208, 20);
            this.selectionCount.TabIndex = 3;
            this.selectionCount.Text = "Number of Titles Selected: 0";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(208, 277);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(131, 20);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Total Price: $0.00";
            // 
            // MyFlix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 361);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.selectionCount);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.titlesLabel);
            this.Controls.Add(this.titlesList);
            this.Name = "MyFlix";
            this.Text = "Movie & T.V Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox titlesList;
        private System.Windows.Forms.Label titlesLabel;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Label selectionCount;
        private System.Windows.Forms.Label priceLabel;
    }
}

