using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex8
{
    class Person
    {
        String name;
        int age;
        public String NAME
        {
            get { return name; }
            set { name = value; }
        }
        public int AGE
        {
            get { return age; }
            set { age = value; }
        }
        public static void display(Person[] p, int age)
        {
            Console.WriteLine("Name Age");
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].AGE > age)
                {
                    Console.WriteLine(p[i].NAME + " " + p[i].AGE);
                }
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Person[] p = new Person[3];
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Person();
                Console.Write("Enter the name");
                p[i].NAME = Console.ReadLine();
                Console.Write("Enter the age");
                p[i].AGE = int.Parse(Console.ReadLine());
            }
            int age = 16;
            Person.display(p, age);
        }
    }
}
