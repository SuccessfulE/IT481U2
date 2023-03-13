using System.Data.SqlClient;

namespace IT481U2
{
    internal class Sqlcommand
    {
        private string countQuery;
        private SqlConnection cnn;

        public Sqlcommand(string countQuery, SqlConnection cnn)
        {
            this.countQuery = countQuery;
            this.cnn = cnn;
        }

        internal SqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }

        internal bool ExecuteScalar()
        {
            throw new NotImplementedException();
        }
    }
}