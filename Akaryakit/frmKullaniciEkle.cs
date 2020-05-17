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
    public partial class frmKullaniciEkle : MetroForm
    {
        csFormKontrol formKontrol = new csFormKontrol();
        csTasarim tasarim = new csTasarim();
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        frmYonetim yonetim = new frmYonetim();
        csGenelGosterim genel = new csGenelGosterim();

        public frmKullaniciEkle()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
            doldur();
        }
        void doldur()
        {
            genel.cmbVeriEkle(cmbYetki, "t_auth", "auth_name", "auth_id");
            genel.cmbVeriEkle(cmbCinsiyet, "t_gender","gender_type","gender_id");
        }

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
            cmbYetki.SelectedIndex = 2;
            cmbCinsiyet.SelectedIndex = 2;
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
        }

        string[] txtBoxAdlar={"Nick","Ad","Soyad","Sifre","SifreTekrar","Telefon","Adres"};
        string[] txtBoxNumaraOlmasiGerekenler = {"Telefon"};
        string[] txtBoxMetinselOlmasiGerekenler = {"Nick", "Ad", "Soyad", "Adres"};

        public void btnKaydet_Click(object sender, EventArgs e)
        {
            if (formKontrol.txtKontrol(txtBoxAdlar, pnlKullaniciEkle,this) == 1 && formKontrol.txtTurStringKontrol(txtBoxNumaraOlmasiGerekenler, pnlKullaniciEkle,this) == true && formKontrol.txtTurIntegerKontrol(txtBoxMetinselOlmasiGerekenler, pnlKullaniciEkle,this)==true && formKontrol.degerKontrol(txtTelefon, 11,"Telefon",this)==true && formKontrol.ikiTexboxDegerKontrolu(txtSifre,txtSifreTekrar,this,"Şifre alanı Şifre Tekrar")==true)
            {
                kullanici.kullaniciNick = txtNick.Text;
                kullanici.kullaniciAd = txtAd.Text;
                kullanici.kullaniciAdres = txtAdres.Text;
                kullanici.kullaniciNick = txtNick.Text;
                kullanici.kullaniciSoyad = txtSoyad.Text;
                kullanici.kullaniciTel = Convert.ToInt64(txtTelefon.Text);
                kullanici.kullaniciSifre = txtSifre.Text;
                kullanici.kullaniciCinsiyet = Convert.ToInt32(cmbCinsiyet.SelectedValue.ToString());
                kullanici.kullaniciYetkiId = Convert.ToInt32(cmbYetki.SelectedValue.ToString());
                if(formKontrol.benzerKayitKontroluEkleme("t_users","user_nick",txtNick.Text) <= 0 )
                {
                    if(kullanici.kullaniciEkle()>=0)
                    {
                        MetroMessageBox.Show(this, "Mesaj  !", txtAd.Text + " " + txtSoyad.Text + " adlı kişi başarıyla eklendi...", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Hata  !","veri işlenirken hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Hata  !", "Aynı nick zaten mevcut !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {

        }

        private void txtSoyad_Click(object sender, EventArgs e)
        {

        }

        private void txtAdres_Click(object sender, EventArgs e)
        {
            
        }

        private void txtAd_Click(object sender, EventArgs e)
        {

        }

        private void txtNick_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
        }

        private void imgGeri_Click(object sender, EventArgs e)
        {

        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
