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
    public class ogrenciNot : BaseDaoa
    {
        private int _idOgrenciNot;
        public int idOgrenciNot
        {
            get { return _idOgrenciNot; }
            set
            {
                _idOgrenciNot = value;
                QueryVariable.Add("@idOgrenciNot", idOgrenciNot);
            }
        }

        private string _derskod;
        public string Derskod
        {
            get { return _derskod; }
            set
            {
                _derskod = value;
                QueryVariable.Add("@derskod", Derskod);
            }
        }
        private int _yazili1;
        public int Yazili1
        {
            get { return _yazili1; }
            set
            {
                _yazili1 = value;
                QueryVariable.Add("@yazili1", Yazili1);
            }
        }

        private int _yazili2;
        public int Yazili2
        {
            get { return _yazili2; }
            set
            {
                _yazili2 = value;
                QueryVariable.Add("@yazili2", Yazili2);
            }
        }
        private int _yazili3;
        public int Yazili3
        {
            get { return _yazili3; }
            set
            {
                _yazili3 = value;
                QueryVariable.Add("@yazili3", Yazili3);
            }
        }
        private int _uygualama1;
        public int Uygulama1
        {
            get { return _uygualama1; }
            set
            {
                _uygualama1 = value;
                QueryVariable.Add("@uygulama1", Uygulama1);
            }
        }
        private int _uygualama2;
        public int Uygulama2
        {
            get { return _uygualama2; }
            set
            {
                _uygualama2 = value;
                QueryVariable.Add("@uygulama2", Uygulama2);
            }
        }
        private int _sozlu1;
        public int Sozlu1
        {
            get { return _sozlu1; }
            set
            {
                _sozlu1 = value;
                QueryVariable.Add("@sozlu1", Sozlu1);
            }
        }
        private int _sozlu2;
        public int Sozlu2
        {
            get { return _sozlu2; }
            set
            {
                _sozlu2 = value;
                QueryVariable.Add("@sozlu2", Sozlu2);
            }
        }

        private int _ortalama;
        public int Ortalama
        {
            get { return _ortalama; }
            set
            {
                _ortalama = value;
                QueryVariable.Add("@ortalama", Ortalama);
            }
        }
        private int _ogrenciID;
        public int ogrenciID
        {
            get { return _ogrenciID; }
            set
            {
                _ogrenciID = value;
                QueryVariable.Add("@ogrenciID", ogrenciID);
            }
        }
        public override void ComaboxSelect()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            Delete("delete  from ogrencinot  where idOgrenciNot = @idOgrenciNot");
        }

        public override void Insert()
        {
            Insert("insert into ogrencinot (ogrenciID ,dersKoduFk,yazili1,yazili2,yazili3,uygulama1,uygulama2,sozlu1,sozlu2,ortalama) values(@ogrenciID,@derskod,@yazili1,@yazili2,@yazili3,@uygulama1,@uygulama2,@sozlu1,@sozlu2,@ortalama);");
        }

        public override DataTable Select()
        {
            return Select("select * from ogrencinot");
        }

        public override void Texdolurma()
        {
            Texdolurma();
        }

        public override void Update()
        {
             Update("update  ogrencinot set ogrenciID = @ogrenciID , dersKoduFk = @derskod , yazili1 = @yazili1, yazili2 = @yazili2 ,yazili3 = @yazili3 ,uygulama1= @uygulama1 ,uygulama2= @uygulama2,sozlu1=@sozlu1,sozlu2=@sozlu2,ortalama = @ortalama where idOgrenciNot =@idOgrenciNot;");
        }
        public MySqlCommand Texdolurma2()
        {
            return Texdolurma("SELECT *  FROM ogrencinot  WHERE idOgrenciNot=@idOgrenciNot;");
        }
      
    }
}
