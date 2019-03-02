namespace MonthChecker
{
    partial class monthCheckerForm
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
            this.monthButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(87, 99);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(85, 23);
            this.monthButton.TabIndex = 0;
            this.monthButton.Text = "Check Month";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.MonthButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(70, 160);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 1;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(73, 49);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(114, 20);
            this.inputBox.TabIndex = 2;
            this.inputBox.Text = "Enter your birth month";
            // 
            // monthCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.monthButton);
            this.Name = "monthCheckerForm";
            this.Text = "Month Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputBox;
    }
}

