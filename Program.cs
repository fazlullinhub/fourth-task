using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[5, 5];
            int[,] arr2 = new int[5, 5];


            Random rand = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    arr1[i, j] = rand.Next(20);
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    arr2[i, j] = rand.Next(20);


            Console.WriteLine("Array 1:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nArray 2:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMultiply the first array by 2:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write((arr1[i, j] * 2) + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nAmount of first and second arrays:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write((arr1[i, j] + arr2[i, j]) + "\t");
               
                }
                Console.WriteLine();
            }


            Console.WriteLine("Product:");
            int[,] arr3 = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        arr3[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
