namespace KutuphaneYonetimSistemi
{
    partial class FormKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonTümKitaplarıGöster = new System.Windows.Forms.Button();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonKitapBilgiGuncelle = new System.Windows.Forms.Button();
            this.buttonKitapEkle = new System.Windows.Forms.Button();
            this.textBoxKitapTurKodu = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxYazarSoyad = new System.Windows.Forms.TextBox();
            this.textBoxYazarAdi = new System.Windows.Forms.TextBox();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonKitapOduncVer = new System.Windows.Forms.Button();
            this.dateTimePickerOduncAlmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBoxOduncAlan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonKitabiIadeEt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelGecikmeBedeli = new System.Windows.Forms.Label();
            this.buttonGecikmeBedeliHesapla = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Controls.Add(this.buttonTümKitaplarıGöster);
            this.groupBox1.Controls.Add(this.buttonAra);
            this.groupBox1.Controls.Add(this.buttonTemizle);
            this.groupBox1.Controls.Add(this.buttonKitapBilgiGuncelle);
            this.groupBox1.Controls.Add(this.buttonKitapEkle);
            this.groupBox1.Controls.Add(this.textBoxKitapTurKodu);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.textBoxYazarSoyad);
            this.groupBox1.Controls.Add(this.textBoxYazarAdi);
            this.groupBox1.Controls.Add(this.textBoxKitapAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(250, 323);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(110, 40);
            this.buttonSil.TabIndex = 17;
            this.buttonSil.Text = "Kitap Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonTümKitaplarıGöster
            // 
            this.buttonTümKitaplarıGöster.Location = new System.Drawing.Point(598, 323);
            this.buttonTümKitaplarıGöster.Name = "buttonTümKitaplarıGöster";
            this.buttonTümKitaplarıGöster.Size = new System.Drawing.Size(110, 40);
            this.buttonTümKitaplarıGöster.TabIndex = 16;
            this.buttonTümKitaplarıGöster.Text = "Tüm Kitapları Göster";
            this.buttonTümKitaplarıGöster.UseVisualStyleBackColor = true;
            this.buttonTümKitaplarıGöster.Click += new System.EventHandler(this.buttonTümKitaplarıGöster_Click);
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(482, 324);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(110, 40);
            this.buttonAra.TabIndex = 15;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(366, 323);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(110, 40);
            this.buttonTemizle.TabIndex = 14;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonKitapBilgiGuncelle
            // 
            this.buttonKitapBilgiGuncelle.Location = new System.Drawing.Point(16, 324);
            this.buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            this.buttonKitapBilgiGuncelle.Size = new System.Drawing.Size(110, 40);
            this.buttonKitapBilgiGuncelle.TabIndex = 13;
            this.buttonKitapBilgiGuncelle.Text = "Kitap Bilgileri Güncelle";
            this.buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            this.buttonKitapBilgiGuncelle.Click += new System.EventHandler(this.buttonKitapBilgiGuncelle_Click);
            // 
            // buttonKitapEkle
            // 
            this.buttonKitapEkle.Location = new System.Drawing.Point(134, 324);
            this.buttonKitapEkle.Name = "buttonKitapEkle";
            this.buttonKitapEkle.Size = new System.Drawing.Size(110, 40);
            this.buttonKitapEkle.TabIndex = 12;
            this.buttonKitapEkle.Text = "Yeni Kitap Ekle";
            this.buttonKitapEkle.UseVisualStyleBackColor = true;
            this.buttonKitapEkle.Click += new System.EventHandler(this.buttonKitapEkle_Click);
            // 
            // textBoxKitapTurKodu
            // 
            this.textBoxKitapTurKodu.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKitapTurKodu.Location = new System.Drawing.Point(183, 246);
            this.textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            this.textBoxKitapTurKodu.Size = new System.Drawing.Size(201, 30);
            this.textBoxKitapTurKodu.TabIndex = 11;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxISBN.Location = new System.Drawing.Point(183, 205);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(201, 30);
            this.textBoxISBN.TabIndex = 10;
            // 
            // textBoxYazarSoyad
            // 
            this.textBoxYazarSoyad.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxYazarSoyad.Location = new System.Drawing.Point(183, 162);
            this.textBoxYazarSoyad.Name = "textBoxYazarSoyad";
            this.textBoxYazarSoyad.Size = new System.Drawing.Size(373, 30);
            this.textBoxYazarSoyad.TabIndex = 9;
            // 
            // textBoxYazarAdi
            // 
            this.textBoxYazarAdi.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxYazarAdi.Location = new System.Drawing.Point(183, 122);
            this.textBoxYazarAdi.Name = "textBoxYazarAdi";
            this.textBoxYazarAdi.Size = new System.Drawing.Size(373, 30);
            this.textBoxYazarAdi.TabIndex = 8;
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKitapAdi.Location = new System.Drawing.Point(183, 76);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(373, 30);
            this.textBoxKitapAdi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kitap Tür Kodu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap ID :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(183, 47);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(12, 15);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kitap Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yazar Soyad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "ISBN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yazar Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.buttonKitapOduncVer);
            this.groupBox2.Controls.Add(this.dateTimePickerOduncAlmaTarihi);
            this.groupBox2.Controls.Add(this.textBoxOduncAlan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(782, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 403);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitapOduncVer
            // 
            this.buttonKitapOduncVer.Location = new System.Drawing.Point(80, 312);
            this.buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            this.buttonKitapOduncVer.Size = new System.Drawing.Size(162, 40);
            this.buttonKitapOduncVer.TabIndex = 17;
            this.buttonKitapOduncVer.Text = "Kitabı Ödünç Ver";
            this.buttonKitapOduncVer.UseVisualStyleBackColor = true;
            this.buttonKitapOduncVer.Click += new System.EventHandler(this.buttonKitapOduncVer_Click);
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            this.dateTimePickerOduncAlmaTarihi.CalendarFont = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerOduncAlmaTarihi.Location = new System.Drawing.Point(166, 184);
            this.dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            this.dateTimePickerOduncAlmaTarihi.Size = new System.Drawing.Size(145, 23);
            this.dateTimePickerOduncAlmaTarihi.TabIndex = 7;
            // 
            // textBoxOduncAlan
            // 
            this.textBoxOduncAlan.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOduncAlan.Location = new System.Drawing.Point(166, 109);
            this.textBoxOduncAlan.Name = "textBoxOduncAlan";
            this.textBoxOduncAlan.Size = new System.Drawing.Size(145, 30);
            this.textBoxOduncAlan.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ödünç Alan :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tarih :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonKitabiIadeEt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.labelGecikmeBedeli);
            this.groupBox3.Controls.Add(this.buttonGecikmeBedeliHesapla);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(1141, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 403);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap İade";
            // 
            // buttonKitabiIadeEt
            // 
            this.buttonKitabiIadeEt.Location = new System.Drawing.Point(180, 312);
            this.buttonKitabiIadeEt.Name = "buttonKitabiIadeEt";
            this.buttonKitabiIadeEt.Size = new System.Drawing.Size(120, 40);
            this.buttonKitabiIadeEt.TabIndex = 16;
            this.buttonKitabiIadeEt.Text = "Kitabı İade Et";
            this.buttonKitabiIadeEt.UseVisualStyleBackColor = true;
            this.buttonKitabiIadeEt.Click += new System.EventHandler(this.buttonKitabiIadeEt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(154, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            this.labelGecikmeBedeli.AutoSize = true;
            this.labelGecikmeBedeli.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGecikmeBedeli.Location = new System.Drawing.Point(112, 167);
            this.labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            this.labelGecikmeBedeli.Size = new System.Drawing.Size(21, 23);
            this.labelGecikmeBedeli.TabIndex = 14;
            this.labelGecikmeBedeli.Text = "0";
            // 
            // buttonGecikmeBedeliHesapla
            // 
            this.buttonGecikmeBedeliHesapla.Location = new System.Drawing.Point(17, 312);
            this.buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            this.buttonGecikmeBedeliHesapla.Size = new System.Drawing.Size(128, 40);
            this.buttonGecikmeBedeliHesapla.TabIndex = 13;
            this.buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            this.buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = true;
            this.buttonGecikmeBedeliHesapla.Click += new System.EventHandler(this.buttonGecikmeBedeliHesapla_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(71, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Gecikme Bedeli :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewKitaplar);
            this.groupBox4.Location = new System.Drawing.Point(12, 409);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1448, 243);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.RowTemplate.Height = 25;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(1442, 221);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellClick);
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1476, 664);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKitaplar";
            this.Text = "AHS Kütüphane Yönetim Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKitaplar_FormClosed);
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label labelID;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyad;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private Button buttonKitapBilgiGuncelle;
        private Button buttonKitapEkle;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private TextBox textBoxOduncAlan;
        private Label label9;
        private Label label8;
        private Button buttonKitabiIadeEt;
        private Label label11;
        private Label labelGecikmeBedeli;
        private Button buttonGecikmeBedeliHesapla;
        private Label label10;
        private Button buttonKitapOduncVer;
        private Button buttonTemizle;
        private Button buttonAra;
        private Button buttonTümKitaplarıGöster;
        private Button buttonSil;
    }
}