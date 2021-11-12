using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("AREA OF TRIANGLE: ");
            //Console.Write("Enter a: ");
            //double side = double.Parse(Console.ReadLine());
            //Console.Write("Enter h: ");
            //double h = double.Parse(Console.ReadLine());
            //Console.WriteLine("Result : " + (side * h) / 2);

            //Console.WriteLine();
            //Console.WriteLine("AREA OF RECTANGLE: ");
            //Console.Write("Enter a: ");
            //double side1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter b: ");
            //double side2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Result : " + side1 * side2);

            //Console.WriteLine();
            //Console.WriteLine("AREA OF CIRCLE: ");
            //Console.Write("Enter r: ");
            //double r = double.Parse(Console.ReadLine());
            //Console.WriteLine("Result : " + Math.PI * r * r);

            //Console.WriteLine();
            //Console.WriteLine("AREA OF TRAPEZOID: ");
            //Console.Write("Enter a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Enter b: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Enter h: ");
            //double h1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Result : " + ((a + b) * h1) / 2);

            Console.WriteLine();
            Console.WriteLine("AREA OF PRISM: ");
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter h/l: ");
            double h = double.Parse(Console.ReadLine());

            double P = 4 * a;
            double B = a * a;
            double S = P * h;
            double S1 = S + 2 * B;
            double V = B * h;

            Console.WriteLine($"The full area is: {S1} and the volume is: {V}.");

            Console.ReadKey();
        }
    }
}
