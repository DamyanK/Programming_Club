using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("До кой символ да се закръглят числата(0 - 15)? > ");
            int symb = int.Parse(Console.ReadLine());

            //EUR to BGN
            Console.Write("EUR = ");
            double euro = double.Parse(Console.ReadLine());
            double leva = Math.Round(euro * 1.95583, symb);
            Console.WriteLine($"{euro} EUR = {leva} BGN");

            //BGN to EUR
            Console.Write("BGN = ");
            double bgn = double.Parse(Console.ReadLine());
            double eur = Math.Round(bgn * 0.511292, symb);
            Console.WriteLine($"{bgn} BGN = {eur} EUR");

            Console.ReadKey();
        }
    }
}
