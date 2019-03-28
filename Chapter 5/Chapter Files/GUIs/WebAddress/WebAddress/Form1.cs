using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAddress
{
    public partial class WebAddressForm : Form
    {
        public WebAddressForm()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            char[] whitespaces = { ' ', '\t', '\n' };

            string boxInput = nameInputBox.Text;
            string suggestion = "";

            if (boxInput != "Enter your Business Name")
            {
                string businessName = "";
                for (int i = 0; i < boxInput.Length; i++)
                {
                    // string currentCh = (string) inputName[i];
                    if (!whitespaces.Contains(boxInput[i]))
                    {
                        businessName += boxInput[i];
                    }
                }
                suggestion = "www." + businessName + ".com";
            }
            suggestionLabel.Text = suggestion;
        }
    }
}
