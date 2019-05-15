namespace ViewInvoices
{
    partial class InvoicesForm
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
            reader.Close();
            file.Close();
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
            this.viewButton = new System.Windows.Forms.Button();
            this.invoiceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.invoiceBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(24, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(135, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Click the button\r\nto view records";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(203, 44);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(102, 40);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "View Records";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // invoiceLabel
            // 
            this.invoiceLabel.AutoSize = true;
            this.invoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceLabel.Location = new System.Drawing.Point(56, 128);
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Size = new System.Drawing.Size(52, 17);
            this.invoiceLabel.TabIndex = 2;
            this.invoiceLabel.Text = "Invoice";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(56, 165);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(56, 202);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(56, 17);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "Amount";
            // 
            // invoiceBox
            // 
            this.invoiceBox.Location = new System.Drawing.Point(175, 128);
            this.invoiceBox.Name = "invoiceBox";
            this.invoiceBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(175, 164);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 6;
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(175, 201);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 7;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 281);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.invoiceBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.invoiceLabel);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "InvoicesForm";
            this.Text = "Invoice Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label invoiceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox invoiceBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox amountBox;
    }
}

