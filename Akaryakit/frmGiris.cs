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
using MetroFramework.Controls;
using MetroFramework.Components;
using MetroFramework;

namespace Akaryakit
{
    public partial class frmGiris : MetroForm
    {
        csTasarim tasarim = new csTasarim();
        public frmGiris()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }

        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();

        private void pnlGiris_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullanici.kullaniciAd = txtKullaniciAd.Text;
            kullanici.kullaniciSifre = txtKullaniciSifre.Text;
            kullanici.kullaniciNick = txtKullaniciAd.Text;
            int sonuc = kullanici.girisKontrol();
            DataTable dt = new DataTable();
            dt = kullanici.sartliKullaniciNickGetir();
            //MessageBox.Show(sonuc.ToString());
            if (sonuc == 1)
            {
                csFormArasiVeriler.kullaniciAdi = txtKullaniciAd.Text;
                csFormArasiVeriler.kullaniciId = Convert.ToInt32(dt.Rows[0][0]);
                csFormArasiVeriler.erisimIzni = 1;

                frmYonetim yonetimFormu = new frmYonetim();
                yonetimFormu.Show();
                this.Hide();
            }
            else if (sonuc == 2)
            {
                csFormArasiVeriler.kullaniciAdi = txtKullaniciAd.Text;
                csFormArasiVeriler.kullaniciId = Convert.ToInt32(dt.Rows[0][0]);

                frmMuhasebe muhasebe = new frmMuhasebe();
                muhasebe.Show();
                this.Hide();
                csFormArasiVeriler.erisimIzni = 1;
            }
            else if (sonuc == 3)
            {
                csFormArasiVeriler.kullaniciAdi = txtKullaniciAd.Text;
                csFormArasiVeriler.kullaniciId =Convert.ToInt32(dt.Rows[0][0]);
                frmStandart st = new frmStandart();
                st.Show();
                csFormArasiVeriler.erisimIzni = 0;
                this.Hide();
            }
            else if (sonuc==4)
            {
                csFormArasiVeriler.kullaniciAdi = txtKullaniciAd.Text;
                csFormArasiVeriler.kullaniciId = Convert.ToInt32(dt.Rows[0][0]);
                frmAraForm a = new frmAraForm();
                a.Show();
                csFormArasiVeriler.erisimIzni = 0;
                this.Hide();
            }
            else if (sonuc==5)
            {
                MetroMessageBox.Show(this, "Uyarı !", "Bu kullanıcı silinmiş ", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else
            {
                MetroMessageBox.Show(this, "Hata !", "Yanlış kullanıcı adı veya şifre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKullaniciAd_Click(object sender, EventArgs e)
        {

        }
        int sayac;
        private void txtKullaniciSifre_ButtonClick(object sender, EventArgs e)
        {
            sayac++;
            char goster = Convert.ToChar("\0");
            char gizle = Convert.ToChar("*");
            int mod;
            mod = sayac % 2;
            if (mod==1)
            {
                txtKullaniciSifre.PasswordChar = goster;
            }
            else
            {
                txtKullaniciSifre.PasswordChar=gizle;
            }
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmTest t = new frmTest();
            t.Show();

        }

        private void lnkYeniKayit_Click(object sender, EventArgs e)
        {
            frmYeniKayit yeni = new frmYeniKayit();
            yeni.Show();
        }
    }
}
