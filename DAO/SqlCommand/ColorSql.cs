using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.BaseDao;
using DAO.CityParams;
using DAO.DAL.Abstract;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Utilities.Collections;

namespace DAO.SqlCommand
{
    public class ColorSql : BaseDaoa
    {

     

        private string _renk;

        public string Renk
        {
            get { return _renk; }
            set
            {
                _renk = value;
                QueryVariable.Add("@renk", value);
            }
        }


        private string _renkid;

        public string Renkid
        {
            get => _renkid;
            set
            {
                _renkid = value;
                QueryVariable.Add("@renkid", value);
            }
        }


        private string _renkkodu;
        public string Renkkodu
        {
            get => _renkkodu;
            set
            {
                _renkkodu = value;
                QueryVariable.Add("@renkkodu", value);
            }
        }

        public override DataTable Select()
        {
            return Select("select * from renkler ;");
        }

        public override void Insert()
        {
            Insert("Insert into renkler (renkkodu,renk) values (@renkkodu , @renk);");
        }

        public override void Update()
        {
            Update("UPDATE renkler SET renk = @renk, renkkodu = @renkkodu WHERE renkid = @renkid");
        }

        public override void Delete()
        {
            Delete("delete from renkler where renkid = @renkid ;");
        }

        public override void ComaboxSelect()
        {
            ComaboxSelect("Select * from renkler");
        }

        public override void Texdolurma()
        {
            Texdolurma("SELECT *  FROM renkler  WHERE renkid=@renkid");
        }
        public  MySqlCommand Texdolurma2()
        {
            return Texdolurma("SELECT *  FROM renkler  WHERE renkid=@renkid");
        }
        public MySqlCommand Gettext()
        {
           return Texdolurma("select * from renkler ;");

        }

        public DataTable Triger()
        {
            return Select("select  * from renkler_log ");
        }


        //public DataTable  Gostermek()
        //{

        //    return Select("select * from renkler ;");
        //}

        //public string  InsertC()
        //{


        //    return  Insert("Insert into renkler (renkkodu,renk) values (@renkkodu , @renk);");
        //}
        //public string  Updatee()
        //{
        //    bool a = true;
        //    return Update("UPDATE renkler SET renk = @renk, renkkodu = @renkkodu WHERE renkid = @renkid"); 
        //}
        ////public string Delete()
        ////{

        ////    return Delete("delete from renkler where renkid = @renkid ;");
        ////}
        //public MySqlCommand Texbox()
        //{ 
        //    return ComaboxSelect("Select * from renkler");
        //}
        //public MySqlCommand TextGet()
        //{
        //    return Texdolurma("SELECT *  FROM renkler  WHERE renkid=@renkid");
        //}
        //public override DataTable Select()
        //{
        //    return Select("select * from renkler ;");
        //}


    }
}
