using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProductsData
{
    /// <summary>
    /// Persists products data in a binary filem using serialization
    /// </summary>
    public static class ProductBinaryDB
    {
        private const string path = "Products.dat"; // places in the same folder as .exe file

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            //read data from binary file
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                if(fs.Length > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    products = (List<Product>)formatter.Deserialize(fs);
                }
            }
            return products;
        }
        /// <summary>
        /// Saves products to the binary file
        /// </summary>
        /// <param name="products">List of Products</param>
        public static void SaveProducts(List<Product> products)
        {
            using(FileStream fs = new FileStream(path, FileMode.Create,FileAccess.Write)) // open for writing and overriding content
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, products);
            }
        }
    }
}
