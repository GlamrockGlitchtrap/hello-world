using System;

// My collection of classes for this project.
namespace hello_world
{
    // Main class for our program
    class Program
    {
        // The Main method executed when application starts
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

            // Prints a welcome message with firstName and lastName
            Console.WriteLine($"Hellow, {firstName} {lastName}!");
        }
    }
}
