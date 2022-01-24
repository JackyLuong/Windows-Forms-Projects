using System;
using System.Windows.Forms;

namespace BankAccountDemo
{
    public static class Validator
    {
        /// <summary>
        /// Checks if the text box is empty
        /// </summary>
        /// <param name="txtBox"></param>
        /// <returns></returns>
        public static bool isPresent(TextBox txtBox)
        {
            bool isValid = true;
            if (txtBox.Text == "") // empty
            {
                isValid = false;
                MessageBox.Show(txtBox.Name + " is required");
                txtBox.Focus();
            }
            else
            {

            }
            return isValid;
        }
        /// <summary>
        /// Validates if the textBox contains non-negative decimal value
        /// </summary>
        /// <param name="txtBox"></param>
        /// <returns></returns>
        public static bool IsNonNegativeDecimal(TextBox txtBox)
        {
            bool isValid = true;
            decimal result; // for try parse

            if(!decimal.TryParse(txtBox.Text, out result)) // TryParse returned false
            {
                isValid = false;
                MessageBox.Show(txtBox.Tag + " must be a number");
                txtBox.SelectAll();
                txtBox.Focus();
            }
            else
            {
                //True if the number is less than 0
                if(result < 0)
                {
                    isValid = false;
                    MessageBox.Show(txtBox.Tag + "Cant be negative");
                    txtBox.SelectAll();
                    txtBox.Focus();
                }
            }
            return isValid;
        }
    }
}
