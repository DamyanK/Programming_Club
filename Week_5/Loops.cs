using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Броячен цикъл (итеративен)
            for (int i = 0; i < 10; i++) // i++ <=> i = i + 1 <=> i += 1
            {
                Console.WriteLine(i + 1);
            }
            Console.WriteLine("Цикълът приключи изпълнението на задачата.");

            // Индуктивни цикли

            // - цикъл с предусловие
            double a = 1.6;
            while (a < 3)
            {
                Console.WriteLine(a);
                a = a + 0.17;
                // Има възможност да не се изпълни нито веднъж.
            }
            Console.WriteLine("Цикълът приключи изпълнението на задачата.");

            // - цикъл със следусловие
            double b;
            do
            {
                Console.Write("Enter value for b: ");
                b = double.Parse(Console.ReadLine());
                // Задължително се изпълнява поне един път.
            } while (b < 0.0 || b > 14.3); // |0;14.3|
            Console.WriteLine("Цикълът приключи изпълнението на задачата.");

            Console.ReadKey();
        }
    }
}
