using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CustomerMaintenance
{
    public class CustomerDB
    {
        /// <summary>
        /// Retrieve data of customer with given ID
        /// </summary>
        /// <param name="customerID"> ID of the customer to get</param>
        /// <returns>Customer object or null if not found</returns>
        public static Customer GetCustomer(int customerID)
        {
            Customer customer = null; // empty customer Object
            using(SqlConnection connection = MMABooksDB.GetConnection())
            {
                string query = "SELECT CustomerID, Name, Address, City, State, ZipCode " +
                               "FROM Customers " +
                               "WHERE CustomerID = @CustomerID"; // @ is a parameter
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID); // assign parameter from query to the method parameter
                    connection.Open();

                    // process a single customer row instead of all customers
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if(dr.Read()) // if there is data
                        {
                            customer = new Customer()
                            {
                                CustomerID = (int)dr["CustomerID"],
                                Name = dr["Name"].ToString(),
                                Address = dr["Address"].ToString(),
                                City = dr["City"].ToString(),
                                State = dr["State"].ToString(),
                                ZipCode = dr["ZipCode"].ToString()
                            };
                        }
                    }
                }
            }
            return customer;
        }

        /// <summary>
        /// Adds another customer data to the table
        /// </summary>
        /// <param name="customer">Customer object to add</param>
        /// <returns>Generated CustomerID/ Primary Key Value</returns>
        public static int AddCustomer (Customer customer)
        {
            int custId = 0;
            using(SqlConnection connection = MMABooksDB.GetConnection())
            {
                string insertStatment = "INSERT INTO Customers(Name, Address, City, State, ZipCode) " +
                                        "OUTPUT inserted.CustomerID " + // returns the customerID from the inserted customer data
                                        "VALUES(@Name, @Address, @City, @State, @ZipCode)";
                using(SqlCommand cmd = new SqlCommand(insertStatment, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Address", customer.Address);
                    cmd.Parameters.AddWithValue("@City", customer.City);
                    cmd.Parameters.AddWithValue("@State", customer.State);
                    cmd.Parameters.AddWithValue("@ZipCode", customer.ZipCode);

                    connection.Open();
                    custId = (int)cmd.ExecuteScalar(); // return customer ID and creates customer object to the database
                }
            }
            return custId;
        }
        /// <summary>
        /// Delete given customer
        /// </summary>
        /// <param name="customer">Customer to delete</param>
        /// <returns>success flag</returns>
        public static bool DeleteCustomer(Customer customer)
        {
            bool result = true;
            using(SqlConnection connection = MMABooksDB.GetConnection())
            {
                string deleteStatement = "DELETE FROM Customers " +
                                         "WHERE CustomerID = @CustomerID " + // enough to identify the customer
                                         "AND Name = @Name " +
                                         "AND Address = @Address " +
                                         "AND City = @City " +
                                         "AND State = @State " +
                                         "AND ZipCode = @ZipCode "; // State all the columns for optimistic concurrency
                                                                   // Ensuring that nothing was changed when trying to delete customer data
                using(SqlCommand cmd = new SqlCommand(deleteStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerID);
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Address", customer.Address);
                    cmd.Parameters.AddWithValue("@City", customer.City);
                    cmd.Parameters.AddWithValue("@State", customer.State);
                    cmd.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
                    
                    connection.Open();
                    //Thread.Sleep(10000); // deplay execution by 10 seconds - test for concurrency

                    int count = cmd.ExecuteNonQuery(); // returns number of rows affected
                    if (count == 0) //  nothing was deleted - concurrency problem 
                        return false;
                }
            }
            return result;
        }
        /// <summary>
        /// Update customer record
        /// </summary>
        /// <param name="oldCustomer">Old data, for optimistic concurrency</param>
        /// <param name="newCustomer">New data for the upadate</param>
        /// <returns>Success flag</returns>
        public static bool UpdateCustomer(Customer oldCustomer, Customer newCustomer)
        {
            bool result = true;

            using(SqlConnection connection = MMABooksDB.GetConnection())
            {
                string updateStatement = "UPDATE Customers SET " +
                                         "Name = @NewName, " +
                                         "Address = @NewAddress, " +
                                         "City = @NewCity, " +
                                         "State = @NewState, " +
                                         "ZipCode = @NewZipCode " +
                                         "WHERE CustomerId = @OldCustomerID " + // for identification
                                            "AND Name = @OldName " +
                                            "AND Address = @OldAddress " +
                                            "AND State = @OldState " +
                                            "AND City = @OldCity " +
                                            "AND ZipCode = @OldZipCode ";
                using (SqlCommand cmd = new SqlCommand(updateStatement, connection))
                {
                    cmd.Parameters.AddWithValue("@NewName", newCustomer.Name);
                    cmd.Parameters.AddWithValue("@NewAddress", newCustomer.Address);
                    cmd.Parameters.AddWithValue("@NewCity", newCustomer.City);
                    cmd.Parameters.AddWithValue("@NewState", newCustomer.State);
                    cmd.Parameters.AddWithValue("@NewZipCode", newCustomer.ZipCode);

                    cmd.Parameters.AddWithValue("@OldCustomerID", oldCustomer.CustomerID);
                    cmd.Parameters.AddWithValue("@OldName", oldCustomer.Name);
                    cmd.Parameters.AddWithValue("@OldAddress", oldCustomer.Address);
                    cmd.Parameters.AddWithValue("@OldCity", oldCustomer.City);
                    cmd.Parameters.AddWithValue("@OldState", oldCustomer.State);
                    cmd.Parameters.AddWithValue("@OldZipCode", oldCustomer.ZipCode);

                    connection.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count == 0)
                        result = false;
                }
            }
            return result;
        }
    }
}
