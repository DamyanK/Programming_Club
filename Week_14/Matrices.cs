using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = random.Next(-5, 11);
                    matrix2[i, j] = random.Next(-5, 11);
                }
            }

            int[,] matrix3 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} + {1} = {2} \t", matrix1[i, j], matrix2[i, j], matrix3[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
