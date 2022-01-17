using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born?");
            var month = Console.ReadLine();

            Console.WriteLine("Your name is: {0}" , name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if(month == "July")
             {
                Console.WriteLine("You are beautiful!");
             }
            else if (month == "April")
            {
                Console.WriteLine("You are Wonderful!");
            }
            else if (month == "June")
            {
                Console.WriteLine("You are nice!");
            }
        }
    }
}
