using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DatabaseHandler
{
    public class DatabaseConnector
    {
        //Connection to local database
        SqlConnection con;
        //SQL command variable
        SqlCommand cmd;
        //SQL reader variable
        SqlDataReader reader;
        //Send request to database
        public List<String[]> send(String request)
        {
            //Set current path
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Messages.mdf;Integrated Security=True");
            //Varaible for results
            List<String[]> results = new List<string[]>();
            try
            {
                //Open connection to database
                con.Open();
                //Create new command
                cmd = new SqlCommand(request, con);
                //Execute command
                using (reader = cmd.ExecuteReader())
                {
                    //Iterate through the results
                    while (reader.Read())
                    {
                        string[] response = new string[0];
                        //Check response field count
                        if (reader.FieldCount > 1)
                        {
                            //parse response
                            string[] r = { reader["DateSent"].ToString(), reader["Message"].ToString() };
                            response = r;
                        }
                        //Add to results
                        results.Add(response);
                    }
                }
                
            }
            //Catch possible exceptions thrown
            catch(Exception e)
            {
                //Print errors
                Console.WriteLine("Database error: \n" + e);
                return new List<String[]>();
            }
            finally
            {
                //Close connection
                con.Close();
            }
            return results;
        }
    }
}
