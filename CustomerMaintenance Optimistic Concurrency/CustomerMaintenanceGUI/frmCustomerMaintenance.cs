using Microsoft.Data.SqlClient; // ADO.NET provider for SQL Server 
using Microsoft.EntityFrameworkCore;
using MMABooksData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenanceGUI
{
    public partial class frmCustomerMaintenance : Form
    {
        Customer selectedCustomer = null; // current customer        

        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        // user entered customer ID; get data of this customer
        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(txtCustomerID) &&
               Validator.IsNonNegativeInt(txtCustomerID))
            {
                int custID = Convert.ToInt32(txtCustomerID.Text);
                try
                {
                    using(MMABooksContext db = new MMABooksContext())
                    {
                        selectedCustomer = db.Customers.Find(custID); // Find works when searching by PK
                        if(selectedCustomer != null) // we have current customer
                        {
                            DisplayCustomer();

                            var invoices = selectedCustomer.Invoices.
                                Select(i => new {i.InvoiceId, i.CustomerId, i.InvoiceDate, i.InvoiceTotal}).
                                ToList(); // lazy loading of related invoices
                            
                            // display related records
                            dgvInvoices.DataSource = invoices;
                            dgvInvoices.Columns[3].DefaultCellStyle.Format = "c"; // format 4-th column (invoice total)
                        }
                        else // not found
                        {
                            MessageBox.Show("No customer found with ID " + custID, "Customer Not Found");
                            ClearControls();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error while getting customer's data: " + ex.Message, ex.GetType().ToString());
                }
            }
        }

        // no selected customer
        private void ClearControls()
        {
            txtCustomerID.Text = ""; 
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";

            // disable Modify and Delete buttons
            btnModify.Enabled = false;
            btnDelete.Enabled = false;

            txtCustomerID.Focus();
        }

        private void DisplayCustomer()
        {
            txtCustomerID.Text = selectedCustomer.CustomerId.ToString(); // should not change from the find
            txtName.Text = selectedCustomer.Name;
            txtAddress.Text = selectedCustomer.Address;
            txtCity.Text = selectedCustomer.City;
            txtState.Text = selectedCustomer.State;
            txtZipCode.Text = selectedCustomer.ZipCode;        

            // enable Modify and Delete buttons
            btnModify.Enabled = true;
            btnDelete.Enabled = true;

            txtCustomerID.Focus();
        }

        // terminate application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // add another customer to the Customers table
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyCustomer secondForm = new frmAddModifyCustomer();
            secondForm.isAdd = true;
            secondForm.customer = null;

            DialogResult result = secondForm.ShowDialog(); // display second form modal

            if(result == DialogResult.OK) // second form has customer object with data
            {
                selectedCustomer = secondForm.customer;
                // add it to the database table using EF
                try
                {
                    using(MMABooksContext db =new MMABooksContext())
                    {
                        db.Customers.Add(selectedCustomer);
                        db.SaveChanges();                        
                    }
                    DisplayCustomer();
                }
                catch(DbUpdateException ex)
                {
                    this.HandleDbUpdateException(ex);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error while adding a customer: " + ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyCustomer secondForm = new frmAddModifyCustomer();
            secondForm.isAdd = false; // it's Modify
            secondForm.customer = selectedCustomer; 

            DialogResult result = secondForm.ShowDialog();

            if (result == DialogResult.OK) // second form has customer with new data
            {
                using (MMABooksContext db = new MMABooksContext())
                {
                    try
                    {
                        int custID = secondForm.customer.CustomerId;
                        // need to have object in the current  context
                        selectedCustomer = db.Customers.Find(custID);

                        ////simulate concurrency error
                        //db.Database.ExecuteSqlRaw($"UPDATE Customers SET Address = '123 Main Street' WHERE CustomerID = {custID}");
                        
                        // copy data from customer on the second form
                        selectedCustomer.Name = secondForm.customer.Name;
                        selectedCustomer.Address = secondForm.customer.Address;
                        selectedCustomer.City = secondForm.customer.City;
                        selectedCustomer.State = secondForm.customer.State;
                        selectedCustomer.ZipCode = secondForm.customer.ZipCode;
                        db.SaveChanges();
                        DisplayCustomer();

                    }
                    catch (DbUpdateConcurrencyException ex) // concurrency error
                    {
                        this.HandleConcurrencyError(ex, db);
                    }
                    catch (DbUpdateException ex)
                    {
                        this.HandleDbUpdateException(ex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while modifying customer: " + ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        //retrieve up to date data
        private void HandleConcurrencyError(DbUpdateConcurrencyException ex, MMABooksContext db)
        {
            ex.Entries.Single().Reload();
            var state = db.Entry(selectedCustomer).State;
            if(state == EntityState.Detached) // record was deleted
            {
                MessageBox.Show("Another user has deleted this customer", "Concurrency Error");
                this.ClearControls();
            }
            else // it was updated
            {
                MessageBox.Show("Another user updated this customer. Try again.", "Concurrency Error");
                this.DisplayCustomer();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(selectedCustomer != null)
            {
                //get confirmation from the user
                DialogResult answer = MessageBox.Show($"Do you want to delete {selectedCustomer.Name}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(answer == DialogResult.Yes) // user confirmed
                {
                    using (MMABooksContext db = new MMABooksContext())
                    {
                        try
                        {

                            // need to have object in the current  context
                            selectedCustomer = db.Customers.Find(selectedCustomer.CustomerId);
                            db.Customers.Remove(selectedCustomer);
                            db.SaveChanges();
                            ClearControls();

                        }
                        catch (DbUpdateConcurrencyException ex)
                        {
                            this.HandleConcurrencyError(ex, db);
                        }
                        catch (DbUpdateException ex)
                        {
                            this.HandleDbUpdateException(ex);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while deleting customer: " + ex.Message, ex.GetType().ToString());
                        }
                    }
                }
            }
            else // no selected customer
            {
                MessageBox.Show("You need to select a customer first", "Delete Aborted");
            }
        }

        private void HandleDbUpdateException(DbUpdateException ex ) // problems with performing SaveChanges
        {
            // get the inner exception with potentially multiple errors
            SqlException innerException = (SqlException) ex.InnerException;
            string message = "";
            foreach(SqlError err in innerException.Errors)
            {
                message += $"Error {err.Number}: {err.Message}\n";
            }
            MessageBox.Show(message, "Database error(s)");
        }

    }
}
