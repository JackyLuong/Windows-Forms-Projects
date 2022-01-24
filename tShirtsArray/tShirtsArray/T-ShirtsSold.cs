using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tShirtsArray
{
    public partial class Form1 : Form
    {
        int[,] tShirtSales = new int[,]
        {
                {345 , 564 , 1245, 1690},
                {2232, 1534, 795 , 238 },
                {1189, 1387, 987 , 546 }
        };
    public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {       
            for (int i = 0; i < tShirtSales.GetLength(0); i++) // the first dimension - rows
            {
                string[] tShirtSalesRow = new string [tShirtSales.GetLength(1)]; //a new 1-D string array for displaying each row

                for (int j = 0; j < tShirtSales.GetLength(1); j++) // the second dimension - columns
                {
                    tShirtSalesRow[j] = tShirtSales[i, j].ToString();
                }
                dataGridViewShirts.Rows.Add(tShirtSalesRow);
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sumRow = new int [tShirtSales.GetLength(0)];
            for (int i = 0; i < sumRow.Length; i++) 
            {
                for (int j = 0; j < tShirtSales.GetLength(1); j++) 
                {
                    sumRow[i] += tShirtSales[i, j];
                    
                }
            }
            textBoxRow1.Text = sumRow[0].ToString();
            textBoxRow2.Text = sumRow[1].ToString();
            textBoxRow3.Text = sumRow[2].ToString();

            if (sumRow[0] >= sumRow[1] && sumRow[0] >= sumRow[2])
            {
                textBoxMaximum.Text = "The winning colour is Black (Row 1) with " + sumRow[0] + " T-shirts sold";
            }
            else if (sumRow[1] >= sumRow[0] && sumRow[1] >= sumRow[2])
            {
                textBoxMaximum.Text = "The winning colour is White (Row 2) with " + sumRow[1] + " T-shirts sold";
            }
            else
            {
                textBoxMaximum.Text = "The winning colour is Red (Row 3) with " + sumRow[2] + " T-shirts sold";
            }       
        }
    }
}
