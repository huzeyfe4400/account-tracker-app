
namespace HesapTakipUygulaması
{
    partial class hesaptakipform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hesaptakipform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşteriBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlıMüşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlıÜrünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnindir = new System.Windows.Forms.Button();
            this.btnguncel = new System.Windows.Forms.Button();
            this.btnarama = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriBilgileriToolStripMenuItem,
            this.ürünBilgileriToolStripMenuItem,
            this.siparişBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1855, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşteriBilgileriToolStripMenuItem
            // 
            this.müşteriBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlıMüşterilerToolStripMenuItem,
            this.müşteriEklemeToolStripMenuItem});
            this.müşteriBilgileriToolStripMenuItem.Name = "müşteriBilgileriToolStripMenuItem";
            this.müşteriBilgileriToolStripMenuItem.Size = new System.Drawing.Size(131, 25);
            this.müşteriBilgileriToolStripMenuItem.Text = "Müşteri Bilgileri";
            this.müşteriBilgileriToolStripMenuItem.Click += new System.EventHandler(this.müşteriBilgileriToolStripMenuItem_Click);
            // 
            // kayıtlıMüşterilerToolStripMenuItem
            // 
            this.kayıtlıMüşterilerToolStripMenuItem.Name = "kayıtlıMüşterilerToolStripMenuItem";
            this.kayıtlıMüşterilerToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.kayıtlıMüşterilerToolStripMenuItem.Text = "Kayıtlı Müşteriler";
            this.kayıtlıMüşterilerToolStripMenuItem.Click += new System.EventHandler(this.kayıtlıMüşterilerToolStripMenuItem_Click);
            // 
            // müşteriEklemeToolStripMenuItem
            // 
            this.müşteriEklemeToolStripMenuItem.Name = "müşteriEklemeToolStripMenuItem";
            this.müşteriEklemeToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.müşteriEklemeToolStripMenuItem.Text = "Müşteri Ekleme";
            this.müşteriEklemeToolStripMenuItem.Click += new System.EventHandler(this.müşteriEklemeToolStripMenuItem_Click);
            // 
            // ürünBilgileriToolStripMenuItem
            // 
            this.ürünBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlıÜrünlerToolStripMenuItem,
            this.ürünEkleToolStripMenuItem});
            this.ürünBilgileriToolStripMenuItem.Name = "ürünBilgileriToolStripMenuItem";
            this.ürünBilgileriToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.ürünBilgileriToolStripMenuItem.Text = "Ürün Bilgileri";
            this.ürünBilgileriToolStripMenuItem.Click += new System.EventHandler(this.ürünBilgileriToolStripMenuItem_Click);
            // 
            // kayıtlıÜrünlerToolStripMenuItem
            // 
            this.kayıtlıÜrünlerToolStripMenuItem.Name = "kayıtlıÜrünlerToolStripMenuItem";
            this.kayıtlıÜrünlerToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.kayıtlıÜrünlerToolStripMenuItem.Text = "Kayıtlı Ürünler";
            this.kayıtlıÜrünlerToolStripMenuItem.Click += new System.EventHandler(this.kayıtlıÜrünlerToolStripMenuItem_Click);
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // siparişBilgileriToolStripMenuItem
            // 
            this.siparişBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişlerToolStripMenuItem,
            this.siparişOluşturToolStripMenuItem});
            this.siparişBilgileriToolStripMenuItem.Name = "siparişBilgileriToolStripMenuItem";
            this.siparişBilgileriToolStripMenuItem.Size = new System.Drawing.Size(125, 25);
            this.siparişBilgileriToolStripMenuItem.Text = "Sipariş Bilgileri";
            this.siparişBilgileriToolStripMenuItem.Click += new System.EventHandler(this.siparişBilgileriToolStripMenuItem_Click);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            this.siparişlerToolStripMenuItem.Click += new System.EventHandler(this.siparişlerToolStripMenuItem_Click);
            // 
            // siparişOluşturToolStripMenuItem
            // 
            this.siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            this.siparişOluşturToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparişOluşturToolStripMenuItem.Click += new System.EventHandler(this.siparişOluşturToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MÜŞTERİ",
            "SİPARİŞ NUMARASI"});
            this.comboBox1.Location = new System.Drawing.Point(780, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(136, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnindir);
            this.panel1.Controls.Add(this.btnguncel);
            this.panel1.Controls.Add(this.btnarama);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1855, 78);
            this.panel1.TabIndex = 9;
            // 
            // btnindir
            // 
            this.btnindir.BackColor = System.Drawing.Color.White;
            this.btnindir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnindir.Image = global::HesapTakipUygulaması.Properties.Resources.indir2;
            this.btnindir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnindir.Location = new System.Drawing.Point(1471, 3);
            this.btnindir.Name = "btnindir";
            this.btnindir.Size = new System.Drawing.Size(156, 72);
            this.btnindir.TabIndex = 13;
            this.btnindir.Text = "İNDİR";
            this.btnindir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnindir.UseVisualStyleBackColor = false;
            this.btnindir.Click += new System.EventHandler(this.btnindir_Click);
            // 
            // btnguncel
            // 
            this.btnguncel.BackColor = System.Drawing.Color.White;
            this.btnguncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncel.ForeColor = System.Drawing.Color.Green;
            this.btnguncel.Image = global::HesapTakipUygulaması.Properties.Resources.güncelle;
            this.btnguncel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncel.Location = new System.Drawing.Point(1632, 3);
            this.btnguncel.Name = "btnguncel";
            this.btnguncel.Size = new System.Drawing.Size(211, 72);
            this.btnguncel.TabIndex = 14;
            this.btnguncel.Text = "GÜNCELLE";
            this.btnguncel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguncel.UseVisualStyleBackColor = false;
            this.btnguncel.Click += new System.EventHandler(this.btnguncel_Click);
            // 
            // btnarama
            // 
            this.btnarama.BackColor = System.Drawing.Color.White;
            this.btnarama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnarama.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnarama.Image = global::HesapTakipUygulaması.Properties.Resources.arama;
            this.btnarama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnarama.Location = new System.Drawing.Point(1320, 2);
            this.btnarama.Name = "btnarama";
            this.btnarama.Size = new System.Drawing.Size(128, 74);
            this.btnarama.TabIndex = 12;
            this.btnarama.Text = "ARA";
            this.btnarama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnarama.UseVisualStyleBackColor = false;
            this.btnarama.Click += new System.EventHandler(this.btnarama_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1141, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1074, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aranan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Arama Türü";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1855, 818);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 109);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1855, 740);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 109);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 50;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1855, 740);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 109);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 50;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1855, 740);
            this.dataGridView3.TabIndex = 14;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 109);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 50;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1855, 740);
            this.dataGridView4.TabIndex = 15;
            this.dataGridView4.Visible = false;
            // 
            // hesaptakipform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 849);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "hesaptakipform";
            this.Text = "Hesap Takip Uygulaması";
            this.Load += new System.EventHandler(this.hesaptakipform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişBilgileriToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem kayıtlıMüşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlıÜrünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnarama;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnindir;
        private System.Windows.Forms.Button btnguncel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}

