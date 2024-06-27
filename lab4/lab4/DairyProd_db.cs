using MySql.Data.MySqlClient;

namespace lab4
{
    public class DairyProd_db
    {
        private string connectionString = "server=localhost;database=dairy_production;uid=root;pwd=Maha8520_;";
        public MySqlConnection Connection { get; private set; }

        public DairyProd_db()
        {
            Connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
