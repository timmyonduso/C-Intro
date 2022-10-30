// See https://aka.ms/new-console-template for more information
using System;

namespace Intro
{
    class UserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name");
            Console.WriteLine("Enter your age");

            string username = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Your name is " + username);

            Console.WriteLine("You are " + age + " years old");
        }
    }
}
