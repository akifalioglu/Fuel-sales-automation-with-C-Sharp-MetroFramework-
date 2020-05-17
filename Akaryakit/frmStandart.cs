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
    public partial class frmStandart : MetroForm
    {
        public frmStandart()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGiris f = new frmGiris();
            f.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmSatislar satis = new frmSatislar();
            satis.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            frmKullaniciSatislari f = new frmKullaniciSatislari();
            f.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmYakitSeviye f = new frmYakitSeviye();
            f.Show();
        }

        private void tlIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistik f = new frmIstatistik();
            f.Show();
        }
    }
}
