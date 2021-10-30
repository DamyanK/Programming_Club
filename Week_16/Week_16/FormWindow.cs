using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_16
{
    public partial class FormWindow : Form
    {
        public FormWindow()
        {
            InitializeComponent();
        }

        private Mp3 mp3 = new Mp3();
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3.Open(ofd.FileName);
                }
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            mp3.Play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            mp3.Stop();
        }
    }
}
