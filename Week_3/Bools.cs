using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Логически изрази
            Boolean sample1 = true;
            sample1 = false;
            bool sample2 = true;
            sample2 = false;

            // Действия

            // ! - обратното на текущото
            //Console.WriteLine(!sample2); // -> връща True

            // && - конюнкция, логическо "И"
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(false && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);

            // || - дизюнкция, логическо "ИЛИ"
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(false || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);

            Console.ForegroundColor = ConsoleColor.White;

            // ПРИМЕР: a || b && !a, a=0, b=1
            // ПРИМЕР: a && b || !a && b || !(a && b), a=1, b=0 

            Console.ReadKey();
        }
    }
}
