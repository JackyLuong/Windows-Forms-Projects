using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsData
{
    public static class ProductDB
    {
        const string path = "products.txt"; // same folder as the .exe file (in project ProductsGUI)

        //Read products data and build the list
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>(); // empty list
            //read data from the file
            using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate,FileAccess.Read))
            {
                string line; //  line from the file
                string[] parts; // line split into field
                Product prod; // auxilliary for reading

                using(StreamReader sr = new StreamReader(fs))
                {
                    while(!sr.EndOfStream) // while there is still data in the file
                    {
                        line = sr.ReadLine(); // read a line in the text file
                        parts = line.Split(','); // split the line using comma as seperator
                        prod = new Product(parts[0], Convert.ToDecimal(parts[1]), Convert.ToInt32(parts[2]));
                        products.Add(prod);
                    }
                }
            }
            return products;
        }

        //Takes the list and saves it in the list
        public static void SaveProducts(List<Product> products)
        {
            using(FileStream fs = new FileStream(path, FileMode.Create,FileAccess.Write))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    foreach(Product p in products)
                    {
                        sw.WriteLine(p.ToCSVFileString());
                    }
                } // StreamWriter will be closed if opened, and recycled
            }// fs will be closed if opened, and recycled
        }
    }
}
