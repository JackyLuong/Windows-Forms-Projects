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
    public partial class frmAddProduct : Form
    {
        public Product newProd = null; // new product to add (main form can see it because it's public)

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // validate user user inputs
            if( Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsNonNegativeDecimal(txtPrice) &&
                Validator.IsPresent(txtQuantity) &&
                Validator.IsNonNegativeInt(txtQuantity)
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
