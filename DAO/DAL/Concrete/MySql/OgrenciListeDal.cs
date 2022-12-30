using DAO.CityParams;

using DAO.Tools.Connection.MySql;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAL.Concrete.MySql
{
    //public class OgrenciListeDal : MysqlParamsStudent
    //{

        //public Hashtable QueryVariable = new Hashtable();

        //List<Ogrenci> list = new List<Ogrenci>();

        //public List<Ogrenci> Listele()
        //{
        //    try
        //    {
        //        using (MySqlCommand myCommand = new MySqlCommand("Select * from ulke", MysqlBaglanti.Connection))
        //        {
        //            MysqlBaglanti.BaglantiAc();
        //            using (MySqlDataReader reader = myCommand.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    list.Add(new Ogrenci()
        //                    {
        //                        id = Convert.ToInt32(reader["UlkeID"]),
        //                        Adi = reader["Ulkead"].ToString(),
        //                        SoyAdi = reader["Ulkead"].ToString(),
        //                        NickName = reader["Ulkead"].ToString(),
        //                        Age = Convert.ToInt32(reader["Age"]),
        //                        BirthDay = reader["birady"].ToString(),
        //                        Ulke = reader["ulke"].ToString(),
        //                        City = reader["city"].ToString(),
        //                        FavoriRenk = reader["favorirenk"].ToString(),
                              

        //                    });
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("CityDal Sınıfı - Listele Methodu:" + ex);
        //    }
        //    finally
        //    {
        //        MysqlBaglanti.BaglantiKapat();
        //    }
        //    return list;
        //}
        //public DataTable GetStudent()
        //{
        //    DataTable myData = new DataTable();
        //    MySqlDataAdapter myAdapter = new MySqlDataAdapter();

        //    MySqlCommand myCommand = new MySqlCommand("Select * from ogrenci", MysqlBaglanti.Connection);
        //    myAdapter.SelectCommand = myCommand;
        //    myAdapter.Fill(myData);
        //    return myData;
        //}

        //public bool StudentUpdate()
        //{
        //    int a = 0;

        //    using (MySqlCommand myCommand = new MySqlCommand("update ogrenci set ogrenciad = @ogrenciad , ogrencisoyad = @ogrencisoyad , nickname = @nickname , Age = @Age, birday = @birday , ulke = @ulke , city = @city , favorirenk = @favorirenk  Where ogrenciID = @ogrenciID ", MysqlBaglanti.Connection))
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
        //public bool StudentAdd()
        //{
        //    int a = 0;
        //    using (MySqlCommand myCommand = new MySqlCommand("Insert into ogrenci (ogrenciad,ogrencisoyad,nickname,Age,birday,ulke,city,favoriren) values(@ogrenciad,@ogrencisoyad,@nickname,@Age,@birday,@ulke,@city,@favorirenk);", MysqlBaglanti.Connection))
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
        //public bool StudentDelete()
        //{// değişçek 
        //    using (MySqlCommand myCommand = new MySqlCommand("delete from ogrenci where ogrenciID = @ogrenciID  ;", MysqlBaglanti.Connection))
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
        //public MySqlCommand SetTexboxStudent()
        //{
        //    MySqlDataAdapter myAdapter = new MySqlDataAdapter();
        //    using (MySqlCommand myCommand = new MySqlCommand("SELECT *  FROM ogrenci  WHERE ogrenciID=@ogrenciID;", MysqlBaglanti.Connection))
        //    {
        //        MysqlBaglanti.BaglantiAc();
        //        QueryVariable = GetParameters();
        //        foreach (DictionaryEntry item in QueryVariable)
        //        {
        //            myCommand.Parameters.AddWithValue(item.Key.ToString(), item.Value);
        //        }
        //        myAdapter.SelectCommand = myCommand;
        //        return myCommand;
        //    }

        //}


    
}