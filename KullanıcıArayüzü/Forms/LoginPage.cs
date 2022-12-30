using DAO.link_checker;
using DAO.Tools.Connection.MySql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıArayüzü
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btncorrnet_Click(object sender, EventArgs e)
        {
            MysqlConnectionString.GetInstance(textServer.Text, textveritabani.Text, textuser.Text, textpasword.Text);
            Parameters.ConnectionActive = true;
            Close();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private bool ControlTueFalse()
        //{

        //}
    }
}
