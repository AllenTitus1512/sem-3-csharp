using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the dimensions");
                int r = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                int[,] a = new int[r, c];
                int k = 0;
                Console.WriteLine("Commandline arguements");
                for (int i = 0; i < args.Length; i++)
                    Console.Write(args[i] + "\t");
                Console.WriteLine();
                Console.WriteLine("Matrix form:");
                Console.WriteLine();
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        a[i, j] = int.Parse(args[k++]);
                    }
                }
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine("Program executed successfully");
                Console.WriteLine("");
            }
        }
    }
}
