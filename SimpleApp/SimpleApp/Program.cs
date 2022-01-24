using System;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.DateOfBirth =  new DateTime(2023, 12, 22);
            person1.FName = "";
            person1.LName = "";
            Console.WriteLine(person1);
        }
    }
}
