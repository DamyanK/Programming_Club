using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Week_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            string text = richTextBox1.Text;
            for (int i = 0; i < richTextBox1.Text.Length - 1; i++)
                if (text[i] == ' ' && text[i + 1] != ' ')
                    count++;
            labelCount.Text = (count + 1).ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            labelCount.Text = "";
        }
    }
}
