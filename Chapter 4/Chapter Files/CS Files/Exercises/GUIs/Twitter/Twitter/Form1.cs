using System;
using System.Windows.Forms;

namespace Twitter
{
    public partial class TwitterForm : Form
    {
        public TwitterForm()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int maxLen = 140;
            int length = inputBox.Text.Length;
            if (length > maxLen)
            {
                outputLabel.Text = ("Your message is too long");
            }
            else
            {
                outputLabel.Text = String.Format("Your message is acceptable\n and is {0} characters long", length);
            }
        }
    }
}
