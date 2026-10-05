//program to demonstrate array of interface types(for runtime polymorphism).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prgm10
{
    interface shape
    {
        double cal_area();
    }
    class circle : shape
    {
        public double cal_area()
        {
            Console.WriteLine();
            Console.Write("Enter the radius:");
            double r = double.Parse(Console.ReadLine());
            double area = 3.14 * r * r;
            return area;
        }
    }
    class triangle:shape
    {
        public double cal_area()
        {
            Console.WriteLine();
            Console.Write("Enter the three sides of triangle:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double s = (a + b + c) / 2.0;
            double s1 = s * (s - a);
            double s2 = s - b;
            double s3 = s - c;
            double area = Math.Sqrt(s1 * s2 * s3);
            return area;
        }
    }
    class sqaure:shape
    {
        public double cal_area()
        {
            Console.WriteLine();
            Console.Write("Enter the side of a sqaure:");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            return area;
        }
    }
    class rectangle:shape
    {
        public double cal_area()
        {
            Console.WriteLine();
            Console.Write("Enter the Length and breadth of a rectangle:");
            double l = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = l * b;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            shape[] s = new shape[4];
            s[0] = new circle();
            s[1] = new triangle();
            s[2] = new sqaure();
            s[3] = new rectangle();
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("The area is {0:0.00}", s[i].cal_area());
            }
        }
    }
}
