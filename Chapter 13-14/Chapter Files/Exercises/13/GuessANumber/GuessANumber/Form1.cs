using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class GuessANumberForm : Form
    {
        Random rando = new Random();
        private int randomNum;

        public GuessANumberForm()
        {
            InitializeComponent();
            this.randomNum = this.GenerateNewNum(0, 6);
        }

        private void CheckWinner(object sender, EventArgs e)
        {
            RadioButton[] numberButtons = { this.radioOne, this.radioTwo, this.radioThree, this.radioFour, this.radioFive };
            bool correctButton = false;
            int count = 1;
            foreach ( RadioButton button in numberButtons )
            {
                button.Enabled = false;
                if ((button.Checked) && (count == this.randomNum))
                {
                    correctButton = true;
                    break;
                }
            }
            if (correctButton)
            {
                this.winLabel.Text = "Congratulations. You picked the right number";
            }
            else
            {
                this.winLabel.Text = "Whoops. Wrong answer. Try again";
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            RadioButton[] numberButtons = { this.radioOne, this.radioTwo, this.radioThree, this.radioFour, this.radioFive };
            foreach (RadioButton button in numberButtons)
            {
                button.Enabled = true;
                button.Checked = false;
            }
            this.winLabel.Text = "";
            this.randomNum = this.GenerateNewNum(0,6);
            // this.numberButton.Text = this.randomNum.ToString();
        }

        private void GiveHint(object sender, EventArgs e)
        {
            RadioButton[] numberButtons = { this.radioOne, this.radioTwo, this.radioThree, this.radioFour, this.radioFive };
            for (int i = 0; i < numberButtons.Length; i++)
            {
                if (i != this.randomNum)
                {
                    winLabel.Text = String.Format("{0} isn't the right choice", i+1);
                    break;
                }
            }
        }

        private int GenerateNewNum(int min, int max)
        {
            return (this.rando.Next(min, max));
        }
    }
}
