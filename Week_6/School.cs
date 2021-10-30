using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day from the week: ");
            string day = Console.ReadLine();

            switch (day.ToLower())
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday": Console.WriteLine("School :( yuck"); break;
                case "saturday":
                case "sunday": Console.WriteLine("Free time :D"); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }

            Console.ReadKey();
        }
    }
}
