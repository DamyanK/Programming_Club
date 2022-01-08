using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.Write($"{i} * {j} = {i * j} | ");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    if (i + j == 12)
                    {
                        Console.WriteLine($"i = {i}, j = {j}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
