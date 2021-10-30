using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Week_11
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        int x = -1;
        int y = -1;
        bool drawing = false;
        Pen pen;

        public Form1()
        {
            InitializeComponent();

            graphics = Canvas.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = LineCap.Round;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            x = e.X;
            y = e.Y;
            Canvas.Cursor = Cursors.Cross;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            x = -1;
            y = -1;
            Canvas.Cursor = Cursors.Default;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing == true && x != -1 && y != -1)
            {
                graphics.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Canvas.Refresh();
        }

        private void pictureBoxRed_Click_1(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pen.Color = picture.BackColor;
        }
    }
}
