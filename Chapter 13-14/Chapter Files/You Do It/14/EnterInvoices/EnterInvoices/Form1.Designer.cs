namespace EnterInvoices
{
    partial class InvoiceForm
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
            writer.Close();
            outFile.Close();
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.recordButton = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(48, 34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(204, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Enter invoice data";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(33, 93);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(82, 13);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Invoice Number";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(33, 134);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Last Name";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(33, 178);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "Amount";
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(200, 221);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(92, 35);
            this.recordButton.TabIndex = 4;
            this.recordButton.Text = "Enter Record";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(174, 90);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(100, 20);
            this.numberBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(174, 131);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 6;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(174, 175);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 7;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 281);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InvoiceForm";
            this.Text = "Invoice Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox amountBox;
    }
}

