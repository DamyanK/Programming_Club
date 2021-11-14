using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
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
                case "понеделник":
                case "tuesday":
                case "вторник":
                case "wednesday":
                case "сряда":
                case "thursday":
                case "четвъртък":
                case "петък":
                case "friday": Console.WriteLine("Weekday"); break;
                case "saturday":
                case "събота":
                case "неделя":
                case "sunday": Console.WriteLine("Weekend"); break;
                default: Console.WriteLine("Имаш някаква грешка!"); break;
            }

            /*
             * switch (<променлива>/<условие>)
             * {
             *      case <стойност>: <действие>; break;
             *      case <стойност 2>: <действие 2>; break;
             *      ...
             *      case <стойност N>: <действие N>; break;
             *      default: <действие>; break; ----> default = else
             * }
             */

            Console.ReadKey();
        }
    }
}
