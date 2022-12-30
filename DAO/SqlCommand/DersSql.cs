using DAO.BaseDao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.SqlCommand
{
    public class DersSql : BaseDaoa
    {
        private string _dersKodu;
        public string DersKodu
        {
            get => _dersKodu;
            set
            {
                _dersKodu = value;
                QueryVariable.Add("@dersKodu", value);
            }
        }
        private string _dersadi;
        public string dersadi
        {
            get => _dersadi;
            set
            {
                _dersadi = value;
                QueryVariable.Add("@dersAdi", value);
            }
        }
        public override void ComaboxSelect()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            Delete("delete  from dersler  where dersKodu = @dersKodu");
        }

        public override void Insert()
        {
            Insert("INSERT INTO dersler (dersKodu,dersAdi) VALUES(@dersKodu,@dersAdi);");

        }

        public override DataTable Select()
        {
           return Select("select * from dersler;");
        }

        public override void Texdolurma()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            Update(" Update(UPDATE dersler SET dersKodu = @derskodu, dersAdi = @dersadi WHERE dersKodu =@derskodu;");
        }
        public MySqlCommand Gettext()
        {
            return Texdolurma("select * from dersler ;");
        }
    }
}
