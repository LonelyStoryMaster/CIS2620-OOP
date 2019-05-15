namespace TeamSelector
{
    partial class TeamSelectorForm
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
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SingleTicketLabel = new System.Windows.Forms.Label();
            this.selectionCalendar = new System.Windows.Forms.MonthCalendar();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamsListBox
            // 
            this.teamsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 29;
            this.teamsListBox.Items.AddRange(new object[] {
            "Minnesota Vikings",
            "Dallas Cowboys",
            "New York Giants",
            "Pittsburg Steelers"});
            this.teamsListBox.Location = new System.Drawing.Point(30, 61);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(208, 120);
            this.teamsListBox.TabIndex = 0;
            this.teamsListBox.SelectedIndexChanged += new System.EventHandler(this.TeamsListBox_SelectedIndexChanged);
            this.teamsListBox.MouseLeave += new System.EventHandler(this.ClearTicketLabels);
            this.teamsListBox.MouseHover += new System.EventHandler(this.ListBoxMouseHover);
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamLabel.Location = new System.Drawing.Point(22, 32);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(249, 26);
            this.TeamLabel.TabIndex = 1;
            this.TeamLabel.Text = "Pick a team for tickets";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // SingleTicketLabel
            // 
            this.SingleTicketLabel.AutoSize = true;
            this.SingleTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleTicketLabel.Location = new System.Drawing.Point(25, 227);
            this.SingleTicketLabel.Name = "SingleTicketLabel";
            this.SingleTicketLabel.Size = new System.Drawing.Size(0, 26);
            this.SingleTicketLabel.TabIndex = 3;
            // 
            // selectionCalendar
            // 
            this.selectionCalendar.Location = new System.Drawing.Point(411, 59);
            this.selectionCalendar.MaxSelectionCount = 1;
            this.selectionCalendar.Name = "selectionCalendar";
            this.selectionCalendar.TabIndex = 4;
            this.selectionCalendar.Visible = false;
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.Location = new System.Drawing.Point(459, 33);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(124, 26);
            this.calendarLabel.TabIndex = 5;
            this.calendarLabel.Text = "Pick a Date";
            this.calendarLabel.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(408, 233);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(230, 38);
            this.nameBox.TabIndex = 6;
            this.nameBox.Text = "Enter your name";
            this.nameBox.Visible = false;
            // 
            // amountBox
            // 
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.Location = new System.Drawing.Point(408, 277);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(230, 38);
            this.amountBox.TabIndex = 7;
            this.amountBox.Text = "How many tickets";
            this.amountBox.Visible = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(474, 331);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(99, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Visible = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(406, 377);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(103, 24);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total Cost: ";
            this.totalLabel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(406, 415);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(132, 24);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Date Selected:";
            this.dateLabel.Visible = false;
            // 
            // TeamSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 461);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.selectionCalendar);
            this.Controls.Add(this.SingleTicketLabel);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.teamsListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeamSelectorForm";
            this.Text = "Team Selector";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label SingleTicketLabel;
        private System.Windows.Forms.MonthCalendar selectionCalendar;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}

