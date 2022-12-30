using DAO.DAL.Abstract;

using DAO.SqlCommand;
using Google.Protobuf.WellKnownTypes;
using KullanıcıArayüzü.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıArayüzü
{
    public partial class ColorTablePage : Form
    {
  
        ColorSql renkSql = new ColorSql();      
        public ColorTablePage()
        {
            InitializeComponent();
        }
       
        private void ColorTablePage_Load(object sender, EventArgs e)
        {
            grdRenkler.DataSource = renkSql.Select();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Güncellemek istediğine emin misin ?", "Emin misin", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                ColorSql renkSql = new ColorSql();
                renkSql.Renkid = renkidtex.Text;
                renkSql.Renkkodu = renkkodu.Text;
                renkSql.Renk = renk.Text;
                renkSql.Update();
                grdRenkler.DataSource = renkSql.Select();              
            }

            else if (result1 == DialogResult.No)
            {
                MessageBox.Show("güncelleme işlemi iptal edildi");
            }        
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            ColorSql renkSql = new ColorSql();
            renkSql.Renk = renk.Text;
            renkSql.Renkkodu =renkkodu.Text;
            DialogResult bakalim = MessageBox.Show("Eklemek istediğine emin misin ", "(^_^)", MessageBoxButtons.YesNo);
            if (bakalim == DialogResult.Yes)
            {
                renkSql.Insert();
                grdRenkler.DataSource = renkSql.Select();
                var lastRow = grdRenkler.Rows[grdRenkler.Rows.Count - 2]; 
                MessageBox.Show($"Eklendi: ID {lastRow.Cells[0].Value}");
            }   
        }
        // code
        private void button3_Click(object sender, EventArgs e)
        {
            ColorSql renkSql = new ColorSql();
         
            DialogResult result0 = MessageBox.Show("Silmek istediğine emin misin ", ":)", MessageBoxButtons.YesNoCancel);
            if (result0 == DialogResult.Yes)
            {
                renkSql.Renkid = renkidtex.Text;
                renkSql.Delete();
                grdRenkler.DataSource = renkSql.Select();
                MessageBox.Show(renkSql.Renkid + "numaralı id silindi");
            }
           //  int id = int.Parse(renkidtex.Text);
          else   if (result0 == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi");
            }      
        }

        private void grdRenkler_Click(object sender, EventArgs e)
        {
            ColorSql renkSql = new ColorSql();
            int numara = Convert.ToInt32(grdRenkler.CurrentRow.Cells[0].Value);
            renkSql.Renkid = numara.ToString();
            MySqlDataReader dr;
            dr = renkSql.Texdolurma2().ExecuteReader();
            while (dr.Read())
            {
                renkidtex.Text = dr["renkid"].ToString();
                renk.Text = dr["renk"].ToString();
                renkkodu.Text = dr["renkkodu"].ToString();
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grdRenkler.DataSource = renkSql.Triger();
        }

        private void ara_TextChanged(object sender, EventArgs e)
        {
            DataView dv = renkSql.Select().DefaultView;     
            dv.RowFilter = "renk  LIKE '" + ara.Text +  "%'";            
            grdRenkler.DataSource = dv ;
            //grdRenkler.DataSource = dv;
        }
    }
}
