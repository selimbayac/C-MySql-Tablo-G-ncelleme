namespace KullanıcıArayüzü.Forms
{
    partial class CityPage
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
            this.components = new System.ComponentModel.Container();
            this.Sil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.Ulketext = new System.Windows.Forms.TextBox();
            this.Nufus = new System.Windows.Forms.TextBox();
            this.ulkeid = new System.Windows.Forms.TextBox();
            this.Ulkegrd = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ulkegrd)).BeginInit();
            this.SuspendLayout();
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(248, 308);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(87, 49);
            this.Sil.TabIndex = 13;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(12, 308);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(87, 49);
            this.Ekle.TabIndex = 11;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Ulketext
            // 
            this.Ulketext.Location = new System.Drawing.Point(481, 80);
            this.Ulketext.Name = "Ulketext";
            this.Ulketext.Size = new System.Drawing.Size(100, 23);
            this.Ulketext.TabIndex = 10;
            // 
            // Nufus
            // 
            this.Nufus.Location = new System.Drawing.Point(481, 126);
            this.Nufus.Name = "Nufus";
            this.Nufus.Size = new System.Drawing.Size(100, 23);
            this.Nufus.TabIndex = 9;
            this.Nufus.TextChanged += new System.EventHandler(this.Nufus_TextChanged);
            // 
            // ulkeid
            // 
            this.ulkeid.Location = new System.Drawing.Point(481, 32);
            this.ulkeid.Name = "ulkeid";
            this.ulkeid.ReadOnly = true;
            this.ulkeid.Size = new System.Drawing.Size(100, 23);
            this.ulkeid.TabIndex = 8;
            // 
            // Ulkegrd
            // 
            this.Ulkegrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ulkegrd.Location = new System.Drawing.Point(7, 8);
            this.Ulkegrd.Name = "Ulkegrd";
            this.Ulkegrd.RowTemplate.Height = 25;
            this.Ulkegrd.Size = new System.Drawing.Size(449, 265);
            this.Ulkegrd.TabIndex = 7;
            this.Ulkegrd.Click += new System.EventHandler(this.Ulkegrd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Yapılan İşlemler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şehir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nufus";
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(7, 279);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(449, 23);
            this.ara.TabIndex = 18;
            this.ara.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CityPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(647, 373);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Ulketext);
            this.Controls.Add(this.Nufus);
            this.Controls.Add(this.ulkeid);
            this.Controls.Add(this.Ulkegrd);
            this.Name = "CityPage";
            this.Text = "CityPage";
            this.Load += new System.EventHandler(this.CityPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ulkegrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Sil;
        private Button button1;
        private Button Ekle;
        public TextBox Ulketext;
        public TextBox Nufus;
        public TextBox ulkeid;
        public DataGridView Ulkegrd;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ara;
    }
}