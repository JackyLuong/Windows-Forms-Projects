using System;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod = new Product();
            Product prod1 = new Product("apples", -1.29m, 25);
            Product prod2 = new Product("bananas", 0.79m, -12);
            Product prod3 = new Product("Pears", 2.45m);
            Product prod4 = new Product("Grapes");
            Product prod5 = new Product { Qoh = 17, Price = 2.99m, Name = "gizmo"}; // object initializer
            
            prod2.Price = -0.99m;
            prod1.Qoh = -27;
            prod1.Name = "Ambrosia apples";

            Console.WriteLine(prod); // ToString() method called implicitly
            Console.WriteLine(prod1.Display()); // needs explicit code
            Console.WriteLine(prod2);
            Console.WriteLine(prod3);
            Console.WriteLine(prod4);
            Console.WriteLine(prod5);
        }
    }
}
