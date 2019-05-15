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
using static System.Console;

namespace TeamSelector
{
    public partial class OpenDataForm : Form
    {
        public OpenDataForm()
        {
            InitializeComponent();
            this.LoadData();
        }

        private void LoadData()
        {
            string ticketData = "";
            string path = Directory.GetCurrentDirectory() + @"\SoldTickets.txt";
            if (File.Exists(path))
            {
                int numLines = File.ReadLines(path).Count();
                if (numLines > 0)
                {
                    string[] lines = new string[numLines];
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string[] lineContents = new string[numLines];
                        string currentLine = "";
                        int count = 0;
                        while ((currentLine = sr.ReadLine()) != null)
                        {
                            lineContents = currentLine.Split(',');
                            string addedLine = String.Format("{0} bought{1} tickets for{2} totalling {3}",
                                lineContents[0], lineContents[1], lineContents[2], Convert.ToDouble(lineContents[3]).ToString("C2"));
                            lines[count] = (addedLine);
                            count++;
                        }
                    }
                    Array.Sort(lines);
                    foreach (string line in lines) { ticketData += line + "\n"; }
                    this.savedDataLabel.Text = ticketData; 
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
