using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Akaryakit
{
    public partial class frmAraForm : MetroForm
    {
        public frmAraForm()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }

        private void frmAraForm_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }

        private void tlMuhasebe_Click(object sender, EventArgs e)
        {
            frmMuhasebe m = new frmMuhasebe();
            m.Show();
        }

        private void tlYonetim_Click(object sender, EventArgs e)
        {
            frmStandart st = new frmStandart();
            st.Show();
        }

        private void imgGeri_Click(object sender, EventArgs e)
        {

        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGiris f = new frmGiris();
            f.Show();
        }
    }
}
