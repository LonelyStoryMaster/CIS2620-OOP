using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshallsRevenueGUI
{
    public partial class revenueForm : Form
    {
        public revenueForm()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            int[] nonExteriorMonths = { 12, 1, 2 };
            int[] preferedExtMonths = { 4, 5, 9, 10 };
            int[] preferedIntMonths = { 7, 8 };

            int intPrice = 500;
            int extPrice = 750;

            int intCount = 0, extCount = 0, monthInt = 0;

            try
            {
                intCount = Convert.ToInt32(interiorBox.Text);
                extCount = Convert.ToInt32(exteriorBox.Text);
                monthInt = Convert.ToInt32(monthBox.Text);
            } catch (FormatException) {
                intCount = 0;
                extCount = 0;
                monthInt = 0;
            }

            if (nonExteriorMonths.Contains(monthInt))
            {
                extCount = 0;
            }
            if (preferedIntMonths.Contains(monthInt))
            {
                intPrice = 450;
            }
            if (preferedExtMonths.Contains(monthInt))
            {
                extPrice = 699;
            }

            int intTotal = intCount * intPrice;
            int extTotal = extCount * extPrice;
            int total = intTotal + extTotal;

            string intString = string.Format("Interior Murals \n\n Number of Murals:  {0}\nPrice per Mural:  ${1}\nSubtotal:  ${2}", intCount, intPrice, intTotal);
            string extString = string.Format("Exterior Murals \n\n Number of Murals:  {0}\nPrice per Mural:  ${1}\nSubtotal:  ${2}", extCount, extPrice, extTotal);

            interiorLabel.Text = intString;
            exteriorLabel.Text = extString;

            totalLabel.Text = string.Format("Total Price: ${0}", total);
        }
    }
}
