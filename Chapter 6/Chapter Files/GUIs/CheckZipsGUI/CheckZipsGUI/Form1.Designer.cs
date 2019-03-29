namespace CheckZipsGUI
{
    partial class CheckZipsForm
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
            this.checkerButton = new System.Windows.Forms.Button();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.zipInBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkerButton
            // 
            this.checkerButton.Location = new System.Drawing.Point(58, 53);
            this.checkerButton.Name = "checkerButton";
            this.checkerButton.Size = new System.Drawing.Size(121, 32);
            this.checkerButton.TabIndex = 0;
            this.checkerButton.Text = "Check Service";
            this.checkerButton.UseVisualStyleBackColor = true;
            this.checkerButton.Click += new System.EventHandler(this.CheckerButton_Click);
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Location = new System.Drawing.Point(41, 99);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(166, 34);
            this.serviceLabel.TabIndex = 1;
            this.serviceLabel.Text = "Zip Code Serviced: False";
            // 
            // zipInBox
            // 
            this.zipInBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipInBox.Location = new System.Drawing.Point(58, 12);
            this.zipInBox.Name = "zipInBox";
            this.zipInBox.Size = new System.Drawing.Size(121, 26);
            this.zipInBox.TabIndex = 2;
            this.zipInBox.Text = "Enter Zip Code";
            // 
            // CheckZipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(276, 153);
            this.Controls.Add(this.zipInBox);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.checkerButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckZipsForm";
            this.Text = "Zip Code Service Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkerButton;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.TextBox zipInBox;
    }
}

