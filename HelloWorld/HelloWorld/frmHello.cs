using System;
using System.Windows.Forms;

/*
 * Hello World Application
 * Display personalized greeting
 * Author: Jacky Luong
 * When: Dec 9th, 2021
 */
namespace HelloWorld
{
    #region frmHello Class
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        //Display greeting with name when user clicks a button
        private void greetButton_Click(object sender, EventArgs e)
        {
            // Check if user wrote a name and that the number textbox contains a whole number
            if(Validator.isPresent(userNameTxtBox) && Validator.IsNonNegativeInt(txtNum))
            {
                lblUserName.Text = "Hello " + userNameTxtBox.Text;
                lblNum.Text = "Your number is: " + txtNum.Text;
            }

        }

        //Clear Field when clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            lblUserName.Text = "What is your name?";
            lblNum.Text = "Write a number";
            userNameTxtBox.Text = "";
        }
        //Terminate execution
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close(); // close form
        }
    }
    #endregion
}//namespace
