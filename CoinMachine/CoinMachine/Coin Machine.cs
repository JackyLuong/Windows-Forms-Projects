using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinMachine
{
    public partial class Form1 : Form
    {
        const int toonie = 200;
        const int loonie = 100;
        const int quarter = 25;
        const int dime = 10;
        const int nickle = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double userAmount = double.Parse(txtUser.Text);
            int amountInCents = Convert.ToInt32(userAmount * 100);

            int amountInCentsRounded = (int)Math.Ceiling((decimal)amountInCents/5)*5;
            txtCents.Text = amountInCentsRounded.ToString();

            int toonieAmount = amountInCentsRounded / toonie;
            txtToonies.Text = toonieAmount.ToString();

            int amountLeftFromToonie = amountInCentsRounded % toonie;

            int loonieAmount = amountLeftFromToonie / loonie;
            txtLoonies.Text = loonieAmount.ToString();

            int amountLeftFromLoonie = amountInCentsRounded % loonie;

            int quaterAmount = amountLeftFromLoonie / quarter;
            txtQuarters.Text = quaterAmount.ToString();

            int amountLeftFromQuarter = amountInCentsRounded % quarter;

            int dimeAmount = amountLeftFromQuarter / dime;
            txtDimes.Text = dimeAmount.ToString();

            int amountLeftFromDime = amountLeftFromQuarter % dime;

            int nickleAmount = amountLeftFromDime / nickle;
            txtNickels.Text = nickleAmount.ToString();
        }
    }
}
