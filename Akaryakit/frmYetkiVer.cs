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
    public partial class frmYetkiVer : MetroForm
    {
        public frmYetkiVer()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }
        csGenelGosterim genel = new csGenelGosterim();
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        private void frmYetkiVer_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
            genel.cmbVeriEkle(cmbYetki, "t_auth", "auth_name", "auth_id");
            lblKisi.Text = csFormArasiVeriler.kullaniciNick;
            lblYetki.Text = csFormArasiVeriler.kullaniciYetkiAd;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            kullanici.kullaniciYetkiId = Convert.ToInt32(cmbYetki.SelectedValue);
            kullanici.kullaniciNick = lblKisi.Text;
            if (kullanici.yetkiGuncelle()==1)
            {
                MetroMessageBox.Show(this, "Başarılı !", "Başarıyla güncellendi..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                MetroMessageBox.Show(this, "Hata !", "Bir hata oluştu..", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgGeri_Click(object sender, EventArgs e)
        {
            frmYetkilendirme yetki = new frmYetkilendirme();
            yetki.Show();
            this.Close();
        }
    }
}
