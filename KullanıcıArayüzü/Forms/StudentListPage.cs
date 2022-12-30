
using DAO.DAL.Concrete.MySql;
using DAO.SqlCommand;
using KullanıcıArayüzü.Forms;
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
    public partial class StudentListPage : Form
    {
        public  static bool  truefalse { get; set; }
        
        public StudentListPage()
        {
            InitializeComponent();
        }
        SutudentSql sutudentSql = new SutudentSql();
        private void StudentListPage_Load(object sender, EventArgs e)
        {
          

            Ogrencidt.DataSource = sutudentSql.Select();
        }
  
        private void Ekle_Click(object sender, EventArgs e)
        {
            StudentSettingsPage acilsusam = new StudentSettingsPage();
            acilsusam.MdiParent = this.MdiParent;
            acilsusam.Show();

            var lastRow = Ogrencidt.Rows[Ogrencidt.Rows.Count - 2];
            acilsusam.Tutucu = lastRow.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentSettingsPage acilsusam = new StudentSettingsPage();
            int numara = Convert.ToInt32(Ogrencidt.CurrentRow.Cells[0].Value);
            acilsusam.selectedId = numara;
            acilsusam.MdiParent = this.MdiParent;
            acilsusam.Show();
        }
        private void Ekranyenileme()
        {
            if(truefalse == true)
            { Ogrencidt.DataSource = sutudentSql.Select(); }
        }

        private void Ogrencidt_MouseHover(object sender, EventArgs e)
        {
            Ekranyenileme();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SutudentSql sutudentSql = new SutudentSql();
            
            DialogResult secenek = MessageBox.Show("Silme işlemi yapılsın mı ?!", "Dikkat verikaybı olabilir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                int numara = Convert.ToInt32(Ogrencidt.CurrentRow.Cells[0].Value);
                sutudentSql.OgrenciID = numara;
                sutudentSql.Delete();
               Ogrencidt.DataSource = sutudentSql.Select();
            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("Silmedik la korkma Hehe :D ", "Silmedik");
            }
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bakımda ");
            Ogrencidt.DataSource = sutudentSql.Trigger();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            DataView dv = sutudentSql.Select().DefaultView;
            dv.RowFilter = "ogrenciad LIKE '" + ara.Text + "%'";
            Ogrencidt.DataSource = dv;
        }
    }
}
