using System;
using System.Linq;
using System.Windows.Forms;

/*
 * Lunch Order Application
 * Takes what the user selects for their main course and add-ons and calculate its subtotal,
 * tax total, and order total.
 * Authror: Jacky
 * When: December 09, 2021
 */
namespace LunchOrderApp
{
    public partial class frmLunchOrder : Form
    {

        //cost for a hamburger
        const decimal hamburgerPrice = 6.95m;

        //cost for a pizza
        const decimal pizzaPrice = 5.95m;

        //cost for a salad
        const decimal saladPrice = 4.95m;

        //tax rate which is 5%
        const decimal taxRate = 0.05m;

        //price of the main course that will change
        //based on what the user selects as their main course
        decimal coursePrice = 0m;

        //price of add-ons that will change
        //based on what the user selects as their main course
        decimal addPrice = 0;

        public frmLunchOrder()
        {
            InitializeComponent();

            //Change radio button text to thier item and price
            radHamburger.Text = "Hamburger - $" + hamburgerPrice.ToString();
            radPizza.Text = "Pizza - $" + pizzaPrice.ToString();
            radSalad.Text = "Salad - $" + saladPrice.ToString();
        }

        //Method for when the user selects hamburger as thier main course
        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            //Declare add-on prices
            addPrice = 0.75m;

            //Declare course price
            coursePrice = hamburgerPrice;

            //Change add-ons group box title so that the price matches with the 
            //add-on prices for the meal
            ChangeAddOnPrice(addPrice);

            //Display add-ons for the selected meal
            cbItem1.Text = "Lettus, tomato, and onions";
            cbItem2.Text = "Ketchup, mustard, and mayo";
            cbItem3.Text = "French fries";
            
            //Clears the selected add-ons if the user switches their main course
            clearAddOns();
        }
        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            //Declare add-on prices
            addPrice = 0.5m;

            //Declare course price
            coursePrice = pizzaPrice;

            //Change add-ons group box title so that the price matches with the 
            //add-on prices for the meal
            ChangeAddOnPrice(addPrice);

            //Display add-ons for the selected meal
            cbItem1.Text = "Pepperoni";
            cbItem2.Text = "Sausage";
            cbItem3.Text = "Olives";

            //Clears the selected add-ons if the user switches their main course
            clearAddOns();
        }
        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            //Declare add-on prices
            addPrice = 0.25m;

            //Declare course price
            coursePrice = saladPrice;

            //Change add-ons group box text so that the price matches with the 
            //add-on prices for the meal
            ChangeAddOnPrice(addPrice);

            //Display add-ons for the selected meal
            cbItem1.Text = "Croutons";
            cbItem2.Text = "Bacon bits";
            cbItem3.Text = "Bread sticks";

            //Clears the selected add-ons if the user switches their main course
            clearAddOns();
        }

        //Add the price to the add-on items and change the text in add-on group box
        private void ChangeAddOnPrice(decimal _addPrice)
        {
            grbAddOns.Text = "Add-On Items ($" + _addPrice.ToString() + "/each)";
        }

        //When the user presses the "Place Order" button, it will calculate and 
        //display the subtotal, tax amount, and order total based on what 
        // they selected
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //used to calculate the number of add-on items selected 
            int itemsSelected = 0;

            //Counts how many add-ons are selected
            var checkboxes = grbAddOns.Controls.OfType<CheckBox>();
            foreach (CheckBox cb in checkboxes)
            {
                if (cb.Checked == true)
                {
                    itemsSelected++;
                }
            }
            //Get the total for all the add-ons that the user selected
            decimal addOnTotal = addPrice * itemsSelected;

            //Declares subtotal
            decimal subtotal = coursePrice + addOnTotal;

            //Declares how much the user needs to pay for tax
            decimal taxCost = getTaxAmount(subtotal);

            //Declares how much the user needs to pay all together including tax
            decimal orderTotal = getOrderTotal(subtotal, taxCost);

            //Display all the costs into its respective fields
            txtSubtotal.Text = System.Math.Round(subtotal, 2).ToString();
            txtTax.Text = System.Math.Round(taxCost, 2).ToString();
            txtOTotal.Text = System.Math.Round(orderTotal, 2).ToString();
        }

        //Calculate tax amount
        private decimal getTaxAmount(decimal subTotal)
        {
            return subTotal * taxRate;
        }

        //Calculate orderTotal
        private decimal getOrderTotal(decimal subTotal, decimal taxCost)
        {
            return subTotal * taxCost;
        }

        //uncheck all addons
        private void clearAddOns()
        {
            var checkboxes = grbAddOns.Controls.OfType<CheckBox>();
            foreach (CheckBox cb in checkboxes)
            {
                cb.Checked = false;
            }
        }

        //Clear all fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            //uncheck the add-on checkboxs
            clearAddOns();

            //clear the subtotal
            txtSubtotal.Clear();

            //clear the tax amount
            txtTax.Clear();

            //clear the order total
            txtOTotal.Clear();

            //set the radio button value back to the hamburger
            radHamburger.Checked = true;
        }

        //close form
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
