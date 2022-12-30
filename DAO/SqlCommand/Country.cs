using DAO.BaseDao;

using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.SqlCommand
{
    public  class Country : BaseDaoa
    {
        #region Ulkenin paramtereleri burda abstract yapılmaz aşırı gereksiz interfacede 
        private string _ulkead;
        public string Ulkead
        {
            get { return _ulkead; }
            set
            {
                _ulkead = value;
                QueryVariable.Add("@Ulkead", Ulkead);
            }
        }
        private string _ulkenufus;
        public string Ulkenufus
        {
            get { return _ulkenufus; }
            set
            {
                _ulkenufus = value;
                QueryVariable.Add("@Ulkenufus", Ulkenufus);
            }
        }
        private string _ulkeID;
        public string UlkeID
        {
            get { return _ulkeID; }
            set
            {
                _ulkeID = value;
                QueryVariable.Add("@UlkeID", UlkeID);
            }
        }

        #endregion

        #region lazım olabilir 
        //public string Insert()
        //{         
        //    return Insert("Insert into ulke (Ulkead, ulkenufus) values(@Ulkead, @Ulkenufus);");
        //}
        //public string Update()
        //{

        //    return Update("UPDATE ulke SET Ulkead = @Ulkead, Ulkenufus = @Ulkenufus WHERE ulkeID =@UlkeID;");
        //}
        //public string Delete()
        //{

        //    return Delete("delete from ulke where UlkeID =  @UlkeID ;");
        //}
        //public MySqlCommand text()
        //{

        //    return Texdolurma("Select * from ulke");
        //}
        //public MySqlCommand TextGet()
        //{
        //    return Texdolurma("SELECT *  FROM ulke  WHERE UlkeID=@UlkeID");
        //}
        #endregion
        public override DataTable Select()
        {
            return Select("Select * from ulke");
        }

        public  DataTable Trigger()
        {
            return Select("select * from ulke_log;");
        }

        public override void Insert()
        {
            Insert("Insert into ulke (Ulkead, ulkenufus) values(@Ulkead, @Ulkenufus);");
        }

        public override void Update()
        {
            Update("UPDATE ulke SET Ulkead = @Ulkead, Ulkenufus = @Ulkenufus WHERE ulkeID =@UlkeID;");
        }

        public override void Delete()
        {
            Delete("delete from ulke where UlkeID =  @UlkeID ;");
        }

        public override void ComaboxSelect()
        {
            Texdolurma("Select * from ulke");
        }

        public override void Texdolurma()
        {
            Texdolurma("SELECT *  FROM ulke  WHERE UlkeID=@UlkeID");
        }
        public  MySqlCommand Texdolurma2()
        {
         return Texdolurma("SELECT *  FROM ulke  WHERE UlkeID=@UlkeID");
        }
        public MySqlCommand  GetText()
        {
            return Texdolurma("Select * from ulke");
        }
    }
}
