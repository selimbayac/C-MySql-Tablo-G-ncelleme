using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO.Tools.Connection.MySql
{
    public class MysqlConnectionString
    {
        private MysqlConnectionString() { }
        private static MysqlConnectionString _connectionString;//singled  private oldğu için  ismi böyle 
        private string Server { get; set; }
        private string DbName { get; set; }
        private string User { get; set; }
        private string Password { get; set; }
        public static MysqlConnectionString GetInstance()
        {
            if (_connectionString == null)
            {
                throw new Exception("Baglanti değerleri henüz alınmamış!");
            }
            else return _connectionString;
        }

        public static MysqlConnectionString GetInstance(string server, string dbname, string user, string password)
        {
            if (_connectionString == null)
            {
                _connectionString = new MysqlConnectionString();
                _connectionString.Server = server;
                _connectionString.DbName = dbname;
                _connectionString.User = user;
                _connectionString.Password = password;
                return _connectionString;
            }
            else return _connectionString;
        }
        public string ConnectionString
        {
            get
            {        
                return $"SERVER={Server};DATABASE={DbName};UID={User};PWD={Password};";
            }
        }
    }
}
