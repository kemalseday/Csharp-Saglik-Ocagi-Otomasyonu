using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Ana_Ekran
{
    public partial class Hastaİslemleri : Form
    {
        public Hastaİslemleri()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        SqlCommand cmd;
        int selectedIndex = -1;
        public string A_dosya_no = "", A_poliklinik = "", A_sira_no = "", A_yapilan_islem = "", A_drKod = "", A_miktar = "", A_birimFiyat = "", A_saat = "", A_toplamTutar = "";
        private void Hastaİslemleri_Load(object sender, EventArgs e)
        {
            DataGridViewStunOlusturma();
            PoliklinikIsımDoldurma();
            YapilanIslemDoldurma();
            DrKodDoldurma();
        }
        private void DrKodDoldurma()
        {
            try
            {
                cmd = new SqlCommand("SELECT kullaniciKod FROM kullanici WHERE unvan='Doktor'", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    comboBox4_DoktorKod.Items.Add(dr["kullaniciKod"].ToString());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }
        Dictionary<string, string> islemFiyat;
        private void YapilanIslemDoldurma()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM islem", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                islemFiyat = new Dictionary<string, string>();
                comboBox3_YapilanIslem.Items.Clear();
                while (dr.Read())
                {
                    comboBox3_YapilanIslem.Items.Add(dr["islemAdi"].ToString());
                    islemFiyat.Add(dr["islemAdi"].ToString(), dr["birimFiyat"].ToString());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }
        private void PoliklinikIsımDoldurma()
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM poliklinik", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    comboBox2_PoliklinikAd.Items.Add(dr["poliklinikAdi"]);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }
        private void DataGridViewStunOlusturma()
        {
            dataGridView1_YapilanTahlilVeIslemler.ColumnCount = 8;
            dataGridView1_YapilanTahlilVeIslemler.Columns[0].Name = "Poliklinik";
            dataGridView1_YapilanTahlilVeIslemler.Columns[1].Name = "Sıra No";
            dataGridView1_YapilanTahlilVeIslemler.Columns[2].Name = "Saat";
            dataGridView1_YapilanTahlilVeIslemler.Columns[3].Name = "Yapılan İşlem";
            dataGridView1_YapilanTahlilVeIslemler.Columns[4].Name = "Dr. Kodu";
            dataGridView1_YapilanTahlilVeIslemler.Columns[5].Name = "Miktar";
            dataGridView1_YapilanTahlilVeIslemler.Columns[6].Name = "Birim Fiyat";
            dataGridView1_YapilanTahlilVeIslemler.Columns[7].Name = "Taburcu Durumu";
        }
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        private void BaskiOnIzleme()
        {
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
        }

        private void textBox1_DosyaNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1_DosyaNo.Text != "")
            {
                KullaniciIDAramaEkraniTemizle();
                HastaKullaniciKodIleArama();
            }
        }
        private void KullaniciIDAramaEkraniTemizle()
        {
            dataGridView1_YapilanTahlilVeIslemler.Rows.Clear();
            textBox2_HastaAd.Text = "";
            textBox3_HastaSoyad.Text = "";
            textBox4_KurumAdi.Text = "";
            dateTimePicker1_SevkTarihi.Text = "";
            comboBox1_OncekiIslemler.Items.Clear();
            comboBox2_PoliklinikAd.Text = "";
            textBox5_SiraNo.Text = "";
            comboBox3_YapilanIslem.Text = "";
            comboBox4_DoktorKod.Text = "";
            numericUpDown1_Miktar.Value = 1;
            textBox6_birimFiyat.Text = "";
        }
        private void HastaKullaniciKodIleArama()
        {
            try
            {
                string dosyaNo = textBox1_DosyaNo.Text;
                cmd = new SqlCommand("SELECT H.ad,H.soyad,H.kurumAdi,H.dosyaNo,S.sevkTarihi FROM hasta H,sevk S  WHERE H.dosyaNo = H.dosyaNo AND H.dosyaNo =@dosyaNo", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();
                cmd.Parameters.Add("@dosyaNo", SqlDbType.Int);
                cmd.Parameters["@dosyaNo"].Value = Convert.ToInt32(dosyaNo);

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    textBox2_HastaAd.Text = dr[0].ToString();
                    textBox3_HastaSoyad.Text = dr[1].ToString();
                    textBox4_KurumAdi.Text = dr[2].ToString();
                    dateTimePicker1_SevkTarihi.Text = dr[4].ToString();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Kullanici Bulunamadı" + E.ToString());
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
            SevkTarihGirisleri();
        }
        private void SevkTarihGirisleri()
        {
            try
            {
                SqlDataReader dr;
                string dosyaNo = textBox1_DosyaNo.Text;

                cmd = new SqlCommand("SELECT S.sevkTarihi FROM SOHTS.dbo.hasta H, SOHTS.dbo.sevk S WHERE H.dosyaNo = S.dosyaNo and H.dosyaNo =@dosyaNo", SQLBaglanti.SqlBaglan());
                cmd.Parameters.Add("@dosyaNo", SqlDbType.VarChar);
                cmd.Parameters["@dosyaNo"].Value = dosyaNo;

                SQLBaglanti.SqlBaglan().Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                comboBox1_OncekiIslemler.Items.Clear();
                while (dr.Read())
                {
                    comboBox1_OncekiIslemler.Items.Add(dr["sevkTarihi"]);
                }

            }
            catch (Exception E)
            {
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }

        private void button2_OncekiIslemlerGit_Click(object sender, EventArgs e)
        {
            if (comboBox1_OncekiIslemler.Text != "")
            {
                SevkTarihveKullaniciKodaGoreDataGridViewDoldurma();
                ToplamFiyatHesaplama();
            }
            else
                MessageBox.Show("Lütfen Öncelikle Bir İşlem Seçiniz");
        }
        string[] row;
        private void SevkTarihveKullaniciKodaGoreDataGridViewDoldurma()
        {
            dataGridView1_YapilanTahlilVeIslemler.Rows.Clear();
            try
            {
                DateTime sevkTarihx = Convert.ToDateTime(comboBox1_OncekiIslemler.Text);
                string x = String.Format("{0:yyyy/MM/dd}", sevkTarihx);
                string dosyaNo = textBox1_DosyaNo.Text;

                cmd = new SqlCommand("SELECT S.poliklinik, S.sira, S.saat, S.yapilanIslem, S.doktorKod, S.miktar, S.birimFiyat,S.taburcu FROM hasta H, sevk S WHERE H.dosyaNo = H.dosyaNo AND H.dosyaNo = @dosyaNo AND S.sevkTarihi =@x", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();
                cmd.Parameters.Add("@dosyaNo", SqlDbType.VarChar);
                cmd.Parameters["@dosyaNo"].Value = dosyaNo;

                cmd.Parameters.Add("@x", SqlDbType.VarChar);
                cmd.Parameters["@x"].Value = x;

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    row = new string[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString() };
                }
                dataGridView1_YapilanTahlilVeIslemler.Rows.Add(row);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView1_YapilanTahlilVeIslemler.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView1_YapilanTahlilVeIslemler.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView1_YapilanTahlilVeIslemler.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Hasta Sevk İşlemleri : " + textBox2_HastaAd.Text + "  " + textBox3_HastaSoyad.Text, new Font(dataGridView1_YapilanTahlilVeIslemler.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Hasta Sevk İşlemleri : " + textBox2_HastaAd.Text + " " + textBox3_HastaSoyad.Text, new Font(dataGridView1_YapilanTahlilVeIslemler.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new Font(dataGridView1_YapilanTahlilVeIslemler.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dataGridView1_YapilanTahlilVeIslemler.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Hasta Sevk İşlemleri : " + textBox2_HastaAd.Text + "  " + textBox3_HastaSoyad.Text, new Font(new Font(dataGridView1_YapilanTahlilVeIslemler.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);
                           // string toplamtutar = label_ToplamTutar.Text;
                           


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView1_YapilanTahlilVeIslemler.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView1_YapilanTahlilVeIslemler.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Taburcu_Click(object sender, EventArgs e)
        {
            if (textBox1_DosyaNo.Text != "")
            {
                HastaTaburcuEkraniVeri.cikis_tarihi = DateTime.Now;
                HastaTaburcuEkraniVeri.dosyaNo = textBox1_DosyaNo.Text;
                HastaTaburcuEkraniVeri.sevk_tarih = dateTimePicker1_SevkTarihi.Value;
                HastaTaburcuEkraniVeri.toplam_tutar = label_ToplamTutar.Text;

                TaburcuEkrani t = new TaburcuEkrani();
                t.MdiParent = Program.anaekran;
                t.Show();
            }
            else
                MessageBox.Show("Dosya No Alanı Boş Olamaz.");
        }
        string[] doktor_ad_yazdirma, toplam_fiyat_yazdirma, tarih_ad_yazdirma;
        string DOKTOR_AD = "";

        private void button9_BaskiOnIzlemeYap_Click(object sender, EventArgs e)
        {
            if (dataGridView1_YapilanTahlilVeIslemler.RowCount <= 0)
            {
                MessageBox.Show("Lütfen Öncelikle Sorgulama Yapınız.");
                return;
            }

            DOKTOR_AD = DoktorAdSorgulama();

            if (DOKTOR_AD != "" && DOKTOR_AD != null)
            {
                yazdirma_OnizlemeIslemleri();

                PrintPreviewDialog onizleme = new PrintPreviewDialog();
                onizleme.Document = printDocument1;
                onizleme.MdiParent = Program.anaekran;
                onizleme.Show();
                
               // onizleme.ShowDialog();
            }
            else
                MessageBox.Show("Doktor Sorgulama Hatası");

            // işlem sonrasında aktif etmeliyiz
            yazdirma_sirasinda_veri_ekleme_yapildi_FiyatHesaplama_devre_disi = false;
            // yazdirma işlemi için eklediğimiz verileri siliyoruz.
            yazdirmaSonrasiFazlaEkledigimizVerileriSilme();
        }
        bool yazdirma_sirasinda_veri_ekleme_yapildi_FiyatHesaplama_devre_disi = false;
        private void yazdirmaSonrasiFazlaEkledigimizVerileriSilme()
        {
            // listeye toplam 6 veri eklendi
            int countData = dataGridView1_YapilanTahlilVeIslemler.RowCount;
            for (int i = 0; i < 5; i++)
            {
                int x = countData - i;
                dataGridView1_YapilanTahlilVeIslemler.Rows.RemoveAt(x - 1);
                dataGridView1_YapilanTahlilVeIslemler.Refresh();
            }
        }

       

        private void button1_HastaBilgileri_Click(object sender, EventArgs e)
        {
            HastaIslemleriHastaBilgisiAktarma.HastaDosyaNo = textBox1_DosyaNo.Text;
            HastaBilgileri p = new HastaBilgileri();
            p.MdiParent = Program.anaekran;
            p.Show();
        }

        private void button6_Yeni_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeni işlem yapmak istediğinize emin misiniz? Tüm alanlar silinecektir!", "Yeni İşlem", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                selectedIndex = -1;
                textBox1_DosyaNo.Text = "";
                KullaniciIDAramaEkraniTemizle();
            }
        }

        private void button3_BulDosyaNo_Click(object sender, EventArgs e)
        {
            HastaBulmaEkranı d = new HastaBulmaEkranı();
            d.hastaDosyaNoEvent += new HastaBulmaEkranı.DelegeteTanimlamam(HastaBulButonVeriGoldurma);

            HastaIslemleriHastaBilgisiAktarma.HastaDosyaNoBulButon = textBox1_DosyaNo.Text;
            d.MdiParent = Program.anaekran;
            d.Show();
        }

        public void yazdirma_OnizlemeIslemleri()
        {
            // veri eklediğimiz için toplam fiyat hesaplamasını devre dışı bırakmalıyız
            yazdirma_sirasinda_veri_ekleme_yapildi_FiyatHesaplama_devre_disi = true;
            doktor_ad_yazdirma = new string[] { "", "", "", "", DOKTOR_AD, "", "" };
            tarih_ad_yazdirma = new string[] { "", "", "", "", DateTime.Now.ToString(), "", "" };
            toplam_fiyat_yazdirma = new string[] { "", "", "", "", "", "Toplam :", label_ToplamTutar.Text };

            dataGridView1_YapilanTahlilVeIslemler.Rows.Add(" ");
            dataGridView1_YapilanTahlilVeIslemler.Rows.Add(toplam_fiyat_yazdirma);
            dataGridView1_YapilanTahlilVeIslemler.Rows.Add(" ");
            dataGridView1_YapilanTahlilVeIslemler.Rows.Add(doktor_ad_yazdirma);
            dataGridView1_YapilanTahlilVeIslemler.Rows.Add(tarih_ad_yazdirma);
        }

        private void comboBox3_YapilanIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1_Miktar.Value = 1;
            textBox6_birimFiyat.Text = islemFiyat[comboBox3_YapilanIslem.Text];
        }

        private void button4_Ekle_Click(object sender, EventArgs e)
        {
            if (textBox1_DosyaNo.Text != "" && textBox2_HastaAd.Text != "")
            {
                if (comboBox2_PoliklinikAd.Text != "" && comboBox3_YapilanIslem.Text != "" && comboBox4_DoktorKod.Text != "")
                {
                    try
                    {
                        DataGridviewEklemeAyniVeri();
                        EkleVeriTabaniKayıt();
                        islemMenusuTemizleme();
                        SevkTarihGirisleri();
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("İşlem Menüsünde Yer Alan İşlemleri Doldurmanız Gerekmektedir.");
                }
            }
            else
                MessageBox.Show("Dosya No ve Hasta Ad Boş Olamaz");
        }

        private string DoktorAdSorgulama()
        {
            try
            {
                string DOKTOR_KOD = dataGridView1_YapilanTahlilVeIslemler.Rows[0].Cells[4].Value.ToString();
                cmd = new SqlCommand("SELECT kullanici.ad FROM kullanici WHERE unvan = 'Doktor' AND kullaniciKod=@DOKTOR_KOD", SQLBaglanti.SqlBaglan());
                cmd.Parameters.Add("@DOKTOR_KOD", SqlDbType.VarChar);
                cmd.Parameters["@DOKTOR_KOD"].Value = DOKTOR_KOD;

                SQLBaglanti.SqlBaglan().Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    DOKTOR_AD = dr[0].ToString();
                }

                if (DOKTOR_AD != "")
                    return DOKTOR_AD;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }

            return null;
        }
        public void HastaBulButonVeriGoldurma()
        {
            islemMenusuTemizleme();
            KullaniciIDAramaEkraniTemizle();
            dataGridView1_YapilanTahlilVeIslemler.Rows.Clear();
            HastaKullaniciKodIleArama();
        }
        private void islemMenusuTemizleme()
        {
            comboBox2_PoliklinikAd.Text = "";
            textBox5_SiraNo.Text = "";
            comboBox3_YapilanIslem.Text = "";
            comboBox4_DoktorKod.Text = "";
            textBox6_birimFiyat.Text = "";
            numericUpDown1_Miktar.Value = 1;
        }

        private void dataGridView1_YapilanTahlilVeIslemler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                A_poliklinik = dataGridView1_YapilanTahlilVeIslemler.CurrentRow.Cells["Poliklinik"].Value.ToString().Trim();
                A_sira_no = dataGridView1_YapilanTahlilVeIslemler.CurrentRow.Cells["Sıra No"].Value.ToString().Trim();
                A_saat = dataGridView1_YapilanTahlilVeIslemler.CurrentRow.Cells["Saat"].Value.ToString().Trim();
                A_yapilan_islem = dataGridView1_YapilanTahlilVeIslemler.CurrentRow.Cells["Yapılan İşlem"].Value.ToString().Trim();
                A_drKod = dataGridView1_YapilanTahlilVeIslemler.CurrentRow.Cells["Dr. Kodu"].Value.ToString().Trim();
                A_miktar = dataGridView1_YapilanTahlilVeIslemler.CurrentRow.Cells["Miktar"].Value.ToString().Trim();
                A_birimFiyat = dataGridView1_YapilanTahlilVeIslemler.CurrentRow.Cells["Birim Fiyat"].Value.ToString().Trim();

                selectedIndex = dataGridView1_YapilanTahlilVeIslemler.CurrentCell.RowIndex;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void textBox1_DosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dataGridView1_YapilanTahlilVeIslemler_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (yazdirma_sirasinda_veri_ekleme_yapildi_FiyatHesaplama_devre_disi == false)
            {
                ToplamFiyatHesaplama();
            }
        }

        private void button10_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_PoliklinikAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_Miktar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGridviewEklemeAyniVeri()
        {
            saat = DateTime.Now.ToLongTimeString().ToString();
            row = new string[] { comboBox2_PoliklinikAd.Text, textBox5_SiraNo.Text, saat, comboBox3_YapilanIslem.Text, comboBox4_DoktorKod.Text, numericUpDown1_Miktar.Text, textBox6_birimFiyat.Text };
            dataGridView1_YapilanTahlilVeIslemler.Rows.Add(row);
        }

        private void button5_SecSil_Click(object sender, EventArgs e)
        {
            if (textBox1_DosyaNo.Text == "")
            {
                MessageBox.Show("Dosya Numarası Bilgisi Boş Geçilemez.");
                return;
            }
            if (selectedIndex > -1)
            {
                DialogResult result = MessageBox.Show("Seçilen veriyi silmek istediğinize emin misiniz? İşlem geri alınamamaktadır!", "Sil", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    GridViewSecileniSil();
                    // Önceki işlemlerdeki listeye göre 
                    SevkTarihGirisleri();
                }
            }
            else
                MessageBox.Show("Lütfen Listeden Bir Veri Seçin");
            selectedIndex = -1;
        }

        public static string saat;
        private void EkleVeriTabaniKayıt()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = SQLBaglanti.SqlBaglan();
                SQLBaglanti.SqlBaglan().Open();

                cmd.CommandText = "sevk_veri_ekleme_v2";
                cmd.CommandType = CommandType.StoredProcedure;

                string dt = dateTimePicker1_SevkTarihi.Value.Date.ToString("dd-MM-yyyy");
                cmd.Parameters.Add("@sevk_tarih", SqlDbType.SmallDateTime);
                cmd.Parameters["@sevk_tarih"].Value = Convert.ToDateTime(dt);

                cmd.Parameters.Add("@dosyaNo", SqlDbType.VarChar);
                cmd.Parameters["@dosyaNo"].Value = textBox1_DosyaNo.Text;

                cmd.Parameters.Add("@poliklinik", SqlDbType.VarChar);
                cmd.Parameters["@poliklinik"].Value = comboBox2_PoliklinikAd.Text;

                cmd.Parameters.Add("@saat", SqlDbType.NVarChar);
                cmd.Parameters["@saat"].Value = saat;

                cmd.Parameters.Add("@yapilanislem", SqlDbType.VarChar);
                cmd.Parameters["@yapilanislem"].Value = comboBox3_YapilanIslem.Text;

                cmd.Parameters.Add("@doktorKod", SqlDbType.VarChar);
                cmd.Parameters["@doktorKod"].Value = comboBox4_DoktorKod.Text;

                cmd.Parameters.Add("@miktar", SqlDbType.VarChar);
                cmd.Parameters["@miktar"].Value = numericUpDown1_Miktar.Text;

                cmd.Parameters.Add("@birimFiyat", SqlDbType.VarChar);
                cmd.Parameters["@birimFiyat"].Value = textBox6_birimFiyat.Text;

                cmd.Parameters.Add("@sira", SqlDbType.VarChar);
                cmd.Parameters["@sira"].Value = textBox5_SiraNo.Text;

                cmd.Parameters.Add("@toplamTutar", SqlDbType.VarChar);
                cmd.Parameters["@toplamTutar"].Value = label_ToplamTutar.Text;

                cmd.Parameters.Add("@taburcu", SqlDbType.VarChar);
                cmd.Parameters["@taburcu"].Value = "Hayir";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Veriler Kaydedildi.");
                SQLBaglanti.SqlBaglan().Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }
        
        private void GridViewSecileniSil()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = SQLBaglanti.SqlBaglan();
                SQLBaglanti.SqlBaglan().Open();

                cmd.CommandText = "hasta_islemleri_secileni_sil_V2";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@dosyaNo", SqlDbType.Int);
                cmd.Parameters["@dosyaNo"].Value = Convert.ToInt32(textBox1_DosyaNo.Text.Trim());

                cmd.Parameters.Add("@poliklinik", SqlDbType.VarChar);
                cmd.Parameters["@poliklinik"].Value = A_poliklinik.Trim();

                cmd.Parameters.Add("@saat", SqlDbType.NVarChar);
                cmd.Parameters["@saat"].Value = A_saat.Trim();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme Başarılı");
                if (selectedIndex > -1)
                {
                    dataGridView1_YapilanTahlilVeIslemler.Rows.RemoveAt(selectedIndex);
                    dataGridView1_YapilanTahlilVeIslemler.Refresh();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }

        private void textBox5_SiraNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_HastaAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void dataGridView1_YapilanTahlilVeIslemler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = dataGridView1_YapilanTahlilVeIslemler.CurrentCell.RowIndex;
            DialogResult secim = MessageBox.Show("Satırı silmek istediğinize emin misiniz? Veri Tabanından Silinmeyecektir", "Satır Silme İşlemi", MessageBoxButtons.OKCancel);

            if (secim == DialogResult.OK)
            {
                dataGridView1_YapilanTahlilVeIslemler.Rows.RemoveAt(selectedIndex);
                dataGridView1_YapilanTahlilVeIslemler.Refresh();
                ToplamFiyatHesaplama();
            }
        }

        private void DataGridViewSecileniSil()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = SQLBaglanti.SqlBaglan();
                SQLBaglanti.SqlBaglan().Open();

                cmd.CommandText = "hasta_islemleri_secileni_sil";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@dosyaNo", SqlDbType.Int);
                cmd.Parameters["@dosyaNo"].Value = Convert.ToInt32(textBox1_DosyaNo.Text.Trim());

                cmd.Parameters.Add("@poliklinik", SqlDbType.VarChar);
                cmd.Parameters["@poliklinik"].Value = A_poliklinik.Trim();

                cmd.Parameters.Add("@saat", SqlDbType.NVarChar);
                cmd.Parameters["@saat"].Value = A_saat.Trim();

                cmd.Parameters.Add("@yapilanislem", SqlDbType.VarChar);
                cmd.Parameters["@yapilanislem"].Value = A_yapilan_islem.Trim();

                cmd.Parameters.Add("@doktorKod", SqlDbType.VarChar);
                cmd.Parameters["@doktorKod"].Value = A_drKod.Trim();

                cmd.Parameters.Add("@miktar", SqlDbType.VarChar);
                cmd.Parameters["@miktar"].Value = A_miktar.Trim();

                cmd.Parameters.Add("@birimFiyat", SqlDbType.VarChar);
                cmd.Parameters["@birimFiyat"].Value = A_birimFiyat.Trim();

                cmd.Parameters.Add("@sira", SqlDbType.VarChar);
                cmd.Parameters["@sira"].Value = A_sira_no.Trim();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme Başarılı");
                if (selectedIndex > -1)
                {
                    dataGridView1_YapilanTahlilVeIslemler.Rows.RemoveAt(selectedIndex);
                    dataGridView1_YapilanTahlilVeIslemler.Refresh();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }
        private void ToplamFiyatHesaplama()
        {
            int D_miktar = 0, D_birim_fiyat = 0, D_Toplam_Fiyat = 0;
            for (int i = 0; i < dataGridView1_YapilanTahlilVeIslemler.Rows.Count; ++i)
            {
                D_miktar = Convert.ToInt32(dataGridView1_YapilanTahlilVeIslemler.Rows[i].Cells[5].Value);
                D_birim_fiyat = Convert.ToInt32(dataGridView1_YapilanTahlilVeIslemler.Rows[i].Cells[6].Value);
                D_Toplam_Fiyat += (D_miktar * D_birim_fiyat);
            }
            label_ToplamTutar.Text = Convert.ToString(D_Toplam_Fiyat);//çalıştır
        }

    }
}
