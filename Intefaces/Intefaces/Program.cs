using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = (int)5.99m;
            Console.WriteLine(i);
            List<Product> productsList = new List<Product>();
            productsList.Add(new Product("Apples", 1.49m, 25));
            productsList.Add(new Product("Bananas", .99m, 5));
            productsList.Add(new Product("Pears", 2.49m, 15));
            productsList.Add(new Product("Grapes", 1.50m, 10));
            productsList.Add(new Product("Peaches", 1.00m, 12));
            productsList.Add(new Product("Cherries", 2.39m, 13));

            foreach (Product prod in productsList)
            {
                Console.WriteLine(prod + ":" + prod.IventoryValue().ToString());
            }
        }
    }
}
