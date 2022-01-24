using System;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables to store user input
            string firstName, lastName;
            int birthYear;

            // Get user input
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter your birth year: ");

            while (!Int32.TryParse(Console.ReadLine(), out birthYear))
            {
                Console.WriteLine("Please enter a whole number!");
                Console.Write("Enter your birth year: ");
            }

            int age = DateTime.Today.Year - birthYear;

            DateTime birthDate = DateTime.Today.AddYears(-age);

            // Try to create the new object!
            try
            {
                Person bob = new Person(firstName, lastName, birthDate);
                Console.WriteLine(bob);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
