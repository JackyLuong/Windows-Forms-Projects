using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Pay Roll Apllication
 * Calculates pay amount
 * Author:Jacky Luong
 * When: December 09. 2021
 */
namespace payRoll
{
    public partial class frmPayRoll : Form
    {
        //Class-level variables
        const decimal fullWeek = 37.5m; // Full week hours
        const decimal OTRate = 1.5m; // Over-time rate
        public frmPayRoll()
        {
            InitializeComponent();
        }
        /*
         * Calculates Pay amount based on hours worked and rates
         * 37.5 hours make full time week.
         * extra hours are paid 1.5 times more
         */
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //method-level variables
            decimal payAmount;
            decimal extraTime;
            decimal hoursWorked = 0;
            decimal hourRate = 0;

            // Check if the user has typed numbers
            try
            {
                hoursWorked = decimal.Parse(txtHWorked.Text);
                hourRate = decimal.Parse(txtHRate.Text);
            }
            catch (FormatException)
            {
                txtHWorked.Clear();
                txtHRate.Clear();
                txtPAmount.Clear();
            }

            //Calculate  With Overtime Pay
            if (hoursWorked > fullWeek)
            {
                extraTime = hoursWorked - fullWeek;
                payAmount = (fullWeek * hourRate) + (extraTime * hourRate * OTRate);
            }
            else
            {
                //Calculate Without Overtime pay
                payAmount = (hoursWorked * hourRate);
            }

            if(hoursWorked != 0 && hourRate != 0)
            {
                txtPAmount.Text = payAmount.ToString();
            }
            // return blank if there are no values for hours and rates
            else
            {
                txtPAmount.Text = "";
            }
        }

        //Clears fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears all fields
            txtHWorked.Clear();
            txtHRate.Clear();
            txtPAmount.Clear();

            //focus to hour
            txtHWorked.Focus();
        }
        //Terminates program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
