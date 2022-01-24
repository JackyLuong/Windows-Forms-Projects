using MMABooksData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenanceGUI
{
    public partial class frmAddModifyCustomer : Form
    {
        // public data - main form needs access to it
        public bool isAdd; // true - Add, false - Modify
        public Customer customer; // current customer

        public frmAddModifyCustomer()
        {
            InitializeComponent();
        }

        // as the form loads
        private void frmAddModifyCustomer_Load(object sender, EventArgs e)
        {
            List<State> states = null;

            // load the combo box
            try
            {
                using (MMABooksContext db = new MMABooksContext())
                {
                    states = db.States.OrderBy(s => s.StateName).ToList();
                }
                cboState.DataSource = states;
                cboState.DisplayMember = "StateName";
                cboState.ValueMember = "StateCode";

                if (isAdd)
                {
                    this.Text = "Add Customer";
                }
                else
                {
                    this.Text = "Modify Customer";
                    // display current customer
                    if(customer == null)
                    {
                        MessageBox.Show("There is no current customer", "Modify Error");
                        this.Close();
                    }
                    // we have current customer
                    txtName.Text = customer.Name;
                    txtAddress.Text = customer.Address;
                    txtCity.Text = customer.City;
                    cboState.SelectedValue = customer.State;
                    txtZipCode.Text = customer.ZipCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving states: " + ex.Message, e.GetType().ToString());
            }
            

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtAddress) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsPresent(txtZipCode)
                )
            {
                if (isAdd) // need to create customer object
                {
                    customer = new Customer();
                }
                // put data from the form into the customer object
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.City = txtCity.Text;
                customer.State = cboState.SelectedValue.ToString();
                customer.ZipCode = txtZipCode.Text;

                this.DialogResult = DialogResult.OK; // closes the form
            }
        }
        // no need to code btnCancel_Click because it is the Cancel button on the form:
        // closes the form and returns DialogResult.Cancel
    }
}
