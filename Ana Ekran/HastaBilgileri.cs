﻿using System;
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
    public partial class HastaBilgileri : Form
    {
        public HastaBilgileri()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        SqlCommand cmd;
        private void HastaBilgileri_Load(object sender, EventArgs e)
        {
            KullaniciBilgileriEkranaYazdir();
          
            label_islem_tamamlandi.Hide();
        }
        private void KullaniciBilgileriEkranaYazdir()
        {
            try
            {
                cmd = new SqlCommand("Select * FROM hasta WHERE dosyaNo=@HastaDosyaNo", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();
                cmd.Parameters.Add("@HastaDosyaNo", SqlDbType.VarChar);
                cmd.Parameters["@HastaDosyaNo"].Value = HastaIslemleriHastaBilgisiAktarma.HastaDosyaNo.Trim();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    textBox3_TC.Text = dr[0].ToString();
                    textBox1_DosyaNo.Text = dr[1].ToString();
                    textBox2_Ad.Text = dr[2].ToString();
                    textBox4_Soyad.Text = dr[3].ToString();
                    textBox5_DogumYeri.Text = dr[4].ToString();
                    dateTimePicker1_DogumTarihi.Text = dr[5].ToString();
                    textBox6_BabaAd.Text = dr[6].ToString();
                    textBox7_AnneAd.Text = dr[7].ToString();
                    comboBox1_Cinsiyet.Text = dr[8].ToString();
                    comboBox2_KanGrubu.Text = dr[9].ToString();
                    textBox9_TelefonNo.Text = dr[10].ToString();
                    textBox8_Adres.Text = dr[11].ToString();
                    textBox1_YakinAdres.Text = dr[12].ToString();
                    textBox10_KurumSicilNo.Text = dr[13].ToString();
                    textBox11_KurumAdi.Text = dr[14].ToString();
                    textBox12_YakinTelefonNo.Text = dr[15].ToString();
                    textBox1_YakinKurumSicilNO.Text = dr[16].ToString();
                    textBox2_YakinKurumAd.Text = dr[17].ToString();
                }
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
        private string TCKimlikVeriTabaniKontrol()
        {
            try
            {
                string TC = textBox3_TC.Text;
                cmd = new SqlCommand("SELECT dosyaNo FROM hasta WHERE TC=@TC", SQLBaglanti.SqlBaglan());
                cmd.Parameters.Add("@TC", SqlDbType.VarChar);
                cmd.Parameters["@TC"].Value = TC;

                SQLBaglanti.SqlBaglan().Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    return dr[0].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }

            return "-1";
        }
        private string dosyanumarasıkontrol()
        {
            try
            {
                string TC = textBox3_TC.Text;
                cmd = new SqlCommand("SELECT dosyaNo FROM hasta WHERE dosyaNo=@dosyano", SQLBaglanti.SqlBaglan());
                cmd.Parameters.Add("@dosyano", SqlDbType.VarChar);
                cmd.Parameters["@dosyano"].Value = TC;

                SQLBaglanti.SqlBaglan().Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    return dr[0].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }

            return "-1";
        }
        private void YeniHastaKayit()
        {
            HastaVerileriUpdateKayit("yeni_hasta_kayit");
        }

        private void HastaVerileriUpdateKayit(string ProcedurIsmi)
        {
            label_islem_tamamlandi.Hide();
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = SQLBaglanti.SqlBaglan();
                SQLBaglanti.SqlBaglan().Open();

                cmd.CommandText = ProcedurIsmi;
                cmd.CommandType = CommandType.StoredProcedure;

                if (ProcedurIsmi != "yeni_hasta_kayit")
                {
                    cmd.Parameters.Add("@DosyaNo", SqlDbType.Int);
                    cmd.Parameters["@DosyaNo"].Value = Convert.ToInt32(textBox1_DosyaNo.Text);
                }

                cmd.Parameters.Add("@Ad", SqlDbType.VarChar);
                cmd.Parameters["@Ad"].Value = textBox2_Ad.Text;

                cmd.Parameters.Add("@Soyad", SqlDbType.VarChar);
                cmd.Parameters["@Soyad"].Value = textBox4_Soyad.Text;

                cmd.Parameters.Add("@DogumYeri", SqlDbType.VarChar);
                cmd.Parameters["@DogumYeri"].Value = textBox5_DogumYeri.Text;

                cmd.Parameters.Add("@DogumTarihi", SqlDbType.DateTime);
                cmd.Parameters["@DogumTarihi"].Value = dateTimePicker1_DogumTarihi.Value;

                cmd.Parameters.Add("@BabaAd", SqlDbType.VarChar);
                cmd.Parameters["@BabaAd"].Value = textBox6_BabaAd.Text;

                cmd.Parameters.Add("@AnneAd", SqlDbType.VarChar);
                cmd.Parameters["@AnneAd"].Value = textBox7_AnneAd.Text;

                cmd.Parameters.Add("@Cinsiyet", SqlDbType.VarChar);
                cmd.Parameters["@Cinsiyet"].Value = comboBox1_Cinsiyet.Text;

                cmd.Parameters.Add("@KanGrubu", SqlDbType.VarChar);
                cmd.Parameters["@KanGrubu"].Value = comboBox2_KanGrubu.Text;

                cmd.Parameters.Add("@telNo", SqlDbType.VarChar);
                cmd.Parameters["@telNo"].Value = textBox9_TelefonNo.Text;

                cmd.Parameters.Add("@Adres", SqlDbType.VarChar);
                cmd.Parameters["@Adres"].Value = textBox8_Adres.Text;

                cmd.Parameters.Add("@yakinAdres", SqlDbType.VarChar);
                cmd.Parameters["@yakinAdres"].Value = textBox1_YakinAdres.Text;

                cmd.Parameters.Add("@KrumScilNo", SqlDbType.VarChar);
                cmd.Parameters["@KrumScilNo"].Value = textBox10_KurumSicilNo.Text;

                cmd.Parameters.Add("@KrumAd", SqlDbType.VarChar);
                cmd.Parameters["@KrumAd"].Value = textBox11_KurumAdi.Text;

                cmd.Parameters.Add("@YakinTelNo", SqlDbType.VarChar);
                cmd.Parameters["@YakinTelNo"].Value = textBox12_YakinTelefonNo.Text;

                cmd.Parameters.Add("@YakinKurumSicilNo", SqlDbType.VarChar);
                cmd.Parameters["@YakinKurumSicilNo"].Value = textBox1_YakinKurumSicilNO.Text;

                cmd.Parameters.Add("@YakinKurumAd", SqlDbType.VarChar);
                cmd.Parameters["@YakinKurumAd"].Value = textBox2_YakinKurumAd.Text;

                cmd.Parameters.Add("@TC", SqlDbType.VarChar);
                cmd.Parameters["@TC"].Value = textBox3_TC.Text;

                cmd.Parameters.Add("@MedeniHal", SqlDbType.VarChar);
                cmd.Parameters["@MedeniHal"].Value = comboBox3_MedeniHal.Text;

                cmd.ExecuteNonQuery();
                label_islem_tamamlandi.Show();
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

        private void button1_Yeni_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeni Kullanıcı Eklemek İçin Ekrandaki Veriler Silinecektir! Onaylıyor Musunuz?", "Yeni Kullanıcı Ekleme Uyarı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                label_islem_tamamlandi.Hide();
                FormTemizle();
                dosyasayisisorgula();
            }
        }
        public void dosyasayisisorgula()
        {
            SQLBaglanti.SqlBaglan().Open();
            SqlCommand cmd = new SqlCommand("SELECT top 1 dosyaNo FROM hasta order by dosyaNo desc ", SQLBaglanti.SqlBaglan());
            int kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            SQLBaglanti.SqlBaglan().Close();
            kayitSayisi++;
            textBox1_DosyaNo.Text = kayitSayisi.ToString();
        }

        private void FormTemizle()
        {
            textBox3_TC.Text = "";
            textBox1_DosyaNo.Text = "";
            textBox2_Ad.Text = "";
            textBox4_Soyad.Text = "";
            textBox5_DogumYeri.Text = "";
            dateTimePicker1_DogumTarihi.Text = "";
            textBox6_BabaAd.Text = "";
            textBox7_AnneAd.Text = "";
            comboBox1_Cinsiyet.Text = "";
            comboBox2_KanGrubu.Text = "";
            textBox9_TelefonNo.Text = "";
            textBox8_Adres.Text = "";
            textBox1_YakinAdres.Text = "";
            textBox10_KurumSicilNo.Text = "";
            textBox11_KurumAdi.Text = "";
            textBox12_YakinTelefonNo.Text = "";
            textBox1_YakinKurumSicilNO.Text = "";
            textBox2_YakinKurumAd.Text = "";
        }

        private void button3_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Kaydet_Click(object sender, EventArgs e)
        {
            string kontrol = TCKimlikVeriTabaniKontrol().Trim();
          
            if (kontrol == "-1")
            {
                DialogResult result = MessageBox.Show("Yeni Hasta Kayıt İşlemini Onaylıyor Musunuz? İşlem Geri Alınamamaktadır!", "Kullanıcı Kayıt Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // kayit yoksa yeniden kayit açar
                    YeniHastaKayit();
                }
                MessageBox.Show("Yeni Hasta Kaydı Başarıyla Oluşturuldu.");
                FormTemizle();
            }
            else
            {
                textBox1_DosyaNo.Text = TCKimlikVeriTabaniKontrol().Trim();
                HastaVerileriUpdateKayit("hasta_bilgileri_update");
                MessageBox.Show("Hasta Bilgileri Başarıyla Güncellendi.");
                //DialogResult result = MessageBox.Show("Hasta Kaydı Daha Önce Oluşturulmuş.", "Kullanıcı Kayıt Uyarı", MessageBoxButtons.YesNo);
                FormTemizle();
            }

        }

        private void button1_hastaKayitSorgula_Click(object sender, EventArgs e)
        {
            string kontrol = TCKimlikVeriTabaniKontrol().Trim();
            if (kontrol == "-1")
            {
                label19_kayıtsonuc.BackColor = Color.Red;
                label19_kayıtsonuc.Text=("Kayıt Yok.");
            }
            else
            {
                label19_kayıtsonuc.BackColor = Color.Green;
                label19_kayıtsonuc.Text = ("Kayıt Var.");
            }
               

        }
    }
}
