using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics.Contracts;

namespace DAO.Tools.Connection.MySql
{
    public static class MysqlBaglanti
    {
        private static MySqlConnection _connection;
        public static MySqlConnection Connection 
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new MySqlConnection(MysqlConnectionString.GetInstance().ConnectionString);
                    return _connection;
                }
                else return _connection;
            }
        }
        public static void BaglantiAc()
        {
            if (Connection.State == ConnectionState.Closed)
            { 
                Connection.Open();
            }
        }
        public static bool Connet()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            return true;
        }

        public static void BaglantiKapat()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
