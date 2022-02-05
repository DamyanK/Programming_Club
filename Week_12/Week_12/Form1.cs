using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            try
            {
                processes[listBox.SelectedIndex].Kill();
                GetAllProc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Process[] processes;
        private void GetAllProc()
        {
            processes = Process.GetProcesses();
            listBox.Items.Clear();
            foreach (var item in processes)
            {
                listBox.Items.Add(item.ProcessName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProc();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            using (CreateNew form = new CreateNew())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    GetAllProc();
                }
            }
        }
    }
}
