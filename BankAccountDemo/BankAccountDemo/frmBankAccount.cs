using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountDemo
{
    public partial class frmBankAccount : Form
    {
        const int COUNT = 3; //three accounts
        int current; // get current account
        Account[] accounts;
        public frmBankAccount()
        {
            InitializeComponent();
        }

        private void frmBankAccount_Load(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void LoadAccount()
        {
            // three predefined accounts
            accounts = new Account[] {new Account (100),
                                      new Account (250),
                                      new Account (500),};
            //puts account numbers into the combo box
            for(int i = 0; i < COUNT; i++)
            {
                cobAcc.Items.Add(accounts[i].AccNo);
                
                //first account is selected
                cobAcc.SelectedIndex = 0;
                txtBalance.Text = accounts[0].Balance.ToString("c");
                txtAmount.Text = "0.00";
                txtAmount.Focus();
            }
        }
        //Display current account balance
        private void cobAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            current = cobAcc.SelectedIndex;
            txtBalance.Text = accounts[current].Balance.ToString("c");
        }
        //Validate when textbox loses focus
        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            if(!Validator.isPresent(txtAmount))
            {
                txtAmount.Text = "0.00";
            }
            else if(!Validator.IsNonNegativeDecimal(txtAmount))
            {
                decimal value;
                if(decimal.TryParse(txtAmount.Text, out value)) // negative
                {
                    txtAmount.Text = Math.Abs(value).ToString();// change to positive
                }
            }
        }

        private void btnDepo_Click(object sender, EventArgs e)
        {
            if (Validator.isPresent(txtAmount) && 
                Validator.IsNonNegativeDecimal(txtAmount))
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                if (!accounts[current].Deposit(amount))
                {
                    MessageBox.Show("Deposit ignored");
                }
                else
                {
                    txtBalance.Text = accounts[current].Balance.ToString("c");
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (Validator.isPresent(txtAmount) &&
                Validator.IsNonNegativeDecimal(txtAmount))
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                if (!accounts[current].Withdraw(amount))
                {
                    MessageBox.Show("Deposit ignored");
                }
                else
                {
                    txtBalance.Text = accounts[current].Balance.ToString("c");
                }
            }
        }
    }
}
