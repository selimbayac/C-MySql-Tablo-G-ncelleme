using DAO.BaseDao;
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

namespace DAO.SqlCommand
{
    public class City : BaseDaoa
    {
        private string _cityId;
        public string  CityId
        {
            get { return _cityId; }
            set
            {
                _cityId = value;
                QueryVariable.Add("@cityID", value);

            }
        }
        private string _cityName;
        public string CityName
        {
            get => _cityName;
            set 
            {
                _cityName= value;
                QueryVariable.Add("@cityad", value);
            }
        }
        private string _nufus;
        public string Nufus
        {
            get => _nufus;
            set
            {
                _nufus = value;
                QueryVariable.Add("@citynufus", value);
            }
        }
        public override DataTable Select()
        {
            return Select("Select * from city");
        }
        public DataTable Triger()
        {
            return Select("select* from city_log");
        }

        public override void Insert()
        {
            Insert("Insert into city (cityad, citynufus) values(@cityad, @citynufus);");
        }

        public override void Update()
        {
            Update("UPDATE city SET cityad = @cityad, citynufus = @citynufus WHERE cityID =@cityID;");
        }

        public override void Delete()
        {
            Delete("delete from city where cityID =  @cityID ;");
        }

        public override void ComaboxSelect()
        {
            Texdolurma("Select * from city");
        }

        public override void Texdolurma()
        {
            Texdolurma("Select * from city");
        }
        public  MySqlCommand Texdolurma2()
        {
           return  Texdolurma("SELECT *  FROM city  WHERE cityID=@cityID");
        }

        public MySqlCommand text()
        {

            return Texdolurma("Select * from city");
        }



    }
}
