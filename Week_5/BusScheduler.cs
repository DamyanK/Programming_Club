using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusNavigator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Departure: ");
            Console.Write("Hour: ");
            int h = int.Parse(Console.ReadLine());

            Console.Write("Minutes: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Duration in minutes: ");
            int duration = int.Parse(Console.ReadLine());

            int departureMins = h * 60 + m;

            // 09h.20m + 0h.30m = 540 + 20 + 30 = 590
            int arrivalInMins = departureMins + duration;

            int arrivalHour = arrivalInMins / 60 % 24;
            //590 / 60 = 9,9
            //590 % 60 = 59 % 6 = 9| ->  5 * 10
            int arrivalMinute = arrivalInMins % 60;

            Console.WriteLine($"Departs at: {h}h.{m}m - Arrives at: {arrivalHour}h.{arrivalMinute}m");
            Console.ReadKey();
        }
    }
}
