using KullanıcıArayüzü;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
        private void ülkeTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CountryTable ulkeSehircs = new CountryTable();
            ulkeSehircs.MdiParent = this;
            ulkeSehircs.Show();
        }

        private void öğrenciTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorTablePage renktablosu = new  ColorTablePage();
            renktablosu.MdiParent = this;
            renktablosu.Show();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListPage studentListPage    = new StudentListPage();
            studentListPage.MdiParent = this;
            studentListPage.Show();
        }

        private void şehitTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityPage city = new CityPage();
            city.MdiParent = this;
            city.Show();
        }

        private void dersTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dersler dersler = new Dersler();
            dersler.MdiParent = this;
            dersler.Show();
        }

        private void notlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notlar notlar = new Notlar();
            notlar.MdiParent = this;
            notlar.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Çıkış yapmak istediğine emin misin ?", "Emin misin", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
