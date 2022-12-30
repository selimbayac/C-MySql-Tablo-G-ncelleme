using DAO.BaseDao;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.SqlCommand
{
    public  class SutudentSql:BaseDaoa
    {
        #region parametre 
        public string selectid { get; set; }
        public string Ogrencinumara { get; set; }

        private int _ogrenciId;
        public int OgrenciID
        {
            get => _ogrenciId;
            set
            {
                _ogrenciId = value;
                QueryVariable.Add("@ogrenciID", OgrenciID);
            }
        }
        private string _ogrenciad;
        public  string Ogrenciad
        {
            get => _ogrenciad; 
            set
            {
                _ogrenciad = value;
                QueryVariable.Add("@ogrenciad", Ogrenciad);
            }
        }
        private string _ogrenciSoyad;
        public string OgrenciSoyad
        {
            get => _ogrenciSoyad; 
            set { _ogrenciSoyad = value;
                QueryVariable.Add("@ogrencisoyad", OgrenciSoyad);
            }
        }
        private string _nickname;
        public string Nickname
        {
            get => _nickname;
            set
            {
                _nickname = value;
                QueryVariable.Add("@nickname", Nickname);
            }
        }
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                QueryVariable.Add("@Age",Age);
            }
        }
        private string _birday;
        public string Birday
        {
            get =>  _birday; 
            set
            {
                _birday = value;
                QueryVariable.Add("@birday", Birday);
            }
        }
        private string _ulke;
        public  string Ulke
        {
            get => _ulke;
            set { _ulke = value;
                QueryVariable.Add("@ulke", Ulke);
            }
        }
        private string _city;
        public string City
        {
            get => _city;
            set
            {
                _city = value;
                QueryVariable.Add("@city", City);
            }
        }
        private string _favorirenk;
        public string Favorirenk
        {
            get { return _favorirenk; }
            set { _favorirenk= value;
                QueryVariable.Add("@favorirenk", Favorirenk);
            }
        }

        private string _ogrenciBolumu;
        public string ogrenciBolumu
        {
            get { return _ogrenciBolumu; }
            set
            {
                _ogrenciBolumu = value;
                QueryVariable.Add("@ogrenciBolumu", ogrenciBolumu);
            }
        }

        private int _ogrenciSinifi;
        public int ogrenciSinifi
        {
            get { return _ogrenciSinifi; }
            set
            {
                _ogrenciSinifi = value;
                QueryVariable.Add("@ogrenciSinifi", ogrenciSinifi);
            }
        }
        #endregion

        public override DataTable Select()
        {
            return Select("Select * from ogrenci ;");
        }

        public override void Insert()
        {
            Insert("Insert into ogrenci (ogrenciad,ogrencisoyad,nickname,Age,birday,ogrenciBolumu,ogrenciSinifi,ulke,city,favoriren) values(@ogrenciad,@ogrencisoyad,@nickname,@Age,@birday,@ogrenciBolumu ,@ogrenciSinifi, @ulke,@city,@favorirenk);");
        }

        public override void Update()
        {
            Update("update ogrenci set ogrenciad = @ogrenciad , ogrencisoyad = @ogrencisoyad , nickname = @nickname , Age = @Age, birday = @birday , ogrenciBolumu = @ogrenciBolumu , ogrenciSinifi = @ogrenciSinifi , ulke = @ulke , city = @city , favoriren = @favorirenk  Where ogrenciID = @ogrenciID ;");
        }

        public override void Delete()
        {
            Delete("delete from ogrenci where ogrenciID = @ogrenciID  ;");
        }

        public override void ComaboxSelect()
        {
            throw new NotImplementedException();
        }

        public override void Texdolurma()
        {
            Texdolurma("SELECT *  FROM ogrenci  WHERE ogrenciID=@ogrenciID;");
        }
        public  MySqlCommand Texdolurma2()
        {
         return   Texdolurma("SELECT *  FROM ogrenci  WHERE ogrenciID=@ogrenciID;");
        }
        public MySqlCommand text2()
        {
        return   Texdolurma("Select * from ogrenci");   
        }
        public DataTable Trigger()
        {
            return Select("select * from ogrenci_log;");
        }
        public MySqlCommand Gettext()
        {
            return Texdolurma("select * from ogrenci ;");
        }
        //public DataTable Gostermek()
        //{
        //    return Select("Select * from ogrenci ;");
        //}

        //public string InsertC()
        //{       
        //    return Insert("Insert into ogrenci (ogrenciad,ogrencisoyad,nickname,Age,birday,ulke,city,favoriren) values(@ogrenciad,@ogrencisoyad,@nickname,@Age,@birday,@ulke,@city,@favorirenk);");
        //}
        ////public string Update()
        ////{    
        ////    return Update("update ogrenci set ogrenciad = @ogrenciad , ogrencisoyad = @ogrencisoyad , nickname = @nickname , Age = @Age, birday = @birday , ulke = @ulke , city = @city , favorirenk = @favorirenk  Where ogrenciID = @ogrenciID");
        ////}
        ////public string Delete()
        ////{
        ////    return Delete("delete from ogrenci where ogrenciID = @ogrenciID  ;");
        ////}
        //public MySqlCommand text()
        //{
        //    return Texdolurma("SELECT *  FROM ogrenci  WHERE ogrenciID=@ogrenciID;");
        //}
        //public MySqlCommand Text2()
        //{
        //    return Texdolurma("Select * from ogrenci");
        //}
    }
}
// daha fazla ekleme yapılabiilir 
// parametleri düzeltmek lazım 
// parametreler düzeldi const rada sorun var 
// oda düzelirse olur 
