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
using System.Threading;

namespace Week_16
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if ((txtPassword.Text == "" && txtUsername.Text == "")
                || (txtPassword.Text != "" && txtUsername.Text == "")
                || (txtPassword.Text == "" && txtUsername.Text != ""))
            {
                MessageBox.Show("Please fill up the blanks!");
            }
            // Всякакви манипулации и заявки
            else
            {
                //bool usernameCorrect = true, passwordCorrect = true;
                if (txtUsername.Text.Length < 8)
                {
                    txtUsername.Clear();
                    MessageBox.Show("The field 'username' must contain at least 8 symbols");
                    txtUsername.Focus();
                }
                else
                {
                    if (txtPassword.Text.Length < 8)
                    {
                        txtPassword.Clear();
                        MessageBox.Show("The field 'password' must contain at least 8 symbols");
                        txtPassword.Focus();
                    }
                    // Тук вече ще регистрираме
                    else
                    {
                        Register(txtUsername.Text, txtPassword.Text);

                        FormLogIn fl = new FormLogIn();
                        this.Hide();
                        fl.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void Register(string username, string password)
        {
            FileStream fs = new FileStream("users.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(username);
            sw.WriteLine(password);

            sw.Close();
            fs.Close();
        }
    }
}
