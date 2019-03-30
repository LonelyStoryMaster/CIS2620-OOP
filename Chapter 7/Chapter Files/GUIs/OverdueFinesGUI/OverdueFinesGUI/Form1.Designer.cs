namespace OverdueFinesGUI
{
    partial class OverdueFinesForm
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
            this.bookInputBox = new System.Windows.Forms.TextBox();
            this.daysInputBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.finesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookInputBox
            // 
            this.bookInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookInputBox.Location = new System.Drawing.Point(12, 33);
            this.bookInputBox.Name = "bookInputBox";
            this.bookInputBox.Size = new System.Drawing.Size(154, 29);
            this.bookInputBox.TabIndex = 0;
            this.bookInputBox.Text = "Number of Books";
            // 
            // daysInputBox
            // 
            this.daysInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysInputBox.Location = new System.Drawing.Point(208, 33);
            this.daysInputBox.Name = "daysInputBox";
            this.daysInputBox.Size = new System.Drawing.Size(144, 29);
            this.daysInputBox.TabIndex = 1;
            this.daysInputBox.Text = "Number of Days";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(93, 111);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(178, 37);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate Fines";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // finesLabel
            // 
            this.finesLabel.AutoSize = true;
            this.finesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finesLabel.Location = new System.Drawing.Point(59, 191);
            this.finesLabel.Name = "finesLabel";
            this.finesLabel.Size = new System.Drawing.Size(250, 31);
            this.finesLabel.TabIndex = 3;
            this.finesLabel.Text = "Total Fines: $0.00";
            // 
            // OverdueFinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.finesLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.daysInputBox);
            this.Controls.Add(this.bookInputBox);
            this.Name = "OverdueFinesForm";
            this.Text = "Overdue Fine Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookInputBox;
        private System.Windows.Forms.TextBox daysInputBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label finesLabel;
    }
}

