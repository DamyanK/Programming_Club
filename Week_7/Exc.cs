using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Enter N: ");
                N = int.Parse(Console.ReadLine());
            } while (N < 0 || N > 50);

            while (true)
            {
                Console.Write("Enter the type of the array you want: (string/double/int) > ");
                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "int": int[] array = new int[N];
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Your elements: " + string.Join(" ", array));
                        Console.ReadKey();
                        break;

                    case "double": double[] array_double = new double[N];
                        for (int i = 0; i < array_double.Length; i++)
                        {
                            array_double[i] = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Your elements: " + string.Join(" ", array_double));
                        Console.ReadKey();
                        break;

                    case "string": string[] array_string = new string[N];
                        for (int i = 0; i < array_string.Length; i++)
                        {
                            array_string[i] = Console.ReadLine();
                        }
                        Console.WriteLine("Your elements: " + string.Join(" ", array_string));
                        Console.ReadKey();
                        break;

                    default: Console.WriteLine("Please choose a valid type from above!"); continue;
                }
                break;
            }
        }
    }
}
