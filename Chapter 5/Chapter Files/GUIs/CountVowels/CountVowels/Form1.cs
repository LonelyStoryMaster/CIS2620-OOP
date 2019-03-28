using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class CountVowelsForm : Form
    {
        public CountVowelsForm()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            char[] vowels = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };

            string input = inputBox.Text;

            int vowelCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    vowelCount += 1;
                }
            }

            string output  = "Number of Vowels: " + Convert.ToString(vowelCount);
            countLabel.Text = output;
        }
    }
}
