using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace ElectricityBillApp
{
    /// <summary>
    /// Display all the customer accounts and their information.
    /// Displays the customers first name, last name, kWh used,
    /// and their bill total based on their kWh used.
    /// </summary>
    public partial class frmElectricityBill : Form
    {
        #region Class Variables
        private static List<Customer> custList = new List<Customer>();
        #endregion
        public frmElectricityBill()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Display customer first name, last name, the kWh they used
        /// and the total for their electricity bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCustAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFName.Text = custList[cboCustAcc.SelectedIndex].FName;
            txtLName.Text = custList[cboCustAcc.SelectedIndex].LName;
            txtKWh.Text = custList[cboCustAcc.SelectedIndex].NumOfkWh.ToString();
            txtBill.Text = custList[cboCustAcc.SelectedIndex].BillAmount.ToString("c");
        }
        /// <summary>
        /// Opens a new form to add new customers to the list and updates the comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            frmCust custForm = new frmCust();
            DialogResult result = custForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                Customer newCust = custForm.newCust;
                custList.Add(newCust); //Add new customer to the list
                cboCustAcc.Items.Add(newCust.accountNo); // Add new customer to the combo box
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            frmStats statsForm = new frmStats();
            statsForm.ShowDialog();
        }
        public List<Customer> CustList
        {
            get
            {
                return custList;
            }
        }
        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
