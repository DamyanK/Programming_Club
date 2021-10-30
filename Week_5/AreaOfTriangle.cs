using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            // S = (a * h) / 2
            Console.Write("Enter a side: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            double h = double.Parse(Console.ReadLine());

            double S = (a * h) / 2;

            Console.WriteLine($"The area is: {S}");
            Console.ReadKey();
        }
    }
}
