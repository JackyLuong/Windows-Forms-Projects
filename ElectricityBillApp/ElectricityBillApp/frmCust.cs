using System;
using System.Windows.Forms;

namespace ElectricityBillApp
{
    /// <summary>
    /// Asks for customer's first name, last name, kWh used.
    /// </summary>
    public partial class frmCust : Form
    {
        #region Class Variables
        public Customer newCust;
        private string fName;
        private string lName;
        private decimal kWhUsed;
        #endregion
        public frmCust()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Validates the textboxes and assign customer's
        /// first name, last name and the number of kWh they used.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        { 
            if (Validator.isPresent(txtFName) &&
                Validator.isLettersOnly(txtFName) &&
                Validator.isPresent(txtLName) &&
                Validator.isLettersOnly(txtLName) &&
                Validator.isPresent(txtKWh) &&
                Validator.IsNonNegativeDecimal(txtKWh)
                )
            {
                fName = txtFName.Text;
                lName = txtLName.Text;
                kWhUsed = Convert.ToDecimal(txtKWh.Text);
                newCust = new Customer(fName, lName, kWhUsed);
                this.DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
