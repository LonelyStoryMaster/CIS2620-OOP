using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TeamSelector
{
    public partial class TeamSelectorForm : Form
    {
        const string FILE_NAME = @"\SoldTickets.txt";
        double ticketCost, totalCost;
        int numTickets;
        string name, selectedDate, filePath;
        int checkedIndex;

        public TeamSelectorForm()
        {
            InitializeComponent();
            this.filePath = Directory.GetCurrentDirectory() + FILE_NAME;
        }

        private void ListBoxMouseHover(object sender, EventArgs e)
        {
            int index = GetListBoxIndex(this.teamsListBox);
            if (index < 0) return;
            if (this.teamsListBox.SelectedItems.Count == 1) { index = this.checkedIndex; }
            this.DisplaySingleTicket(index);
        }

        private void ClearTicketLabels(object sender, EventArgs e)
        {
            if (this.teamsListBox.SelectedItems.Count != 1) { this.SingleTicketLabel.Text = ""; }
        }

        private void TeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.GetListBoxIndex(this.teamsListBox);

            if (index >= 0)
            {
                this.ChangeBackColor(index);
                this.DisplaySingleTicket(index);
                this.checkedIndex = index;

                this.SetDataVisible(true);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            this.selectedDate = this.selectionCalendar.SelectionStart.ToShortDateString();
            this.name = this.nameBox.Text;
            this.numTickets = Convert.ToInt32(this.amountBox.Text);

            this.dateLabel.Text = "Date Selected: " + this.selectedDate;
            this.totalCost = this.ticketCost * this.numTickets;
            this.totalLabel.Text = String.Format("Total Cost: {0}", this.totalCost.ToString("C2"));
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newLine = String.Format("{0}, {1}, {2}, {3}",
                this.name, this.numTickets.ToString(), this.selectedDate, this.totalCost);
            this.TryFileOrMake(this.filePath);
            using (StreamWriter sw = File.AppendText(this.filePath))
            {
                sw.WriteLine(newLine);
            }
            this.SetDataVisible(false);
            this.teamsListBox.ClearSelected();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDataForm openForm = new OpenDataForm();
            openForm.Show();
        }

        private int GetListBoxIndex(ListBox listBox)
        {
            Point point = listBox.PointToClient(Cursor.Position);
            int index = listBox.IndexFromPoint(point);
            return index;
        }

        private void DisplaySingleTicket(int listIndex)
        {
            if (listIndex < 0)
            {
                return;
            }
            else if (listIndex == 0)
            {
                this.ticketCost = 120.95;
            }
            else if (listIndex == 1)
            {
                this.ticketCost = 100.23;
            }
            else if (listIndex == 2)
            {
                this.ticketCost = 132.64;
            }
            else if (listIndex == 3)
            {
                this.ticketCost = 95.32;
            }
            this.SingleTicketLabel.Text = String.Format("To watch the {0}\nplay one game, the cost is: {1}", this.teamsListBox.Items[listIndex].ToString(), this.ticketCost.ToString("C2"));
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void ChangeBackColor(int listIndex)
        {
            if (listIndex == 0)
            {
                this.BackColor = Color.Purple;
            }
            else if (listIndex == 1)
            {
                this.BackColor = Color.Silver;
            }
            else if (listIndex == 2)
            {
                this.BackColor = Color.RoyalBlue;
            }
            else if (listIndex == 3)
            {
                this.BackColor = Color.Gold;
            }
        }

        private void TryFileOrMake(string path)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(this.filePath))
                {
                    sw.WriteLine("Name, Num Tickets, Date, Total Cost");
                }
            }
        }

        private void SetDataVisible(bool visible)
        {
            this.calendarLabel.Visible = visible;
            this.selectionCalendar.Visible = visible;
            this.nameBox.Visible = visible;
            this.amountBox.Visible = visible;
            this.calculateButton.Visible = visible;
            this.totalLabel.Visible = visible;
            this.dateLabel.Visible = visible;
        }
    }
}
