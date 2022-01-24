namespace ProductsGUI
{
    /// <summary>
    /// represents a product
    /// </summary>
    public class Product
    {
        // private data
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
        public Product(string n = "Unknown", decimal p = 0, int q = 0) // constructor with  parameters and default values
        {
            Name = n;
            Price = p;
            Qoh = q;
        }
        public decimal IventoryValue()
        {
            return price * qoh;
        }
    }
}
