using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollGUI
{
    public partial class frmEmployees : Form
    {
        //form-Level
        List<Employees> employeesList = new List<Employees>(); // employee List
        private decimal totalPay = 0;
        private int empCount = 0;
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            string name; // input name
            decimal hours; // input hours
            decimal rate; // input rate
            decimal rrsp; // input rrsp percentage
            decimal pay; // calculated pay
            Employees emp; //reference variable

            //Validate employees Data
            if (Validator.isPresent(txtName) &&
                Validator.isPresent(txtHours) &&
                Validator.isPresent(txtRate) &&
                Validator.IsNonNegativeDecimal(txtHours) &&
                Validator.IsNonNegativeDecimal(txtRate)
                )
            {
                name = txtName.Text;
                hours = Convert.ToDecimal(txtHours.Text);
                rate = Convert.ToDecimal(txtRate.Text);

                if(radRegular.Checked) //Build Regular employee object
                {
                    emp = new Employees(name, hours,rate);
                }
                else //Build Permanent employee object
                {
                    if(Validator.isPresent(txtRRSP) &&
                       Validator.IsDecimalInRange(txtRRSP,0,100)
                       )
                    {
                        rrsp = Convert.ToDecimal(txtRRSP.Text);
                        emp = new PermanentEmployee(name, hours, rate, rrsp / 100);
                    }
                    else //failed validation
                    {
                        return;
                    }
                }
                //add employee objects to the list and display in the list box
                employeesList.Add(emp);

                //update and display stats
                DisplayEmp();
                totalPay += emp.CalcPay();
                empCount++;
                lblTotalPayRoll.Text = totalPay.ToString("c");
                lblNumOfEmp.Text = empCount.ToString();

                //reset data entry controls
                clearInputFields();
            }
        }

        //Display Employees
        private void DisplayEmp()
        {
            lstEmp.Items.Clear();
            decimal pay;
            foreach (Employees emp in employeesList)
            {
                pay = emp.CalcPay();
                lstEmp.Items.Add($"{emp} Pay: {pay.ToString("c")}"); // add all employees to the list box
            }
        }
        private void clearInputFields()
        {
            txtHours.Clear();
            txtName.Clear();
            txtRate.Clear();
            txtRRSP.Clear();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearInputFields();
        }

        private void radRegular_CheckedChanged(object sender, EventArgs e)
        {
            lblRRSP.Visible = false;
            txtRRSP.Visible = false;
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            radRegular.Checked = true;
        }

        private void radPermanent_CheckedChanged(object sender, EventArgs e)
        {
            lblRRSP.Visible = true;
            txtRRSP.Visible = true;
        }

        private void btnResetList_Click(object sender, EventArgs e)
        {
            lstEmp.Items.Clear();
            lblTotalPayRoll.Text = "0";
            lblNumOfEmp.Text = "0";
        }
    }
}
