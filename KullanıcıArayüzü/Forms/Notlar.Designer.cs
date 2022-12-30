namespace KullanıcıArayüzü.Forms
{
    partial class Notlar
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
            this.tablosu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.OgrenciGoster = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbx_Sozlu1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbx_Uygulama2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbx_Uygulama1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbx_UcuncuYazili = new System.Windows.Forms.MaskedTextBox();
            this.mtbx_İkinciYazili = new System.Windows.Forms.MaskedTextBox();
            this.mtbx_İlkYazili = new System.Windows.Forms.MaskedTextBox();
            this.mtbx_Sozlu2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbx_Ortalama = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Dersler = new System.Windows.Forms.Button();
            this.derskod = new System.Windows.Forms.ComboBox();
            this.OgrenciID = new System.Windows.Forms.ComboBox();
            this.Notid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // tablosu
            // 
            this.tablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablosu.Location = new System.Drawing.Point(0, 78);
            this.tablosu.Name = "tablosu";
            this.tablosu.RowTemplate.Height = 25;
            this.tablosu.Size = new System.Drawing.Size(1075, 226);
            this.tablosu.TabIndex = 4;
            this.tablosu.Click += new System.EventHandler(this.tablosu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1190, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "3. Yazılı ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1194, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "2.Sözlü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1194, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "1.Sözlü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1190, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "2.Uygulamalı Sınav";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1190, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "2. Yazılı ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1190, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "1.Uygulamalı Sınav";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1190, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "1. Yazılı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1196, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ortalama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(370, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(360, 37);
            this.label9.TabIndex = 19;
            this.label9.Text = "Öğrenci numarasına göre ara";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(1056, 409);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(192, 37);
            this.Ekle.TabIndex = 20;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(12, 308);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(257, 64);
            this.Guncelle.TabIndex = 21;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(301, 309);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(252, 63);
            this.Sil.TabIndex = 22;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // OgrenciGoster
            // 
            this.OgrenciGoster.Location = new System.Drawing.Point(582, 309);
            this.OgrenciGoster.Name = "OgrenciGoster";
            this.OgrenciGoster.Size = new System.Drawing.Size(236, 63);
            this.OgrenciGoster.TabIndex = 23;
            this.OgrenciGoster.Text = "Öğrenci Göster";
            this.OgrenciGoster.UseVisualStyleBackColor = true;
            this.OgrenciGoster.Click += new System.EventHandler(this.OgrenciGoster_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1189, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Öğrenci Id";
            // 
            // mtbx_Sozlu1
            // 
            this.mtbx_Sozlu1.Location = new System.Drawing.Point(1084, 306);
            this.mtbx_Sozlu1.Name = "mtbx_Sozlu1";
            this.mtbx_Sozlu1.Size = new System.Drawing.Size(100, 23);
            this.mtbx_Sozlu1.TabIndex = 29;
            // 
            // mtbx_Uygulama2
            // 
            this.mtbx_Uygulama2.Location = new System.Drawing.Point(1084, 277);
            this.mtbx_Uygulama2.Name = "mtbx_Uygulama2";
            this.mtbx_Uygulama2.Size = new System.Drawing.Size(100, 23);
            this.mtbx_Uygulama2.TabIndex = 30;
            // 
            // mtbx_Uygulama1
            // 
            this.mtbx_Uygulama1.Location = new System.Drawing.Point(1084, 248);
            this.mtbx_Uygulama1.Name = "mtbx_Uygulama1";
            this.mtbx_Uygulama1.Size = new System.Drawing.Size(100, 23);
            this.mtbx_Uygulama1.TabIndex = 31;
            // 
            // mtbx_UcuncuYazili
            // 
            this.mtbx_UcuncuYazili.Location = new System.Drawing.Point(1084, 219);
            this.mtbx_UcuncuYazili.Name = "mtbx_UcuncuYazili";
            this.mtbx_UcuncuYazili.Size = new System.Drawing.Size(100, 23);
            this.mtbx_UcuncuYazili.TabIndex = 32;
            // 
            // mtbx_İkinciYazili
            // 
            this.mtbx_İkinciYazili.Location = new System.Drawing.Point(1084, 190);
            this.mtbx_İkinciYazili.Name = "mtbx_İkinciYazili";
            this.mtbx_İkinciYazili.Size = new System.Drawing.Size(100, 23);
            this.mtbx_İkinciYazili.TabIndex = 33;
            // 
            // mtbx_İlkYazili
            // 
            this.mtbx_İlkYazili.Location = new System.Drawing.Point(1084, 161);
            this.mtbx_İlkYazili.Name = "mtbx_İlkYazili";
            this.mtbx_İlkYazili.Size = new System.Drawing.Size(100, 23);
            this.mtbx_İlkYazili.TabIndex = 34;
            // 
            // mtbx_Sozlu2
            // 
            this.mtbx_Sozlu2.Location = new System.Drawing.Point(1084, 335);
            this.mtbx_Sozlu2.Name = "mtbx_Sozlu2";
            this.mtbx_Sozlu2.Size = new System.Drawing.Size(100, 23);
            this.mtbx_Sozlu2.TabIndex = 35;
            // 
            // mtbx_Ortalama
            // 
            this.mtbx_Ortalama.Location = new System.Drawing.Point(1084, 364);
            this.mtbx_Ortalama.Name = "mtbx_Ortalama";
            this.mtbx_Ortalama.ReadOnly = true;
            this.mtbx_Ortalama.Size = new System.Drawing.Size(100, 23);
            this.mtbx_Ortalama.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1190, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "Ders Kodu";
            // 
            // Dersler
            // 
            this.Dersler.Location = new System.Drawing.Point(834, 309);
            this.Dersler.Name = "Dersler";
            this.Dersler.Size = new System.Drawing.Size(241, 63);
            this.Dersler.TabIndex = 40;
            this.Dersler.Text = "Dersleri Göster";
            this.Dersler.UseVisualStyleBackColor = true;
            this.Dersler.Click += new System.EventHandler(this.Dersler_Click);
            // 
            // derskod
            // 
            this.derskod.FormattingEnabled = true;
            this.derskod.Location = new System.Drawing.Point(1084, 132);
            this.derskod.Name = "derskod";
            this.derskod.Size = new System.Drawing.Size(100, 23);
            this.derskod.TabIndex = 41;
            // 
            // OgrenciID
            // 
            this.OgrenciID.FormattingEnabled = true;
            this.OgrenciID.Location = new System.Drawing.Point(1084, 103);
            this.OgrenciID.Name = "OgrenciID";
            this.OgrenciID.Size = new System.Drawing.Size(100, 23);
            this.OgrenciID.TabIndex = 42;
            // 
            // Notid
            // 
            this.Notid.Location = new System.Drawing.Point(1084, 74);
            this.Notid.Name = "Notid";
            this.Notid.ReadOnly = true;
            this.Notid.Size = new System.Drawing.Size(100, 23);
            this.Notid.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1189, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Not ID";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 49);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(1075, 23);
            this.maskedTextBox1.TabIndex = 45;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // Notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1302, 458);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Notid);
            this.Controls.Add(this.OgrenciID);
            this.Controls.Add(this.derskod);
            this.Controls.Add(this.Dersler);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mtbx_Ortalama);
            this.Controls.Add(this.mtbx_Sozlu2);
            this.Controls.Add(this.mtbx_İlkYazili);
            this.Controls.Add(this.mtbx_İkinciYazili);
            this.Controls.Add(this.mtbx_UcuncuYazili);
            this.Controls.Add(this.mtbx_Uygulama1);
            this.Controls.Add(this.mtbx_Uygulama2);
            this.Controls.Add(this.mtbx_Sozlu1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OgrenciGoster);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablosu);
            this.Name = "Notlar";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.Notlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tablosu;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label2;
        private Label label9;
        private Button Ekle;
        private Button Guncelle;
        private Button Sil;
        private Button OgrenciGoster;
        private Label label10;
        private MaskedTextBox mtbx_Sozlu1;
        private MaskedTextBox mtbx_Uygulama2;
        private MaskedTextBox mtbx_Uygulama1;
        private MaskedTextBox mtbx_UcuncuYazili;
        private MaskedTextBox mtbx_İkinciYazili;
        private MaskedTextBox mtbx_İlkYazili;
        private MaskedTextBox mtbx_Sozlu2;
        private MaskedTextBox mtbx_Ortalama;
        private Label label11;
        private Button Dersler;
        private ComboBox derskod;
        private ComboBox OgrenciID;
        private TextBox Notid;
        private Label label12;
        private MaskedTextBox maskedTextBox1;
    }
}