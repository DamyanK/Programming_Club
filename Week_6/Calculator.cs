using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            Console.Write("Enter operation: ");
            //int operation = int.Parse(Console.ReadLine()); 
            string operation = Console.ReadLine();

            // Console.ReadLine() = string
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            //if (operation == 1)
            //{
            //    Console.WriteLine(a + b);
            //}
            //else if (operation == 2)
            //{
            //    Console.WriteLine(a - b);
            //}
            //else if (operation == 3)
            //{
            //    Console.WriteLine(a * b);
            //}
            //else if (operation == 4)
            //{
            //    Console.WriteLine(a / b);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operation!");
            //}

            switch(operation.ToLower())
            {
                case "sum": Console.WriteLine(a + b); break;
                case "subtract": Console.WriteLine(a - b); break;
                case "multiplication": Console.WriteLine(a * b); break;
                case "division": Console.WriteLine(a / b); break;
                default: Console.WriteLine("Invalid Operation!"); break;
            }

            Console.ReadKey();
        }
    }
}
