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
using MetroFramework;

namespace Akaryakit
{
    public partial class frmSatislar : MetroForm
    {
        public frmSatislar()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }
        csGenelGosterim genel = new csGenelGosterim();
        csFiyatlandirma fiyatlandirma = new csFiyatlandirma();
        csFormKontrol formkontrol = new csFormKontrol();
        csUrunler urunler = new csUrunler();
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        static double Indirim = 0;
        private void frmSatislar_Load(object sender, EventArgs e)
        {
            baslangic();
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
            
        }
        void baslangic()
        {
            genel.cmbVeriEkle(cmbPompaSec, "t_pump", "pump_no", "pump_id");
            genel.cmbVeriEkle(cmbKullanici, "t_users", "user_nick", "user_id");
            dtgSatislar.DataSource = fiyatlandirma.satisListele();
            if (csFormArasiVeriler.erisimIzni==0)
            {
                cmbKullanici.SelectedValue = csFormArasiVeriler.kullaniciId;
                cmbKullanici.Enabled = false;
            }
            txtFiyat.Text = 0.ToString();
        }
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        static int urunId;
        private void cmbPompaSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string[] txtBoxAdlari = {"Urun","Plaka","Fiyat","Litre","Tutar","AraToplam"};
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (formkontrol.txtKontrol(txtBoxAdlari, pnlSatislar, this) == 1)
            {
                fiyatlandirma.plaka=txtPlaka.Text;
                fiyatlandirma.urunId=urunId;
                fiyatlandirma.litre=Convert.ToDouble(txtLitre.Text.Replace('.',','));
                fiyatlandirma.satisiYapanId =Convert.ToInt32( cmbKullanici.SelectedValue);
                urunler.urunId = urunId;
                DataTable dtb = new DataTable();
                dtb = urunler.uruneGoreTankGetir();
                urunler.tankId = Convert.ToInt32(dtb.Rows[0]["tank_id"]);
                double litre=  Convert.ToDouble( txtLitre.Text.Replace('.',',') );
                int kapasite = Convert.ToInt32(dtb.Rows[0]["tank_level"]);
                    if (litre < kapasite)
                    {
                        if (Convert.ToDouble(txtAraToplam.Text)>Convert.ToDouble(txtTutar.Text))
                        {
                            urunler.yapilanSatisLitre = litre;

                            fiyatlandirma.satisEkle();
                            urunler.urunStokAzalt();
                            fiyatlandirma.promosyonId = IndirimID;
                            fiyatlandirma.promosyonKullanim();
                            txtIndirim.Text = "0";
                            MetroMessageBox.Show(this, "Başarılı !", "İndirimli satış yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        else
                        {
                            fiyatlandirma.satisiYapanId =Convert.ToInt32( cmbKullanici.SelectedValue);
                            urunler.yapilanSatisLitre = litre;
                            fiyatlandirma.satisEkle();
                            urunler.urunStokAzalt();
                            MetroMessageBox.Show(this, "Başarılı !", "Satış yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        if (Convert.ToDouble(txtIndirim.Text) > 0)
                        {
                            fiyatlandirma.promosyonLitre = Convert.ToDouble(txtIndirim.Text);
                            fiyatlandirma.plaka = txtPlaka.Text;
                            fiyatlandirma.satisiYapanId = Convert.ToInt32(cmbKullanici.SelectedValue);
                            fiyatlandirma.promosyonSahiplendir();
                            MetroMessageBox.Show(this, "Başarılı !", "Tebrikler, " + txtIndirim.Text + " litre indirim kazandınız ..", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Hata !", "Depoda " + litre + " litre yakıt bulunmuyor !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                dtgSatislar.DataSource = fiyatlandirma.satisListele();
            }
        }
        void hesapla()
        {

            if (txtLitre.Text != string.Empty)
            {
                try
                {
                    double fiyat = Convert.ToDouble(txtFiyat.Text);
                    double litre = Convert.ToDouble(txtLitre.Text.Replace('.',','));
                    double sonuc = (fiyat * litre);
                    txtAraToplam.Text = sonuc.ToString();
                    txtTutar.Text= "";
                    txtIndirim.Text = fiyatlandirma.indirimHesap().ToString();
                    double toplam = 0;
                    if (litre>Indirim*2)
                    {
                        toplam = litre - Indirim;
                        double araToplam = Convert.ToDouble(txtAraToplam.Text);
                        txtTutar.Text = (araToplam - (Indirim * fiyat)).ToString();
                    }
                    else
                    {
                        txtTutar.Text = txtAraToplam.Text;
                    }

                }
                catch (FormatException)
                {
                    MetroMessageBox.Show(this, "Hata !", "Litre alanı sayısal ifade olmalıdır...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Convert.ToDouble(txtAraToplam.Text) > Convert.ToDouble(txtTutar.Text))
                {
                    txtIndirim.Text = "0";
                }

            }
        }

        private void txtLitre_TextChanged(object sender, EventArgs e)
        {
            hesapla();
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            try
            {
                fiyatlandirma.litre = Convert.ToInt32(txtLitre.Text);
            }
            catch (Exception)
            {
            }
            txtIndirim.Text= fiyatlandirma.indirimHesap().ToString();
            if (Convert.ToDouble(txtAraToplam.Text) > Convert.ToDouble(txtTutar.Text))
            {
                txtIndirim.Text = "0";
            }
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgGeri_Click(object sender, EventArgs e)
        {
            frmMuhasebe muhasebe = new frmMuhasebe();
            muhasebe.Show();
            this.Close();
        }

        private void cmbPompaSec_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void cmbPompaSec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable();
            fiyatlandirma.pompaId = Convert.ToInt32(cmbPompaSec.SelectedValue);
            dtb = fiyatlandirma.satisGuncelfiyat();
            if (dtb.Rows.Count>0)
            {
                txtFiyat.Text = dtb.Rows[0]["prod_cost"].ToString();
                txtUrun.Text = dtb.Rows[0]["prod_name"].ToString();
                urunId = Convert.ToInt32(dtb.Rows[0]["prod_id"]);
            }
            else
            {
                txtUrun.Text = string.Empty;
                txtFiyat.Text = string.Empty;

                MetroMessageBox.Show(this, "Hata !", "Satış yapmak istediğiniz ürün mevcut değil , lütfen başka bir pompa seçiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (txtFiyat.Text==string.Empty)
            {
                txtFiyat.Text = 0.ToString();
            }

            hesapla();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtLitre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46
                         && e.KeyChar != 8)
                e.Handled = true; 
        }
        static int IndirimID = 0;
        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            fiyatlandirma.plaka = txtPlaka.Text.Trim();
            DataTable dt = new DataTable();
            dt = fiyatlandirma.promosyonLitreGetir();
            if (dt.Rows.Count>0)
            {
                Indirim = Convert.ToInt32(dt.Rows[0][4]);
                IndirimID = Convert.ToInt32(dt.Rows[0][0]);
                dt.Clear();
            }
            else
            {
                Indirim = 0;
            }
            hesapla();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Indirim.ToString());
        }

        private void txtIndirim_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Indirim.ToString());
        }
    }
}