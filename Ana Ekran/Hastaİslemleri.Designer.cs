namespace Ana_Ekran
{
    partial class Hastaİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hastaİslemleri));
            this.label11 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_YapilanTahlilVeIslemler = new System.Windows.Forms.DataGridView();
            this.button4_Ekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_ToplamTutar = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button10_Cikis = new System.Windows.Forms.Button();
            this.button9_BaskiOnIzlemeYap = new System.Windows.Forms.Button();
            this.button7_Taburcu = new System.Windows.Forms.Button();
            this.button5_SecSil = new System.Windows.Forms.Button();
            this.button6_Yeni = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3_HastaSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1_Miktar = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4_DoktorKod = new System.Windows.Forms.ComboBox();
            this.comboBox3_YapilanIslem = new System.Windows.Forms.ComboBox();
            this.comboBox2_PoliklinikAd = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5_SiraNo = new System.Windows.Forms.TextBox();
            this.textBox6_birimFiyat = new System.Windows.Forms.TextBox();
            this.textBox4_KurumAdi = new System.Windows.Forms.TextBox();
            this.textBox2_HastaAd = new System.Windows.Forms.TextBox();
            this.textBox1_DosyaNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1_SevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2_OncekiIslemlerGit = new System.Windows.Forms.Button();
            this.button3_BulDosyaNo = new System.Windows.Forms.Button();
            this.button1_HastaBilgileri = new System.Windows.Forms.Button();
            this.comboBox1_OncekiIslemler = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_YapilanTahlilVeIslemler)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Miktar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(559, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Dr. Kodu";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1_YapilanTahlilVeIslemler);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 249);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1149, 303);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yapılan Tahlil ve İşlemler / Listeden Çıkarmak İçin Çift Tıklayın";
            // 
            // dataGridView1_YapilanTahlilVeIslemler
            // 
            this.dataGridView1_YapilanTahlilVeIslemler.AllowUserToAddRows = false;
            this.dataGridView1_YapilanTahlilVeIslemler.AllowUserToDeleteRows = false;
            this.dataGridView1_YapilanTahlilVeIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_YapilanTahlilVeIslemler.Location = new System.Drawing.Point(8, 25);
            this.dataGridView1_YapilanTahlilVeIslemler.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1_YapilanTahlilVeIslemler.Name = "dataGridView1_YapilanTahlilVeIslemler";
            this.dataGridView1_YapilanTahlilVeIslemler.ReadOnly = true;
            this.dataGridView1_YapilanTahlilVeIslemler.Size = new System.Drawing.Size(1127, 270);
            this.dataGridView1_YapilanTahlilVeIslemler.TabIndex = 0;
            this.dataGridView1_YapilanTahlilVeIslemler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_YapilanTahlilVeIslemler_CellClick);
            this.dataGridView1_YapilanTahlilVeIslemler.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_YapilanTahlilVeIslemler_CellMouseDoubleClick);
            this.dataGridView1_YapilanTahlilVeIslemler.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_YapilanTahlilVeIslemler_RowsAdded);
            // 
            // button4_Ekle
            // 
            this.button4_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4_Ekle.Location = new System.Drawing.Point(1025, 134);
            this.button4_Ekle.Margin = new System.Windows.Forms.Padding(4);
            this.button4_Ekle.Name = "button4_Ekle";
            this.button4_Ekle.Size = new System.Drawing.Size(137, 103);
            this.button4_Ekle.TabIndex = 13;
            this.button4_Ekle.Text = "Ekle";
            this.button4_Ekle.UseVisualStyleBackColor = true;
            this.button4_Ekle.Click += new System.EventHandler(this.button4_Ekle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_ToplamTutar);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(825, 560);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 54);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_ToplamTutar
            // 
            this.label_ToplamTutar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ToplamTutar.ForeColor = System.Drawing.Color.Crimson;
            this.label_ToplamTutar.Location = new System.Drawing.Point(136, 15);
            this.label_ToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ToplamTutar.Name = "label_ToplamTutar";
            this.label_ToplamTutar.Size = new System.Drawing.Size(70, 28);
            this.label_ToplamTutar.TabIndex = 1;
            this.label_ToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(4, 13);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 28);
            this.label14.TabIndex = 1;
            this.label14.Text = "Toplam Tutar :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button10_Cikis
            // 
            this.button10_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10_Cikis.Location = new System.Drawing.Point(867, 16);
            this.button10_Cikis.Margin = new System.Windows.Forms.Padding(4);
            this.button10_Cikis.Name = "button10_Cikis";
            this.button10_Cikis.Size = new System.Drawing.Size(170, 70);
            this.button10_Cikis.TabIndex = 0;
            this.button10_Cikis.Text = "Kapat";
            this.button10_Cikis.UseVisualStyleBackColor = true;
            this.button10_Cikis.Click += new System.EventHandler(this.button10_Cikis_Click);
            // 
            // button9_BaskiOnIzlemeYap
            // 
            this.button9_BaskiOnIzlemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9_BaskiOnIzlemeYap.Location = new System.Drawing.Point(670, 16);
            this.button9_BaskiOnIzlemeYap.Margin = new System.Windows.Forms.Padding(4);
            this.button9_BaskiOnIzlemeYap.Name = "button9_BaskiOnIzlemeYap";
            this.button9_BaskiOnIzlemeYap.Size = new System.Drawing.Size(170, 70);
            this.button9_BaskiOnIzlemeYap.TabIndex = 0;
            this.button9_BaskiOnIzlemeYap.Text = "Yazdır";
            this.button9_BaskiOnIzlemeYap.UseVisualStyleBackColor = true;
            this.button9_BaskiOnIzlemeYap.Click += new System.EventHandler(this.button9_BaskiOnIzlemeYap_Click);
            // 
            // button7_Taburcu
            // 
            this.button7_Taburcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7_Taburcu.Location = new System.Drawing.Point(459, 16);
            this.button7_Taburcu.Margin = new System.Windows.Forms.Padding(4);
            this.button7_Taburcu.Name = "button7_Taburcu";
            this.button7_Taburcu.Size = new System.Drawing.Size(170, 70);
            this.button7_Taburcu.TabIndex = 0;
            this.button7_Taburcu.Text = "Taburcu";
            this.button7_Taburcu.UseVisualStyleBackColor = true;
            this.button7_Taburcu.Click += new System.EventHandler(this.button7_Taburcu_Click);
            // 
            // button5_SecSil
            // 
            this.button5_SecSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5_SecSil.Location = new System.Drawing.Point(253, 16);
            this.button5_SecSil.Margin = new System.Windows.Forms.Padding(4);
            this.button5_SecSil.Name = "button5_SecSil";
            this.button5_SecSil.Size = new System.Drawing.Size(170, 70);
            this.button5_SecSil.TabIndex = 0;
            this.button5_SecSil.Text = "Seç - Sil";
            this.button5_SecSil.UseVisualStyleBackColor = true;
            this.button5_SecSil.Click += new System.EventHandler(this.button5_SecSil_Click);
            // 
            // button6_Yeni
            // 
            this.button6_Yeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6_Yeni.Location = new System.Drawing.Point(54, 16);
            this.button6_Yeni.Margin = new System.Windows.Forms.Padding(4);
            this.button6_Yeni.Name = "button6_Yeni";
            this.button6_Yeni.Size = new System.Drawing.Size(170, 70);
            this.button6_Yeni.TabIndex = 0;
            this.button6_Yeni.Text = "Yeni";
            this.button6_Yeni.UseVisualStyleBackColor = true;
            this.button6_Yeni.Click += new System.EventHandler(this.button6_Yeni_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10_Cikis);
            this.groupBox3.Controls.Add(this.button9_BaskiOnIzlemeYap);
            this.groupBox3.Controls.Add(this.button7_Taburcu);
            this.groupBox3.Controls.Add(this.button5_SecSil);
            this.groupBox3.Controls.Add(this.button6_Yeni);
            this.groupBox3.Location = new System.Drawing.Point(32, 614);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1087, 94);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(18, 569);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(799, 34);
            this.label15.TabIndex = 14;
            this.label15.Text = "Listede Görünen Veriler Veritabanına Kayıt Edilmiştir.Silmek İçin Listeden Seçip " +
    "Sil Butonunu Kullanınız.";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3_HastaSoyad
            // 
            this.textBox3_HastaSoyad.Location = new System.Drawing.Point(630, 51);
            this.textBox3_HastaSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3_HastaSoyad.Name = "textBox3_HastaSoyad";
            this.textBox3_HastaSoyad.Size = new System.Drawing.Size(203, 22);
            this.textBox3_HastaSoyad.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(866, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown1_Miktar
            // 
            this.numericUpDown1_Miktar.Location = new System.Drawing.Point(670, 60);
            this.numericUpDown1_Miktar.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1_Miktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1_Miktar.Name = "numericUpDown1_Miktar";
            this.numericUpDown1_Miktar.Size = new System.Drawing.Size(113, 24);
            this.numericUpDown1_Miktar.TabIndex = 3;
            this.numericUpDown1_Miktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1_Miktar.ValueChanged += new System.EventHandler(this.numericUpDown1_Miktar_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox4_DoktorKod);
            this.groupBox1.Controls.Add(this.comboBox3_YapilanIslem);
            this.groupBox1.Controls.Add(this.comboBox2_PoliklinikAd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDown1_Miktar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox5_SiraNo);
            this.groupBox1.Controls.Add(this.textBox6_birimFiyat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(36, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(965, 106);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Menüsü";
            // 
            // comboBox4_DoktorKod
            // 
            this.comboBox4_DoktorKod.FormattingEnabled = true;
            this.comboBox4_DoktorKod.Location = new System.Drawing.Point(554, 62);
            this.comboBox4_DoktorKod.Name = "comboBox4_DoktorKod";
            this.comboBox4_DoktorKod.Size = new System.Drawing.Size(102, 26);
            this.comboBox4_DoktorKod.TabIndex = 8;
            // 
            // comboBox3_YapilanIslem
            // 
            this.comboBox3_YapilanIslem.FormattingEnabled = true;
            this.comboBox3_YapilanIslem.Location = new System.Drawing.Point(327, 61);
            this.comboBox3_YapilanIslem.Name = "comboBox3_YapilanIslem";
            this.comboBox3_YapilanIslem.Size = new System.Drawing.Size(212, 26);
            this.comboBox3_YapilanIslem.TabIndex = 7;
            this.comboBox3_YapilanIslem.SelectedIndexChanged += new System.EventHandler(this.comboBox3_YapilanIslem_SelectedIndexChanged);
            // 
            // comboBox2_PoliklinikAd
            // 
            this.comboBox2_PoliklinikAd.FormattingEnabled = true;
            this.comboBox2_PoliklinikAd.Location = new System.Drawing.Point(49, 61);
            this.comboBox2_PoliklinikAd.Name = "comboBox2_PoliklinikAd";
            this.comboBox2_PoliklinikAd.Size = new System.Drawing.Size(121, 26);
            this.comboBox2_PoliklinikAd.TabIndex = 6;
            this.comboBox2_PoliklinikAd.SelectedIndexChanged += new System.EventHandler(this.comboBox2_PoliklinikAd_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(317, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Yapılan İşlem";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(670, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 28);
            this.label13.TabIndex = 1;
            this.label13.Text = "Miktar";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(791, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 28);
            this.label12.TabIndex = 1;
            this.label12.Text = "Birim Fiyat";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(175, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sıra No";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Poliklinik";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5_SiraNo
            // 
            this.textBox5_SiraNo.Location = new System.Drawing.Point(181, 62);
            this.textBox5_SiraNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5_SiraNo.Name = "textBox5_SiraNo";
            this.textBox5_SiraNo.Size = new System.Drawing.Size(132, 24);
            this.textBox5_SiraNo.TabIndex = 5;
            this.textBox5_SiraNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_SiraNo_KeyPress);
            // 
            // textBox6_birimFiyat
            // 
            this.textBox6_birimFiyat.Enabled = false;
            this.textBox6_birimFiyat.Location = new System.Drawing.Point(791, 61);
            this.textBox6_birimFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6_birimFiyat.Name = "textBox6_birimFiyat";
            this.textBox6_birimFiyat.Size = new System.Drawing.Size(132, 24);
            this.textBox6_birimFiyat.TabIndex = 5;
            // 
            // textBox4_KurumAdi
            // 
            this.textBox4_KurumAdi.Location = new System.Drawing.Point(630, 91);
            this.textBox4_KurumAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4_KurumAdi.Name = "textBox4_KurumAdi";
            this.textBox4_KurumAdi.Size = new System.Drawing.Size(203, 22);
            this.textBox4_KurumAdi.TabIndex = 26;
            // 
            // textBox2_HastaAd
            // 
            this.textBox2_HastaAd.Location = new System.Drawing.Point(630, 7);
            this.textBox2_HastaAd.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_HastaAd.Name = "textBox2_HastaAd";
            this.textBox2_HastaAd.Size = new System.Drawing.Size(203, 22);
            this.textBox2_HastaAd.TabIndex = 24;
            this.textBox2_HastaAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_HastaAd_KeyPress);
            // 
            // textBox1_DosyaNo
            // 
            this.textBox1_DosyaNo.Location = new System.Drawing.Point(174, 7);
            this.textBox1_DosyaNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_DosyaNo.Name = "textBox1_DosyaNo";
            this.textBox1_DosyaNo.Size = new System.Drawing.Size(132, 22);
            this.textBox1_DosyaNo.TabIndex = 25;
            this.textBox1_DosyaNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_DosyaNo_KeyDown);
            this.textBox1_DosyaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_DosyaNo_KeyPress);
            // 
            // dateTimePicker1_SevkTarihi
            // 
            this.dateTimePicker1_SevkTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1_SevkTarihi.Location = new System.Drawing.Point(174, 51);
            this.dateTimePicker1_SevkTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1_SevkTarihi.Name = "dateTimePicker1_SevkTarihi";
            this.dateTimePicker1_SevkTarihi.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker1_SevkTarihi.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(488, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kurum Adı :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Önceki İşlemler :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(488, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hasta Soyad :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sevk Tarihi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(488, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hasta Ad :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dosya No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2_OncekiIslemlerGit
            // 
            this.button2_OncekiIslemlerGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2_OncekiIslemlerGit.Location = new System.Drawing.Point(320, 83);
            this.button2_OncekiIslemlerGit.Margin = new System.Windows.Forms.Padding(4);
            this.button2_OncekiIslemlerGit.Name = "button2_OncekiIslemlerGit";
            this.button2_OncekiIslemlerGit.Size = new System.Drawing.Size(81, 38);
            this.button2_OncekiIslemlerGit.TabIndex = 10;
            this.button2_OncekiIslemlerGit.Text = "Git";
            this.button2_OncekiIslemlerGit.UseVisualStyleBackColor = true;
            this.button2_OncekiIslemlerGit.Click += new System.EventHandler(this.button2_OncekiIslemlerGit_Click);
            // 
            // button3_BulDosyaNo
            // 
            this.button3_BulDosyaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3_BulDosyaNo.Location = new System.Drawing.Point(316, 6);
            this.button3_BulDosyaNo.Margin = new System.Windows.Forms.Padding(4);
            this.button3_BulDosyaNo.Name = "button3_BulDosyaNo";
            this.button3_BulDosyaNo.Size = new System.Drawing.Size(85, 38);
            this.button3_BulDosyaNo.TabIndex = 11;
            this.button3_BulDosyaNo.Text = "Bul";
            this.button3_BulDosyaNo.UseVisualStyleBackColor = true;
            this.button3_BulDosyaNo.Click += new System.EventHandler(this.button3_BulDosyaNo_Click);
            // 
            // button1_HastaBilgileri
            // 
            this.button1_HastaBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_HastaBilgileri.Location = new System.Drawing.Point(885, 45);
            this.button1_HastaBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.button1_HastaBilgileri.Name = "button1_HastaBilgileri";
            this.button1_HastaBilgileri.Size = new System.Drawing.Size(277, 74);
            this.button1_HastaBilgileri.TabIndex = 12;
            this.button1_HastaBilgileri.Text = "Hasta Bilgileri / Hasta Ekleme";
            this.button1_HastaBilgileri.UseVisualStyleBackColor = true;
            this.button1_HastaBilgileri.Click += new System.EventHandler(this.button1_HastaBilgileri_Click);
            // 
            // comboBox1_OncekiIslemler
            // 
            this.comboBox1_OncekiIslemler.FormattingEnabled = true;
            this.comboBox1_OncekiIslemler.Location = new System.Drawing.Point(174, 98);
            this.comboBox1_OncekiIslemler.Name = "comboBox1_OncekiIslemler";
            this.comboBox1_OncekiIslemler.Size = new System.Drawing.Size(132, 24);
            this.comboBox1_OncekiIslemler.TabIndex = 32;
            // 
            // Hastaİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1169, 726);
            this.Controls.Add(this.comboBox1_OncekiIslemler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4_Ekle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox3_HastaSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4_KurumAdi);
            this.Controls.Add(this.textBox2_HastaAd);
            this.Controls.Add(this.textBox1_DosyaNo);
            this.Controls.Add(this.dateTimePicker1_SevkTarihi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2_OncekiIslemlerGit);
            this.Controls.Add(this.button3_BulDosyaNo);
            this.Controls.Add(this.button1_HastaBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hastaİslemleri";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastaİslemleri";
            this.Load += new System.EventHandler(this.Hastaİslemleri_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_YapilanTahlilVeIslemler)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Miktar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1_YapilanTahlilVeIslemler;
        private System.Windows.Forms.Button button4_Ekle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ToplamTutar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button10_Cikis;
        private System.Windows.Forms.Button button9_BaskiOnIzlemeYap;
        private System.Windows.Forms.Button button7_Taburcu;
        private System.Windows.Forms.Button button5_SecSil;
        private System.Windows.Forms.Button button6_Yeni;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3_HastaSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Miktar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5_SiraNo;
        private System.Windows.Forms.TextBox textBox6_birimFiyat;
        private System.Windows.Forms.TextBox textBox4_KurumAdi;
        private System.Windows.Forms.TextBox textBox2_HastaAd;
        public System.Windows.Forms.TextBox textBox1_DosyaNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_SevkTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2_OncekiIslemlerGit;
        private System.Windows.Forms.Button button3_BulDosyaNo;
        private System.Windows.Forms.Button button1_HastaBilgileri;
        private System.Windows.Forms.ComboBox comboBox2_PoliklinikAd;
        private System.Windows.Forms.ComboBox comboBox4_DoktorKod;
        private System.Windows.Forms.ComboBox comboBox3_YapilanIslem;
        private System.Windows.Forms.ComboBox comboBox1_OncekiIslemler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}