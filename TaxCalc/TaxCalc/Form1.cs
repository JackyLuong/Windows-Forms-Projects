using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalc
{
    public partial class frmTaxCalc : Form
    {
        const double firstTax = 0.15;
        const double secondTax = 0.18;
        const double thirdTax = 0.22;
        const double fourthTax = 0.27;
        const double fifthTax = 0.33;
        public frmTaxCalc()
        {
            InitializeComponent();
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            double salary;
            try
            {
                salary = double.Parse(txtSalary.Text);
            }
            catch(FormatException)
            {
                salary = 0;
                txtSalary.Text = "0";
            }
            if (salary <= 15000)
            {
                txtTax.Text = (salary * firstTax).ToString();
            }
            else if (salary > 15000 && salary < 30000)
            {
                txtTax.Text = ((salary - 15000) * secondTax + 2250.00).ToString();
            }
            else if (salary >= 30000 && salary < 50000)
            {
                txtTax.Text = ((salary - 30000) * thirdTax + 4950.00).ToString();
            }
            else if (salary >= 50000 && salary < 80000)
            {
                txtTax.Text = ((salary - 50000) * fourthTax + 9350.00).ToString();
            }
            else
            {
                txtTax.Text = ((salary - 80000) * thirdTax + 17450.00).ToString();
            }
        }
    }
}
