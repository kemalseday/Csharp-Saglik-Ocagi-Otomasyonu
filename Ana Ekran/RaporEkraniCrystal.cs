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
    public partial class RaporEkraniCrystal : Form
    {
        public RaporEkraniCrystal()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = Rapor_Veri_Kaynagı.a;
        }

        private void RaporEkraniCrystal_Load(object sender, EventArgs e)
        {

        }
    }
}
