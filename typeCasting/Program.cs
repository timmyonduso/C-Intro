// See https://aka.ms/new-console-template for more information
using System;

namespace Intro
{
    class TypeCasting
    {
        static void Main(string[] args)
        {
            int myNum = 9;
            double myDouble = myNum;

            Console.WriteLine(myNum);
            Console.WriteLine(myDouble);

            double myDouble2 = 9.59;
            int myInt2 = (int)myDouble2;

            Console.WriteLine(myDouble2);
            Console.WriteLine(myInt2);


            int inum = 67;
            double dnum = 67.67;
            bool umbwa = true;

            Console.WriteLine(Convert.ToString(inum));
            Console.WriteLine(Convert.ToDouble(inum));
            Console.WriteLine(Convert.ToInt32(dnum));
            Console.WriteLine(Convert.ToString(umbwa));

        }
    }
}
