using DAO.SqlCommand;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KullanıcıArayüzü.Forms
{
    public partial class Notlar : Form
    {
        List<MaskedTextBox> _maskedTextBoxList;
        public Notlar()
        {
            InitializeComponent();
            _maskedTextBoxList = new List<MaskedTextBox>()
            {
                mtbx_İlkYazili,
                mtbx_İkinciYazili,
                mtbx_UcuncuYazili,
                mtbx_Uygulama1,
                mtbx_Uygulama2,
                mtbx_Sozlu1,
                mtbx_Sozlu2
            };
            AssingActions();
        }
        private void AssingActions()
        {
            _maskedTextBoxList.ForEach(x => {
                x.TextChanged += X_TextChanged;

            });
        }
        private void X_TextChanged(object? sender, EventArgs e)
        {
            MaskedTextBox tempSender = ((MaskedTextBox)sender);
            string value = tempSender.Text;

            if (Int32.TryParse(value, out int num))
            {
                if (num < 0)
                {
                    tempSender.Text = 0.ToString();
                }
                else if (num > 100)
                {
                    tempSender.Text = 100.ToString();
                }
            }
            
            CalculateAllBox();
        }
        private void CalculateAllBox()
        {
            int total=0;
            int counter = 0;
            _maskedTextBoxList.ForEach(x => {
                if (int.TryParse(x.Text, out int num))
                {
                    total += num;
                    counter++;
                }
            });

            if (total > 0) mtbx_Ortalama.Text = (total / counter).ToString();
            else mtbx_Ortalama.Text = total.ToString();
        }

        private void Notlar_Load(object sender, EventArgs e)
        {
            DersSql dersSql = new DersSql();
            ogrenciNot ogrenciNot = new ogrenciNot();
            tablosu.DataSource = ogrenciNot.Select();
            SutudentSql SutudentSql = new SutudentSql();
                        
            MySqlDataReader dr;
            SutudentSql.OgrenciID = 2;
            dr = SutudentSql.Gettext().ExecuteReader();
          //  dr = SutudentSql.text2().ExecuteReader();
            while (dr.Read())
            {
                OgrenciID.Items.Add(dr["ogrenciID"].ToString());
                
            }
            dr.Close();
            dr = dersSql.Gettext().ExecuteReader();
            while (dr.Read())
            {
                derskod.Items.Add(dr["dersKodu"]);
            }
            dr.Close();
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Dersler_Click(object sender, EventArgs e)
        {
            Dersler acilsusam = new Dersler();
            acilsusam.MdiParent = this.MdiParent;
            acilsusam.Show();
        }

        private void OgrenciGoster_Click(object sender, EventArgs e)
        {
            StudentListPage studentListPage = new StudentListPage();
            studentListPage.MdiParent = this.MdiParent;
            studentListPage.Show();
        }

        private void tablosu_Click(object sender, EventArgs e)
        {
            int numara = Convert.ToInt32(tablosu.CurrentRow.Cells[0].Value);
            ogrenciNot ogrenciNot = new ogrenciNot();
            ogrenciNot.idOgrenciNot = numara;
            MySqlDataReader dr;
            dr = ogrenciNot.Texdolurma2().ExecuteReader();
            while (dr.Read())
            {
                Notid.Text = dr["idOgrenciNot"].ToString();
                OgrenciID.Text = dr["ogrenciID"].ToString();
                derskod.Text = dr["dersKoduFk"].ToString();
                mtbx_İlkYazili.Text = dr["yazili1"].ToString();
                mtbx_İkinciYazili.Text = dr["yazili2"].ToString();
                mtbx_UcuncuYazili.Text = dr["yazili3"].ToString();
                mtbx_Uygulama1.Text = dr["uygulama1"].ToString();
                mtbx_Uygulama2.Text = dr["uygulama2"].ToString();
                mtbx_Sozlu1.Text = dr["sozlu1"].ToString();
                mtbx_Sozlu2.Text = dr["sozlu2"].ToString();
            }
            int yazili1 = Int32.Parse(mtbx_İlkYazili.Text);
            int yazili2 = Int32.Parse(mtbx_İkinciYazili.Text);
            int yazili3 = Int32.Parse(mtbx_UcuncuYazili.Text);
            int uygulama1 = Int32.Parse(mtbx_Uygulama1.Text);
            int uygulama2 = Int32.Parse(mtbx_Uygulama2.Text);
            int sozlu1 = Int32.Parse(mtbx_Sozlu1.Text);
            int sozlu2 = Int32.Parse(mtbx_Sozlu2.Text);        
            //int ortalama = Int32.Parse(Ortalama.Text);       
            dr.Close();
           
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            int yazili1 = Int32.Parse(mtbx_İlkYazili.Text);
            int yazili2 = Int32.Parse(mtbx_İkinciYazili.Text);
            int yazili3 = Int32.Parse(mtbx_UcuncuYazili.Text);
            int uygulama1 = Int32.Parse(mtbx_Uygulama1.Text);
            int uygulama2 = Int32.Parse(mtbx_Uygulama2.Text);
            int sozlu1 = Int32.Parse(mtbx_Sozlu1.Text);
            int sozlu2 = Int32.Parse(mtbx_Sozlu2.Text);
            int ogrenciid = Int32.Parse(OgrenciID.Text);
            int notid = Int32.Parse(Notid.Text);
            int ort = Int32.Parse(mtbx_Ortalama.Text);
            ogrenciNot ogrenciNot = new ogrenciNot();
            ogrenciNot.ogrenciID = ogrenciid;
            ogrenciNot.Derskod = derskod.Text;
            ogrenciNot.Yazili1 = yazili1;
            ogrenciNot.Yazili2 = yazili2;
            ogrenciNot.Yazili3 = yazili3;
            ogrenciNot.Uygulama1 = uygulama1;
            ogrenciNot.Uygulama2 = uygulama2;
            ogrenciNot.Sozlu1 = sozlu1;
            ogrenciNot.Sozlu2 = sozlu2;
            ogrenciNot.idOgrenciNot = notid;
            ogrenciNot.Ortalama = ort;
            //*grenciNot.idOgrenciNot = A;*/

            DialogResult secenek = MessageBox.Show("Güncelleme  işlemi yapılsın mı?", "^_^ Ekliyim mi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                ogrenciNot.Update();
                MessageBox.Show("Güncelleme yapıldı ");
                tablosu.DataSource = ogrenciNot.Select();
            }

            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("Güncelleme yapılmadı ");
            }
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            int yazili1 = Int32.Parse(mtbx_İlkYazili.Text);
            int yazili2 = Int32.Parse(mtbx_İkinciYazili.Text);
            int yazili3 = Int32.Parse(mtbx_UcuncuYazili.Text);
            int uygulama1 = Int32.Parse(mtbx_Uygulama1.Text);
            int uygulama2 = Int32.Parse(mtbx_Uygulama2.Text);
            int sozlu1 = Int32.Parse(mtbx_Sozlu1.Text);
            int sozlu2 = Int32.Parse(mtbx_Sozlu2.Text);
            int ogrenciid = Int32.Parse(OgrenciID.Text);          
            int ort = Int32.Parse(mtbx_Ortalama.Text);
            ogrenciNot ogrenciNot = new ogrenciNot();
            ogrenciNot.ogrenciID = ogrenciid;
            ogrenciNot.Derskod = derskod.Text;
            ogrenciNot.Yazili1 = yazili1;
            ogrenciNot.Yazili2 = yazili2;
            ogrenciNot.Yazili3 = yazili3;
            ogrenciNot.Uygulama1 = uygulama1;
            ogrenciNot.Uygulama2 = uygulama2;
            ogrenciNot.Sozlu1 = sozlu1;
            ogrenciNot.Sozlu2 = sozlu2;
            ogrenciNot.Ortalama = ort;
            DialogResult secenek = MessageBox.Show("Ekleme  işlemi yapılsın mı?", "^_^ Ekliyim mi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                ogrenciNot.Insert();
                MessageBox.Show( mtbx_Ortalama +" Numaralı id başarı ile eklendi  ");
                tablosu.DataSource = ogrenciNot.Select();
            }

            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("Eklemeedik  yapılmadı ");
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("silinme  işlemi yapılsın mı?", "^_^ Ekliyim mi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                ogrenciNot ogrenciNot = new ogrenciNot();
                int id = Int32.Parse(Notid.Text);
                ogrenciNot.idOgrenciNot = id; ;
                ogrenciNot.Delete();
                MessageBox.Show(id+"istenilen id silindi");
                tablosu.DataSource = ogrenciNot.Select();              
            }                
        }
        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {       
            ogrenciNot ogrenciNot = new ogrenciNot();
            DataView dv = ogrenciNot.Select().DefaultView;
            dv.RowFilter = "ogrenciID LIKE '" + maskedTextBox1.Text + "%'";
            tablosu.DataSource = dv;
        }
    }
    }

