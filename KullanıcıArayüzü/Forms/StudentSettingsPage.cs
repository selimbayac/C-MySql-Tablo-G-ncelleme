
using DAO.SqlCommand;
using MySql.Data.MySqlClient;

namespace KullanıcıArayüzü
{
    public partial class StudentSettingsPage : Form
    {
        SutudentSql SutudentSql = new SutudentSql();
        public StudentSettingsPage()
        {
            InitializeComponent();
        }
        private string _tutucu { get; set; }
        public string Tutucu
        {
            get { return _tutucu; }
            set
            {
                _tutucu = value;
            }
        }
        private int _selectedId { get; set; }
        private bool _truefalse { get; set; }
        public int selectedId
        {
            get
            {
                return _selectedId;
            }

            set
            {
                tbx_OgrenciId.Text = value.ToString();
                _selectedId = value;
            }
        }

        private void StudentSettingsPage_Load(object sender, EventArgs e)
        {
            Sınıf.Items.Add("9");
            Sınıf.Items.Add("10");
            Sınıf.Items.Add("11");
            Sınıf.Items.Add("12");
            SutudentSql SutudentSql = new SutudentSql();
            Country country = new Country();
            City city = new City();
            ColorSql colorSql = new ColorSql();
            DersSql dersSql = new DersSql();
            // ekkle
            MySqlDataReader dr;
            SutudentSql.OgrenciID = selectedId;
            dr = SutudentSql.Texdolurma2().ExecuteReader();
            while (dr.Read())
            {
                Oad.Text = dr["ogrenciad"].ToString();
                Osoyad.Text = dr["ogrencisoyad"].ToString();
                nick.Text = dr["nickname"].ToString();
                yas.Text = dr["Age"].ToString();
                dogum.Text = dr["birday"].ToString();
                Ulke.Text = dr["ulke"].ToString();
                Sehir.Text = dr["city"].ToString();
                renkler.Text = dr["favoriren"].ToString();
                Ders.Text = dr["ogrenciBolumu"].ToString();
                Sınıf.Text = dr["ogrenciSinifi"].ToString();
            }
            dr.Close();
            dr = country.GetText().ExecuteReader();
            while (dr.Read())
            {
                Ulke.Items.Add(dr["Ulkead"]);
            }
            dr.Close();
            dr = city.text().ExecuteReader();
            while (dr.Read())
            {
                Sehir.Items.Add(dr["cityad"]);
            }
            dr.Close();
            dr = colorSql.Gettext().ExecuteReader();
            while (dr.Read())
            { renkler.Items.Add(dr["renk"]); }
            dr.Close();
            dr = dersSql.Gettext().ExecuteReader();
            while (dr.Read())
            {
                Ders.Items.Add(dr["dersAdi"]);
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e) // ekleme ekliyor
        {
            SutudentSql SutudentSql = new SutudentSql();
            DialogResult secenek = MessageBox.Show("Ekleme işlemi yapılsın mı?", "Veri ekleme ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                if (Oad.Text == "" || Osoyad.Text == "" || Osoyad.Text == "" || yas.Text == "" || dogum.Text == "" || Ulke.Text == "" || Sehir.Text == "")
                {
                    MessageBox.Show("kırmızı alanları boş bırakmayınız  ");
                    ad.ForeColor = Color.Red;
                    soyad.ForeColor = Color.Red;
                    hayattakalmasuresi.ForeColor = Color.Red;
                    gun.ForeColor = Color.Red;
                    label7.ForeColor = Color.Red;
                    label6.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    int sonuc = Int32.Parse(yas.Text);
                    int sınıf = Int32.Parse(Sınıf.Text);
                    SutudentSql.Ogrenciad = Oad.Text;
                    SutudentSql.OgrenciSoyad = Osoyad.Text;
                    SutudentSql.Nickname = nick.Text;
                    SutudentSql.Age = sonuc;
                    SutudentSql.Birday = dogum.Text;
                    SutudentSql.Ulke = Ulke.Text;
                    SutudentSql.City = Sehir.Text;
                    SutudentSql.Favorirenk = renkler.Text;
                    SutudentSql.ogrenciBolumu = Ders.Text;
                    SutudentSql.ogrenciSinifi = sınıf;
                    StudentListPage.truefalse = true;
                    SutudentSql.Insert();
                    MessageBox.Show(Tutucu + " Numaralı id ekledik");
                    Close();
                }
            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("Eklemedik ", "Panik yok");
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            SutudentSql SutudentSql = new SutudentSql();
            DialogResult secenek = MessageBox.Show("İşlem yapılsın mı?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                if (Oad.Text == "" || Osoyad.Text == "" || Osoyad.Text == "" || yas.Text == "" || dogum.Text == "" || Ulke.Text == "" || Sehir.Text == "")
                {
                    MessageBox.Show("kırmızı alanları boş bırakmayınız  ");
                    ad.ForeColor = Color.Red;
                    soyad.ForeColor = Color.Red;
                    hayattakalmasuresi.ForeColor = Color.Red;
                    gun.ForeColor = Color.Red;
                    label7.ForeColor = Color.Red;
                    label6.ForeColor = Color.Red;
                    return;
                }
                else
                {
                    int sonuc = Int32.Parse(yas.Text);
                    int sınıf = Int32.Parse(Sınıf.Text);
                    SutudentSql.Ogrencinumara = selectedId.ToString();
                    SutudentSql.OgrenciID = selectedId;
                    SutudentSql.Ogrenciad = Oad.Text;
                    SutudentSql.OgrenciSoyad = Osoyad.Text;
                    SutudentSql.Age = sonuc;
                    SutudentSql.Birday = dogum.Text;
                    SutudentSql.Nickname = nick.Text;
                    SutudentSql.ogrenciBolumu = Ders.Text;
                    SutudentSql.ogrenciSinifi = sınıf;
                    SutudentSql.Ulke = Ulke.Text;
                    SutudentSql.City = Sehir.Text;
                    SutudentSql.Favorirenk = renkler.Text;
                    SutudentSql.Update();
                    StudentListPage.truefalse = true;
                    MessageBox.Show(selectedId + "id güncellendi");
                    Close();
                }
            }
            else if (secenek == DialogResult.No)
            {
                MessageBox.Show("Güncelleme iptali ", "¯\\_(ツ)_/¯");
            }
        }
        private void yas_KeyDown(object sender, KeyEventArgs e)
        {
            if (yas.Text == "")
            { }
            else if (!Int32.TryParse(yas.Text, out int sayi))
            {
                MessageBox.Show($"Geçersiz bir sayı girdiniz: {yas}");
            }
        }
    }
}
