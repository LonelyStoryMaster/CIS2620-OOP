using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedNBreakfast
{
    public partial class BaileysForm : Form
    {
        public BaileysForm()
        {
            InitializeComponent();
        }

        private void BelleAireCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (belleAireCheckBox.Checked)
            {
                BelleAireForm belleAireForm = new BelleAireForm();
                belleAireForm.ShowDialog();
                belleAireCheckBox.Checked = false;
            }
        }

        private void LincolnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lincolnCheckBox.Checked)
            {
                LincolnRoom lincolnRoom = new LincolnRoom();
                lincolnRoom.ShowDialog();
                lincolnCheckBox.Checked = false;
            }
        }

        private void MealButton_Click(object sender, EventArgs e)
        {
            BreakfastOptionsForm breakfastForm = new BreakfastOptionsForm();
            breakfastForm.ShowDialog();
        }
    }
}
