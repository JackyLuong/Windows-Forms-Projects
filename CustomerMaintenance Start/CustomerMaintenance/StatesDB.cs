using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public static class StatesDB
    {
        /// <summary>
        /// Retrieves all the States in the database
        /// </summary>
        /// <returns>List of distinct states</returns>
        public static List<State> GetStates()
        {
            List<State> states = new List<State>(); // start with an empty list
            State state;
            using(SqlConnection connection = MMABooksDB.GetConnection())
            {
                string query = "SELECT StateCode, StateName FROM States ORDER BY StateName"; //SQL Query
                using(SqlCommand cmd = new SqlCommand(query, connection)) // Execute Query
                {
                    connection.Open(); //open the connection
                    using (SqlDataReader dr = cmd.ExecuteReader()) //reads data from connection
                    {
                        while(dr.Read()) // while there is data to read
                        {
                            state = new State() // Object Initializer
                            {
                                StateCode = dr["StateCode"].ToString(),
                                StateName = dr["StateName"].ToString()
                            };
                            states.Add(state); // add the object to the list
                        }
                    }// dr reader is recycled
                } // cmd ends and is recycled
            } // connection is automatically closed and recycled
            return states;
        }
    }
}
