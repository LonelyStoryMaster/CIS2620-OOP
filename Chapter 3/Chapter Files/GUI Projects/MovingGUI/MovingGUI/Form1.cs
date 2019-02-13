using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingGUI
{
    public partial class MovingForm : Form
    {
        public MovingForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double hours = Convert.ToDouble(hoursInput.Text);
            double miles = Convert.ToDouble(milesInput.Text);
            double cost = 200 + (hours * 150.00) + (miles * 2.00);
            outputBox.Text = Convert.ToString(cost);
        }
    }
}
