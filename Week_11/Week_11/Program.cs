using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11
{
    class Program
    {
        static char[,] grid = {
        //     1    2    3    4    5    6    7    8    9
            { '0', '2', '0', '0', '0', '0', '0', '0', '0' }, // 1
            { '0', '0', '0', '6', '0', '0', '0', '0', '3' }, // 2
            { '0', '7', '0', '8', '0', '0', '0', '0', '0' }, // 3
            { '0', '0', '0', '0', '0', '3', '0', '0', '2' }, // 4
            { '0', '8', '0', '0', '4', '0', '0', '1', '0' }, // 5
            { '6', '0', '0', '5', '0', '0', '0', '0', '0' }, // 6 
            { '0', '0', '0', '0', '1', '0', '7', '8', '0' }, // 7
            { '5', '0', '0', '0', '0', '9', '0', '0', '0' }, // 8
            { '0', '0', '0', '0', '0', '0', '0', '4', '0' }  // 9
        };

        static bool Valid_Move(char[,] grid, int row, int column, char num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (num == grid[row, i])
                {
                    return false;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                if (num == grid[i, column])
                {
                    return false;
                }
            }

            int corner_row = row - row % 3;
            int corner_column = column - column % 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[corner_row + i, corner_column + j] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static bool Solve(char[,] grid, int row, int column)
        {
            if (column == 9)
            {
                if (row == 8)
                {
                    return true;
                }
                row += 1;
                column = 0;
            }

            if (grid[row, column] > '0')
            {
                return Solve(grid, row, column + 1);
            }

            for (char i = '1'; i <= '9'; i++)
            {
                if (Valid_Move(grid, row, column, i))
                {
                    grid[row, column] = i;

                    if (Solve(grid, row, column + 1))
                    {
                        return true;
                    }
                }

                grid[row, column] = '0';
            }

            return false;
        }

        static void Main(string[] args)
        {
            if (Solve(grid, 0, 0))
            {
                for (int i = 0; i < 9; i++)
                {
                    if (i % 3 == 0)
                    {
                        for (int k = 0; k < 25; k++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine();
                    }

                    for (int j = 0; j < 9; j++)
                    {
                        if (j >= 0 && j % 3 == 0)
                        {
                            Console.Write("| ");
                        }

                        Console.Write(grid[i, j] + " ");
                    }
                    Console.WriteLine("|");
                }
                for (int i = 0; i < 25; i++)
                {
                    Console.Write("-");
                }
            }
            else
            {
                Console.WriteLine("Solve is not possible!!!");
            }

            Console.ReadKey();
        }
    }
}
