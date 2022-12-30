using DAO.CityParams;

using DAO.Tools.Connection.MySql;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAL.Concrete.MySql
{
    //public class ColorDal:MysqlParamsColor
    //{    
        //public DataTable GetColor()
        //{
        //    DataTable myData = new DataTable();
        //    MySqlDataAdapter myAdapter = new MySqlDataAdapter();

        //    MySqlCommand myCommand = new MySqlCommand("Select * from renkler", MysqlBaglanti.Connection);
        //    myAdapter.SelectCommand = myCommand;
        //    myAdapter.Fill(myData);
        //    return myData;
        //}
        //public bool ColorUpdate()
        //{
        //    int a = 0;

        //    using (MySqlCommand myCommand = new MySqlCommand("UPDATE renkler SET renk = @renk , renkkodu = @renkkodu WHERE renkid =@renkid;", MysqlBaglanti.Connection))
        //    {
        //        MysqlBaglanti.BaglantiAc();

        //        QueryVariable = GetParameters();
        //        foreach (DictionaryEntry item in QueryVariable)
        //        {
        //            myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
        //        }
        //        using (MySqlDataReader reader = myCommand.ExecuteReader())
        //        {
        //            return true;
        //        }
        //    }
        //}
        //public bool ColorAdd()
        //{
        //    int a = 0;

        //    using (MySqlCommand myCommand = new MySqlCommand("Insert into renkler (renkkodu , renk) values(@renkkodu , @renk);", MysqlBaglanti.Connection))
        //    {
        //        MysqlBaglanti.BaglantiAc();

        //        QueryVariable = GetParameters();
        //        foreach (DictionaryEntry item in QueryVariable)
        //        {
        //            myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
        //        }
        //        using (MySqlDataReader reader = myCommand.ExecuteReader())
        //        {
        //            return true;
        //        }
        //    }
        //}
        //public bool ColorDelete()
        //{
        //    using (MySqlCommand myCommand = new MySqlCommand("delete from renkler where renkid =  @renkid ;", MysqlBaglanti.Connection))
        //    {
        //        MysqlBaglanti.BaglantiAc();
        //        QueryVariable = GetParameters();
        //        foreach (DictionaryEntry item in QueryVariable)
        //        {
        //            myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
        //        }
        //        using (MySqlDataReader reader = myCommand.ExecuteReader())
        //        {
        //            return true;
        //        }
        //    }
        //}
        //public MySqlCommand SetTexboxColor()
        //{
        //    DataTable myData = new DataTable();
        //    MySqlDataAdapter myAdapter = new MySqlDataAdapter();
        //    using (MySqlCommand myCommand = new MySqlCommand("Select * from renkler", MysqlBaglanti.Connection))
        //    {
        //        MysqlBaglanti.BaglantiAc();
        //        QueryVariable = GetParameters();
        //        foreach (DictionaryEntry item in QueryVariable)
        //        {
        //            myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
        //        }
        //        myAdapter.SelectCommand = myCommand;
        //        myCommand.CommandType = CommandType.Text;
        //        myAdapter.Fill(myData);
        //        return myCommand;
        //    }

        //}
        //public MySqlCommand Gettexttcolor()
        //{
        //    using (MySqlCommand myCommand = new MySqlCommand("SELECT *  FROM renkler  WHERE renkid=@renkid", MysqlBaglanti.Connection))
        //    {
        //        MysqlBaglanti.BaglantiAc();
        //        QueryVariable = GetParameters();
        //        foreach (DictionaryEntry item in QueryVariable)
        //        {
        //            myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
        //        }
        //        using (MySqlDataReader reader = myCommand.ExecuteReader())
        //        {
        //            return myCommand;
        //        }
        //    }
        //}
    
}
