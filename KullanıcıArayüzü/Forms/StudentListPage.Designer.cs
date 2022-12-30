namespace KullanıcıArayüzü
{
    partial class StudentListPage
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
            this.Ogrencidt = new System.Windows.Forms.DataGridView();
            this.Ekle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ogrencidt)).BeginInit();
            this.SuspendLayout();
            // 
            // Ogrencidt
            // 
            this.Ogrencidt.AllowUserToAddRows = false;
            this.Ogrencidt.AllowUserToDeleteRows = false;
            this.Ogrencidt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Ogrencidt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ogrencidt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Ogrencidt.Location = new System.Drawing.Point(16, 14);
            this.Ogrencidt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ogrencidt.MultiSelect = false;
            this.Ogrencidt.Name = "Ogrencidt";
            this.Ogrencidt.Size = new System.Drawing.Size(1106, 402);
            this.Ogrencidt.TabIndex = 1;
            this.Ogrencidt.MouseHover += new System.EventHandler(this.Ogrencidt_MouseHover);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(4, 505);
            this.Ekle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(270, 69);
            this.Ekle.TabIndex = 11;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 505);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 69);
            this.button2.TabIndex = 12;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(560, 505);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 69);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(12, 452);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(1104, 23);
            this.ara.TabIndex = 14;
            this.ara.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(492, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Öğrenci Ara ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(838, 505);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 69);
            this.button1.TabIndex = 16;
            this.button1.Text = "Yapılan İşlemleri Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1139, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Ogrencidt);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StudentListPage";
            this.Text = "Ogrencitablosu";
            this.Load += new System.EventHandler(this.StudentListPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ogrencidt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Ogrencidt;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private TextBox ara;
        private Label label1;
        private Button button1;
    }
}