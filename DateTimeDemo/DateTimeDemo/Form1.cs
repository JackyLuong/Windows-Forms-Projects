using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            DisplayDateTime();
        }

        private void DisplayDateTime()
        {
            lblDate.Text = DateTime.Today.ToString("dddd, MMMM dd, yyyy");
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayDateTime();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime partyDate = dateTimePicker1.Value.Date;
            
            //How many days to the party
            TimeSpan difference = partyDate.Subtract(DateTime.Today);
            int days = difference.Days;

            lblMessage.Text = "The party is on " + partyDate.ToLongDateString();

            //If there are days left till the party
            if (days > 0)
            {
                lblMessage.Text += "\n" + days + " day(s) left to the party";
            }
            //If if the party is on the day of
            else if(days == 0)
            {
                lblMessage.Text += "\n" +"IT'S TODAY!!!!";
            }
            //If the party has already passed
            else
            {
                lblMessage.Text +=  "\n It was " + -days + " day(s) ago.";
            }
        }
    }
}
