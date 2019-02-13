namespace MovingGUI
{
    partial class MovingForm
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
            this.milesLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.hoursInput = new System.Windows.Forms.TextBox();
            this.milesInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Location = new System.Drawing.Point(47, 84);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(112, 13);
            this.milesLabel.TabIndex = 0;
            this.milesLabel.Text = "Enter how many miles:";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(12, 45);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(174, 13);
            this.hourLabel.TabIndex = 1;
            this.hourLabel.Text = "How many hours does the job take:";
            // 
            // hoursInput
            // 
            this.hoursInput.Location = new System.Drawing.Point(192, 42);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(75, 20);
            this.hoursInput.TabIndex = 2;
            // 
            // milesInput
            // 
            this.milesInput.Location = new System.Drawing.Point(192, 81);
            this.milesInput.Name = "milesInput";
            this.milesInput.Size = new System.Drawing.Size(75, 20);
            this.milesInput.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(59, 118);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 25);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate Cost";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(192, 121);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(75, 20);
            this.outputBox.TabIndex = 5;
            // 
            // MovingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.milesInput);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.milesLabel);
            this.Name = "MovingForm";
            this.Text = "Moving Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.TextBox hoursInput;
        private System.Windows.Forms.TextBox milesInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox outputBox;
    }
}

