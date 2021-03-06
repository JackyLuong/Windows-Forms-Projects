using System;
using System.Windows.Forms;

namespace HelloWorld
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
        /// Validates if the textBox contains non-negative int value
        /// </summary>
        /// <param name="txtBox"></param>
        /// <returns></returns>
        public static bool IsNonNegativeInt(TextBox txtBox)
        {
            bool isValid = true;
            int result; // for try parse

            if(!Int32.TryParse(txtBox.Text, out result)) // TryParse returned false
            {
                isValid = false;
                MessageBox.Show(txtBox.Tag + " must be a number");
                txtBox.SelectAll();
                txtBox.Focus();
            }
            else
            {
                //True if the number is less than 1
                if(result < 1)
                {
                    isValid = false;
                    MessageBox.Show(txtBox.Tag + "must be a whole number");
                    txtBox.SelectAll();
                    txtBox.Focus();
                }
            }
            return isValid;
        }
    }
}
