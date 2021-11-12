using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // int - целочислен тип -> 1, 0, 2321, -15 ...
            Console.Write("Enter sample for INT: ");
            int a = int.Parse(Console.ReadLine());

            // double - реален тип числа -> 0.221, 14.25, -33.12, 12.0 ...
            Console.Write("Enter sample for DOUBLE: ");
            double b = double.Parse(Console.ReadLine());

            // char - символ -> 'D', 'a', '1', '^' ...
            Console.Write("Enter sample for CHAR: ");
            char c = char.Parse(Console.ReadLine());

            // string - символен низ -> "string", "123", "ала-бала", *"§43"* ... 
            Console.Write("Enter sample for STRING: ");
            string d = Console.ReadLine();

            Console.WriteLine($"\nYour sample for int \t:\t {a} \nYour sample for double \t:\t {b} " +
                $"\nYour sample for char \t:\t {c} \nYour sample for string \t:\t {d}");
            Console.ReadKey();
        }
    }
}
