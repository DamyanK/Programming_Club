using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            // a = 1, b = 2, c = 3
            // Av = (1 + 2 + 3) / 3 = 6 / 3 = 2

            Console.Write("Enter number 1: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter number 3: ");
            double c = double.Parse(Console.ReadLine());

            double average = (a + b + c) / 3;

            Console.WriteLine($"Average = {average}");
            Console.ReadKey();
        }
    }
}
