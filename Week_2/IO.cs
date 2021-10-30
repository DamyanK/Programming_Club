using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 4;
            //double number2 = 5.2;
            //Console.WriteLine(number);
            //Console.WriteLine(number2);

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Hello {0}, you are {1} years old!", name, age);

            Console.ReadKey();
        }
    }
}
