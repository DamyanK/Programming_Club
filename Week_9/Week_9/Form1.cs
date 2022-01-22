using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        Button[,] buttons;
        bool turn = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons = new Button[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].BackColor = Color.White;
                    buttons[i, j].Size = new Size(100, 100);
                    buttons[i, j].Location = new Point(100 * j, 100 * i);
                    buttons[i, j].Click += new EventHandler(button_click);
                    Controls.Add(buttons[i, j]);
                }
            }
            ClientSize = new Size(300, 300);
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (turn)
            {
                b.Text = "O";
                b.Name = "O";
                b.Enabled = false;
                turn = false;
                Win(buttons, "O");
            }
            else
            {
                b.Text = "X";
                b.Name = "X";
                b.Enabled = false;
                turn = true;
                Win(buttons, "X");
            }

            if (Tie(buttons) == 0)
            {
                MessageBox.Show("It's a tie!", "GAME OVER!");
                this.Close();
            }
        }

        private bool equal(string a, string b, string c, string d)
        {
            return a == b && b == c && c == d;
        }

        private void Win(Button[,] grid, string player)
        {
            bool win = false;

            for (int i = 0; i < 3; i++)
            {
                if (equal(player, grid[i, 0].Name, grid[i, 1].Name, grid[i, 2].Name))
                {
                    win = true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (equal(player, grid[0, i].Name, grid[1, i].Name, grid[2, i].Name))
                {
                    win = true;
                }
            }

            if (equal(player, grid[0, 0].Name, grid[1,1].Name, grid[2,2].Name))
            {
                win = true;
            }
            if (equal(player, grid[2, 0].Name, grid[1,1].Name, grid[0, 2].Name))
            {
                win = true;
            }

            if (win)
            {
                MessageBox.Show($"Player {player} wins!", "GAME OVER!");
                this.Close();
            }
        }

        private int Tie(Button[,] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].Enabled)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
