using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsGUI
{
    /// <summary>
    /// a repository of user input validation methods for Windows Forms projects
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// validates if text box is not empty
        /// </summary>
        /// <param name="tb"> text box to validate</param>
        /// <returns>true if not empty and false if empty</returns>
        public static bool IsPresent(TextBox tb)
        {
            bool isValid = true;
            if(tb.Text == "") // empty
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " is required");
                tb.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// validates if text box contains non-negative int value
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeInt(TextBox tb)
        {
            bool isValid = true;
            int result; // for TryParse
            if(!Int32.TryParse(tb.Text, out result)) // TryParse returned false
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " must be a whole number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // it's an int, but could be negative
            {
                if(result < 0)
                {
                    isValid = false;
                    MessageBox.Show(tb.Tag + " must be positive or zero");
                    tb.SelectAll(); // select all content for replacement
                    tb.Focus();
                }
            }
            return isValid;
        }

        /// <summary>
        /// validates if text box contains non-negative double value
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDouble(TextBox tb)
        {
            bool isValid = true;
            double result; // for TryParse
            if (!Double.TryParse(tb.Text, out result)) // TryParse returned false
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " must be a number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // it's double value, but could be negative
            {
                if (result < 0)
                {
                    isValid = false;
                    MessageBox.Show(tb.Tag + " must be positive or zero");
                    tb.SelectAll(); // select all content for replacement
                    tb.Focus();
                }
            }
            return isValid;
        }

        /// <summary>
        /// validates if text box contains non-negative decimal value
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox tb)
        {
            bool isValid = true;
            decimal result; // for TryParse
            if (!Decimal.TryParse(tb.Text, out result)) // TryParse returned false
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " must be a number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // it's decimal value, but could be negative
            {
                if (result < 0)
                {
                    isValid = false;
                    MessageBox.Show(tb.Tag + " must be positive or zero");
                    tb.SelectAll(); // select all content for replacement
                    tb.Focus();
                }
            }
            return isValid;
        }

        /// <summary>
        /// validates if text box contains non-negative double value
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsDoubleInRange(TextBox tb, double minValue, double maxValue)
        {
            bool isValid = true;
            double result; // for TryParse
            if (!Double.TryParse(tb.Text, out result)) // TryParse returned false
            {
                isValid = false;
                MessageBox.Show(tb.Tag + " must be a number");
                tb.SelectAll(); // select all content for replacement
                tb.Focus();
            }
            else // it's double value, check the range
            {
                if (result < minValue || result > maxValue)
                {
                    isValid = false;
                    MessageBox.Show($"{tb.Tag} must be between {minValue} and {maxValue}");
                    tb.SelectAll(); // select all content for replacement
                    tb.Focus();
                }
            }
            return isValid;
        }


    }
}
