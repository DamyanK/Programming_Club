using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.ReadKey();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("How old are you? : ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {name}. You are {age} y.o.");
            Console.ReadKey();
        }
    }
}
