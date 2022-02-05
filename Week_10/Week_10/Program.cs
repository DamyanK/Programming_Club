using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10
{
    class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        } 

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static int[] SortArray(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            return a;
        }

        static int[] ReverseArray(params int[] a)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = temp;
            }

            return a;
        }

        static ulong Factorial(ulong a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a * Factorial(a - 1);
        }

        static int Fibbonaci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fibbonaci(n - 1) + Fibbonaci(n - 2);
        }

        static void Main(string[] args)
        {
            //Add(3, 3);
            //Console.WriteLine(Subtraction(4, 5));

            //int[] array = { 3, -1, 0, 2, 1 };
            //Console.WriteLine(string.Join(" ", array));
            //array = SortArray(array);
            //Console.WriteLine(string.Join(" ", array));
            //array = ReverseArray(3,1,2,3,4,5,6,7,1);
            //Console.WriteLine(string.Join(" ", array));

            //Console.WriteLine(Factorial(5));

            //int a = 0;
            //int b = 1;
            //int c = 0;

            //while (a < 200)
            //{
            //    c = a + b;
            //    Console.WriteLine(c);
            //    a = b;
            //    b = c;
            //}

            Console.WriteLine(Fibbonaci(9));

            Console.ReadKey();
        }

        /*
         Богомил -   3
         Боян -      7
         Георги -    1 
         Момчил -    2
         Даниел -    4
         Кристияна - 6
         Виктор -    5         
         */



    }
}
