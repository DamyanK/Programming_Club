using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Условни конструкции

            // Кратка форма
            if (2 + 2 == 5)
            {
                Console.WriteLine("da");
            }

            // if - else конструкция
            if (2 + 2 == 5)
            {
                Console.WriteLine("da, taka e");
            }
            else
            {
                //Console.WriteLine("ne stava taka");
            }

            // Пълна форма
            if (2 + 2 == 5)
            {
                Console.WriteLine("da");
            }
            else if (2 + 2 == 4)
            {
                //Console.WriteLine("tozi put stana");
            }
            // else if()
            // else if()
            // ...
            else
            {
                Console.WriteLine("tva ne moje bude!");
            }

            // 2 5 7 -> 1
            // 7 5 2 -> -1
            // 2 7 5 -> 0

            // РАЗЯСНЕНИЯ: 
            // Въведете 3 числа, целочислен тип
            // Проверете дали са подредени
            // ЖОКЕР: A < B и B < C == 1

            int a = 3;
            int b = 5;
            int c = 7;

            //if (a < b && b < c)
            //{
            //    Console.WriteLine("1");
            //}
            //else if (a > b && b > c)
            //{
            //    Console.WriteLine("-1");
            //}
            //else
            //{
            //    Console.WriteLine("0");
            //}

            /*
             a < b + c,
             b < a + c,
             c < a + b.
             */

            if (a < b + c && b < a + c && c < a + b && a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Съществува!");
            }
            else
            {
                Console.WriteLine("Не съществува! Защото: ");
                Console.WriteLine($"{a} : {b + c}");
                Console.WriteLine($"{b} : {a + c}");
                Console.WriteLine($"{c} : {a + b}");
            }

            Console.ReadKey();
        }
    }
}
