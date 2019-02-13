using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlix
{
    public partial class MyFlix : Form
    {
        public MyFlix()
        {
            InitializeComponent();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            double pricePerTitle = 1.99;
            double total = 0.00;
            int count = 0;
            for (int x = 0; x < titlesList.Items.Count; x++)
            {
                if (titlesList.GetSelected(x))
                {
                    count++;
                }
            }
            total = pricePerTitle * count;
            selectionCount.Text = "Number of Titles Selected: " + Convert.ToString(count);
            priceLabel.Text = "Total Price: " + Convert.ToString(total);
        }
    }
}
