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
    public partial class kullanici_tanitma : Form
    {
        public kullanici_tanitma()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataReader dr;
        public void KayitliKullaniciEkranaBas()
        {
            try
            {
                cmd = new SqlCommand("SELECT userName From kullanici", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["username"].ToString().Trim());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }
        private void kullanici_tanitma_Load(object sender, EventArgs e)
        {
            KayitliKullaniciEkranaBas();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aranan_kullanici = comboBox1.Text;

            bool poliklinik_ac_bool = KullaniciTanitmaKullaniciEkraniAc(aranan_kullanici);
            // false geri dönüş var ise veri var demektir
            if (poliklinik_ac_bool == false)
            {
                kullanici p = new kullanici();
                p.MdiParent = Program.anaekran;
                p.Show();
                this.Hide();
            }
        }
        public bool KullaniciTanitmaKullaniciEkraniAc(string kullanici_userName)
        {
            try
            {
                cmd = new SqlCommand("SELECT * From kullanici WHERE userName = @kullanici_userName", SQLBaglanti.SqlBaglan());
                cmd.Parameters.Add("@kullanici_userName", SqlDbType.VarChar);
                cmd.Parameters["@kullanici_userName"].Value = kullanici_userName;

                SQLBaglanti.SqlBaglan().Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KullaniciVeriAktarimi.kullaniciUserName = dr["userName"].ToString();
                    if (KullaniciVeriAktarimi.kullaniciUserName != "")
                    {
                        return false;
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Devam Etmek İstiyormusunuz?","Uyarı",MessageBoxButtons.YesNo);
            
            if (onay == DialogResult.Yes)
            {
                kayıteklemekontrol.a = onay.ToString();
                kullanici kullaniciekle = new kullanici();
                //  kullaniciekle.kayitsayisisorgula();
                buttonclick.button = true;
                kullaniciekle.MdiParent = Program.anaekran;
                kullaniciekle.Show();
                this.Hide();
            }
            
              //  this.Close();

        }
     

    }
}
