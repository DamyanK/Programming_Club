using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2;
            int y1 = 2;
            int x2 = 6;
            int y2 = 5;

            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());

            if ((y == y1 || y == y2) && (x1 < x && x < x2))
            {
                Console.WriteLine("Border");
            }
            else if ((x == x1 || x == x2) && (y1 < y && y < y2))
            {
                Console.WriteLine("Border");
            }
            else if ((x1 < x && x < x2) && (y1 < y && y < y2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }

            Console.ReadKey();
        }
    }
}
