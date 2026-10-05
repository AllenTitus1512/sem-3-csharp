using System;

namespace part_A_lab7
{
    class calculate
    {
        public float add(float a, float b)
        {
            return (a + b);
        }
        public float sub(float a, float b)
        {
            return (a - b);
        }
        public float mul(float a, float b)
        {
            return (a * b);
        }
        public float div(float a, float b)
        {
            return (a / b);
        }
        public float rem(float a, float b)
        {
            return (a % b);
        }
    }
    public delegate float operation(float a, float b);
    class Program
    {
        static void Main(string[] args)
        {
            calculate c = new calculate();
            operation cd = new operation(c.add);
            Console.WriteLine("Enter first number:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("The sum is:" + cd(a, b));
            cd += c.sub;

            Console.WriteLine("The difference is:" + cd(a, b));
            cd += c.mul;

            Console.WriteLine("The product is:" + cd(a, b));
            cd += c.div;

            Console.WriteLine("The quotient is:" + cd(a, b));
            cd += c.rem;

            Console.WriteLine("The remainder is:" + cd(a, b));

        }
    }
}
