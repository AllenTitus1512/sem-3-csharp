using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int r = int.Parse(Console.ReadLine());
            int[][] a = new int[r][];
            Console.WriteLine("Enter the columns size of each rows");
            for (int i = 0; i < r; i++)
            {
                int c = int.Parse(Console.ReadLine());
                a[i] = new int[c];
            }
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Jagged Array Elements are:");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum of each array");
            for (int i = 0; i < a.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < a[i].Length; j++)
                {
                    sum = sum + a[i][j];
                }
                Console.WriteLine("Sum of" + (i + 1) + "Rows=" + sum);
            }
           

        }
    }
}
