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

namespace Ana_Ekran
{
    public partial class TaburcuEkrani : Form
    {
        public TaburcuEkrani()
        {
            InitializeComponent();
        }

        private void TaburcuEkrani_Load(object sender, EventArgs e)
        {
            VerileriDoldur();
        }

        SqlCommand cmd;
        private void cikisIslemiDBKayit()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = SQLBaglanti.SqlBaglan();
                SQLBaglanti.SqlBaglan().Open();

                cmd.CommandText = "hasta_cikis_veri_kayit";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@dosya_no", SqlDbType.Int);
                cmd.Parameters["@dosya_no"].Value = Convert.ToInt32(textBox1_DosyaNo.Text.Trim());

                DateTime sevkTarihx = Convert.ToDateTime(comboBox1_sevkTarihi.Text.Trim());
                string x = String.Format("{0:yyyy/MM/dd}", sevkTarihx);

                cmd.Parameters.Add("@sevk_tarih", SqlDbType.DateTime);
                cmd.Parameters["@sevk_tarih"].Value = Convert.ToDateTime(x);

                cmd.Parameters.Add("@cikis_tarihi", SqlDbType.DateTime);
                cmd.Parameters["@cikis_tarihi"].Value = Convert.ToDateTime(comboBox2_cikisTarihi.Text.Trim());

                cmd.Parameters.Add("@odeme_sekli", SqlDbType.VarChar);
                cmd.Parameters["@odeme_sekli"].Value = comboBox3_OdemeSekli.Text.Trim();

                cmd.Parameters.Add("@toplam_tutar", SqlDbType.VarChar);
                cmd.Parameters["@toplam_tutar"].Value = comboBox4_ToplamTutar.Text.Trim();

                cmd.Parameters.Add("@taburcu", SqlDbType.VarChar);
                cmd.Parameters["@taburcu"].Value = "Evet";

                cmd.ExecuteNonQuery();
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
        private void VerileriDoldur()
        {
            textBox1_DosyaNo.Text = HastaTaburcuEkraniVeri.dosyaNo;
            comboBox1_sevkTarihi.Text = HastaTaburcuEkraniVeri.sevk_tarih.ToString();
            comboBox2_cikisTarihi.Text = HastaTaburcuEkraniVeri.cikis_tarihi.ToString();
            comboBox4_ToplamTutar.Text = HastaTaburcuEkraniVeri.toplam_tutar;

           
        }

        private void button1_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1_DosyaNo.Text != "" && comboBox1_sevkTarihi.Text != "" && comboBox2_cikisTarihi.Text != "" && comboBox3_OdemeSekli.Text != "")
                {
                    if (comboBox4_ToplamTutar.Text == "")
                    {
                        DialogResult result = MessageBox.Show("Toplam Tutar Bulunamadı. Hastayı Yinede Taburcu Etmek İstiyor Musunuz?", "Fiyat Uyarısı", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            comboBox4_ToplamTutar.Text = "0";
                            cikisIslemiDBKayit();
                            MessageBox.Show("Hasta Taburcu İşlemi Gerçekleştirildi.");
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        cikisIslemiDBKayit();
                        MessageBox.Show("Hasta Taburcu İşlemi Gerçekleştirildi.");
                    }
                       
                    // aynı zamanda Sevk tablosundaki taburcu kısmı evet olarak doldurulur.
                }
                else
                {
                    MessageBox.Show("Tüm Alanlar Dolu Olmalıdır.");
                    return;
                }
                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void button3_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
