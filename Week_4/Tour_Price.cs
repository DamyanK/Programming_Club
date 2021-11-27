using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int proverka = 0;
            if (n >= 1 && n <= 20)
            {
                proverka = 1;
            }
            else
            {
                if (n <= 100)
                {
                    proverka = 2;
                }
                else
                {
                    if (n <= 5000)
                    {
                        proverka = 3;
                    }
                }
            }

            switch (proverka)
            {
                case 1:
                    {
                        Console.Write("D/N? > ");
                        string dn = Console.ReadLine();
                        switch (dn.ToLower())
                        {
                            case "d": Console.WriteLine(0.7 + n * 0.79 + "лв."); break;
                            case "n": Console.WriteLine(0.7 + n * 0.9 + "лв."); break;
                            default: Console.WriteLine("greshka"); break;
                        }
                    } break;
                case 2: Console.WriteLine(n * 0.09 + "лв."); break;
                case 3: Console.WriteLine(n * 0.06 + "лв."); break;
            }

            //if (n <= 5000 && n >= 1)
            //{
            //    if (n <= 20)
            //    {
            //        Console.Write("day/night -> ");
            //        string dayCycle = Console.ReadLine();

            //        switch (dayCycle.ToLower())
            //        {
            //            case "day": Console.WriteLine(0.7 + n * 0.79 + "лв."); break;
            //            case "night": Console.WriteLine(0.7 + n * 0.9 + "лв."); break;
            //            default: Console.WriteLine("Invalid choice! Try again with day or night!"); break;
            //        }
            //    }
            //    else
            //    {
            //        if (n <= 100)
            //        {
            //            Console.WriteLine(n * 0.09 + "лв.");
            //        }
            //        else
            //        {
            //            Console.WriteLine(n * 0.06 + "лв.");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Try again!");
            //}

            Console.ReadKey();
        }
    }
}
