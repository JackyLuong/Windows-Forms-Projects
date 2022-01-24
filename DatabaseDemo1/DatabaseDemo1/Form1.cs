using DatabaseDemo1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //load products data into the grid
        private void Form1_Load(object sender, EventArgs e)
        {
            using (MMABooksContext db = new MMABooksContext()) // Opens database to allow processing inside the curly brackets
            {
                //dgvProducts.DataSource = db.Products.ToList();
                //exclude navigation property InvoiceLineItems
                var products = db.Products.Select(p => new { p.ProductCode, p.Description, p.UnitPrice, p.OnHandQuantity }).ToList();
                dgvProducts.DataSource = products;

                //format headers 
                dgvProducts.EnableHeadersVisualStyles = false;
                dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
                dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkGray;

                //format alternating rows
                dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                
                //format the columns
                dgvProducts.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProducts.Columns[0].HeaderText = "Product Code";

                dgvProducts.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
                dgvProducts.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProducts.Columns[2].HeaderText = "Price";
                dgvProducts.Columns[2].Width = 200;
                dgvProducts.Columns[2].DefaultCellStyle.Format = "c";
                dgvProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // right-justify

                dgvProducts.Columns[3].HeaderText = "Quantity";
                dgvProducts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // right-justify

                //dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }// db is recycled
        }
    }
}
