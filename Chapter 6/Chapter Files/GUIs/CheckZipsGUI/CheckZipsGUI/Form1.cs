using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckZipsGUI
{
    public partial class CheckZipsForm : Form
    {
        public CheckZipsForm()
        {
            InitializeComponent();
        }

        private void CheckerButton_Click(object sender, EventArgs e)
        {
            int[] servicedZips = { 55800, 55801, 55802, 55803, 55804, 55805, 55806, 55807, 55808, 55809 };
            int inputZip = Convert.ToInt32(zipInBox.Text);
            string outText = "";
            if (servicedZips.Contains(inputZip))
            {
                outText = String.Format("Zip Code Serviced: True");
            }
            else
            {
                outText = String.Format("Zip Code Serviced: False");
            }
            serviceLabel.Text = outText;
        }
    }
}
