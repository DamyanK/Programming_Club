using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 14;
            Console.WriteLine($"Before swap: a = {a}, b = {b}");

            //a - синя чаша
            //b - червена чаша
            //temp - черна чаша

            int temp = a; // 1. Изсипи съдържанието на синята чаша в черната чаша
            a = b;    // 2. Щом си изпълнил 1., изсипи съдържанието на червената чаша в празната синя
            b = temp; // 3. Щом си изпълнил 1. и 2., изсипи съдържанието на черната чаша в червената
            Console.WriteLine($"After swap: a = {a}, b = {b}");

            a = a + b; // 5 + 14 = 19
            b = a - b; // 19 - 14 = 5
            a = a - b; // 19 - 5 = 14
            Console.WriteLine($"After mathematical swap: a = {a}, b = {b}");

            Console.ReadKey();
        }
    }
}
