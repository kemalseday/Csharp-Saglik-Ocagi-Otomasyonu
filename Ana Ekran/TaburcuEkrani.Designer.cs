namespace Ana_Ekran
{
    partial class TaburcuEkrani
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
            this.button1_Kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1_sevkTarihi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2_cikisTarihi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox4_ToplamTutar = new System.Windows.Forms.ComboBox();
            this.textBox1_DosyaNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3_Vazgec = new System.Windows.Forms.Button();
            this.comboBox3_OdemeSekli = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_Kaydet
            // 
            this.button1_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_Kaydet.Location = new System.Drawing.Point(278, 235);
            this.button1_Kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.button1_Kaydet.Name = "button1_Kaydet";
            this.button1_Kaydet.Size = new System.Drawing.Size(115, 52);
            this.button1_Kaydet.TabIndex = 5;
            this.button1_Kaydet.Text = "Kaydet";
            this.button1_Kaydet.UseVisualStyleBackColor = true;
            this.button1_Kaydet.Click += new System.EventHandler(this.button1_Kaydet_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dosya No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Toplam Tutar :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1_sevkTarihi
            // 
            this.comboBox1_sevkTarihi.Enabled = false;
            this.comboBox1_sevkTarihi.FormattingEnabled = true;
            this.comboBox1_sevkTarihi.Location = new System.Drawing.Point(149, 52);
            this.comboBox1_sevkTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1_sevkTarihi.Name = "comboBox1_sevkTarihi";
            this.comboBox1_sevkTarihi.Size = new System.Drawing.Size(213, 24);
            this.comboBox1_sevkTarihi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödeme Şekli :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox2_cikisTarihi
            // 
            this.comboBox2_cikisTarihi.Enabled = false;
            this.comboBox2_cikisTarihi.FormattingEnabled = true;
            this.comboBox2_cikisTarihi.Location = new System.Drawing.Point(149, 85);
            this.comboBox2_cikisTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2_cikisTarihi.Name = "comboBox2_cikisTarihi";
            this.comboBox2_cikisTarihi.Size = new System.Drawing.Size(213, 24);
            this.comboBox2_cikisTarihi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Çıkış Tarihi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sevk Tarihi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox4_ToplamTutar
            // 
            this.comboBox4_ToplamTutar.Enabled = false;
            this.comboBox4_ToplamTutar.FormattingEnabled = true;
            this.comboBox4_ToplamTutar.Location = new System.Drawing.Point(149, 151);
            this.comboBox4_ToplamTutar.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4_ToplamTutar.Name = "comboBox4_ToplamTutar";
            this.comboBox4_ToplamTutar.Size = new System.Drawing.Size(213, 24);
            this.comboBox4_ToplamTutar.TabIndex = 1;
            // 
            // textBox1_DosyaNo
            // 
            this.textBox1_DosyaNo.Enabled = false;
            this.textBox1_DosyaNo.Location = new System.Drawing.Point(149, 20);
            this.textBox1_DosyaNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_DosyaNo.Name = "textBox1_DosyaNo";
            this.textBox1_DosyaNo.Size = new System.Drawing.Size(213, 22);
            this.textBox1_DosyaNo.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3_OdemeSekli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1_sevkTarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox2_cikisTarihi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox4_ToplamTutar);
            this.groupBox1.Controls.Add(this.textBox1_DosyaNo);
            this.groupBox1.Location = new System.Drawing.Point(11, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(381, 193);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // button3_Vazgec
            // 
            this.button3_Vazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3_Vazgec.Location = new System.Drawing.Point(11, 235);
            this.button3_Vazgec.Margin = new System.Windows.Forms.Padding(4);
            this.button3_Vazgec.Name = "button3_Vazgec";
            this.button3_Vazgec.Size = new System.Drawing.Size(115, 52);
            this.button3_Vazgec.TabIndex = 6;
            this.button3_Vazgec.Text = "Vazgeç";
            this.button3_Vazgec.UseVisualStyleBackColor = true;
            this.button3_Vazgec.Click += new System.EventHandler(this.button3_Vazgec_Click);
            // 
            // comboBox3_OdemeSekli
            // 
            this.comboBox3_OdemeSekli.FormattingEnabled = true;
            this.comboBox3_OdemeSekli.Items.AddRange(new object[] {
            "Nakit ",
            "Kredi Kartı Tek Çekim",
            "Kredi Kartı Taksitli "});
            this.comboBox3_OdemeSekli.Location = new System.Drawing.Point(149, 120);
            this.comboBox3_OdemeSekli.Name = "comboBox3_OdemeSekli";
            this.comboBox3_OdemeSekli.Size = new System.Drawing.Size(213, 24);
            this.comboBox3_OdemeSekli.TabIndex = 4;
            // 
            // TaburcuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 322);
            this.Controls.Add(this.button1_Kaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3_Vazgec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaburcuEkrani";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taburcu Ekranı";
            this.Load += new System.EventHandler(this.TaburcuEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_Kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1_sevkTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2_cikisTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox4_ToplamTutar;
        private System.Windows.Forms.TextBox textBox1_DosyaNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3_Vazgec;
        private System.Windows.Forms.ComboBox comboBox3_OdemeSekli;
    }
}