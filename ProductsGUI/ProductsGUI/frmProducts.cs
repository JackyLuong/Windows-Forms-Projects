using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProductsGUI
{
    public partial class frmProducts : Form
    {
        //class variables
        List<Product> prodList = new List<Product>(); // empty list of products
        decimal totalInventory = 0; // total inventory value
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            frmAddProduct secondForm = new frmAddProduct();//Create object of the second form
            DialogResult result = secondForm.ShowDialog(); //Display results from second form 
            if(result == DialogResult.OK)
            {
                Product newProd = secondForm.newProd;
                prodList.Add(newProd);
                totalInventory += newProd.IventoryValue();

                //adjust display
                lstProd.Items.Add(newProd.Name); // Display name of products
                txtInventory.Text = totalInventory.ToString("c");//Display total inventory in currency
                txtProd.Text = prodList.Count.ToString();//Display the number of different types of products
            }
        }
    }
}
