namespace KullanıcıArayüzü.Forms
{
    partial class Dersler
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
            this.Derstablo = new System.Windows.Forms.DataGridView();
            this.Derskodu = new System.Windows.Forms.TextBox();
            this.Dersad = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ekle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.guncel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Derstablo)).BeginInit();
            this.SuspendLayout();
            // 
            // Derstablo
            // 
            this.Derstablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Derstablo.Location = new System.Drawing.Point(28, 70);
            this.Derstablo.Name = "Derstablo";
            this.Derstablo.RowTemplate.Height = 25;
            this.Derstablo.Size = new System.Drawing.Size(295, 215);
            this.Derstablo.TabIndex = 0;
            this.Derstablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Derstablo_CellClick);
            // 
            // Derskodu
            // 
            this.Derskodu.Location = new System.Drawing.Point(392, 79);
            this.Derskodu.Name = "Derskodu";
            this.Derskodu.Size = new System.Drawing.Size(100, 23);
            this.Derskodu.TabIndex = 1;
            // 
            // Dersad
            // 
            this.Dersad.Location = new System.Drawing.Point(392, 108);
            this.Dersad.Name = "Dersad";
            this.Dersad.Size = new System.Drawing.Size(100, 23);
            this.Dersad.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(295, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ders kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ders adı ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ders Ara";
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(402, 137);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(75, 23);
            this.Ekle.TabIndex = 7;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(186, 291);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(137, 23);
            this.Sil.TabIndex = 8;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // guncel
            // 
            this.guncel.Location = new System.Drawing.Point(28, 291);
            this.guncel.Name = "guncel";
            this.guncel.Size = new System.Drawing.Size(137, 23);
            this.guncel.TabIndex = 9;
            this.guncel.Text = "Güncelle";
            this.guncel.UseVisualStyleBackColor = true;
            this.guncel.Click += new System.EventHandler(this.guncel_Click);
            // 
            // Dersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(538, 319);
            this.Controls.Add(this.guncel);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Dersad);
            this.Controls.Add(this.Derskodu);
            this.Controls.Add(this.Derstablo);
            this.Name = "Dersler";
            this.Text = "Dersler";
            this.Load += new System.EventHandler(this.Dersler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Derstablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Derstablo;
        private TextBox Derskodu;
        private TextBox Dersad;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Ekle;
        private Button Sil;
        private Button guncel;
    }
}