namespace Ana_Ekran
{
    partial class poliklinik
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
            this.button_PoliklinikCikisYap = new System.Windows.Forms.Button();
            this.button_PoliklinikSil = new System.Windows.Forms.Button();
            this.button1_PoliklinikGuncelle = new System.Windows.Forms.Button();
            this.textBox_PoliklinikAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_poliklinikGecerliMi = new System.Windows.Forms.CheckBox();
            this.textBox1_poliklinikPoliklinikAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_PoliklinikCikisYap
            // 
            this.button_PoliklinikCikisYap.Location = new System.Drawing.Point(324, 276);
            this.button_PoliklinikCikisYap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_PoliklinikCikisYap.Name = "button_PoliklinikCikisYap";
            this.button_PoliklinikCikisYap.Size = new System.Drawing.Size(120, 74);
            this.button_PoliklinikCikisYap.TabIndex = 18;
            this.button_PoliklinikCikisYap.Text = "Kapat";
            this.button_PoliklinikCikisYap.UseVisualStyleBackColor = true;
            this.button_PoliklinikCikisYap.Click += new System.EventHandler(this.button_PoliklinikCikisYap_Click);
            // 
            // button_PoliklinikSil
            // 
            this.button_PoliklinikSil.Location = new System.Drawing.Point(154, 276);
            this.button_PoliklinikSil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_PoliklinikSil.Name = "button_PoliklinikSil";
            this.button_PoliklinikSil.Size = new System.Drawing.Size(120, 74);
            this.button_PoliklinikSil.TabIndex = 19;
            this.button_PoliklinikSil.Text = "Sil";
            this.button_PoliklinikSil.UseVisualStyleBackColor = true;
            this.button_PoliklinikSil.Click += new System.EventHandler(this.button_PoliklinikSil_Click);
            // 
            // button1_PoliklinikGuncelle
            // 
            this.button1_PoliklinikGuncelle.Location = new System.Drawing.Point(24, 276);
            this.button1_PoliklinikGuncelle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1_PoliklinikGuncelle.Name = "button1_PoliklinikGuncelle";
            this.button1_PoliklinikGuncelle.Size = new System.Drawing.Size(120, 74);
            this.button1_PoliklinikGuncelle.TabIndex = 20;
            this.button1_PoliklinikGuncelle.Text = "Güncelle";
            this.button1_PoliklinikGuncelle.UseVisualStyleBackColor = true;
            this.button1_PoliklinikGuncelle.Click += new System.EventHandler(this.button1_PoliklinikGuncelle_Click);
            // 
            // textBox_PoliklinikAciklama
            // 
            this.textBox_PoliklinikAciklama.Location = new System.Drawing.Point(22, 151);
            this.textBox_PoliklinikAciklama.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_PoliklinikAciklama.MaxLength = 250;
            this.textBox_PoliklinikAciklama.Multiline = true;
            this.textBox_PoliklinikAciklama.Name = "textBox_PoliklinikAciklama";
            this.textBox_PoliklinikAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_PoliklinikAciklama.Size = new System.Drawing.Size(422, 114);
            this.textBox_PoliklinikAciklama.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Poliklinik Ad :";
            // 
            // checkBox_poliklinikGecerliMi
            // 
            this.checkBox_poliklinikGecerliMi.AutoSize = true;
            this.checkBox_poliklinikGecerliMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_poliklinikGecerliMi.Location = new System.Drawing.Point(137, 63);
            this.checkBox_poliklinikGecerliMi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox_poliklinikGecerliMi.Name = "checkBox_poliklinikGecerliMi";
            this.checkBox_poliklinikGecerliMi.Size = new System.Drawing.Size(167, 22);
            this.checkBox_poliklinikGecerliMi.TabIndex = 13;
            this.checkBox_poliklinikGecerliMi.Text = "Geçerli / Geçersiz";
            this.checkBox_poliklinikGecerliMi.UseVisualStyleBackColor = true;
            // 
            // textBox1_poliklinikPoliklinikAd
            // 
            this.textBox1_poliklinikPoliklinikAd.Location = new System.Drawing.Point(137, 28);
            this.textBox1_poliklinikPoliklinikAd.Name = "textBox1_poliklinikPoliklinikAd";
            this.textBox1_poliklinikPoliklinikAd.Size = new System.Drawing.Size(307, 24);
            this.textBox1_poliklinikPoliklinikAd.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "<<<  Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // poliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_poliklinikPoliklinikAd);
            this.Controls.Add(this.button_PoliklinikCikisYap);
            this.Controls.Add(this.button_PoliklinikSil);
            this.Controls.Add(this.button1_PoliklinikGuncelle);
            this.Controls.Add(this.textBox_PoliklinikAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_poliklinikGecerliMi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "poliklinik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliklinik";
            this.Load += new System.EventHandler(this.poliklinik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_PoliklinikCikisYap;
        private System.Windows.Forms.Button button_PoliklinikSil;
        private System.Windows.Forms.Button button1_PoliklinikGuncelle;
        private System.Windows.Forms.TextBox textBox_PoliklinikAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_poliklinikGecerliMi;
        private System.Windows.Forms.TextBox textBox1_poliklinikPoliklinikAd;
        private System.Windows.Forms.Button button1;
    }
}