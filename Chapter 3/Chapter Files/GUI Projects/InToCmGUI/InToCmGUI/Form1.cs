using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InToCmGUI
{
    public partial class InchesToCentimeters : Form
    {
        public InchesToCentimeters()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            double inches = Convert.ToDouble(inchesInput.Text);
            double cms = inches * 2.54;
            outputBox.Text = Convert.ToString(cms);
        }
    }
}
