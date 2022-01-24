using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsData
{
    /// <summary>
    /// represents a product
    /// </summary>
    [Serializable]
    public class Product
    {
        // private data
        //private string name;
        private decimal price;
        private int qoh; // quantity on hand

        // public properties - controlled access to the private data
        public string Name { get; set; } // auto-implemented property (unnamed private variable is automatically created)

        public decimal Price
        {
            get
            {
                return price; // get the value of the private variable
            }
            set
            {
                if (value < 0) 
                    price = -value;// make it positive
                else 
                    price = value; // set the value of the private variable - value comens from the context
            }
        }

        public int Qoh
        {
            get { return qoh; }
            set 
            {
                if (value < 0) qoh = -value; // make positive
                else qoh = value;
            }
        }


        // constructor
        public Product(string n = "Unknown", decimal p = 0, int q = 0) // constructor with  parameters and default values
        {
            Name = n;
            Price = p;
            Qoh = q;
        }

        // more public methods

        public decimal InventoryValue()
        {
            return price * qoh;
        }

        // redefine method ToString() method from object type
        public override string ToString()
        {
            return $"{Name}: {price.ToString("c")}, {qoh}";
        }
        //line for CSV file with no formating
       public string ToCSVFileString()
        {
            return Name +  "," + price.ToString() + "," + qoh.ToString();
        }
    }
}
