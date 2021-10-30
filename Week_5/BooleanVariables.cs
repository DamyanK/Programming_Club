using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariables
{
    class Program
    {
        static int RowsCount()
        {
            int N;
            do
            {
                Console.Write("N = ");
                N = Convert.ToInt32(Console.ReadLine());
            } while (N < 1 || N > 15);

            return N;
        }

        static List<int[]> list()
        {
            int N = RowsCount();

            List<int[]> list = new List<int[]>();

            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter elements in array[{0}]: ", i + 1);
                int[] array = Console.ReadLine()
                    .Split()
                    .Select(x => Convert.ToInt32(x))
                    .ToArray();
                list.Add(array);
            }

            return list;
        }

        static void Main(string[] args)
        {
            var numbers = list();

            for (int i = 0; i < numbers.Count; i++)
            {
                int[] temp = numbers[i];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] > 0)
                    {
                        Console.Write(temp[j] + " ");
                    }
                    else
                    {
                        int sum = 0;
                        for (int k = j + 1; k < temp.Length; k++)
                        {
                            sum += temp[k];
                        }
                        if (temp[j] < sum * -1)
                        {
                            Console.Write("(empty)");
                            goto END;
                        }

                        if (j == temp.Length - 1)
                        {
                            break;
                        }
                        else
                        {
                            if (temp[j] + temp[j + 1] > 0)
                            {
                                int tempSum = temp[j] + temp[j + 1];
                                Console.Write(tempSum + " ");
                            }
                            j++;
                        }
                    }
                }
            END:
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
