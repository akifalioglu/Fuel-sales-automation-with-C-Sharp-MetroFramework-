using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Akaryakit
{
    public partial class frmMuhasebe : MetroForm
    {
        public frmMuhasebe()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }

        private void frmMuhasebe_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }

        private void tlKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmSatislar satis = new frmSatislar();
            satis.Show();
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGiris f = new frmGiris();
            f.Show();
        }

        private void tlSatisRapor_Click(object sender, EventArgs e)
        {
            frmSatisRapor rapor = new frmSatisRapor();
            rapor.Show();
        }

        private void tlPanelFiyat_Click(object sender, EventArgs e)
        {
            frmPanelFiyat p = new frmPanelFiyat();
            p.Show();
        }

        private void tlYakitSeviye_Click(object sender, EventArgs e)
        {
            frmYakitSeviye yak = new frmYakitSeviye();
            yak.Show();
        }

        private void tlIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistik f = new frmIstatistik();
            f.Show();
        }

        private void tlUrunIslem_Click(object sender, EventArgs e)
        {
            frmUrun u = new frmUrun();
            u.Show();
        }

        private void tlPompaIslem_Click(object sender, EventArgs e)
        {
            frmPompaIslem f = new frmPompaIslem();
            f.Show();
        }

        private void tlSatislar_Click(object sender, EventArgs e)
        {
            frmSatislar f = new frmSatislar();
            f.Show();
        }

        private void tlGunsonu_Click(object sender, EventArgs e)
        {
            frmGunsonu f = new frmGunsonu();
            f.Show();
        }

        private void tlPromosyon_Click(object sender, EventArgs e)
        {
            frmPromosyonTanimla f = new frmPromosyonTanimla();
            f.Show();
        }

        private void tlTank_Click(object sender, EventArgs e)
        {
            frmTank f = new frmTank();
            f.Show();
        }
    }
}
