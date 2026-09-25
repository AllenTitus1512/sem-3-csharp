using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labpro3
{
    class Complex
    {

        public int Real;
        public int Imaginary;

        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(
                c1.Real + c2.Real,
                c1.Imaginary + c2.Imaginary
            );
        }
        public void Display()
        {
            if (Imaginary > 0)
            {
                Console.WriteLine("{0}+{1}i", Real, Imaginary);
            }
            else
            {
                Console.WriteLine("{0}{1}i", Real, Imaginary);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the first complex number");
                int real1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first complex number");
                int img1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first complex number");
                int real2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first complex number");
                int img2 = int.Parse(Console.ReadLine());

                Complex c1 = new Complex(real1, img1);
                Complex c2 = new Complex(real2, img2);

                Complex sum = c1 + c2;
                Console.WriteLine("Complex number 1");
                c1.Display();
                Console.WriteLine("Complex number 2");
                c2.Display();
                Console.WriteLine("Sum of complex number is");
                sum.Display();
            }
        }
    }
}
