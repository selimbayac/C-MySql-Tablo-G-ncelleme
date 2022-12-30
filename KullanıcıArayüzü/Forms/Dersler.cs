using DAO.SqlCommand;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıArayüzü.Forms
{
    public partial class Dersler : Form
    {
        public Dersler()
        {
            InitializeComponent();
        }

        private void Dersler_Load(object sender, EventArgs e)
        {
            DersSql dersler = new DersSql();
            Derstablo.DataSource = dersler.Select();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            DersSql dersler = new DersSql();
            dersler.DersKodu =Derskodu.Text;
            dersler.dersadi =Dersad.Text;
            dersler.Insert();
            MessageBox.Show(Dersad.Text + "Dersi eklendi ");
            Derstablo.DataSource = dersler.Select();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            DersSql dersler = new DersSql();
            
            dersler.Delete();
            MessageBox.Show(Derskodu.Text+ " Silindi");
            
            Derstablo.DataSource = dersler.Select();
        }

        private void guncel_Click(object sender, EventArgs e)
        {
            DersSql dersler = new DersSql();

        }

        private void Derstablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DersSql dersler = new DersSql();
            string ad = Convert.ToString(Derstablo.CurrentRow.Cells[0].Value);
            string yanad = Convert.ToString(Derstablo.CurrentRow.Cells[1].Value);
            Derskodu.Text = ad;
            Dersad.Text = yanad;
            dersler.DersKodu = Derskodu.Text;
            dersler.dersadi = Dersad.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DersSql dersler = new DersSql();
            DataView dv = dersler.Select().DefaultView;
            dv.RowFilter = "dersadi LIKE '" + textBox3.Text + "%'";
            Derstablo.DataSource = dv;
        }
    }
}
