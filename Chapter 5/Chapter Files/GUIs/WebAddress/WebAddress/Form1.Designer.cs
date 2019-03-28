namespace WebAddress
{
    partial class WebAddressForm
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
            this.suggestionLabel = new System.Windows.Forms.Label();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // suggestionLabel
            // 
            this.suggestionLabel.AutoSize = true;
            this.suggestionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.suggestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suggestionLabel.Location = new System.Drawing.Point(22, 111);
            this.suggestionLabel.Name = "suggestionLabel";
            this.suggestionLabel.Size = new System.Drawing.Size(0, 20);
            this.suggestionLabel.TabIndex = 0;
            // 
            // nameInputBox
            // 
            this.nameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputBox.Location = new System.Drawing.Point(12, 12);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(240, 29);
            this.nameInputBox.TabIndex = 1;
            this.nameInputBox.Text = "Enter your Business Name";
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(65, 57);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(130, 39);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate Site";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // WebAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.nameInputBox);
            this.Controls.Add(this.suggestionLabel);
            this.Name = "WebAddressForm";
            this.Text = "Web Address Sugestor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label suggestionLabel;
        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.Button generateButton;
    }
}

