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
    public partial class frmUrun : MetroForm
    {
        csUrunler urunler = new csUrunler();
        csFormKontrol formkontrol = new csFormKontrol();
        csGenelGosterim genel = new csGenelGosterim();
        frmYonetim yonetim = new frmYonetim();
        public frmUrun()
        {
            InitializeComponent();
            txtMoneyValue = new System.Collections.Generic.List<char>();
            txtFiyat.RightToLeft = RightToLeft.Yes;
            this.StyleManager = stlPanel;

        }
        void doldur ()
        {
            dtgUrun.DataSource = urunler.urunleriGetir();
        }
        List<char> txtMoneyValue;
        private void frmUrun_Load(object sender, EventArgs e)
        {
            doldur();
            dtgUrun.Columns[0].Visible=false;
            dtgUrun.Columns[1].Width = 150;
            dtgUrun.Columns[2].Width = 150;
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }
        private void RemovePoints()
        {
            for (int i = 0; i < txtMoneyValue.Count; i++)
            {
                if (txtMoneyValue[i] == '.')
                    txtMoneyValue.RemoveAt(i);
            }

        } 
 
        public void SetTextbox()
        {
            // boş string tanımladık 
            string s = string.Empty;
            //eğer  bizim listimizdeki sayı sayısı 2 den büyük ise  sonran 2. karakterin önüne virgül atma şeysi 
            if (txtMoneyValue.Count > 1)
            {
                // önce listimizdeki tüm virgülleri kaldırdık 
                txtMoneyValue.Remove(',');
                // listimizin sondan 3. karakterine gene virgül koyduk 
                txtMoneyValue.Insert(txtMoneyValue.Count - 1, ',');
            }


            //mod 3 e  göre  değer  0 ise . koyalım dedik ama  virgülü de unutmadık bu yuzden 5 den büyükse eleman sayısı nokta  koyduk 
            if (txtMoneyValue.Count >= 6)
            {
                // tüm . ları temizliyorum. 
                RemovePoints(); 
                //kaç tane Point koyacağız 
                int pointCount = 1 + (txtMoneyValue.Count - 6) / 3;

                for (int i = 1; i <= pointCount; i++)
                {
                    int pointposition = ((txtMoneyValue.Count - 4) - (i * 1)) - ((i - 1) * 3);
                    txtMoneyValue.Insert(pointposition, '.');
                }
            }

            //txtMoneyValue listimizdeki değrleri string yapıyorum ve textboxa atıyorum. 
            for (int i = 0; i < txtMoneyValue.Count; i++)
            {
                s += txtMoneyValue[i];
            }
            txtFiyat.Text = s;
            //burada cursorun hep en sağda kalmasını sağlıyorum 
            txtFiyat.SelectionStart = txtFiyat.Text.Length;
        }
        private void tbEkle_Click(object sender, EventArgs e)
        {

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void cmbGuncelleUrunSec_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
        string[] txtBoxAdlari = {"UrunAdi","Fiyat"};
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if (formkontrol.txtKontrol(txtBoxAdlari,pnlUrun,this)==1)
            {
                if (formkontrol.benzerKayitKontroluEkleme("t_product","prod_name",txtUrunAdi.Text)>0)
                {
                    MetroMessageBox.Show(this, "Hata !", "Aynı kayıt mevcut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    urunler.urunAdi=txtUrunAdi.Text;
                    urunler.urunFiyati =Convert.ToDouble( txtFiyat.Text);
                    urunler.urunEkle();
                    MetroMessageBox.Show(this, "Başarılı !", "Başarıyla eklendi !", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    doldur();
                }

            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (formkontrol.txtKontrol(txtBoxAdlari, pnlUrun, this) == 1)
            {
                if (formkontrol.benzerKayitKontroluGuncelleme("t_product", "prod_name", txtUrunAdi.Text,"prod_id",csFormArasiVeriler.urunId) > 0)
                {
                    MetroMessageBox.Show(this, "Hata !", "Aynı kayıt mevcut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialog = new DialogResult();
                    if (urunler.urunId == -1)
                    {
                        MetroMessageBox.Show(this, "Hata !", "Düzenlemek için bir kayıt seçmelisiniz !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dialog = MetroMessageBox.Show(this, "Düzenle", csFormArasiVeriler.urunAdi + " adlı ürünü düzenlemek istediğinize emin misiniz ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dialog == DialogResult.Yes)
                        {
                            urunler.urunId = csFormArasiVeriler.urunId;
                            urunler.urunAdi = txtUrunAdi.Text;
                            urunler.urunFiyati = Convert.ToDouble(txtFiyat.Text);
                            if (urunler.urunGuncelle() == 1)
                            {
                                MetroMessageBox.Show(this, "Başarılı !", "Başarıyla Düzenlendi . . .", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                doldur();
                                urunler.urunId = -1;
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
                }

            }
        }

        private void dtgUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            csFormArasiVeriler.urunId = Convert.ToInt32( dtgUrun.CurrentRow.Cells[0].Value);
            DataTable dtb = new DataTable();
            urunler.urunId = csFormArasiVeriler.urunId;
            dtb = urunler.urunGetir();
            txtUrunAdi.Text= dtb.Rows[0]["Ürün Adı"].ToString();
            csFormArasiVeriler.urunAdi = dtb.Rows[0]["Ürün Adı"].ToString();
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            urunler.urunAdi = txtUrunAra.Text;
            dtgUrun.DataSource =  urunler.urunArama();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            if (urunler.urunId == -1)
            {
                MetroMessageBox.Show(this, "Hata !", "Silmek için bir kayıt seçmelisiniz !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dialog = MetroMessageBox.Show(this, "Sil", csFormArasiVeriler.urunAdi + " adlı ürünü silmek istediğinize emin misiniz ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialog == DialogResult.Yes)
                {
                    urunler.urunId = csFormArasiVeriler.urunId;
                    if (urunler.urunSil() == 1)
                    {
                        MetroMessageBox.Show(this, "Başarılı !", "Başarıyla Silindi . . .", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        doldur();
                        urunler.urunId = -1;
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
        }
        public void SetValue()
        {
            // adım adım listeye aktarım 
            txtMoneyValue.Clear();
            for (int i = 0; i < txtFiyat.Text.Length; i++)
            {
                txtMoneyValue.Add(txtFiyat.Text[i]);
            }
        } 
        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtFiyat_KeyUp(object sender, KeyEventArgs e)
        {
              //eğer silme veya backspaceye basılırsa textboxu sıfırlıyoruz. 
              if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) 
              { 
                  txtMoneyValue.Clear(); 
                  txtFiyat.Text = ""; 
              } 
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {

                // txtboxtaki valuenin  değerinin bizim listimize aktarılması 
                SetValue();
                // listimizdeki valuenin textboxa aktarılması 
                SetTextbox();
            }
            else
            {
                e.Handled = true;
            } 
        }
    }
}
