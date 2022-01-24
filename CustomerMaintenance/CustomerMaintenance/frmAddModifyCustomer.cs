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

namespace CustomerMaintenance
{
    public partial class frmAddModifyCustomer : Form
    {
        //public data - main for needs access to it
        public bool isAdd; // true means to add, false means modify
        public Customer customer; // current customer. null if adding, set if modify
        public frmAddModifyCustomer()
        {
            InitializeComponent();
        }

        //as the form loads
        private void frmAddModifyCustomer_Load(object sender, EventArgs e)
        {
            List<State> states = null;
            try
            {
                //load combo box
                using (MMABooksContext db = new MMABooksContext())
                {
                    states = db.States.OrderBy(s => s.StateName).ToList(); // adds states to list by order of the names.
                    cboState.DataSource = states;
                    cboState.DisplayMember = "StateName";
                    cboState.ValueMember = "StateCode";

                    if(isAdd)
                    {
                        this.Text = "Add Customer";
                    }
                    else
                    {
                        if(customer == null)
                        {
                            MessageBox.Show("There is no current Customer","Modify Error");
                            this.DialogResult = DialogResult.Cancel;
                        }
                        //display current customer
                        txtName.Text = customer.Name;
                        txtAddress.Text = customer.Address;
                        txtCity.Text = customer.City;
                        cboState.SelectedValue = customer.State;
                        txtZipCode.Text = customer.ZipCode;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while retrieveing states: {ex.Message}, {ex.GetType()}");
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(Validator.isPresent(txtName) && 
                Validator.isPresent(txtAddress) &&
                Validator.isPresent(txtCity) &&
                Validator.isPresent(txtZipCode) &&
                Validator.isSelected(cboState)
                )
            {
                if(isAdd == true) // create new customer object when adding
                {
                    customer = new Customer();
                }
                //put data from the form into the customer object
                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.City = txtCity.Text;
                customer.State = cboState.SelectedValue.ToString();
                customer.ZipCode = txtZipCode.Text;

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
