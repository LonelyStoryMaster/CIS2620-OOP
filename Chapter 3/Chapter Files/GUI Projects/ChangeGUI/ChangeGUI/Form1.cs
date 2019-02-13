using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeGUI
{
    public partial class ChangeGui : Form
    {
        public ChangeGui()
        {
            InitializeComponent();
        }

        private void MakeChange_Click(object sender, EventArgs e)
        {
            List<int> moneyVals = new List<int>();
            List<int> moneyCounts = new List<int>();
            List<TextBox> textBoxes = new List<TextBox>();

            moneyVals.AddRange(new int[] { 20, 10, 5, 1 });
            textBoxes.AddRange(new TextBox[] { twentiesBox, tensBox, fivesBox, onesBox });

            double changeMade = 0.0;
            double moneyIn = Convert.ToDouble(moneyInput.Text);

            for (int i = 0; i < moneyVals.Count; i++)
            {
                double moneyLeft = moneyIn - changeMade;
                moneyCounts.Add((int)moneyLeft / moneyVals[i]);
                textBoxes[i].Text = Convert.ToString(moneyCounts[i]);
                changeMade += moneyCounts[i] * moneyVals[i];
            }
        }
    }
}
