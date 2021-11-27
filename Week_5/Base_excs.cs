using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // |5;50| -> n*n -/> try again
            while (n < 5 || n > 50)
            {
                Console.Write("Try again: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(n * n);

            // Въвеждат се цели числа и се изписват, докато не се въведе 0

            int a = int.Parse(Console.ReadLine());
            int min = a;
            int max = a;
            int sum = 0;
            while (a != 0)
            {
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }
                sum = sum + a;
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Max = {max} \nMin = {min} \nSum = {sum}");

            //int sum = 0;
            //for (int i = 11; i <= 42; i++)
            //{
            //    sum = sum + i;
            //    Console.WriteLine($"[{i}] = {sum}");
            //}
            //Console.WriteLine("Total = " + sum);

            int mul = 1;
            for (int i = 5; i <= 25; i = i + 5)
            {
                mul = mul * i;
                Console.WriteLine($"[{i}] = {mul}");
            }
            Console.WriteLine("Total = " + mul);





            Console.ReadKey();
        }
    }
}
