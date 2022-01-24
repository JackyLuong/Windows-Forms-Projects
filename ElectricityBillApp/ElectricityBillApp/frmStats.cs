using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ElectricityBillApp
{
    /// <summary>
    /// Displays the total number of customers,
    /// calculates and displays the total kWh used from all customers,
    /// calulate and display the average bill total amoung all customers.
    /// </summary>
    public partial class frmStats : Form
    {
        public frmStats()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Displays the total number of customers, kWh used,
        /// caluclates and displays the average bill price.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStats_Load(object sender, EventArgs e)
        {
            frmElectricityBill electBill = new frmElectricityBill();
            List<Customer> custList = electBill.CustList;
            decimal totalKWh = 0;
            decimal totalBill = 0;
            decimal avgBill = 0;

            if(custList.Count > 0)
            {
                foreach (Customer cust in custList)
                {
                    totalKWh += cust.NumOfkWh;
                    totalBill += cust.BillAmount;
                }
                avgBill = totalBill / custList.Count;
            }

            txtTotalCust.Text = custList.Count.ToString();
            txtTotalKWh.Text = totalKWh.ToString();
            txtAvgBill.Text = avgBill.ToString("c");

        }
        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
