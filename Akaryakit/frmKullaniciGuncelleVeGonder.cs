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
using MetroFramework;

namespace Akaryakit
{
    public partial class frmKullaniciGuncelleVeGonder : MetroForm
    {
        public frmKullaniciGuncelleVeGonder()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        csFormKontrol formKontrol = new csFormKontrol();
        csTasarim tasarim = new csTasarim();
        frmYonetim yonetim = new frmYonetim();
        csGenelGosterim genel = new csGenelGosterim();
        private void csKullaniciGuncelleVeGonder_Load(object sender, EventArgs e)
        {
            baslangictaVeriGetir();
            txtVeriDoldur();

        }
        void baslangictaVeriGetir()
        {
            genel.cmbVeriEkle(cmbYetki, "t_auth", "auth_name", "auth_id");
            genel.cmbVeriEkle(cmbCinsiyet, "t_gender", "gender_type", "gender_id");
            tasarim.formAcilistaRenkDegistir(stlPanel);
            tasarim.formAcilistaTemaDegistir(stlPanel);
        }
        void txtVeriDoldur()
        {
            txtAd.Text = csFormArasiVeriler.kullaniciAdi;
            txtSoyad.Text = csFormArasiVeriler.kullaniciSoyad;
            txtAdres.Text = csFormArasiVeriler.kullaniciAdres;
            txtSifre.Text = csFormArasiVeriler.kullaniciSifre;
            txtTelefon.Text = csFormArasiVeriler.kullaniciTel.ToString();
            txtNick.Text = csFormArasiVeriler.kullaniciNick;
            cmbCinsiyet.SelectedValue = csFormArasiVeriler.kullaniciCinsiyet;
            cmbYetki.SelectedValue = csFormArasiVeriler.kullaniciYetkiId;
            lblKullaniciId.Text += Convert.ToInt32(csFormArasiVeriler.kullaniciId).ToString();
        }
        string[] txtBoxAdlar = { "Nick", "Ad", "Soyad", "Sifre", "Telefon", "Adres" };
        string[] txtBoxNumaraOlmasiGerekenler = { "Telefon" };
        string[] txtBoxMetinselOlmasiGerekenler = { "Nick", "Ad", "Soyad", "Adres" };
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (formKontrol.txtKontrol(txtBoxAdlar, pnlDuzenle,this) == 1 && formKontrol.txtTurStringKontrol(txtBoxNumaraOlmasiGerekenler, pnlDuzenle,this) == true && formKontrol.txtTurIntegerKontrol(txtBoxMetinselOlmasiGerekenler, pnlDuzenle,this)==true && formKontrol.degerKontrol(txtTelefon, 11,"Telefon ",this)==true)
            {
                if (formKontrol.benzerKayitKontroluGuncelleme("t_users", "user_nick", txtNick.Text, "user_id",Convert.ToInt32(lblKullaniciId.Text)) < 1)
                {
                    DialogResult dialog = new DialogResult();
                    dialog = MetroMessageBox.Show(this, "Uyarı !", csFormArasiVeriler.kullaniciAdi + " " + csFormArasiVeriler.kullaniciSoyad + " adlı kişiyi güncellemek istediğinize emin misiniz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        kullanici.kullaniciId = csFormArasiVeriler.kullaniciId;
                        kullanici.kullaniciAd = txtAd.Text;
                        kullanici.kullaniciAdres = txtAdres.Text;
                        kullanici.kullaniciNick = txtNick.Text;
                        kullanici.kullaniciSoyad = txtSoyad.Text;
                        kullanici.kullaniciTel = Convert.ToInt64(txtTelefon.Text);
                        kullanici.kullaniciSifre = txtSifre.Text;
                        kullanici.kullaniciCinsiyet = Convert.ToInt32(cmbCinsiyet.SelectedValue.ToString());
                        kullanici.kullaniciYetkiId = Convert.ToInt32(cmbYetki.SelectedValue.ToString());
                        if (kullanici.kullaniciGuncelle() == 1)
                        {
                            MetroMessageBox.Show(this, "Bilgi !", "Güncelleme işlemi başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Hide();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Hata !", "Güncelleme işleminde bir hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Hata !", "İşlem iptal edildi...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                //MessageBox.Show("Tüm alanları doldurunuz !");
            }
        }

        private void pnlDuzenle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MetroMessageBox.Show(this, "Sil", csFormArasiVeriler.kullaniciAdi + " " + csFormArasiVeriler.kullaniciSoyad + " adlı kişiyi silmek istediğinize emin misiniz ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialog == DialogResult.Yes)
            {
                kullanici.kullaniciId = csFormArasiVeriler.kullaniciId;
                if (kullanici.kullaniciSil() == 1)
                {
                    MetroMessageBox.Show(this, "Başarılı !", "Başarıyla Silindi . . .", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    frmKullaniciGuncelle f = new frmKullaniciGuncelle();
                    f.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "Hata !", "Bir hata oluştu !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Mesaj ", "Kullanıcı tarafından iptal edildi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void imgGeri_Click(object sender, EventArgs e)
        {
            frmKullaniciGuncelle guncelle = new frmKullaniciGuncelle();
            guncelle.Show();
            this.Close();
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
