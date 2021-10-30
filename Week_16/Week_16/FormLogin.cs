using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_16
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private static FileStream fs = new FileStream("users.txt", FileMode.OpenOrCreate);
        private static StreamReader sr = new StreamReader(fs);

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            while (sr.EndOfStream == false)
            {
                string tempUsr, tempPss;
                tempUsr = sr.ReadLine();
                tempPss = sr.ReadLine();

                if (txtUsername.Text == tempUsr && txtPassword.Text == tempPss)
                {
                    FormWindow fw = new FormWindow();
                    this.Hide();
                    fw.ShowDialog();
                    this.Close();
                    break;
                }
                else
                {
                    MessageBox.Show("Username or password incorrect!", "ERROR");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    continue;
                } 
            }
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void labelReg_Click(object sender, EventArgs e)
        {
            FormRegister fg = new FormRegister();
            this.Hide();
            fg.ShowDialog();
            this.Close();
        }
    }
}
