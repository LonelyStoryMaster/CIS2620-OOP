namespace InToCmGUI
{
    partial class InchesToCentimeters
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
            this.inchesInput = new System.Windows.Forms.TextBox();
            this.inputInstructions = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inchesInput
            // 
            this.inchesInput.Location = new System.Drawing.Point(232, 28);
            this.inchesInput.Name = "inchesInput";
            this.inchesInput.Size = new System.Drawing.Size(81, 20);
            this.inchesInput.TabIndex = 0;
            // 
            // inputInstructions
            // 
            this.inputInstructions.AutoSize = true;
            this.inputInstructions.Location = new System.Drawing.Point(39, 31);
            this.inputInstructions.Name = "inputInstructions";
            this.inputInstructions.Size = new System.Drawing.Size(187, 13);
            this.inputInstructions.TabIndex = 1;
            this.inputInstructions.Text = "Enter inches to convert to Centimeters";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(42, 66);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(101, 25);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert Number";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(232, 66);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(81, 20);
            this.outputBox.TabIndex = 3;
            // 
            // InchesToCentimeters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 119);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputInstructions);
            this.Controls.Add(this.inchesInput);
            this.Name = "InchesToCentimeters";
            this.Text = "Converting Inches to Centimeters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inchesInput;
        private System.Windows.Forms.Label inputInstructions;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox outputBox;
    }
}

