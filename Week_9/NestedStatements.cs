using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // NESTED STATEMENTS - Вложени оператори

            START:
            Console.WriteLine("Choose from the options: ");
            Console.WriteLine("1 - Enter even numbers lower than 10,");
            Console.WriteLine("2 - Sum the numbers different from 0,");
            Console.WriteLine("3 - Multiplication table.");
            Console.Write("> ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        while (true)
                        {
                            Console.Write("Enter a value: ");
                            int number = int.Parse(Console.ReadLine());

                            if (number == 403)
                            {
                                break;
                            }

                            if (number <= 10)
                            {
                                if (number % 2 == 0)
                                {
                                    Console.WriteLine("Good job!");
                                }
                                else
                                {
                                    Console.WriteLine("Enter even number!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Mission failed! We'll get them next time!");
                            }
                        }
                        Console.WriteLine("Auf Wiedersehen~!~");
                        break;
                    }
                case 2:
                    {
                        int number, sum = 0;
                        do
                        {
                            Console.Write("> ");
                            number = int.Parse(Console.ReadLine());
                            Console.Clear();

                            sum += number;
                        } while (number != 0);
                        Console.WriteLine(sum);
                        break;
                    }
                case 3:
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                // i = 1 | j = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                                // i = 2 | j = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                                // i = 3 | ...
                                // ...
                                // i = 10 | j = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10

                                Console.Write($"{i} * {j} = {i * j}   ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Wrong choice! Try again!");
                    goto START;
            }

            Console.ReadKey(true);
        }
    }
}
