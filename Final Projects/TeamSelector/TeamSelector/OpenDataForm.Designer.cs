namespace TeamSelector
{
    partial class OpenDataForm
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
            this.savedDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savedDataLabel
            // 
            this.savedDataLabel.AutoSize = true;
            this.savedDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savedDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedDataLabel.Location = new System.Drawing.Point(0, 0);
            this.savedDataLabel.Name = "savedDataLabel";
            this.savedDataLabel.Size = new System.Drawing.Size(0, 26);
            this.savedDataLabel.TabIndex = 0;
            // 
            // OpenDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(586, 338);
            this.Controls.Add(this.savedDataLabel);
            this.MinimumSize = new System.Drawing.Size(0, 200);
            this.Name = "OpenDataForm";
            this.Text = "OpenDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label savedDataLabel;
    }
}