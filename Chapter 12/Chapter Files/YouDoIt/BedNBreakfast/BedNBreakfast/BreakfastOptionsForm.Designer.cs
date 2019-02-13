namespace BedNBreakfast
{
    partial class BreakfastOptionsForm
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
            this.breakfastLabel = new System.Windows.Forms.Label();
            this.contRadioButton = new System.Windows.Forms.RadioButton();
            this.fullRadioButton = new System.Windows.Forms.RadioButton();
            this.deluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // breakfastLabel
            // 
            this.breakfastLabel.AutoSize = true;
            this.breakfastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakfastLabel.Location = new System.Drawing.Point(49, 60);
            this.breakfastLabel.Name = "breakfastLabel";
            this.breakfastLabel.Size = new System.Drawing.Size(240, 24);
            this.breakfastLabel.TabIndex = 0;
            this.breakfastLabel.Text = "Select your breakfast option";
            // 
            // contRadioButton
            // 
            this.contRadioButton.AutoSize = true;
            this.contRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contRadioButton.Location = new System.Drawing.Point(78, 107);
            this.contRadioButton.Name = "contRadioButton";
            this.contRadioButton.Size = new System.Drawing.Size(126, 28);
            this.contRadioButton.TabIndex = 1;
            this.contRadioButton.TabStop = true;
            this.contRadioButton.Text = "Contintental";
            this.contRadioButton.UseVisualStyleBackColor = true;
            this.contRadioButton.CheckedChanged += new System.EventHandler(this.ContRadioButton_CheckedChanged);
            // 
            // fullRadioButton
            // 
            this.fullRadioButton.AutoSize = true;
            this.fullRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullRadioButton.Location = new System.Drawing.Point(78, 140);
            this.fullRadioButton.Name = "fullRadioButton";
            this.fullRadioButton.Size = new System.Drawing.Size(59, 28);
            this.fullRadioButton.TabIndex = 2;
            this.fullRadioButton.TabStop = true;
            this.fullRadioButton.Text = "Full";
            this.fullRadioButton.UseVisualStyleBackColor = true;
            this.fullRadioButton.CheckedChanged += new System.EventHandler(this.FullRadioButton_CheckedChanged);
            // 
            // deluxeRadioButton
            // 
            this.deluxeRadioButton.AutoSize = true;
            this.deluxeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deluxeRadioButton.Location = new System.Drawing.Point(78, 173);
            this.deluxeRadioButton.Name = "deluxeRadioButton";
            this.deluxeRadioButton.Size = new System.Drawing.Size(88, 28);
            this.deluxeRadioButton.TabIndex = 3;
            this.deluxeRadioButton.TabStop = true;
            this.deluxeRadioButton.Text = "Deluxe";
            this.deluxeRadioButton.UseVisualStyleBackColor = true;
            this.deluxeRadioButton.CheckedChanged += new System.EventHandler(this.DeluxeRadioButton_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(114, 231);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(97, 36);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price:";
            // 
            // BreakfastOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.deluxeRadioButton);
            this.Controls.Add(this.fullRadioButton);
            this.Controls.Add(this.contRadioButton);
            this.Controls.Add(this.breakfastLabel);
            this.Name = "BreakfastOptionsForm";
            this.Text = "BreakfastOptionsForm";
            this.Load += new System.EventHandler(this.BreakfastOptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label breakfastLabel;
        private System.Windows.Forms.RadioButton contRadioButton;
        private System.Windows.Forms.RadioButton fullRadioButton;
        private System.Windows.Forms.RadioButton deluxeRadioButton;
        private System.Windows.Forms.Label priceLabel;
    }
}