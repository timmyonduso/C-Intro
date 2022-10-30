// See https://aka.ms/new-console-template for more information
using System;

namespace Intro
{
    class dispVariables
    {
        static void Main(string[] args)
        {
            string name = "John";
            Console.WriteLine("Hello\t" + name);

            string fname = "Mbulu ";
            string sname = "Kafala";
            string fullname = fname + sname;

            Console.WriteLine("My name is " + fullname);


            int y = 69;
            int x = 96;

            Console.WriteLine(x + y);
            int a, b, z;
            a = 46;
            b = z = 23;

            Console.WriteLine(a + z);

            double point = 89.99;
            Console.WriteLine(point);

        }
    }
}
