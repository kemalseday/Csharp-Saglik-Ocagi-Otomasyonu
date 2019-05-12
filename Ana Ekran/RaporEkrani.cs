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
    public partial class RaporEkrani : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;

        public RaporEkrani()
        {
            InitializeComponent();
        }

        private void RaporEkrani_Load(object sender, EventArgs e)
        {
            DataGridViewStunOlusturma();
            TarihlerDBVeriCekme();
        }
        private void DataGridViewStunOlusturma()
        {
            dataGridView1_rapor.ColumnCount = 7;
            dataGridView1_rapor.Columns[0].Name = "Dosya No";
            dataGridView1_rapor.Columns[1].Name = "T.C Kimlik No";
            dataGridView1_rapor.Columns[2].Name = "Ad";
            dataGridView1_rapor.Columns[3].Name = "Soyad";
            dataGridView1_rapor.Columns[4].Name = "Poliklinik";
            dataGridView1_rapor.Columns[5].Name = "Yapılan İşlem";
            dataGridView1_rapor.Columns[6].Name = "Taburcu Durumu";
        }
        private void TarihlerDBVeriCekme()
        {
            try
            {
                cmd = new SqlCommand("SELECT DISTINCT sevkTarihi FROM sevk", SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    comboBox1_baslangic.Items.Add(dr["sevkTarihi"].ToString());
                    comboBox2_bitis.Items.Add(dr["sevkTarihi"].ToString());
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
        string gelenifade;
     
        private void button4_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string[] row;
        private void RaporDadaGridViewEkleme()
        {

            dataGridView1_rapor.Rows.Clear();
            try
            {
                dataGridView1_rapor.Rows.Clear();
               cmd = new SqlCommand("SELECT H.dosyaNo,H.TC,H.ad,H.soyad,S.poliklinik,S.yapilanIslem,S.taburcu " +
                "FROM hasta H INNER JOIN sevk S ON H.dosyaNo = S.dosyaNo  " + gelenifade, SQLBaglanti.SqlBaglan());
                SQLBaglanti.SqlBaglan().Open();
                //  da = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //dataGridView1_rapor.DataSource = dt;
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while(dr.Read())
                {
                    row = new string[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString() };
                    dataGridView1_rapor.Rows.Add(row);
                }
               
                    }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            finally
            {
                dr.Close();
                SQLBaglanti.SqlBaglan().Close();
            }
        }

        private void button1_Sorgula_Click(object sender, EventArgs e)
        {

            string kosul;
            if (comboBox1_baslangic.Text == "" || comboBox2_bitis.Text == "")
            {
                MessageBox.Show("Lütfen Başlangıç ve Bitiş Tarihi Seçiniz.");
                return;
            }

            DateTime sevkTarihBaslangic = Convert.ToDateTime(comboBox1_baslangic.Text);
            string baslangic_tarih = String.Format("{0:yyyy/MM/dd}", sevkTarihBaslangic);

            DateTime sevkTarihSon = Convert.ToDateTime(comboBox2_bitis.Text);
            string son_tarih = String.Format("{0:yyyy/MM/dd}", sevkTarihSon);

            if (radioButton1_taburcuOlmus.Checked == true)
            {
                kosul = "WHERE taburcu = 'Evet' OR taburcu = 'evet' AND sevkTarihi >='" + baslangic_tarih + "' AND sevkTarihi <='" + son_tarih + "'";
                gelenifade = kosul;
                RaporDadaGridViewEkleme();
            }

            if (radioButton2_TaburcuOlmamıs.Checked == true)
            {
                kosul = "WHERE taburcu='Hayir' AND sevkTarihi >='" + baslangic_tarih + "' AND sevkTarihi <='" + son_tarih + "'";
                gelenifade = kosul;
                RaporDadaGridViewEkleme();
            }

            if (radioButton3_hepsi.Checked == true)
            {
                kosul = "WHERE sevkTarihi >='" + baslangic_tarih + "' AND sevkTarihi <='" + son_tarih + "'";
                gelenifade = kosul;
                RaporDadaGridViewEkleme();
            }
        }

        private void button2_temizle_Click(object sender, EventArgs e)
        {
            comboBox1_baslangic.Text = "";
            comboBox2_bitis.Text = "";
            radioButton3_hepsi.Checked = true;
        }



        private void button3_Yazdir_Click(object sender, EventArgs e)
        {


        }

        private void button3_Yazdir_Click_1(object sender, EventArgs e)
        {
             try
            {
            SQLBaglanti.SqlBaglan().Open();
            CrystalReport1 cr = new CrystalReport1();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT H.dosyaNo,H.TC,H.ad,H.soyad,S.poliklinik " +
          "FROM hasta H INNER JOIN sevk S ON H.dosyaNo = S.dosyaNo  " + gelenifade, SQLBaglanti.SqlBaglan());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "hasta");
            SQLBaglanti.SqlBaglan().Close();
            cr.SetDataSource(ds);
            Rapor_Veri_Kaynagı.a = cr;
            SQLBaglanti.SqlBaglan().Close();
            RaporEkraniCrystal a = new RaporEkraniCrystal();
            a.MdiParent = Program.anaekran;
                a.Show();
                
                


            }
            catch(Exception)
            {
                MessageBox.Show(e.ToString());
           }
        }
    }
}
