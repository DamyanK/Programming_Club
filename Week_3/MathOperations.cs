using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Clear();

            //a = 1, b = 2 => sum = 1 + 2 => sum = 3
            int sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");

            //a = 1, b = 2 => diff = 1 - 2 => diff = -1
            int diff = a - b;
            Console.WriteLine($"{a} - {b} = {diff}");

            //a = 1, b = 2 => mult = 1 * 2 => mult = 2 
            int mult = a * b;
            Console.WriteLine($"{a} * {b} = {mult}");

            //a = 1, b = 2 => quot = 1 / 2 => quot = 0
            int quot = a / b;
            Console.WriteLine($"{a} / {b} = {quot}");

            //a = 1, b = 2 => remainder = 1 % 2 => remainder = 1
            int remainder = a % b;
            Console.WriteLine($"{a} % {b} = {remainder}");

            Console.ReadKey();
        }
    }
}
