using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Редица на Фибоначи до елемент < 200 === 0 1 1 2 3 5 8 13 21 34 55 89 144

            int a = 0;
            int b = 1;
            int c = 1;

            while (a < 12200)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine();

            a = 0;
            b = 1;
            c = 1;

            do
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            } while (a < 12200);

            // Да се въведат N на брой числа и ако сумата им е четно число да се отпечaта YES, иначе NO
            //int N = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 0; i < N; i++)
            //{
            //    sum += int.Parse(Console.ReadLine());
            //}

            //if (sum % 2 == 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            Console.ReadKey();
        }
    }
}
