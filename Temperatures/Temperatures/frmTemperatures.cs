using System;
using System.Windows.Forms;

/*
 * Using Arrays to display different temperatures, 
 * number of recorded temperatures, 
 * and the average temperatures
 */
namespace Temperatures
{

    public partial class frmTemperatures : Form
    {
        //Class-level declarations
        const int MAX_COUNT = 31;
        double[] temperatures = new double[MAX_COUNT];
        const double MIN_TEMP = -100;
        const double MAX_TEMP = 100;
        int count = 0; // how many temperatures collected
        double sum = 0; // sum for the average temperature
        double average; //average temperature
        double lowest; // lowest temperature recorded
        double highest; //highest temperature recorded
        public frmTemperatures()
        {
            InitializeComponent();
        }
        //At the start of the application
        private void frmTemperatures_Load(object sender, EventArgs e)
        {
            txtNumOfTemp.Text = count.ToString();
            DisplayStats();
            txtTemp.Focus();
        }
        //When the add button is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //local declarations
            double temp; // new temperature to add

            if(Validator.isPresent(txtTemp) && 
               Validator.IsDoubleInRange(txtTemp, MIN_TEMP, MAX_TEMP))
            {
                //get new temperature
                temp = Convert.ToDouble(txtTemp.Text);

                //add it to the array
                temperatures[count] = temp; // count is allso the index of the next available spot in the array

                // adjust stats in the display
                sum += temperatures[count];
                count++;
                DisplayStats();
                //Disables the grbNewTemp if array reaches the maximum count
                if (count == MAX_COUNT)
                {
                    grbNewTemp.Enabled = false;
                }
            }
        }
        //mothod to find lowest temperature
        //returns zero when no temperatures
        public double findLowest(double[] temperatures, int count)
        {
            double lowest = 0;
            if(count > 0)
            {
                lowest = temperatures[0];
                for(int i = 1; i < count; i++)
                {
                    if(temperatures[i] < lowest)
                    {
                        lowest = temperatures[i];
                    }
                }
            }
            return lowest;
        }
        // Displays average, lowest and highest temperature
        private void DisplayStats()
        {
            DisplayTemperatures();
            txtTemp.Text = "";
            if (count == 0)
            {
                average = lowest = highest = 0;
            }
            else
            {
                //Assign variables to a value
                average = sum / count;
                lowest = findLowest(temperatures, count);
                highest = findHighest(temperatures, count);

                //Display Data
                txtNumOfTemp.Text = count.ToString();
                txtAvg.Text = average.ToString("f2");
                txtHighest.Text = highest.ToString();
                txtLowest.Text = lowest.ToString();
            }
        }
        //Displays Temperature
        void DisplayTemperatures()
        {
            lstTemp.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                lstTemp.Items.Add(temperatures[i]);
            }

        }
        //mothod to find highest temperature
        //returns zero when no temperatures
        public double findHighest(double[] temperatures, int count)
        {
            double highest = 0;
            if (count > 0)
            {
                highest = temperatures[0];
                for (int i = 1; i < count; i++)
                {
                    if (temperatures[i] > highest)
                    {
                        highest = temperatures[i];
                    }
                }
            }
            return highest;
        }
        //When the clear button is clocked
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAvg.Clear();
            txtTemp.Clear();
            txtNumOfTemp.Text = count.ToString();
        }
        //Reset collection
        private void btnResetCollection_Click(object sender, EventArgs e)
        {
            count = 0;
            sum = 0;
            DisplayStats();
        }
    }
}
