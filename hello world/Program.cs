using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user for first name
            Console.WriteLine("what is your first name?");
            // Assigns user input to firstName variable
            string firstName = Console.ReadLine();
            // Asks the user for last name
            Console.WriteLine("What is your last name");
            // Assigns user iput to lastName variable
            string lastName = Console.ReadLine();          

            Console.WriteLine($"Hellow, {firstName} {lastName}!");
        }
    }
}
