using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 0, 3, -1 };

            Console.WriteLine("Before: " + string.Join(" ", array));

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Ascending: " + string.Join(" ", array));

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            Console.WriteLine("Descending: " + string.Join(" ", array));

            Console.ReadKey();
        }
    }
}
