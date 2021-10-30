using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            START:
            Console.Write("Enter a month: ");
            string month = Console.ReadLine();

            switch(month.ToLower())
            {
                case "march":
                case "april":
                case "may": Console.WriteLine("Spring"); break;
                case "june":
                case "july":
                case "august": Console.WriteLine("Summer"); break;
                case "september":
                case "october":
                case "november": Console.WriteLine("Autumn"); break;
                case "december":
                case "january":
                case "february": Console.WriteLine("Winter"); break;
                default: Console.WriteLine("Invalid choice!"); goto START;
            }
            Console.ReadKey();
        }
    }
}
