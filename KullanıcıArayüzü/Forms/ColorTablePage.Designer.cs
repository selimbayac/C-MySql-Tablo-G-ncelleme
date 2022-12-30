namespace KullanıcıArayüzü
{
    partial class ColorTablePage
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
            this.grdRenkler = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.renk = new System.Windows.Forms.TextBox();
            this.renkkodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.renkidtex = new System.Windows.Forms.TextBox();
            this.İd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdRenkler)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRenkler
            // 
            this.grdRenkler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdRenkler.Location = new System.Drawing.Point(14, 14);
            this.grdRenkler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdRenkler.MultiSelect = false;
            this.grdRenkler.Name = "grdRenkler";
            this.grdRenkler.ReadOnly = true;
            this.grdRenkler.Size = new System.Drawing.Size(456, 291);
            this.grdRenkler.TabIndex = 52;
            this.grdRenkler.Click += new System.EventHandler(this.grdRenkler_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 223);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(166, 363);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 27);
            this.button8.TabIndex = 5;
            this.button8.Text = "Güncelle";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 363);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Yapılan işlemleri gör";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // renk
            // 
            this.renk.Location = new System.Drawing.Point(478, 176);
            this.renk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.renk.Name = "renk";
            this.renk.Size = new System.Drawing.Size(116, 23);
            this.renk.TabIndex = 1;
            // 
            // renkkodu
            // 
            this.renkkodu.Location = new System.Drawing.Point(478, 142);
            this.renkkodu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.renkkodu.Name = "renkkodu";
            this.renkkodu.Size = new System.Drawing.Size(116, 23);
            this.renkkodu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "Renk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "Renk Kodu";
            // 
            // renkidtex
            // 
            this.renkidtex.Location = new System.Drawing.Point(478, 104);
            this.renkidtex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.renkidtex.Name = "renkidtex";
            this.renkidtex.ReadOnly = true;
            this.renkidtex.Size = new System.Drawing.Size(116, 23);
            this.renkidtex.TabIndex = 58;
            // 
            // İd
            // 
            this.İd.AutoSize = true;
            this.İd.Location = new System.Drawing.Point(601, 107);
            this.İd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.İd.Name = "İd";
            this.İd.Size = new System.Drawing.Size(17, 15);
            this.İd.TabIndex = 59;
            this.İd.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Renge Göre Ara ";
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(14, 325);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(456, 23);
            this.ara.TabIndex = 60;
            this.ara.TextChanged += new System.EventHandler(this.ara_TextChanged);
            // 
            // ColorTablePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(678, 447);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.İd);
            this.Controls.Add(this.renkidtex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.renkkodu);
            this.Controls.Add(this.renk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdRenkler);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ColorTablePage";
            this.Text = "RenkTablosuEkle";
            this.Load += new System.EventHandler(this.ColorTablePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRenkler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdRenkler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox renk;
        private System.Windows.Forms.TextBox renkkodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox renkidtex;
        private System.Windows.Forms.Label İd;
        private Label label4;
        private TextBox ara;
    }
}