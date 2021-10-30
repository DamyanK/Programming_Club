using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 2-digit number: ");
            int number = int.Parse(Console.ReadLine());

            //53
            int reversed = 0;
            //reversed = 0 + 3 * 10 = 30
            reversed = reversed + (number % 10 * 10);
            //reversed = 30 + (53 / 10) = 5
            reversed = reversed + (number / 10);

            Console.WriteLine($"Първоначално число = {number}, обърната стойност = {reversed}");
            Console.ReadKey();
        }
    }
}
