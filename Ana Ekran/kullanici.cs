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
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
            buttonclick.button = false;
            yetkilimi = "false";
        }
        string yetkilimi;
       
        SqlCommand cmd;
        SqlDataReader dr;
        private void kullanici_Load(object sender, EventArgs e)
        {
            if (buttonclick.button == true)
            {
                button1_Kaydet.Visible = true;
            }
            else
            {
                button1_Kaydet.Visible = false;
            }
            if (KullaniciVeriAktarimi.kullaniciUserName != "")
            {
                VarOlanKullaniciVerileriYukleme();
            }
           kayitsayisisorgula();
        }
        private void VarOlanKullaniciVerileriYukleme()
        {
            cmd = new SqlCommand("SELECT * From kullanici WHERE userName=@userName", SQLBaglanti.SqlBaglan());
            cmd.Parameters.Add("@userName", SqlDbType.VarChar);
            cmd.Parameters["@userName"].Value = KullaniciVeriAktarimi.kullaniciUserName;
            try
            {
                SQLBaglanti.SqlBaglan().Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1_KullaniciKod.Text = dr["kullaniciKod"].ToString().Trim();
                    textBox_TC.Text = dr["TC"].ToString().Trim();
                    textBox_DogumYeri.Text = dr["dogumYeri"].ToString().Trim();
                    textBox_BabaAdi.Text = dr["babaAd"].ToString().Trim();
                    textBox_AnneAdi.Text = dr["anneAd"].ToString().Trim();
                    textBox_CepTel.Text = dr["cepTelefonNo"].ToString().Trim();
                    textBox_EvTel.Text = dr["evTelefonNo"].ToString().Trim();
                    textBox_Ad.Text = dr["ad"].ToString().Trim();
                    textBox_Soyad.Text = dr["soyad"].ToString().Trim();
                    dateTimePicker1_isBaslama.Text = dr["isBaslamaTarih"].ToString().Trim();
                    dateTimePicker2_DogumTarihi.Text = dr["dogumTarihi"].ToString().Trim();
                    comboBox1_cinsiyet.Text = dr["cinsiyet"].ToString().Trim();
                    comboBox2_MedeniHal.Text = dr["medeniHal"].ToString().Trim();
                    textBox_adres.Text = dr["adres"].ToString().Trim();
                    comboBox3_KanGrubu.Text = dr["kanGrubu"].ToString().Trim();
                    textBoxMaas.Text = dr["maas"].ToString().Trim();
                    comboBox1_Unvan.Text = dr["unvan"].ToString().Trim();
                    textBox_KullaniciAd.Text = dr["userName"].ToString().Trim();
                    textBox_Sifre.Text = dr["sifre"].ToString().Trim();
                    string yetki_belgesi = dr["yetki"].ToString().Trim();

                    if (yetki_belgesi == "True")
                    {
                        checkBox_yetkiliKullaniciMi.Checked = true;
                    }
                    else
                        checkBox_yetkiliKullaniciMi.Checked = false;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }

        private void button1_Kaydet_Click(object sender, EventArgs e)
        {
                
           

            try
            {
             
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                
                string kayit = "insert into kullanici(ad,soyad,sifre,yetki,evTelefonNo,cepTelefonNo,adres,unvan,isBaslamaTarih,maas,dogumYeri,anneAd,babaAd,cinsiyet,kanGrubu,medeniHal,dogumTarihi,TC,userName) values (@ad,@soyad,@sifre,@yetki,@evTelefonNo,@cepTelefonNo,@adres,@unvan,@isBaslamaTarih,@maas,@dogumYeri,@anneAd,@babaAd,@cinsiyet,@kanGrubu,@medeniHal,@dogumTarihi,@TC,@userName)";
                SQLBaglanti.SqlBaglan().Open();
                //tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, SQLBaglanti.SqlBaglan());
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@ad", textBox_Ad.Text);
                komut.Parameters.AddWithValue("@soyad", textBox_Soyad.Text);
                komut.Parameters.AddWithValue("@sifre", textBox_Sifre.Text);
                komut.Parameters.AddWithValue("@yetki", yetkilimi.ToString());//dikkat
                komut.Parameters.AddWithValue("@evTelefonNo", textBox_EvTel.Text);
                komut.Parameters.AddWithValue("@cepTelefonNo", textBox_CepTel.Text);
                komut.Parameters.AddWithValue("@adres", textBox_adres.Text);
                komut.Parameters.AddWithValue("@unvan", comboBox1_Unvan.Text);//
                komut.Parameters.AddWithValue("@isBaslamaTarih", dateTimePicker1_isBaslama.Value);
                komut.Parameters.AddWithValue("@maas", textBoxMaas.Text);
                komut.Parameters.AddWithValue("@dogumYeri", textBox_DogumYeri.Text);
                komut.Parameters.AddWithValue("@anneAd", textBox_AnneAdi.Text);
                komut.Parameters.AddWithValue("@babaAd", textBox_BabaAdi.Text);
                komut.Parameters.AddWithValue("@cinsiyet", comboBox1_cinsiyet.Text);
                komut.Parameters.AddWithValue("@kanGrubu", comboBox3_KanGrubu.Text);
                komut.Parameters.AddWithValue("@medeniHal", comboBox2_MedeniHal.Text);
                komut.Parameters.AddWithValue("@dogumTarihi", dateTimePicker2_DogumTarihi.Value);
                komut.Parameters.AddWithValue("@TC", textBox_TC.Text);
                komut.Parameters.AddWithValue("@userName", textBox_KullaniciAd.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                SQLBaglanti.SqlBaglan().Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
            }

            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void checkBox_yetkiliKullaniciMi_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_yetkiliKullaniciMi.Checked==true)
            {
                yetkilimi ="True";

            }
            else
            {
                yetkilimi = "False";
            }
        }
        public void kayitsayisisorgula()
        {
            if (kayıteklemekontrol.a == "Yes")
            {
                SQLBaglanti.SqlBaglan().Open();
                SqlCommand cmd = new SqlCommand("SELECT top 1 kullaniciKod FROM kullanici order by kullaniciKod desc ", SQLBaglanti.SqlBaglan());
                int kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
                SQLBaglanti.SqlBaglan().Close();
                kayitSayisi++;
                foreach (TextBox txt in this.Controls.OfType<TextBox>())
                {
                    txt.Text = "";
                }
                foreach (ComboBox cmb in this.Controls.OfType<ComboBox>())
                {
                    cmb.Text = "";
                }
                foreach ( CheckBox chk in this.Controls.OfType<CheckBox>())
                {
                    chk.Checked = false;
                }
                foreach (DateTimePicker dtp in this.Controls.OfType<DateTimePicker>())
                {
                    dtp.Text = "";
                }
                textBox1_KullaniciKod.Text = kayitSayisi.ToString();
            }
        }

        private void button4_Cikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Guncelle_Click(object sender, EventArgs e)
        {
            string a;
            if (checkBox_yetkiliKullaniciMi.Checked == true)
                a = "true";
            else a = "false";
            // try ile yazacağımız kod denenir:
            try {
                
                // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur: 
                SqlCommand cmd = new SqlCommand("UPDATE kullanici SET ad=@ad,soyad=@soyad,sifre=@sifre,yetki=@yetki,evTelefonNo=@evtel,cepTelefonNo=@ceptel,adres=@adres,unvan=@unvan,isBaslamaTarih=@isebaslama,maas=@maas,dogumYeri=@dogumyeri,anneAd=@annead,babaAd=@babaad,cinsiyet=@cinsiyet,kanGrubu=@kangrubu,medeniHal=@medenihal,dogumTarihi=@dogumtarihi,TC=@tckimlikno,userName=@username WHERE kullaniciKod=@kodu ", SQLBaglanti.SqlBaglan());

      
                // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                cmd.Parameters.AddWithValue("@ad", textBox_Ad.Text);
                cmd.Parameters.AddWithValue("@soyad", textBox_Soyad.Text);
                cmd.Parameters.AddWithValue("@sifre", textBox_Sifre.Text);
                cmd.Parameters.AddWithValue("@yetki", a.ToString());
                cmd.Parameters.AddWithValue("@evtel", textBox_EvTel.Text);
                cmd.Parameters.AddWithValue("@ceptel", textBox_CepTel.Text);
                cmd.Parameters.AddWithValue("@adres", textBox_adres.Text);
                cmd.Parameters.AddWithValue("@unvan", comboBox1_Unvan.Text);
                cmd.Parameters.AddWithValue("@isebaslama", dateTimePicker1_isBaslama.Value);
                cmd.Parameters.AddWithValue("@maas", textBoxMaas.Text);
                cmd.Parameters.AddWithValue("@dogumyeri", textBox_DogumYeri.Text);
                cmd.Parameters.AddWithValue("@annead", textBox_AnneAdi.Text);
                cmd.Parameters.AddWithValue("@babaad", textBox_BabaAdi.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", comboBox1_cinsiyet.Text);
                cmd.Parameters.AddWithValue("@kangrubu", comboBox3_KanGrubu.Text);
                cmd.Parameters.AddWithValue("@medenihal", comboBox2_MedeniHal.Text);
                cmd.Parameters.AddWithValue("@dogumtarihi", dateTimePicker2_DogumTarihi.Value);
                cmd.Parameters.AddWithValue("@tckimlikno", textBox_TC.Text);
                cmd.Parameters.AddWithValue("@username", textBox_KullaniciAd.Text);
                cmd.Parameters.AddWithValue("@kodu",  textBox1_KullaniciKod.Text);
                SQLBaglanti.SqlBaglan().Open();
                cmd.ExecuteNonQuery();
                SQLBaglanti.SqlBaglan().Close();
                MessageBox.Show("Kullanıcı Bilgileri Başarıyla Güncellendi.");
            }

            catch (SqlException)
            {
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu.");
            }
        }

        private void button3_Sil_Click(object sender, EventArgs e)
        {
            try
            {

                // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur: 
                SqlCommand cmd = new SqlCommand("Delete from kullanici WHERE kullaniciKod=@kodu ", SQLBaglanti.SqlBaglan());


                // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                cmd.Parameters.AddWithValue("@kodu", textBox1_KullaniciKod.Text);
                SQLBaglanti.SqlBaglan().Open();
                cmd.ExecuteNonQuery();
                SQLBaglanti.SqlBaglan().Close();
                MessageBox.Show("Kullanıcı Silme Başarıyla Gerçekleşti.");
                kullanici_tanitma p = new kullanici_tanitma();
                p.MdiParent = Program.anaekran;
                p.Show();
                this.Close();


            }

            catch (SqlException)
            {
                MessageBox.Show("Silme İşlemi Sırasında Bir Hata Oluştu.");
            }
        }
     
    }
}
