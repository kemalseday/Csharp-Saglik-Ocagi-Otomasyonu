namespace Ana_Ekran
{
    partial class HastaBulmaEkranı
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
            this.button1_Bul = new System.Windows.Forms.Button();
            this.checkBox1_Ve = new System.Windows.Forms.CheckBox();
            this.label1_aramakriteri = new System.Windows.Forms.Label();
            this.textBox1_Ad = new System.Windows.Forms.TextBox();
            this.dataGridView1_Listele = new System.Windows.Forms.DataGridView();
            this.comboBox1_AramaKriterleri = new System.Windows.Forms.ComboBox();
            this.textBox3_AramaNormalSorgu = new System.Windows.Forms.TextBox();
            this.textBox2_Soyad = new System.Windows.Forms.TextBox();
            this.groupBox1_AdSoyad = new System.Windows.Forms.GroupBox();
            this.label4_aramaSorguGir = new System.Windows.Forms.Label();
            this.label2_ad = new System.Windows.Forms.Label();
            this.label3_soyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Listele)).BeginInit();
            this.groupBox1_AdSoyad.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_Bul
            // 
            this.button1_Bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_Bul.Location = new System.Drawing.Point(614, 27);
            this.button1_Bul.Margin = new System.Windows.Forms.Padding(4);
            this.button1_Bul.Name = "button1_Bul";
            this.button1_Bul.Size = new System.Drawing.Size(169, 69);
            this.button1_Bul.TabIndex = 7;
            this.button1_Bul.Text = "Bul";
            this.button1_Bul.UseVisualStyleBackColor = true;
            this.button1_Bul.Click += new System.EventHandler(this.button1_Bul_Click);
            // 
            // checkBox1_Ve
            // 
            this.checkBox1_Ve.AutoSize = true;
            this.checkBox1_Ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1_Ve.Location = new System.Drawing.Point(159, 39);
            this.checkBox1_Ve.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1_Ve.Name = "checkBox1_Ve";
            this.checkBox1_Ve.Size = new System.Drawing.Size(47, 21);
            this.checkBox1_Ve.TabIndex = 1;
            this.checkBox1_Ve.Text = "ve";
            this.checkBox1_Ve.UseVisualStyleBackColor = true;
            // 
            // label1_aramakriteri
            // 
            this.label1_aramakriteri.AutoSize = true;
            this.label1_aramakriteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_aramakriteri.Location = new System.Drawing.Point(75, 30);
            this.label1_aramakriteri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_aramakriteri.Name = "label1_aramakriteri";
            this.label1_aramakriteri.Size = new System.Drawing.Size(106, 18);
            this.label1_aramakriteri.TabIndex = 8;
            this.label1_aramakriteri.Text = "Arama Kriteri";
            this.label1_aramakriteri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1_Ad
            // 
            this.textBox1_Ad.Location = new System.Drawing.Point(17, 38);
            this.textBox1_Ad.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_Ad.Name = "textBox1_Ad";
            this.textBox1_Ad.Size = new System.Drawing.Size(132, 22);
            this.textBox1_Ad.TabIndex = 3;
            // 
            // dataGridView1_Listele
            // 
            this.dataGridView1_Listele.AllowUserToAddRows = false;
            this.dataGridView1_Listele.AllowUserToDeleteRows = false;
            this.dataGridView1_Listele.AllowUserToOrderColumns = true;
            this.dataGridView1_Listele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1_Listele.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1_Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Listele.Location = new System.Drawing.Point(46, 114);
            this.dataGridView1_Listele.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1_Listele.Name = "dataGridView1_Listele";
            this.dataGridView1_Listele.ReadOnly = true;
            this.dataGridView1_Listele.Size = new System.Drawing.Size(737, 377);
            this.dataGridView1_Listele.TabIndex = 11;
            this.dataGridView1_Listele.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Listele_CellContentDoubleClick);
            // 
            // comboBox1_AramaKriterleri
            // 
            this.comboBox1_AramaKriterleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_AramaKriterleri.FormattingEnabled = true;
            this.comboBox1_AramaKriterleri.Items.AddRange(new object[] {
            "Hasta Ad Soyad",
            "TC Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.comboBox1_AramaKriterleri.Location = new System.Drawing.Point(46, 58);
            this.comboBox1_AramaKriterleri.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1_AramaKriterleri.Name = "comboBox1_AramaKriterleri";
            this.comboBox1_AramaKriterleri.Size = new System.Drawing.Size(191, 24);
            this.comboBox1_AramaKriterleri.TabIndex = 10;
            this.comboBox1_AramaKriterleri.SelectedIndexChanged += new System.EventHandler(this.comboBox1_AramaKriterleri_SelectedIndexChanged);
            // 
            // textBox3_AramaNormalSorgu
            // 
            this.textBox3_AramaNormalSorgu.Location = new System.Drawing.Point(10, 38);
            this.textBox3_AramaNormalSorgu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3_AramaNormalSorgu.Name = "textBox3_AramaNormalSorgu";
            this.textBox3_AramaNormalSorgu.Size = new System.Drawing.Size(341, 22);
            this.textBox3_AramaNormalSorgu.TabIndex = 3;
            // 
            // textBox2_Soyad
            // 
            this.textBox2_Soyad.Location = new System.Drawing.Point(217, 38);
            this.textBox2_Soyad.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_Soyad.Name = "textBox2_Soyad";
            this.textBox2_Soyad.Size = new System.Drawing.Size(132, 22);
            this.textBox2_Soyad.TabIndex = 3;
            // 
            // groupBox1_AdSoyad
            // 
            this.groupBox1_AdSoyad.Controls.Add(this.label4_aramaSorguGir);
            this.groupBox1_AdSoyad.Controls.Add(this.textBox3_AramaNormalSorgu);
            this.groupBox1_AdSoyad.Controls.Add(this.textBox1_Ad);
            this.groupBox1_AdSoyad.Controls.Add(this.checkBox1_Ve);
            this.groupBox1_AdSoyad.Controls.Add(this.textBox2_Soyad);
            this.groupBox1_AdSoyad.Controls.Add(this.label2_ad);
            this.groupBox1_AdSoyad.Controls.Add(this.label3_soyad);
            this.groupBox1_AdSoyad.Location = new System.Drawing.Point(247, 27);
            this.groupBox1_AdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1_AdSoyad.Name = "groupBox1_AdSoyad";
            this.groupBox1_AdSoyad.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1_AdSoyad.Size = new System.Drawing.Size(359, 70);
            this.groupBox1_AdSoyad.TabIndex = 12;
            this.groupBox1_AdSoyad.TabStop = false;
            // 
            // label4_aramaSorguGir
            // 
            this.label4_aramaSorguGir.AutoSize = true;
            this.label4_aramaSorguGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4_aramaSorguGir.Location = new System.Drawing.Point(94, 13);
            this.label4_aramaSorguGir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4_aramaSorguGir.Name = "label4_aramaSorguGir";
            this.label4_aramaSorguGir.Size = new System.Drawing.Size(165, 18);
            this.label4_aramaSorguGir.TabIndex = 2;
            this.label4_aramaSorguGir.Text = "Arama Sorgusu Girin";
            this.label4_aramaSorguGir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2_ad
            // 
            this.label2_ad.AutoSize = true;
            this.label2_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2_ad.Location = new System.Drawing.Point(61, 14);
            this.label2_ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2_ad.Name = "label2_ad";
            this.label2_ad.Size = new System.Drawing.Size(27, 18);
            this.label2_ad.TabIndex = 2;
            this.label2_ad.Text = "Ad";
            this.label2_ad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3_soyad
            // 
            this.label3_soyad.AutoSize = true;
            this.label3_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3_soyad.Location = new System.Drawing.Point(258, 13);
            this.label3_soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3_soyad.Name = "label3_soyad";
            this.label3_soyad.Size = new System.Drawing.Size(55, 18);
            this.label3_soyad.TabIndex = 2;
            this.label3_soyad.Text = "Soyad";
            this.label3_soyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HastaBulmaEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.button1_Bul);
            this.Controls.Add(this.label1_aramakriteri);
            this.Controls.Add(this.dataGridView1_Listele);
            this.Controls.Add(this.comboBox1_AramaKriterleri);
            this.Controls.Add(this.groupBox1_AdSoyad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HastaBulmaEkranı";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaBulmaEkranı";
            this.Load += new System.EventHandler(this.HastaBulmaEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Listele)).EndInit();
            this.groupBox1_AdSoyad.ResumeLayout(false);
            this.groupBox1_AdSoyad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Bul;
        private System.Windows.Forms.CheckBox checkBox1_Ve;
        private System.Windows.Forms.Label label1_aramakriteri;
        private System.Windows.Forms.TextBox textBox1_Ad;
        private System.Windows.Forms.DataGridView dataGridView1_Listele;
        private System.Windows.Forms.ComboBox comboBox1_AramaKriterleri;
        private System.Windows.Forms.TextBox textBox3_AramaNormalSorgu;
        private System.Windows.Forms.TextBox textBox2_Soyad;
        private System.Windows.Forms.GroupBox groupBox1_AdSoyad;
        private System.Windows.Forms.Label label4_aramaSorguGir;
        private System.Windows.Forms.Label label2_ad;
        private System.Windows.Forms.Label label3_soyad;
    }
}