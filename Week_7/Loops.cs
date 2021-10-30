using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Синтаксис на While
            /*
                while(<условие>)
                {
                    <тяло>
                }
            */

            // Синтаксис на Do - While
            /* 
                do
                {
                    
                } while (true);
            */

            // Синтаксис на For
            /*
                for (int i = 0; i < length; i++)
                {
                    
                }
            */


            // Задачи за часа: 
            Console.WriteLine("ZADACHA 1");
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("ZADACHA 2");
            int a, b;
            do
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            } while (a + b == 15);
        }
    }
}
