using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCostGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckerButton_Click(object sender, EventArgs e)
        {
            int[] servicedZips = { 55800, 55801, 55802, 55803, 55804, 55805, 55806, 55807, 55808, 55809 };
            double[] deliveryPrices = { 10.00, 12.00, 13.50, 49.00, 5.99, 12.50, 9.75, 8.23, 9.99, 10.25 };
            int inputZip = Convert.ToInt32(zipInBox.Text);
            string outText = "";
            if (servicedZips.Contains(inputZip))
            {
                int pos = Array.IndexOf(servicedZips, inputZip);
                double cost = deliveryPrices[pos];
                outText = String.Format("Zip Code Serviced: True\r\nCost of Delivery: ${0}", cost);
            }
            else
            {
                outText = String.Format("Zip Code Serviced: False\r\nCost of Delivery: $0.00");
            }
            serviceLabel.Text = outText;
        }
    }
}
