using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthChecker
{
    public partial class monthCheckerForm : Form
    {
        public monthCheckerForm()
        {
            InitializeComponent();
        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string inputMonth = inputBox.Text;
            if (months.Contains(inputMonth)) {
                outputLabel.Text = "You have entered a valid month.\n Congratulations";
            } else
            {
                outputLabel.Text = "That isn't a valid month.\n Try again";
            }
        }
    }
}
