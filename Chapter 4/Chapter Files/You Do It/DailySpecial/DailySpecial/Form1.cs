using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailySpecial
{
    public partial class SpecialsForm : Form
    {
        private enum Days
        {
            SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }

        public SpecialsForm()
        {
            InitializeComponent();
        }

        private void SpecialButton_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(SpecialTextBox.Text) - 1;
            string outputSpecial;
            switch ((Days) day)
            {
                case Days.SUNDAY:
                    outputSpecial = "Fried Chicken";
                    break;
                case Days.MONDAY:
                    outputSpecial = "Sorry - Closed";
                    break;
                case Days.TUESDAY:
                case Days.WEDNESDAY:
                case Days.THURSDAY:
                    outputSpecial = "Meat Loaf";
                    break;
                case Days.FRIDAY:
                    outputSpecial = "Fish Fry";
                    break;
                case Days.SATURDAY:
                    outputSpecial = "Liver and Onions";
                    break;
                default:
                    outputSpecial = "Invalid Days";
                    break;
            }
            OutputLabel.Text = outputSpecial;
        }
    }
}
