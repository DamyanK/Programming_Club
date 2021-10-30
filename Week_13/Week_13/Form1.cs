using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] answers = { "Yes of course!", "May the power be with you!",
            "Sorry for the circumstances!", "By the way, no!", "OK", "50/50" };

        Random random = new Random();

        // При цъкване на бутона
        private void buttonAsk_Click(object sender, EventArgs e)
        {
            // За после
            string text = textBoxQuestion.Text;
            string[] words = text.Split(' ', '?');
            // Как се мие кола?
            // [Как] [се] [мие] [кола]
            //   0     1    2      3

            bool banned = false;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "suicide" || words[i] == "самоубия" || words[i] == "убия") // ...
                {
                    banned = true;
                    break;
                }
            }

            if (banned)
            {
                MessageBox.Show("YOU BETTER NOT!");
            }
            else
            {
                int rnd = random.Next(0, answers.Length);
                MessageBox.Show(answers[rnd]);
            }
        }
    }
}
