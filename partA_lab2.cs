using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labpro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());
            object o = x;
            Console.WriteLine("Integer value is boxed");
            int y = (int)o;
            Console.WriteLine("   value is unboxed");

            try
            {
                float z = (float)o;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
