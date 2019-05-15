using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyButtons
{
    public partial class ManyButtonsForm : Form
    {
        public ManyButtonsForm()
        {
            InitializeComponent();
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
