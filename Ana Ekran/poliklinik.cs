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
    public partial class poliklinik : Form
    {
        public poliklinik()
        {
            InitializeComponent();
        }
        string gecerlimi;
        private void poliklinik_Load(object sender, EventArgs e)
        {
            GelenVerileriYukle();
        }
        private void GelenVerileriYukle()
        {
            if (PoliklinikVeriAktarimi.poliklinikAd != "" || PoliklinikVeriAktarimi.gecerliMi != "" || PoliklinikVeriAktarimi.poliklinikAciklama != "")
            {
                textBox1_poliklinikPoliklinikAd.Text = PoliklinikVeriAktarimi.poliklinikAd;
                if (PoliklinikVeriAktarimi.gecerliMi == "false")
                {
                    checkBox_poliklinikGecerliMi.Checked = false;
                }
                else
                    checkBox_poliklinikGecerliMi.Checked = true;

                textBox_PoliklinikAciklama.Text = PoliklinikVeriAktarimi.poliklinikAciklama;
            }
            PoliklinikVeriAktarimi.gecerliMi = "";
            PoliklinikVeriAktarimi.poliklinikAciklama = "";
            PoliklinikVeriAktarimi.poliklinikAd = "";
        }
        private void PoliklinikSil()
        {
            SQLBaglanti.SqlBaglan().Open();
            string secmeSorgusu = "SELECT * from poliklinik where poliklinikAdi=@poliklinikadi";
            SqlCommand cmd = new SqlCommand(secmeSorgusu, SQLBaglanti.SqlBaglan());
            cmd.Parameters.AddWithValue("@poliklinikadi", textBox1_poliklinikPoliklinikAd.Text);
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            //DataReader ile poliklinik verilerini veritabanından belleğe aktardık.
            if (dr.Read()) //Datareader herhangi bir okuma yapabiliyorsa aşağıdaki kodlar çalışır.
            {
                string isim = dr["poliklinikAdi"].ToString();
                dr.Close();
                //Datareader ile okunan müşteri ad ve soyadını isim değişkenine atadım.
                //Datareader açık olduğu sürece başka bir sorgu çalıştıramayacağımız için dr nesnesini kapatıyoruz.
                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                
                if (DialogResult.Yes == durum) 
                {
                    string silmeSorgusu = "DELETE from poliklinik where poliklinikAdi=@poliklinikadi";
                    //musterino parametresine bağlı olarak müşteri kaydını silen sql sorgusu
                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, SQLBaglanti.SqlBaglan());
                    silKomutu.Parameters.AddWithValue("@poliklinikadi", textBox1_poliklinikPoliklinikAd.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Poliklinik Silindi.");
                    //Silme işlemini gerçekleştirdikten sonra kullanıcıya mesaj verdik.
                }
            }
            else
                MessageBox.Show("Poliklinik Bulunamadı.");
            SQLBaglanti.SqlBaglan().Close();
        }

        private void button_PoliklinikCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_PoliklinikSil_Click(object sender, EventArgs e)
        {
           
                PoliklinikSil();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poliklinik_tanitma p = new poliklinik_tanitma();
            p.MdiParent = Program.anaekran;
            p.Show();
            this.Close();
        }

        private void button1_PoliklinikGuncelle_Click(object sender, EventArgs e)
        {
          
            // try ile yazacağımız kod denenir:
            try
            {
                if (checkBox_poliklinikGecerliMi.Checked == true)
                {
                    gecerlimi = "true";
                }
                else
                    gecerlimi = "false";
                // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur: 
                SqlCommand cmd = new SqlCommand("UPDATE poliklinik SET poliklinikAdi=@poliklinikadi,durum=@durum,aciklama=@aciklama WHERE poliklinikAdi=@poliklinikadi ", SQLBaglanti.SqlBaglan());


                // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                cmd.Parameters.AddWithValue("@poliklinikadi", textBox1_poliklinikPoliklinikAd.Text);
                cmd.Parameters.AddWithValue("@durum", gecerlimi);
                cmd.Parameters.AddWithValue("@aciklama", textBox_PoliklinikAciklama.Text);
                // Bağlantı kapalı ise açılır:
                SQLBaglanti.SqlBaglan().Open();
                cmd.ExecuteNonQuery();
                SQLBaglanti.SqlBaglan().Close();
                MessageBox.Show("Poliklinik Başarıyla Güncellendi.");
            }

            catch (SqlException)
            {
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu.");
            }
        }
    }
}
