using DAO.CityParams;
using DAO.Tools.Connection.MySql;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAL.Concrete.MySql
{
    //public  class UlkeDal :UlkeParams
    //{
    //    public Hashtable QueryVariable = new Hashtable();
    //    public DataTable GetCity()
    //    {


    //        DataTable myData = new DataTable();
    //        MySqlDataAdapter myAdapter = new MySqlDataAdapter();

    //        MySqlCommand myCommand = new MySqlCommand("Select * from city", MysqlBaglanti.Connection);
    //        myAdapter.SelectCommand = myCommand;
    //        myAdapter.Fill(myData);
    //        return myData;

    //    }

    //    public bool Guncelle()
    //    {
    //        int a = 0;

    //        using (MySqlCommand myCommand = new MySqlCommand("UPDATE city SET cityad = @cityad, citynufus = @citynufus WHERE cityID =@cityID;", MysqlBaglanti.Connection))
    //        {
    //            MysqlBaglanti.BaglantiAc();

    //            QueryVariable = GetParameters();
    //            foreach (DictionaryEntry item in QueryVariable)
    //            {
    //                myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
    //            }
    //            using (MySqlDataReader reader = myCommand.ExecuteReader())
    //            {
    //                return true;
    //            }
    //        }
    //    }


    //    public bool Kaydet()
    //    {
    //        int a = 0;

    //        using (MySqlCommand myCommand = new MySqlCommand("Insert into city (cityad, citynufus) values(@cityad, @citynufus);", MysqlBaglanti.Connection))
    //        {
    //            MysqlBaglanti.BaglantiAc();

    //            QueryVariable = GetParameters();
    //            foreach (DictionaryEntry item in QueryVariable)
    //            {
    //                myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
    //            }
    //            using (MySqlDataReader reader = myCommand.ExecuteReader())
    //            {
    //                return true;
    //            }
    //        }
    //    }


    //    public bool Sil()
    //    {
    //        using (MySqlCommand myCommand = new MySqlCommand("delete from city where cityID =  @cityID ;", MysqlBaglanti.Connection))
    //        {
    //            MysqlBaglanti.BaglantiAc();
    //            QueryVariable = GetParameters();
    //            foreach (DictionaryEntry item in QueryVariable)
    //            {
    //                myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
    //            }
    //            using (MySqlDataReader reader = myCommand.ExecuteReader())
    //            {
    //                return true;
    //            }
    //        }
    //    }

    //    public MySqlCommand SetTextBox()
    //    {
    //        DataTable myData = new DataTable();
    //        MySqlDataAdapter myAdapter = new MySqlDataAdapter();
    //        using (MySqlCommand myCommand = new MySqlCommand("Select * from city", MysqlBaglanti.Connection))
    //        {
    //            MysqlBaglanti.BaglantiAc();
    //            QueryVariable = GetParameters();
    //            foreach (DictionaryEntry item in QueryVariable)
    //            {
    //                myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
    //            }
    //            myAdapter.SelectCommand = myCommand;
    //            myCommand.CommandType = CommandType.Text;
    //            myAdapter.Fill(myData);
    //            return myCommand;
    //        }

    //    }
       
    //        public MySqlCommand GettexttcCity()
    //        {
    //            using (MySqlCommand myCommand = new MySqlCommand("SELECT *  FROM city  WHERE cityID=@cityID", MysqlBaglanti.Connection))
    //            {
    //                MysqlBaglanti.BaglantiAc();
    //                QueryVariable = GetParameters();
    //                foreach (DictionaryEntry item in QueryVariable)
    //                {
    //                    myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
    //                }
    //                using (MySqlDataReader reader = myCommand.ExecuteReader())
    //                {
    //                    return myCommand;
    //                }
    //            }
    //        }

    //    }
    }
    

