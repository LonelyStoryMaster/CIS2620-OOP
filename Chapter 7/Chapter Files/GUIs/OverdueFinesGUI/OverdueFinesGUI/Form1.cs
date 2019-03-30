using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverdueFinesGUI
{
    public partial class OverdueFinesForm : Form
    {
        public OverdueFinesForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int numBooks = Convert.ToInt32(bookInputBox.Text);
            int numDays = Convert.ToInt32(daysInputBox.Text);

            double totalFine = CalcFines(numBooks, numDays);
            finesLabel.Text = String.Format("Total fines: ${0}", totalFine);
        }

        static double CalcFines(int numBooks, int numDays)
        {
            const double SEVEN_DAY_FINE = 0.1;
            const double OVER_SEVEN_FINE = 0.2;
            double totalFine;
            if (numDays > 7)
            {
                totalFine = ((7 * SEVEN_DAY_FINE) + ((numDays - 7) * OVER_SEVEN_FINE)) * numBooks;
            }
            else
            {
                totalFine = (numDays * SEVEN_DAY_FINE) * numBooks;
            }
            return totalFine;
        }
    }
}
