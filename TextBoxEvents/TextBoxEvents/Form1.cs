using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextBoxEvents
{
    /*
     * Demonstrate textbox events
     * 1) Name - only certain characters allowed: letters. spacem dot, hyphen, apostrophe,backspace
     * 2) Postal code - validate Canadian postal code with reg ex
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // user presses a key inside textBox1 text box
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.KeyChar - the character on pressed key
            //e.Handled - a bool flag that indicates processing is done
            if(!Char.IsLetter(e.KeyChar) && // not a letter
                e.KeyChar != ' '&&          // not a space
                e.KeyChar != '.' &&         //not a dot
                e.KeyChar != '_' &&         // not a hyphen
                e.KeyChar != '\''&&         // not a apostrophy
                e.KeyChar != (char) Keys.Back// not a backspace
                )
            {
                e.Handled = true; // marked as handled and ignores the conditions
            }
        }

        // happens just before text box loses focus
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            // check the format with reg ex
            Regex pattern = new Regex("^([a-zA-Z][0-9]){3}$"); // 6 characters, alternating letter and digit
            if(!pattern.IsMatch(textBox2.Text))
            {
                MessageBox.Show("Postal code format is incorrect", "Postal Format Error");
                textBox2.SelectAll();
                textBox2.Focus();
            }
        }
    }
}
