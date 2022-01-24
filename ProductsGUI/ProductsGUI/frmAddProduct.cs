using System;
using System.Windows.Forms;
namespace ProductsGUI
{
    public partial class frmAddProduct : Form
    {
        public Product newProd; //new product to add (main form can see it but it's public)
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validates user inputs
            if(Validator.isPresent(txtName) &&
               Validator.isPresent(txtPrice) &&
               Validator.isPresent(txtQuantity) &&
               Validator.IsNonNegativeInt(txtQuantity)&&
               Validator.IsNonNegativeDecimal(txtPrice)
               )
            {
                newProd = new Product(txtName.Text, 
                              Convert.ToDecimal(txtPrice.Text), 
                              Convert.ToInt32(txtQuantity.Text));
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
