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

namespace HighScore
{
    public partial class GuessingForm : Form
    {
        const int NUM_ROUNDS = 10;
        int highScore, score = 0, count = 0;
        string filename = @Directory.GetCurrentDirectory() + @"\Highscore.txt";
        string computerGuess;
        RadioButton[] letterButtons;
        string[] letters = { "A", "B", "C" };

        public GuessingForm()
        {
            InitializeComponent();

            letterButtons = new RadioButton[3] { this.radioA, this.radioB, this.radioC };

            if (!File.Exists(filename))
            {
                using (StreamWriter sw = File.CreateText(filename) ) { sw.WriteLine(0); }
            }
            using ( StreamReader sr = File.OpenText(filename) ) { highScore = Convert.ToInt32(sr.ReadLine()); }
            this.ResetRadioButtons();
            this.highScoreLabel.Text = "Previous High Score: " + highScore.ToString();
        }

        private void PickLetter()
        {
            this.ResetRadioButtons();
            Random rando = new Random();
            int letterPos = rando.Next(0, this.letters.Length);
            this.computerGuess = this.letters[letterPos];
            this.computerLabel.Text = "Computer Chose: _" + this.computerGuess + "_";
        }

        private void CheckLetter(object sender, EventArgs e)
        {
            if (count < NUM_ROUNDS)
            {
                PickLetter();
                for (int i = 0; i < this.letterButtons.Length; i++)
                {
                    if (this.letterButtons[i].Checked && (this.computerGuess == this.letters[i]))
                    {
                        this.score += 1;
                        break;
                    }
                }
                count += 1; 
            } else { CheckScore(); }
            this.playerScoreLabel.Text = "Your score is: " + this.score.ToString();
        }

        private void ResetRadioButtons()
        {
            foreach (RadioButton button in this.letterButtons)
            {
                button.Enabled = true;
                button.Checked = false;
            }
        }

        private void CheckScore()
        {
            if (this.score > this.highScore)
            {
                if (File.Exists(this.filename))
                {
                    File.Delete(this.filename);
                }
                using (StreamWriter sw = File.CreateText(filename)) { sw.WriteLine(this.score); }
            }
        }
    }
}
