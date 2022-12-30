namespace KullanıcıArayüzü
{
    partial class StudentSettingsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dogum = new System.Windows.Forms.TextBox();
            this.yas = new System.Windows.Forms.TextBox();
            this.nick = new System.Windows.Forms.TextBox();
            this.Osoyad = new System.Windows.Forms.TextBox();
            this.Oad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Ulke = new System.Windows.Forms.ComboBox();
            this.Sehir = new System.Windows.Forms.ComboBox();
            this.renkler = new System.Windows.Forms.ComboBox();
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hayattakalmasuresi = new System.Windows.Forms.Label();
            this.gun = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Guncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_OgrenciId = new System.Windows.Forms.TextBox();
            this.Ders = new System.Windows.Forms.ComboBox();
            this.Sınıf = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dogum
            // 
            this.dogum.Location = new System.Drawing.Point(139, 166);
            this.dogum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dogum.Name = "dogum";
            this.dogum.Size = new System.Drawing.Size(140, 23);
            this.dogum.TabIndex = 16;
            // 
            // yas
            // 
            this.yas.Location = new System.Drawing.Point(139, 137);
            this.yas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(140, 23);
            this.yas.TabIndex = 15;
            this.yas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yas_KeyDown);
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(139, 107);
            this.nick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(140, 23);
            this.nick.TabIndex = 14;
            // 
            // Osoyad
            // 
            this.Osoyad.Location = new System.Drawing.Point(139, 77);
            this.Osoyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Osoyad.Name = "Osoyad";
            this.Osoyad.Size = new System.Drawing.Size(140, 23);
            this.Osoyad.TabIndex = 13;
            // 
            // Oad
            // 
            this.Oad.Location = new System.Drawing.Point(139, 43);
            this.Oad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Oad.Name = "Oad";
            this.Oad.Size = new System.Drawing.Size(140, 23);
            this.Oad.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ekle ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 357);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 21;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Ulke
            // 
            this.Ulke.FormattingEnabled = true;
            this.Ulke.Location = new System.Drawing.Point(139, 254);
            this.Ulke.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ulke.Name = "Ulke";
            this.Ulke.Size = new System.Drawing.Size(140, 23);
            this.Ulke.TabIndex = 22;
            // 
            // Sehir
            // 
            this.Sehir.FormattingEnabled = true;
            this.Sehir.Location = new System.Drawing.Point(139, 285);
            this.Sehir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sehir.Name = "Sehir";
            this.Sehir.Size = new System.Drawing.Size(140, 23);
            this.Sehir.TabIndex = 23;
            // 
            // renkler
            // 
            this.renkler.FormattingEnabled = true;
            this.renkler.Location = new System.Drawing.Point(139, 316);
            this.renkler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.renkler.Name = "renkler";
            this.renkler.Size = new System.Drawing.Size(140, 23);
            this.renkler.TabIndex = 24;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ad.ForeColor = System.Drawing.Color.Black;
            this.ad.Location = new System.Drawing.Point(60, 47);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(61, 13);
            this.ad.TabIndex = 25;
            this.ad.Text = "Öğrenci adı";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.soyad.ForeColor = System.Drawing.Color.Black;
            this.soyad.Location = new System.Drawing.Point(44, 85);
            this.soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(77, 13);
            this.soyad.TabIndex = 25;
            this.soyad.Text = "Öğrenci soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Öğrenci nickname";
            // 
            // hayattakalmasuresi
            // 
            this.hayattakalmasuresi.AutoSize = true;
            this.hayattakalmasuresi.ForeColor = System.Drawing.Color.Black;
            this.hayattakalmasuresi.Location = new System.Drawing.Point(52, 145);
            this.hayattakalmasuresi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hayattakalmasuresi.Name = "hayattakalmasuresi";
            this.hayattakalmasuresi.Size = new System.Drawing.Size(69, 15);
            this.hayattakalmasuresi.TabIndex = 25;
            this.hayattakalmasuresi.Text = "Öğrenci yaş";
            // 
            // gun
            // 
            this.gun.AutoSize = true;
            this.gun.Location = new System.Drawing.Point(43, 170);
            this.gun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gun.Name = "gun";
            this.gun.Size = new System.Drawing.Size(78, 15);
            this.gun.TabIndex = 27;
            this.gun.Text = "Doğum günü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Şehir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ülke";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 319);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "En sevdiği renk ";
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(127, 357);
            this.Guncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(88, 27);
            this.Guncelle.TabIndex = 48;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Öğrenci id";
            // 
            // tbx_OgrenciId
            // 
            this.tbx_OgrenciId.Location = new System.Drawing.Point(139, 13);
            this.tbx_OgrenciId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_OgrenciId.Name = "tbx_OgrenciId";
            this.tbx_OgrenciId.Size = new System.Drawing.Size(140, 23);
            this.tbx_OgrenciId.TabIndex = 12;
            // 
            // Ders
            // 
            this.Ders.FormattingEnabled = true;
            this.Ders.Location = new System.Drawing.Point(139, 196);
            this.Ders.Name = "Ders";
            this.Ders.Size = new System.Drawing.Size(140, 23);
            this.Ders.TabIndex = 56;
        
            // 
            // Sınıf
            // 
            this.Sınıf.FormattingEnabled = true;
            this.Sınıf.Location = new System.Drawing.Point(139, 225);
            this.Sınıf.Name = "Sınıf";
            this.Sınıf.Size = new System.Drawing.Size(140, 23);
            this.Sınıf.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Bölümü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 59;
            this.label4.Text = "Sınıfı";
            // 
            // StudentSettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(346, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sınıf);
            this.Controls.Add(this.Ders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gun);
            this.Controls.Add(this.hayattakalmasuresi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.renkler);
            this.Controls.Add(this.Sehir);
            this.Controls.Add(this.Ulke);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dogum);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.Osoyad);
            this.Controls.Add(this.tbx_OgrenciId);
            this.Controls.Add(this.Oad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StudentSettingsPage";
            this.Text = "OgrenciEkleme";
            this.Load += new System.EventHandler(this.StudentSettingsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dogum;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.TextBox Osoyad;
        private System.Windows.Forms.TextBox Oad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Ulke;
        private System.Windows.Forms.ComboBox Sehir;
        private System.Windows.Forms.ComboBox renkler;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hayattakalmasuresi;
        private System.Windows.Forms.Label gun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_OgrenciId;
        private ComboBox Ders;
        private ComboBox Sınıf;
        private Label label2;
        private Label label4;
    }
}