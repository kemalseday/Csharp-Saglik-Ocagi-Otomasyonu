using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ana_Ekran
{
    public partial class Form1 : Form
    {
        Form login;
        public Form1()
        {
            InitializeComponent();
            referanslarToolStripMenuItem.Visible = false;
            hastaKabulToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
           login = new Login();
            FormAc(login);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           toolStripStatusLabel6.Text= "Tarih : "+DateTime.Now.ToShortDateString();
            Program.anaekran = this; //tüm program içinde tek ekran formun bu form olduğunu belirtiyoruz.
            IsMdiContainer = true;
            referanslarToolStripMenuItem.Visible = false;
            hastaKabulToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
                   

        }
       public void FormAc(Form AcilacakForm)
        {
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                //Eğer Form2 Form1 üzrinde açıldıysa
                if (form.Text == AcilacakForm.Text)
                {
                    // açıksa true 
                    durum = true;
                    // Form 2 Aktif Edildi
                    form.Activate();
                    form.Show();
                }
                else
                    form.Close();
            }

            // Form2 Form1 üzerinde açık değilse
            if (!durum)
            {
               AcilacakForm.MdiParent = this;
               AcilacakForm.Show();
            }
        }
        public void yetkilikullanicidegilise()
        {
            poliklinikTanıtmaToolStripMenuItem.Enabled = false;
            kullanıcıTanıtmaToolStripMenuItem.Enabled = false;   
        }
        public void yetkilikullaniciise()
        {
            poliklinikTanıtmaToolStripMenuItem.Enabled = true;
            kullanıcıTanıtmaToolStripMenuItem.Enabled = true;
        }
        public void ReferanslarAktif()
        {
            hastaKabulToolStripMenuItem.Enabled = true;
            raporlarToolStripMenuItem.Enabled = true;
            referanslarToolStripMenuItem.Visible = true;

         
        }
        public void Statusbardoldur(string ad,string soyad)
        {
            toolStripStatusLabel1.Text="Hoşgeldiniz :"+ad;
            toolStripStatusLabel2.Text = soyad;
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.KeyPreview = false;
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel1.Text = "";
            hastaKabulToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
            referanslarToolStripMenuItem.Visible = false;
            login = new Login();
            FormAc(login);
        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanici_tanitma kullanicifrm = new kullanici_tanitma();
            FormAc(kullanicifrm);
        }

        private void poliklinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poliklinik_tanitma poliklinikfrm = new poliklinik_tanitma();
            FormAc(poliklinikfrm);
        }

        private void hastaİşlemleriF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hastaİslemleri hastaislemleri = new Hastaİslemleri();
            FormAc(hastaislemleri);
        }

        private void hastaKabulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F3)
            {
                hastaİşlemleriF2ToolStripMenuItem_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.F4)
            {
                raporlamaToolStripMenuItem_Click(this, new EventArgs());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = DateTime.Now.Hour.ToString() +":" +DateTime.Now.Minute.ToString()+":" + DateTime.Now.Second.ToString();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void referanslarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporEkrani raporekrani = new RaporEkrani();
            FormAc(raporekrani);
        }
    }
}
