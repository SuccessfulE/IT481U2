using System.Data.SqlClient;

namespace IT481U2
{
    internal class Controller
    {
        string connectionString;
        SqlConnection cnn = null;

        //Creating connection to SQL Database
        public Controller() 
        {
            connectionString = "Server = desktop-hp19nsb\\SQLEXPRESS;" +
                                        "Trusted_Connection = true;" +
                                        "Database = northwind;" +
                                        "User Instance = false;" +
                                        "Connection timeout = 30";
        }
        
        public Controller(string conn)
        {
            connectionString = conn;
        }

        //Get the customer count from the SQL database
        public string getCustomerCount()
        {
            Int32 count = 0;

            //Create new SQL connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            //Create Query
            string countQuery = "select count(*) from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }

        //Get the company names from the SQL database
        public string getCompanyNames()
        {
            string names = "";
            SqlDataReader dataReader;

            //Create new SQL connection
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            //Create query
            string countQuery = "select companyname from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return names;
        }
    }
}
