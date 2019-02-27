namespace DailySpecial
{
    partial class SpecialsForm
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
            this.TaskLabel = new System.Windows.Forms.Label();
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.SpecialTextBox = new System.Windows.Forms.TextBox();
            this.SpecialButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Location = new System.Drawing.Point(35, 43);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(209, 13);
            this.TaskLabel.TabIndex = 0;
            this.TaskLabel.Text = "Enter a day number to see our daily special";
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(62, 76);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(124, 13);
            this.ExampleLabel.TabIndex = 1;
            this.ExampleLabel.Text = "For example, Sunday = 1";
            // 
            // SpecialTextBox
            // 
            this.SpecialTextBox.Location = new System.Drawing.Point(95, 104);
            this.SpecialTextBox.Name = "SpecialTextBox";
            this.SpecialTextBox.Size = new System.Drawing.Size(62, 20);
            this.SpecialTextBox.TabIndex = 2;
            // 
            // SpecialButton
            // 
            this.SpecialButton.Location = new System.Drawing.Point(82, 144);
            this.SpecialButton.Name = "SpecialButton";
            this.SpecialButton.Size = new System.Drawing.Size(75, 23);
            this.SpecialButton.TabIndex = 3;
            this.SpecialButton.Text = "Get Special";
            this.SpecialButton.UseVisualStyleBackColor = true;
            this.SpecialButton.Click += new System.EventHandler(this.SpecialButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(95, 192);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 13);
            this.OutputLabel.TabIndex = 4;
            // 
            // SpecialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 261);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SpecialButton);
            this.Controls.Add(this.SpecialTextBox);
            this.Controls.Add(this.ExampleLabel);
            this.Controls.Add(this.TaskLabel);
            this.Name = "SpecialsForm";
            this.Text = "Chatterbox Diner Daily Specials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.TextBox SpecialTextBox;
        private System.Windows.Forms.Button SpecialButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

