using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace labpro1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n1 = int.Parse(args[0]);
            int n2 = int.Parse(args[1]);
            int n3 = int.Parse(args[2]);
            string word = args[3];
            
            Console.WriteLine("The numbers are:{0},{1},{2}", n1,n2,n3);
            Console.WriteLine("Name:{0}",word);
            Console.WriteLine("Sqrt 1: {0}, Sqrt 2: {1}, Sqrt 3: {2}", Math.Sqrt(n1), Math.Sqrt(n2), Math.Sqrt(n3));
            
            int sum = n1+n2+n3;
            double avg = sum / 3.0;
            Console.WriteLine("The sum"+sum);
            Console.WriteLine("The avg"+ avg);
          
        }
    }
}
