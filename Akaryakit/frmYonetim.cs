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
    public partial class frmYonetim : MetroForm
    {
        public frmYonetim()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
            
        }
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        csTasarim tasarim = new csTasarim();
        private void frmYonetim_Load(object sender, EventArgs e)
        {
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }

        private void tlKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle ekle = new frmKullaniciEkle();
            ekle.Show();
        }



        private void imgGeri_Click(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris();
            giris.Show();
            this.Close();
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGiris f = new frmGiris();
            f.Show();
        }

        private void tlAyarVeDuzenleme_Click(object sender, EventArgs e)
        {
            frmAyarVeDuzenlemeler ayarFormu = new frmAyarVeDuzenlemeler();
            ayarFormu.Show();
        }

        private void pnlYonetim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlYetkilendirme_Click(object sender, EventArgs e)
        {
            frmYetkilendirme yetki = new frmYetkilendirme();
            yetki.Show();
        }

        private void tlPompaIslem_Click(object sender, EventArgs e)
        {
            frmPompaIslem pompa = new frmPompaIslem();
            pompa.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmYakitSeviye yakit = new frmYakitSeviye();
            yakit.Show();
        }

        private void lblHosgeldin_Click(object sender, EventArgs e)
        {

        }

        private void lblGirisYazi_Click(object sender, EventArgs e)
        {

        }

        private void tlPanelFiyat_Click(object sender, EventArgs e)
        {
            frmPanelFiyat panel = new frmPanelFiyat();
            panel.Show();
        }

        private void tlSatisRapor_Click(object sender, EventArgs e)
        {
            frmSatisRapor rapor = new frmSatisRapor();
            rapor.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frmUrun urun = new frmUrun();
            urun.Show();
        }

        private void tlSatislar_Click(object sender, EventArgs e)
        {
            frmSatislar satis = new frmSatislar();
            satis.Show();
        }

        private void tlKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            frmKullaniciGuncelle guncelle = new frmKullaniciGuncelle();
            guncelle.Show();
        }

        private void tlIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistik ist = new frmIstatistik();
            ist.Show();
        }

        private void tlTank_Click(object sender, EventArgs e)
        {
            frmTank t = new frmTank();
            t.Show();
        }

        private void tlGunsonu_Click(object sender, EventArgs e)
        {
            frmGunsonu g = new frmGunsonu();
            g.Show();
        }

        private void tlPromosyon_Click(object sender, EventArgs e)
        {
            frmPromosyonTanimla p = new frmPromosyonTanimla();
            p.Show();
        }
    }
}
