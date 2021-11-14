using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better_Math_Formulas_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose a figure: \n1 - Triangle \n2 - Rectangle \n3 - Circle" +
                "\n4 - Trapezoid \n5 - Prism \n6 - Sphere \n> ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("AREA OF TRIANGLE: ");
                        Console.Write("Enter a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter h: ");
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine("Result : " + (a * h) / 2);
                    } break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("AREA OF RECTANGLE: ");
                        Console.Write("Enter a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Result : " + a * b);
                    } break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("AREA OF CIRCLE: ");
                        Console.Write("Enter r: ");
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine("Result : " + Math.PI * r * r);
                    } break;
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("AREA OF TRAPEZOID: ");
                        Console.Write("Enter a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter h: ");
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine("Result : " + ((a + b) * h) / 2);
                    } break;
                case 5:
                    {
                        Console.Clear();
                        Console.WriteLine("AREA AND VOLUME OF PRISM: ");
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
                    } break;
                case 6:
                    {
                        Console.WriteLine("AREA AND VOLUME OF SPHERE");
                        Console.Write("Enter r: ");
                        double r = double.Parse(Console.ReadLine());
                        double S = 4 * Math.PI * r * r;
                        double V = (4 * Math.PI * Math.Pow(r, 3)) / 3;

                        Console.WriteLine($"The full area is: {Math.Round(S, 2)} and the volume is:" +
                            $" {Math.Round(V, 2)}.");
                    } break;
            }

            Console.ReadKey();
        }
    }
}
