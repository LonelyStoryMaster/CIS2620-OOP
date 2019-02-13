using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            double product; //Forgotten semi-colon
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text); //ToDouble spelled wrong
            product = num1 * num2; //Numbers added not mulitpilied
            outputLabel.Text = String.Format("{0} times {1} is {2}", num1, num2, product);
            //forogot commas in print
        }
    }
}
