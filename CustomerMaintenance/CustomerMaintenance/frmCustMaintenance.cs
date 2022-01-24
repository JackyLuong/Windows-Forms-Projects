using Microsoft.Data.SqlClient; //ADO.NET provider for SQL Server  
using Microsoft.EntityFrameworkCore;
using MMABooksData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmCustMaintenance : Form
    {
        Customer selectedCustomer = null;
        public frmCustMaintenance()
        {
            InitializeComponent();
        }

        //User entered customerId; get data of this customer
        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if (Validator.isPresent(txtCustomerID)
                && Validator.IsNonNegativeInt(txtCustomerID))
            {
                int custId = Convert.ToInt32(txtCustomerID.Text);
                try
                {
                    using (MMABooks2Context db = new MMABooks2Context())
                    {
                        selectedCustomer = db.Customers.Find(custId); // Find works by searching PK
                        if(selectedCustomer != null) // we have current customer
                        {
                           var invoices = selectedCustomer.Invoices
                                .Select(i => new { i.InvoiceId, i.CustomerId, i.InvoiceDate, i.InvoiceTotal })
                                .ToList();// lazy loading

                            //display realted records
                            dgvInvoices.DataSource = invoices;
                            dgvInvoices.Columns[3].DefaultCellStyle.Format = "c"; // format 4th column to currency


                            DisplayCustomer();
                        }
                        else // not found
                        {
                            MessageBox.Show($"No customer found with ID: {custId}, Customer Not Found");
                            ClearControls();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error while getting customer's data: {ex.Message}, {ex.GetType()}");
                }
            }

        }

        private void DisplayCustomer()
        {
            txtCustomerID.Text = selectedCustomer.CustomerId.ToString(); // should not change from the find
            txtName.Text = selectedCustomer.Name;
            txtAddress.Text = selectedCustomer.Address;
            txtCity.Text = selectedCustomer.City;
            txtState.Text = selectedCustomer.State;
            txtZipCode.Text = selectedCustomer.ZipCode;

            //enable modify and delete buttons
            btnModify.Enabled = true;
            btnDelete.Enabled = true;

            txtCustomerID.Focus();
        }

        // no customer selected
        private void ClearControls()
        {
            txtCustomerID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZipCode.Clear();

            btnModify.Enabled = false;
            btnDelete.Enabled = false;

            txtCustomerID.Focus();
        }
        //close application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //adds customer to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyCustomer secondfrm = new frmAddModifyCustomer();
            secondfrm.isAdd = true;
            secondfrm.customer = null;

            DialogResult result = secondfrm.ShowDialog(); // display second form model

            if(result == DialogResult.OK) // second form has customer object with data
            {
                selectedCustomer = secondfrm.customer;

                //add it to the database table using EF
                using (MMABooks2Context db = new MMABooks2Context())
                {
                    try
                    {
                        db.Customers.Add(selectedCustomer);
                        db.SaveChanges();
                        DisplayCustomer();
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        this.HandleConcurrencyError(ex, db);
                    }
                    catch (DbUpdateException DB_Ex)
                    {
                        HandleDbUpdateException(DB_Ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding customer: " + ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyCustomer secondfrm = new frmAddModifyCustomer();
            secondfrm.isAdd = false;
            secondfrm.customer = selectedCustomer;

            DialogResult result = secondfrm.ShowDialog(); // display second form model

            if (result == DialogResult.OK) // second form has customer object with data
            {
                //replace original customer data with updated data
                using (MMABooks2Context db = new MMABooks2Context())
                {
                    try
                    {

                        {
                            // need to have object in the current context
                            selectedCustomer = db.Customers.Find(secondfrm.customer.CustomerId);

                            //simulate concurrency error
                            //db.Database.ExecuteSqlRaw($"UPDATE Customers SET Address = '123 Main Street' WHERE CustomerID = {custID}");

                            // copy data from customer on the second form
                            selectedCustomer.Name = secondfrm.customer.Name;
                            selectedCustomer.Address = secondfrm.customer.Address;
                            selectedCustomer.City = secondfrm.customer.City;
                            selectedCustomer.State = secondfrm.customer.State;
                            selectedCustomer.ZipCode = secondfrm.customer.ZipCode;
                            // save changes
                            db.SaveChanges();
                        }
                        DisplayCustomer();
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        this.HandleConcurrencyError(ex, db);
                    }
                    catch (DbUpdateException DB_Ex)
                    {
                        HandleDbUpdateException(DB_Ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding customer: " + ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedCustomer != null)
            {
                //Get confirmation from the user
                DialogResult answer = MessageBox.Show($"Are you sure you want to delete {selectedCustomer.Name}?",
                                                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(answer == DialogResult.Yes) // user confirmed
                {
                    using (MMABooks2Context db = new MMABooks2Context())
                    {
                        try
                        {
                            db.Remove(selectedCustomer);
                            db.SaveChanges();

                            ClearControls();
                        }
                        catch (DbUpdateConcurrencyException ex)
                        {
                            this.HandleConcurrencyError(ex, db);
                        }
                        catch (DbUpdateException DB_Ex)
                        {
                            HandleDbUpdateException(DB_Ex);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error when trying to delete customer:" + ex.Message, ex.GetType().ToString());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You need to select a customer first", "Delete Aborted");
            }
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex, MMABooks2Context db)
        {
            ex.Entries.Single().Reload(); // reload entry
            var state = db.Entry(selectedCustomer).State;
            if (state == EntityState.Detached) // record was deleted
            {
                MessageBox.Show("Another user has deleted this customer", "Concurrency Error");
                this.ClearControls();
            }
            else // it was updated
            {
                MessageBox.Show("Another user has updated this customer", "Concurrency Error");
                this.DisplayCustomer(); // reload the display
            }
        }

        private void HandleDbUpdateException(DbUpdateException ex) // problems with performing SaveChanges
        {
            // get the inner exception with potentially multiple errors
            SqlException innerException = (SqlException)ex.InnerException;
            string message = "";
            foreach(SqlError err in innerException.Errors)
            {
                message += $"Error {err.Number}: {err.Message}\n";
            }
            MessageBox.Show(message, "Database Errors");
        }
    }
}
