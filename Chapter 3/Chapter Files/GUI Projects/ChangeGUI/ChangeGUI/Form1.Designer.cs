namespace ChangeGUI
{
    partial class ChangeGui
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
            this.makeChange = new System.Windows.Forms.Button();
            this.moneyInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.twentiesOut = new System.Windows.Forms.Label();
            this.twentiesBox = new System.Windows.Forms.TextBox();
            this.tensOut = new System.Windows.Forms.Label();
            this.tensBox = new System.Windows.Forms.TextBox();
            this.fivesOut = new System.Windows.Forms.Label();
            this.fivesBox = new System.Windows.Forms.TextBox();
            this.onesOut = new System.Windows.Forms.Label();
            this.onesBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // makeChange
            // 
            this.makeChange.Location = new System.Drawing.Point(51, 44);
            this.makeChange.Name = "makeChange";
            this.makeChange.Size = new System.Drawing.Size(96, 23);
            this.makeChange.TabIndex = 0;
            this.makeChange.Text = "Make Change";
            this.makeChange.UseVisualStyleBackColor = true;
            this.makeChange.Click += new System.EventHandler(this.MakeChange_Click);
            // 
            // moneyInput
            // 
            this.moneyInput.Location = new System.Drawing.Point(88, 18);
            this.moneyInput.Name = "moneyInput";
            this.moneyInput.Size = new System.Drawing.Size(100, 20);
            this.moneyInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Money Input";
            // 
            // twentiesOut
            // 
            this.twentiesOut.AutoSize = true;
            this.twentiesOut.Location = new System.Drawing.Point(28, 76);
            this.twentiesOut.Name = "twentiesOut";
            this.twentiesOut.Size = new System.Drawing.Size(32, 13);
            this.twentiesOut.TabIndex = 4;
            this.twentiesOut.Text = "$20\'s";
            // 
            // twentiesBox
            // 
            this.twentiesBox.Location = new System.Drawing.Point(66, 73);
            this.twentiesBox.Name = "twentiesBox";
            this.twentiesBox.Size = new System.Drawing.Size(100, 20);
            this.twentiesBox.TabIndex = 3;
            // 
            // tensOut
            // 
            this.tensOut.AutoSize = true;
            this.tensOut.Location = new System.Drawing.Point(28, 102);
            this.tensOut.Name = "tensOut";
            this.tensOut.Size = new System.Drawing.Size(32, 13);
            this.tensOut.TabIndex = 6;
            this.tensOut.Text = "$10\'s";
            // 
            // tensBox
            // 
            this.tensBox.Location = new System.Drawing.Point(66, 99);
            this.tensBox.Name = "tensBox";
            this.tensBox.Size = new System.Drawing.Size(100, 20);
            this.tensBox.TabIndex = 5;
            // 
            // fivesOut
            // 
            this.fivesOut.AutoSize = true;
            this.fivesOut.Location = new System.Drawing.Point(28, 128);
            this.fivesOut.Name = "fivesOut";
            this.fivesOut.Size = new System.Drawing.Size(26, 13);
            this.fivesOut.TabIndex = 8;
            this.fivesOut.Text = "$5\'s";
            // 
            // fivesBox
            // 
            this.fivesBox.Location = new System.Drawing.Point(66, 125);
            this.fivesBox.Name = "fivesBox";
            this.fivesBox.Size = new System.Drawing.Size(100, 20);
            this.fivesBox.TabIndex = 7;
            // 
            // onesOut
            // 
            this.onesOut.AutoSize = true;
            this.onesOut.Location = new System.Drawing.Point(28, 154);
            this.onesOut.Name = "onesOut";
            this.onesOut.Size = new System.Drawing.Size(26, 13);
            this.onesOut.TabIndex = 10;
            this.onesOut.Text = "$1\'s";
            // 
            // onesBox
            // 
            this.onesBox.Location = new System.Drawing.Point(66, 151);
            this.onesBox.Name = "onesBox";
            this.onesBox.Size = new System.Drawing.Size(100, 20);
            this.onesBox.TabIndex = 9;
            // 
            // ChangeGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.onesOut);
            this.Controls.Add(this.onesBox);
            this.Controls.Add(this.fivesOut);
            this.Controls.Add(this.fivesBox);
            this.Controls.Add(this.tensOut);
            this.Controls.Add(this.tensBox);
            this.Controls.Add(this.twentiesOut);
            this.Controls.Add(this.twentiesBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moneyInput);
            this.Controls.Add(this.makeChange);
            this.Name = "ChangeGui";
            this.Text = "Create Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeChange;
        private System.Windows.Forms.TextBox moneyInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label twentiesOut;
        private System.Windows.Forms.TextBox twentiesBox;
        private System.Windows.Forms.Label tensOut;
        private System.Windows.Forms.TextBox tensBox;
        private System.Windows.Forms.Label fivesOut;
        private System.Windows.Forms.TextBox fivesBox;
        private System.Windows.Forms.Label onesOut;
        private System.Windows.Forms.TextBox onesBox;
    }
}

