using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EnterInvoices
{
    public partial class InvoiceForm : Form
    {
        const string DELIM = ",";
        static string filename = @Directory.GetCurrentDirectory() + @"\Invoices.txt";
        int num;
        string name;
        double amount;

        static FileStream outFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);

        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(numberBox.Text);
            name = nameBox.Text;
            amount = Convert.ToDouble(amountBox.Text);
            writer.WriteLine(num + DELIM + name + DELIM + amount);
            numberBox.Clear();
            nameBox.Clear();
            amountBox.Clear();
        }
    }
}
