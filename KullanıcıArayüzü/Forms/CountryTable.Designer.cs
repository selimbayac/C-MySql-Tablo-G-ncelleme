namespace KullanıcıArayüzü
{
    partial class CountryTable 
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
            this.Ulkegrd = new System.Windows.Forms.DataGridView();
            this.ulkeid = new System.Windows.Forms.TextBox();
            this.Nufus = new System.Windows.Forms.TextBox();
            this.Ulketext = new System.Windows.Forms.TextBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ulkegrd)).BeginInit();
            this.SuspendLayout();
            // 
            // Ulkegrd
            // 
            this.Ulkegrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ulkegrd.Location = new System.Drawing.Point(3, 12);
            this.Ulkegrd.Name = "Ulkegrd";
            this.Ulkegrd.RowTemplate.Height = 25;
            this.Ulkegrd.Size = new System.Drawing.Size(452, 294);
            this.Ulkegrd.TabIndex = 0;
            this.Ulkegrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ulkegrd_CellContentClick);
            this.Ulkegrd.Click += new System.EventHandler(this.Ulkegrd_Click);
            // 
            // ulkeid
            // 
            this.ulkeid.Location = new System.Drawing.Point(472, 58);
            this.ulkeid.Name = "ulkeid";
            this.ulkeid.ReadOnly = true;
            this.ulkeid.Size = new System.Drawing.Size(100, 23);
            this.ulkeid.TabIndex = 1;
            this.ulkeid.TextChanged += new System.EventHandler(this.ulkeid_TextChanged);
            // 
            // Nufus
            // 
            this.Nufus.Location = new System.Drawing.Point(472, 145);
            this.Nufus.Name = "Nufus";
            this.Nufus.Size = new System.Drawing.Size(100, 23);
            this.Nufus.TabIndex = 2;
            this.Nufus.TextChanged += new System.EventHandler(this.Nufus_TextChanged);
            // 
            // Ulketext
            // 
            this.Ulketext.Location = new System.Drawing.Point(472, 101);
            this.Ulketext.Name = "Ulketext";
            this.Ulketext.Size = new System.Drawing.Size(100, 23);
            this.Ulketext.TabIndex = 3;
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(472, 188);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(121, 45);
            this.Ekle.TabIndex = 4;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(152, 359);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(134, 63);
            this.Sil.TabIndex = 6;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(3, 330);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(452, 23);
            this.ara.TabIndex = 7;
            this.ara.TextChanged += new System.EventHandler(this.ara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ülkenin Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ülkenin Nufusu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ülkeye Arama";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 63);
            this.button2.TabIndex = 12;
            this.button2.Text = "Yapılan işlemleri göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CountryTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(679, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Ulketext);
            this.Controls.Add(this.Nufus);
            this.Controls.Add(this.ulkeid);
            this.Controls.Add(this.Ulkegrd);
            this.Name = "CountryTable";
            this.Text = "CountryTable";
            this.Load += new System.EventHandler(this.CountryTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ulkegrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  DataGridView Ulkegrd;
        public  TextBox ulkeid;
        public  TextBox Nufus;
        public TextBox Ulketext;
        private Button Ekle;
        private Button button1;
        private Button Sil;
        private TextBox ara;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}