using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace part_A_lab8
{
    abstract class calculate
    {
        public abstract float add(float a, float b);
        public abstract float sub(float a, float b);
        public abstract float mul(float a, float b);
        public abstract float div(float a, float b);
        public abstract float mod(float a, float b);
    }
    class calculator : calculate
    {
        public override float add(float a, float b)
        {
            return (a + b);
        }
        public override float sub(float a, float b)
        {
            return (a - b);
        }
        public override float mul(float a, float b)
        {
            return (a * b);
        }
        public override float div(float a, float b)
        {
            return (a / b);
        }
        public override float mod(float a, float b)
        {
            return (a % b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.WriteLine("Enter the first number:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = float.Parse(Console.ReadLine());
            calculator c = new calculator();
            Console.WriteLine("The sum is:" + c.add(a, b));
            Console.WriteLine("The difference is:" + c.sub(a, b));
            Console.WriteLine("The product is:" + c.mul(a, b));
            Console.WriteLine("The quotient is:" + c.div(a, b));
            Console.WriteLine("The remainder is:" + c.mod(a, b));
            Console.WriteLine();
        }
    }
}
