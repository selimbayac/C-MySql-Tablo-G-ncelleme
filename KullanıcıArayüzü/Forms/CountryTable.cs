

using DAO.SqlCommand;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.IsisMtt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıArayüzü
{
    public partial class CountryTable : Form
    {    
     
       // burası ülke tablosu 
       
        public CountryTable()
        {
            InitializeComponent();
        }
        Country country = new Country();
        private void CountryTable_Load(object sender, EventArgs e)
        {
            Ulkegrd.DataSource = country.Select();
        }
        private void Ekle_Click(object sender, EventArgs e)
        {
            Country country = new Country();
          
            DialogResult secenek = MessageBox.Show("Ekleme işlemi yapılsın mı?", "^_^ Ekliyim mi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                int nufus = int.Parse(Nufus.Text);
                country.Ulkead = Ulketext.Text;
                country.Ulkenufus = nufus.ToString();
              
                    country.Insert();
             
                    Ulkegrd.DataSource = country.Select();
                var lastRow = Ulkegrd.Rows[Ulkegrd.Rows.Count - 2];
                MessageBox.Show($"Eklendi: ID {lastRow.Cells[0].Value}");

            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("eklemiyom ", ":| Eklebmeyecek ");
            }
            


        }

        private void Sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Silim mi", "}:)", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Country country = new Country();

           
            if (secenek == DialogResult.Yes)
            {

                country.UlkeID = ulkeid.Text;

                country.Delete();
              
                Ulkegrd.DataSource = country.Select();
                MessageBox.Show(country.UlkeID + "numaralı ID silindi");

            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("Dokunmadık  ", " :'( Silmedik ");

            }
           

        }
        private void ulkeid_TextChanged(object sender, EventArgs e)
        {
             //Gelen veri bu değişkenin değerini alır.
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            Country country = new Country();
            country.UlkeID = ulkeid.Text;
            country.Ulkenufus = Nufus.Text;
            country.Ulkead = Ulketext.Text;
            country.Update();         
            Ulkegrd.DataSource = country.Select();
            MessageBox.Show(country.UlkeID + "Numaralı ID güncellendi ");
          

        }

        private void Ulkegrd_Click(object sender, EventArgs e)
        {
            Country country = new Country();
            int numara = Convert.ToInt32(Ulkegrd.CurrentRow.Cells[0].Value);
            country.UlkeID = numara.ToString();
            MySqlDataReader dr;
            dr = country.Texdolurma2().ExecuteReader();
            while (dr.Read())
            {
                ulkeid.Text = dr["UlkeID"].ToString();
                Ulketext.Text = dr["Ulkead"].ToString();
                Nufus.Text = dr["Ulkenufus"].ToString();
            }
            dr.Close();

        }

        public void TextController()
        {
            //string gelenid = ulkeid.Text;
            //if (!Int32.TryParse(gelenid, out int sayi))
            //{
            //    MessageBox.Show($"geçersiz değer girdiniz:{gelenid}");
            //    return;
            //}
            //string gelennufus = Nufus.Text;
            //if (!Int32.TryParse(gelennufus, out int sayi2))
            //{
            //    MessageBox.Show($"geçersiz değer girdiniz:{gelennufus}");
            //    return;
            //}

        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Ulkegrd.DataSource = country.Trigger();
        }

        private void ara_TextChanged(object sender, EventArgs e)
        {
            DataView dv = country.Select().DefaultView;
            dv.RowFilter = "Ulkead LIKE '" + ara.Text + "%'";
            Ulkegrd.DataSource = dv;
        }

        private void Nufus_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(Nufus.Text, out int sayi))
            {
                MessageBox.Show($"Geçersiz bir sayı girdiniz: {Nufus}");

            }
        }

        private void Ulkegrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
