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

    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select ad,soyad,userName,sifre,yetki from kullanici  where username = @KAdi and sifre = @KParola", SQLBaglanti.SqlBaglan());
                cmd.Parameters.AddWithValue("@KAdi", txt_kullaniciadi.Text);
                cmd.Parameters.AddWithValue("@KParola", txt_sifre.Text);
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                

                if (rd.HasRows) 
                {
                    while (rd.Read()) 
                    {
                        string a = rd["yetki"].ToString();
                        if (a=="False               "||a== "false               ")
                        {
                            ((Form1)this.MdiParent).yetkilikullanicidegilise();
                        }
                        if(a=="True                "||a== "true                ")
                        {
                            ((Form1)this.MdiParent).yetkilikullaniciise();
                        }
               
                            ((Form1)this.MdiParent).ReferanslarAktif();
                            txt_kullaniciadi.Text = "";
                            txt_sifre.Text = "";
                            ((Form1)this.MdiParent).Statusbardoldur(rd["ad"].ToString(), rd["soyad"].ToString());
                           ((Form1)this.MdiParent).KeyPreview = true;
                            this.Close();

                    }
                                     
                }
                else /// Reader SATIR döndüremiyorsa K.Adı Parola Yanlış Demekdir
                {
                    rd.Close();
                    txt_kullaniciadi.Text = "";
                    txt_sifre.Text = "";
                    MessageBox.Show("Kullanıcı Adı veya Parola Hatalı Girilmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cmd.Connection.Close();
            }
            catch // Bağlantı açamayıp Sorgu Çalıştıramıyorsa Veritabanına Ulaşamıyor Demekdir
            {
              
                MessageBox.Show("Veritabanına Ulaşılamıyor.SQL Server Bağlantınızı Kontrol Ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_kullaniciadi.Text.Length > 0 || txt_sifre.Text.Length > 0)
            {
                txt_sifre.Text = "";
                txt_kullaniciadi.Text = "";
            }
            else
                MessageBox.Show("Kullanıcı Adı Veya Şifre Girmelisiniz.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void txt_sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
