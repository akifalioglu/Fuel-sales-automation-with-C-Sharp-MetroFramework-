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
    public partial class frmYeniKayit : MetroForm
    {
        public frmYeniKayit()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }

        csFormKontrol formKontrol = new csFormKontrol();
        csTasarim tasarim = new csTasarim();
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        frmGiris f = new frmGiris();
        csGenelGosterim genel = new csGenelGosterim();

        private void frmYeniKayit_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
            doldur();
        }
        void doldur()
        {
            genel.cmbVeriEkle(cmbCinsiyet, "t_gender", "gender_type", "gender_id");
        }
        string[] txtBoxAdlar = { "Nick", "Ad", "Soyad", "Sifre", "SifreTekrar", "Telefon", "Adres" };
        string[] txtBoxNumaraOlmasiGerekenler = { "Telefon" };
        string[] txtBoxMetinselOlmasiGerekenler = { "Nick", "Ad", "Soyad", "Adres" };

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (formKontrol.txtKontrol(txtBoxAdlar, pnlKullaniciEkle, this) == 1 && formKontrol.txtTurStringKontrol(txtBoxNumaraOlmasiGerekenler, pnlKullaniciEkle, this) == true && formKontrol.txtTurIntegerKontrol(txtBoxMetinselOlmasiGerekenler, pnlKullaniciEkle, this) == true && formKontrol.degerKontrol(txtTelefon, 11, "Telefon", this) == true && formKontrol.ikiTexboxDegerKontrolu(txtSifre, txtSifreTekrar, this, "Şifre alanı Şifre Tekrar") == true)
            {
                kullanici.kullaniciNick = txtNick.Text;
                kullanici.kullaniciAd = txtAd.Text;
                kullanici.kullaniciAdres = txtAdres.Text;
                kullanici.kullaniciNick = txtNick.Text;
                kullanici.kullaniciSoyad = txtSoyad.Text;
                kullanici.kullaniciTel = Convert.ToInt64(txtTelefon.Text);
                kullanici.kullaniciSifre = txtSifre.Text;
                kullanici.kullaniciCinsiyet = Convert.ToInt32(cmbCinsiyet.SelectedValue.ToString());
                kullanici.kullaniciYetkiId = 3;
                if (formKontrol.benzerKayitKontroluEkleme("t_users", "user_nick", txtNick.Text) <= 0)
                {
                    if (kullanici.kullaniciEkle() > 0)
                    {
                        MetroMessageBox.Show(this, "Mesaj  !", txtAd.Text + " " + txtSoyad.Text + " hoşgeldiniz ...", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        f.Show();
                        this.Close();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Hata  !", "veri işlenirken hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Hata  !", "Aynı nick zaten mevcut !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
