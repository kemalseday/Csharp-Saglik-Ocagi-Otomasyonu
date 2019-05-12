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
    public partial class poliklinik_tanitma : Form
    {
        public poliklinik_tanitma()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataReader dr;
        public void poliklinikIsimOkuma()
        {
            try
            {
                cmd = new SqlCommand("SELECT poliklinikAdi From poliklinik", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["poliklinikAdi"].ToString());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri Tabanına Bağlanırken Hata Oluştu." + E.ToString());
                return;
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
        }
        private void poliklinik_tanitma_Load(object sender, EventArgs e)
        {
            poliklinikIsimOkuma();
        }
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox1.Text != "")
            {
                try
                {
                    //Kayi varsa diğer formu açar ve kayıtları doldurur.
                    string poliklinikGirisAd = comboBox1.Text;
                    bool poliklinik_ac_bool = PoliklinikVeriGirisiKayitVarMi(poliklinikGirisAd);
                    // false geri dönüş var ise veri var demektir gerisine gerek yok
                    if (poliklinik_ac_bool == false)
                        return;

                    DialogResult result = MessageBox.Show("Böyle Bir Kayit Bulunamadı, Yeni Bir Kayit Oluşturmak İster Misiniz?", "Poliklinik Bulunamadı", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        comboBox1.Text = "";
                        checkBox1.Checked = false;
                    }
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            PoliklinikVeriAktarimi.poliklinikAd = comboBox1.Text;
                            cmd = new SqlCommand("INSERT INTO poliklinik (poliklinikAdi) VALUES(@PoliklinikAd)", SQLBaglanti.SqlBaglan());

                            cmd.Parameters.Add("@PoliklinikAd", SqlDbType.VarChar);
                            cmd.Parameters["@PoliklinikAd"].Value = PoliklinikVeriAktarimi.poliklinikAd;

                            SQLBaglanti.SqlBaglan().Open();
                            cmd.ExecuteNonQuery();

                            poliklinik p = new poliklinik();
                            p.MdiParent = Program.anaekran;
                            p.Show();
                            this.Close();
                        }
                        catch (Exception E)
                        {
                            MessageBox.Show("Hata : ", E.ToString());
                        }
                        finally
                        {
                            SQLBaglanti.SqlBaglan().Close();
                        }
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show("Hata : " + E.ToString());
                }
            }

        }
        public bool PoliklinikVeriGirisiKayitVarMi(string poliklinikAd)
        {
            try
            {
                cmd = new SqlCommand("SELECT * From poliklinik WHERE poliklinikAdi = @PoliklinikAd", SQLBaglanti.SqlBaglan());
                cmd.Parameters.Add("@PoliklinikAd", SqlDbType.VarChar);
                cmd.Parameters["@PoliklinikAd"].Value = poliklinikAd;
                SQLBaglanti.SqlBaglan().Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PoliklinikVeriAktarimi.gecerliMi = dr["durum"].ToString();
                    PoliklinikVeriAktarimi.poliklinikAciklama = dr["aciklama"].ToString();
                    PoliklinikVeriAktarimi.poliklinikAd = dr["poliklinikAdi"].ToString();
                    if (PoliklinikVeriAktarimi.poliklinikAd != "" || PoliklinikVeriAktarimi.gecerliMi != "" || PoliklinikVeriAktarimi.poliklinikAciklama != "")
                    {
                        poliklinik p = new poliklinik();
                        p.MdiParent = Program.anaekran;
                        p.Show();
                        this.Close();
                        return false;
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri Tabanı Bağlantı Hatası." + E.ToString());
            }
            finally
            {
                SQLBaglanti.SqlBaglan().Close();
            }
            return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
