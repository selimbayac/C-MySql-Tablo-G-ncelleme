using DAO.DAL.Abstract;

using DAO.Tools.Connection.MySql;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.CityParams;

//using CountryTable;  buda boş kod dolu olanlar şunlar boş olanları sikel :Dsdyeşil olanların hepsi boş yer kaplamasın belki ondan hata veriodur 

namespace DAO.DAL.Concrete.MySql
{
    //public class CityDal : MysqlParamCity

    //{
    //    public Hashtable QueryVariable = new Hashtable();
    //    List<City> list = new List<City>();

    //    public List<City> Listele()
    //    {          
    //        try
    //        {
    //            using (MySqlCommand myCommand = new MySqlCommand("Select * from ulke", MysqlBaglanti.Connection))
    //            {
    //                MysqlBaglanti.BaglantiAc();
    //                using (MySqlDataReader reader = myCommand.ExecuteReader())
    //                {
    //                    while (reader.Read())
    //                    {
    //                        list.Add(new City()
    //                        {
    //                            id = Convert.ToInt32(reader["UlkeID"]),
    //                            Adi = reader["Ulkead"].ToString(),
    //                            Nufusu = Convert.ToInt32(reader["Ulkenufus"])
    //                        });
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Debug.WriteLine("CityDal Sınıfı - Listele Methodu:" + ex);
    //        }
    //        finally
    //        {
    //            MysqlBaglanti.BaglantiKapat();
    //        }
    //        return list;
    //      }
      
    //    public DataTable GetCity()
    //    {

           
    //        DataTable myData = new DataTable();
    //        MySqlDataAdapter myAdapter = new MySqlDataAdapter();
       
    //        MySqlCommand myCommand = new MySqlCommand("Select * from ulke", MysqlBaglanti.Connection);
    //        myAdapter.SelectCommand = myCommand;
    //        myAdapter.Fill(myData);
    //        return myData;

    //    }

    //    public bool Guncelle()
    //    {
    //        int a = 0;

    //        using (MySqlCommand myCommand = new MySqlCommand("UPDATE ulke SET Ulkead = @Ulkead, Ulkenufus = @Ulkenufus WHERE ulkeID =@UlkeID;", MysqlBaglanti.Connection))
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
    //    { int a = 0;
          
    //        using (MySqlCommand myCommand = new MySqlCommand("Insert into ulke (Ulkead, ulkenufus) values(@Ulkead, @Ulkenufus);", MysqlBaglanti.Connection))
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
    //        using (MySqlCommand myCommand = new MySqlCommand("delete from ulke where ulkeID =  @UlkeID ;", MysqlBaglanti.Connection))
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
    //        using (MySqlCommand myCommand = new MySqlCommand("Select * from ulke", MysqlBaglanti.Connection))
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
    //    public MySqlCommand Gettextt()
    //    {
    //        using (MySqlCommand myCommand = new MySqlCommand("SELECT *  FROM ulke  WHERE UlkeID=@UlkeID", MysqlBaglanti.Connection))
    //        {
    //            MysqlBaglanti.BaglantiAc();
    //            QueryVariable = GetParameters();
    //            foreach (DictionaryEntry item in QueryVariable)
    //            {
    //                myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
    //            }
    //            using (MySqlDataReader reader = myCommand.ExecuteReader())
    //            {
    //                return myCommand;
    //            }
    //        }
    //    }
    //}
}
