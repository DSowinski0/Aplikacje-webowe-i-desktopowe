using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Hazard
{
    public class Program
    {
        public static int getNumbersOfRows()
        {
            int rows;
            Console.WriteLine("Ile zestawów wylosować? ");
            Int32.TryParse(Console.ReadLine(), out rows);
            return rows;
        }

        public static int[,] makeSet(int rows)
        {
            int[,] randomNumber = new int[rows, 6];
            Random r = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int number;
                    bool exists;
                    do
                    {
                        number = r.Next(1, 47);
                        exists = false;
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (randomNumber[i, k] == number)
                            {
                                exists = true;
                                break;
                            }
                        }
                    } while (exists);

                    randomNumber[i, j] = number;
                }
            }

            return randomNumber;
        }


        static void printSet(int[,] randomNumber, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.Write("Zestaw {0}: ", i + 1);
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(randomNumber[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            int rows = getNumbersOfRows();
            int[,] numbers = makeSet(rows);
            printSet(numbers, rows);

            Console.ReadLine();
        }
    }
}