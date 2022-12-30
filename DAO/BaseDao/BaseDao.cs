
using DAO.link_checker;
using DAO.SqlCommand;
using DAO.Tools.Connection.MySql;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAO.BaseDao
{

    public abstract class BaseDaoa
    {

        public Hashtable QueryVariable = new Hashtable();
        public abstract DataTable Select();
        public abstract void Insert();
        public abstract void Update();
        public abstract void Delete();
        public abstract void ComaboxSelect();
        public abstract void Texdolurma();


        public   DataTable Select(string sqlString)
        {
            DataTable myData = new DataTable();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            MySqlCommand myCommand = new MySqlCommand(sqlString, MysqlBaglanti.Connection);
            myAdapter.SelectCommand = myCommand;
            myAdapter.Fill(myData);
            return myData;
        }

        public  string Update(string sqlString)
        {
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            if (!MysqlBaglanti.Connet()) return null;
            MySqlCommand myCommand = new MySqlCommand(sqlString, MysqlBaglanti.Connection);
            foreach (DictionaryEntry item in QueryVariable)
            {
                myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);              
            }
            myAdapter.SelectCommand = myCommand;
            myCommand.ExecuteNonQuery();
            return sqlString;
        }
        public string Insert(string sqlString)
        {
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            if (!MysqlBaglanti.Connet()) return null;
            MySqlCommand myCommand = new MySqlCommand(sqlString, MysqlBaglanti.Connection);
            foreach (DictionaryEntry item in QueryVariable)
            {
                myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
            }
            myAdapter.SelectCommand = myCommand;
            myCommand.ExecuteNonQuery();
            return sqlString;
        }
        public string Delete(string sqlString)
        {
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            if (!MysqlBaglanti.Connet()) return null;
            MySqlCommand myCommand = new MySqlCommand(sqlString, MysqlBaglanti.Connection);
            // parametre 
            foreach (DictionaryEntry item in QueryVariable)
            {
                myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
            }
            myAdapter.SelectCommand = myCommand;
            myCommand.ExecuteNonQuery();
            return sqlString;
        }
        public MySqlCommand Texdolurma(string sqlString)
        {
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            if (!MysqlBaglanti.Connet()) return null;
            MySqlCommand myCommand = new MySqlCommand(sqlString, MysqlBaglanti.Connection);
            // parametre gelecek 
            foreach (DictionaryEntry item in QueryVariable)
            {
                myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
            }
            myAdapter.SelectCommand = myCommand;
            myCommand.ExecuteNonQuery();
            return myCommand;
        }
        public MySqlCommand ComaboxSelect(string sqlString)
        {
            DataTable myData = new DataTable();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            if (!MysqlBaglanti.Connet()) return null;
            MySqlCommand myCommand = new MySqlCommand(sqlString, MysqlBaglanti.Connection);
            myAdapter.SelectCommand = myCommand;
            myCommand.CommandType = CommandType.Text;
            myAdapter.Fill(myData);
            return myCommand;
        }
      
        
    }
}
