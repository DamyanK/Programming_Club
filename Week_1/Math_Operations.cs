using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // | + | - | * | / | % |  ---- Аритметични оператори
            // 
            // > | < | >= | <= | == | !=
            //
            // = --- int a = 5


            Console.Write("Sample for Math.Round -> ");
            Console.WriteLine(Math.Round(7.9639812381, 2));
            Console.Write("Sample for Math.Ceiling -> ");
            Console.WriteLine(Math.Ceiling(7.9639812381));
            Console.Write("Sample for Math.Floor -> ");
            Console.WriteLine(Math.Floor(7.9639812381));
            Console.Write("Sample for Math.Sqrt -> ");
            Console.WriteLine(Math.Sqrt(9));
            Console.Write("Sample for Math.Pow -> ");
            Console.WriteLine(Math.Pow(9, 2));
            Console.Write("Sample for Math.Abs -> ");
            Console.WriteLine(Math.Abs(-17));
            Console.Write("Sample for Math.Max -> ");
            Console.WriteLine(Math.Max(5, 10));
            Console.Write("Sample for Math.Min -> ");
            Console.WriteLine(Math.Min(5, 10));
            Console.ReadKey();
        }
    }
}
