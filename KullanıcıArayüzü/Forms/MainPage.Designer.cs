namespace KullanıcıArayüzü
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ülkeTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şehitTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersTablosuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.notlarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.dosyaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1359, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciTablosuToolStripMenuItem,
            this.formToolStripMenuItem,
            this.ülkeTablosuToolStripMenuItem,
            this.şehitTablosuToolStripMenuItem,
            this.dersTablosuToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.dosyaToolStripMenuItem.Text = "Tablolar";
            // 
            // öğrenciTablosuToolStripMenuItem
            // 
            this.öğrenciTablosuToolStripMenuItem.Name = "öğrenciTablosuToolStripMenuItem";
            this.öğrenciTablosuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.öğrenciTablosuToolStripMenuItem.Text = "Renk tablosu ";
            this.öğrenciTablosuToolStripMenuItem.Click += new System.EventHandler(this.öğrenciTablosuToolStripMenuItem_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.formToolStripMenuItem.Text = "Öğrenci tablosu";
            this.formToolStripMenuItem.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
            // 
            // ülkeTablosuToolStripMenuItem
            // 
            this.ülkeTablosuToolStripMenuItem.Name = "ülkeTablosuToolStripMenuItem";
            this.ülkeTablosuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ülkeTablosuToolStripMenuItem.Text = "Ülke Tablosu";
            this.ülkeTablosuToolStripMenuItem.Click += new System.EventHandler(this.ülkeTablosuToolStripMenuItem_Click);
            // 
            // şehitTablosuToolStripMenuItem
            // 
            this.şehitTablosuToolStripMenuItem.Name = "şehitTablosuToolStripMenuItem";
            this.şehitTablosuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.şehitTablosuToolStripMenuItem.Text = "Şehir Tablosu ";
            this.şehitTablosuToolStripMenuItem.Click += new System.EventHandler(this.şehitTablosuToolStripMenuItem_Click);
            // 
            // dersTablosuToolStripMenuItem
            // 
            this.dersTablosuToolStripMenuItem.Name = "dersTablosuToolStripMenuItem";
            this.dersTablosuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dersTablosuToolStripMenuItem.Text = "Ders Tablosu";
            this.dersTablosuToolStripMenuItem.Click += new System.EventHandler(this.dersTablosuToolStripMenuItem_Click);
            // 
            // notlarToolStripMenuItem
            // 
            this.notlarToolStripMenuItem.Name = "notlarToolStripMenuItem";
            this.notlarToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.notlarToolStripMenuItem.Text = "Notlar";
            this.notlarToolStripMenuItem.Click += new System.EventHandler(this.notlarToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1359, 659);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainPage";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciTablosuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ülkeTablosuToolStripMenuItem;
        private ToolStripMenuItem şehitTablosuToolStripMenuItem;
        private ToolStripMenuItem dersTablosuToolStripMenuItem;
        private ToolStripMenuItem notlarToolStripMenuItem;
    }
}