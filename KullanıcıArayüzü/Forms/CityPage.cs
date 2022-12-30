
using DAO.DAL.Concrete.MySql;
using DAO.SqlCommand;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıArayüzü.Forms
{
    public partial class CityPage : Form
    {
      
        City city = new City();
        public CityPage()
        {
            InitializeComponent();
        }

        private void CityPage_Load(object sender, EventArgs e)
        {
            Ulkegrd.DataSource = city.Select();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            City city = new City();        
            int nufus = int.Parse(Nufus.Text);
            city.CityName = Ulketext.Text;
            city.Nufus = nufus.ToString();
            city.Insert();// burda ekliyo

            Ulkegrd.DataSource = city.Select();// burda gösteriyo
            var lastRow = Ulkegrd.Rows[Ulkegrd.Rows.Count - 2]; // liste oluşuyor
            MessageBox.Show($"Eklendi: ID {lastRow.Cells[0].Value}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.CityId = ulkeid.Text;
            city.CityName = Ulketext.Text;
            city.Nufus = Nufus.Text;
            city.Update();
            Ulkegrd.DataSource = city.Select();
            MessageBox.Show(city.CityId + "  güncellendi  ");


        }

        private void Ulkegrd_Click(object sender, EventArgs e)
        {
           
            City city = new City();
            int numara = Convert.ToInt32(Ulkegrd.CurrentRow.Cells[0].Value);
            city.CityId = numara.ToString();
            MySqlDataReader dr;
            dr = city.Texdolurma2().ExecuteReader();
            while (dr.Read())
            {
                ulkeid.Text = dr["cityID"].ToString();
                Ulketext.Text = dr["cityad"].ToString();
                Nufus.Text = dr["citynufus"].ToString();
            }
            dr.Close();

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.CityId = ulkeid.Text;
            city.Delete();

            MessageBox.Show(city.CityId+" sildiniz ");
            Ulkegrd.DataSource = city.Select();
        }

        private void Nufus_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Nufus.Text, out int sayi))
            {
                MessageBox.Show($"Geçersiz bir sayı girdiniz: {Nufus}");

            }
        }
       
        private void ara_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ulkegrd.DataSource = city.Triger();
        }
        private void Ulkegrd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(Convert.ToString(Ulkegrd.CurrentCell.Value));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = city.Select().DefaultView;
            dv.RowFilter = "cityad LIKE '" + ara.Text + "%'";
            Ulkegrd.DataSource = dv;
        }
    }
}
