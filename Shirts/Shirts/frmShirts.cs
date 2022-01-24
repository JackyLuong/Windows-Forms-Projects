using System;
using System.Windows.Forms;

namespace Shirts
{
    public partial class frmShirts : Form
    {
        //Class variables
        int[,] shirtSold = new int[,]
        {
            {345 , 564 , 1245, 1690},
            {2232, 1534, 795 , 238 },
            {1189, 1387, 987 , 546 }
        };
        //Available colours
        string[] shirtColours = new string[]
            {
                "Black",
                "White",
                "Red"
            };
        public frmShirts()
        {
            InitializeComponent();
        }

        //At application load
        private void frmShirts_Load(object sender, EventArgs e)
        {
            //lopp through Row
            for(int i = 0; i< shirtSold.GetLength(0); i++)
            {
                string[] shirtSoldRow = new string[shirtSold.GetLength(1) + 1]; // string array to display data in each column of the row
                shirtSoldRow[0] = shirtColours[i]; // Displays colours available
                
                //Loop through numbers for each column
                for (int j = 0; j <shirtSold.GetLength(1); j++)
                {
                    shirtSoldRow[j+1] = shirtSold[i, j].ToString();
                }
                
                //Display row
                dgvShirts.Rows.Add(shirtSoldRow);
            }
            lblWinner.Text = "";
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] sumRow = new int[shirtSold.GetLength(0)]; // Sum of each row
            TextBox[] txtSumBoxes = new TextBox[] // Textbox to display the sum of each row
            {
                txtSum1,
                txtSum2,
                txtSum3,
            };

            //Display sum of each row
            for (int i = 0; i < sumRow.Length; i++)
            {
                for (int j = 0; j < shirtSold.GetLength(1); j++)
                {
                    sumRow[i] += shirtSold[i, j];
                }
                txtSumBoxes[i].Text = sumRow[i].ToString();
            }

            //Display winning product
            lblWinner.Text = "Winning product is: " + shirtColours[findHighest(sumRow)] + " Shirts";
        }
        //mothod to find highest sum and gets the index of the row
        public int findHighest(int[] sumRow)
        {
            int highest = sumRow[0];
            int highestSumIndex = 0;
            for (int i = 0; i < sumRow.Length; i++)
            {
                if (highest < sumRow[i])
                {
                    highest = sumRow[i];
                    highestSumIndex = i;
                }
            }
            return highestSumIndex;
        }
    }
}
