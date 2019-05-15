using System;
using System.Windows.Forms;
using System.IO;

namespace ViewInvoices
{
    public partial class InvoicesForm : Form
    {
        const char DELIM = ',';
        static string filename = @Directory.GetCurrentDirectory() + @"\Invoices.txt";
        string recordIn;
        string[] fields;

        static FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);

        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                recordIn = reader.ReadLine();
                fields = recordIn.Split(DELIM);
                invoiceBox.Text = fields[0];
                nameBox.Text = fields[1];
                amountBox.Text = fields[2];
            }
            catch (NullReferenceException)
            {
                titleLabel.Text = "You have viewed\nall the records";
                viewButton.Enabled = false;

            }
        }
    }
}
