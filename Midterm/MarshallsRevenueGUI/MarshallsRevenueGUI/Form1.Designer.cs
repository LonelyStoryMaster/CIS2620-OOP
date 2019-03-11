namespace MarshallsRevenueGUI
{
    partial class revenueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(revenueForm));
            this.mottoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.interiorBox = new System.Windows.Forms.TextBox();
            this.exteriorBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.interiorLabel = new System.Windows.Forms.Label();
            this.exteriorLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.monthBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mottoLabel
            // 
            this.mottoLabel.AutoSize = true;
            this.mottoLabel.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mottoLabel.Location = new System.Drawing.Point(136, 9);
            this.mottoLabel.Name = "mottoLabel";
            this.mottoLabel.Size = new System.Drawing.Size(348, 38);
            this.mottoLabel.TabIndex = 0;
            this.mottoLabel.Text = "Make your vision your view";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // interiorBox
            // 
            this.interiorBox.Location = new System.Drawing.Point(378, 105);
            this.interiorBox.Name = "interiorBox";
            this.interiorBox.Size = new System.Drawing.Size(106, 20);
            this.interiorBox.TabIndex = 2;
            this.interiorBox.Text = "Num Interior Murals";
            // 
            // exteriorBox
            // 
            this.exteriorBox.Location = new System.Drawing.Point(378, 132);
            this.exteriorBox.Name = "exteriorBox";
            this.exteriorBox.Size = new System.Drawing.Size(106, 20);
            this.exteriorBox.TabIndex = 3;
            this.exteriorBox.Text = "Num Exterior Murals";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(505, 91);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 47);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate Revenue";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // interiorLabel
            // 
            this.interiorLabel.AutoSize = true;
            this.interiorLabel.Location = new System.Drawing.Point(375, 170);
            this.interiorLabel.Name = "interiorLabel";
            this.interiorLabel.Size = new System.Drawing.Size(111, 65);
            this.interiorLabel.TabIndex = 5;
            this.interiorLabel.Text = "Interior Murals\r\n\r\nNumber of Murals:  0\r\nPrice per Mural:  $500\r\nSubtotal:  $0";
            this.interiorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // exteriorLabel
            // 
            this.exteriorLabel.AutoSize = true;
            this.exteriorLabel.Location = new System.Drawing.Point(492, 170);
            this.exteriorLabel.Name = "exteriorLabel";
            this.exteriorLabel.Size = new System.Drawing.Size(111, 65);
            this.exteriorLabel.TabIndex = 6;
            this.exteriorLabel.Text = "Exterior Murals\r\n\r\nNumber of Murals:  0\r\nPrice per Mural:  $750\r\nSubtotal:  $0";
            this.exteriorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(441, 255);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(76, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total Price: $0";
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(378, 81);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(106, 20);
            this.monthBox.TabIndex = 8;
            this.monthBox.Text = "Month Integer (1-12)";
            // 
            // revenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(625, 319);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.exteriorLabel);
            this.Controls.Add(this.interiorLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.exteriorBox);
            this.Controls.Add(this.interiorBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mottoLabel);
            this.Name = "revenueForm";
            this.Text = "Marshall\'s Murals";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mottoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox interiorBox;
        private System.Windows.Forms.TextBox exteriorBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label interiorLabel;
        private System.Windows.Forms.Label exteriorLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox monthBox;
    }
}

