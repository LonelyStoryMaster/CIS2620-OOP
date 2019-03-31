namespace GreenRevenueGUI
{
    partial class RevenueForm
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
            this.lastYearTextBox = new System.Windows.Forms.TextBox();
            this.thisYearTextBox = new System.Windows.Forms.TextBox();
            this.lastYearLabel = new System.Windows.Forms.Label();
            this.thisYearLabel = new System.Windows.Forms.Label();
            this.calcRevButton = new System.Windows.Forms.Button();
            this.outLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastYearTextBox
            // 
            this.lastYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastYearTextBox.Location = new System.Drawing.Point(34, 49);
            this.lastYearTextBox.Name = "lastYearTextBox";
            this.lastYearTextBox.Size = new System.Drawing.Size(100, 23);
            this.lastYearTextBox.TabIndex = 0;
            // 
            // thisYearTextBox
            // 
            this.thisYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisYearTextBox.Location = new System.Drawing.Point(219, 49);
            this.thisYearTextBox.Name = "thisYearTextBox";
            this.thisYearTextBox.Size = new System.Drawing.Size(100, 23);
            this.thisYearTextBox.TabIndex = 1;
            // 
            // lastYearLabel
            // 
            this.lastYearLabel.AutoSize = true;
            this.lastYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastYearLabel.Location = new System.Drawing.Point(12, 29);
            this.lastYearLabel.Name = "lastYearLabel";
            this.lastYearLabel.Size = new System.Drawing.Size(172, 17);
            this.lastYearLabel.TabIndex = 2;
            this.lastYearLabel.Text = "# Poeple Last Year (0-30)";
            // 
            // thisYearLabel
            // 
            this.thisYearLabel.AutoSize = true;
            this.thisYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisYearLabel.Location = new System.Drawing.Point(190, 29);
            this.thisYearLabel.Name = "thisYearLabel";
            this.thisYearLabel.Size = new System.Drawing.Size(172, 17);
            this.thisYearLabel.TabIndex = 3;
            this.thisYearLabel.Text = "# People This Year (0-30)";
            // 
            // calcRevButton
            // 
            this.calcRevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcRevButton.Location = new System.Drawing.Point(93, 100);
            this.calcRevButton.Name = "calcRevButton";
            this.calcRevButton.Size = new System.Drawing.Size(178, 49);
            this.calcRevButton.TabIndex = 4;
            this.calcRevButton.Text = "Calculate Revenue";
            this.calcRevButton.UseVisualStyleBackColor = true;
            this.calcRevButton.Click += new System.EventHandler(this.CalcRevButton_Click);
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outLabel.Location = new System.Drawing.Point(31, 169);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(287, 34);
            this.outLabel.TabIndex = 5;
            this.outLabel.Text = "The expected revenue for this year is: $0.00\r\nMore people entered {year} year";
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(384, 230);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.calcRevButton);
            this.Controls.Add(this.thisYearLabel);
            this.Controls.Add(this.lastYearLabel);
            this.Controls.Add(this.thisYearTextBox);
            this.Controls.Add(this.lastYearTextBox);
            this.MaximumSize = new System.Drawing.Size(400, 275);
            this.MinimumSize = new System.Drawing.Size(377, 251);
            this.Name = "RevenueForm";
            this.Text = "Greenville Competition Revenue Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastYearTextBox;
        private System.Windows.Forms.TextBox thisYearTextBox;
        private System.Windows.Forms.Label lastYearLabel;
        private System.Windows.Forms.Label thisYearLabel;
        private System.Windows.Forms.Button calcRevButton;
        private System.Windows.Forms.Label outLabel;
    }
}

