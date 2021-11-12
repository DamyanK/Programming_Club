using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int c = 2;

            double result = ((b - a) / (2 * b + c)) * (a - c) + 2 * (a - 2 * c);

            int x = 4;
            int y = 2;
            int z = 0;

            double result2 = (x + y) / (z + z / (x + z / (y - x)));
        }
    }
}
