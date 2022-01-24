using ProductsData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsGUI
{
    public partial class frmProducts : Form
    {
        List<Product> products = new List<Product>(); // empty list
        decimal totalInventory = 0; // total inventory value
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProduct secondForm = new frmAddProduct(); // create object of the second form
            DialogResult result = secondForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                Product prod = secondForm.newProd;
                products.Add(prod);
                totalInventory += prod.InventoryValue();
                // adjust display
                lstProducts.Items.Add(prod);
                lblCount.Text = products.Count.ToString();
                lblInventory.Text = totalInventory.ToString("c");
            }
        }
        //read products data from the file
        private void frmProducts_Load(object sender, EventArgs e)
        {
            products = ProductBinaryDB.GetProducts();
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            totalInventory = 0;
            lstProducts.Items.Clear();
            foreach(Product p in products)
            {
                lstProducts.Items.Add(p); // calls ToString() from Product class
                totalInventory += p.InventoryValue();
            }
            lblCount.Text = products.Count.ToString(); // Display Total count
            lblInventory.Text = totalInventory.ToString("c");
        }

        //Save data to the file just before the form closes
        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductBinaryDB.SaveProducts(products);
        }
    }
}
