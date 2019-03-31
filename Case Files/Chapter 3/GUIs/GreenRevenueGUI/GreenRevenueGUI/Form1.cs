using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenRevenueGUI
{
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
        }

        private void CalcRevButton_Click(object sender, EventArgs e)
        {
            const int PRICE_PER_PERSON = 25;

            int numLastYear, numThisYear, revenue;

            numLastYear = Convert.ToInt32(lastYearTextBox.Text);
            numThisYear = Convert.ToInt32(thisYearTextBox.Text);

            if (numLastYear > 30 || numLastYear < 0)
            {
                numLastYear = -1;
            }

            if (numThisYear > 30 || numLastYear < 0)
            {
                numThisYear = -1;
                revenue = 0;
            } else
            {
                revenue = PRICE_PER_PERSON * numThisYear;
            }

            string yearString = "";
            if (numThisYear.Equals(-1) || numLastYear.Equals(-1))
            {
                yearString = "You entered an incorrect number of contestants";
            }
            else if (numThisYear > numLastYear)
            {
                yearString = "The competition is bigger than ever!";
            }
            else if (numThisYear < numLastYear)
            {
                yearString = "A tighter race this year! Come out and cast your vote!";
            }
            else if (numThisYear > (numLastYear * 2))
            {
                yearString = "The competition is more than twice as big this year!";
            }
            else if (numLastYear.Equals(numThisYear))
            {
                yearString = "It\'s all tied up!";
            }

            string revString = String.Format("The expected revenue for this year is: ${0}", revenue);

            outLabel.Text = String.Format(revString + "\n" + yearString);
        }
    }
}
