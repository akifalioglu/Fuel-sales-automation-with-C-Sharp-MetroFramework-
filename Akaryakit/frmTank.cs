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
    public partial class frmTank : MetroForm
    {
        public frmTank()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }
        csGenelGosterim genel = new csGenelGosterim();
        csUrunler urun = new csUrunler();
        csFormKontrol formKontrol = new csFormKontrol();
        private void frmTankEkle_Load(object sender, EventArgs e)
        {
            genel.cmbVeriEkle(cmbUrunler, "t_product", "prod_name", "prod_id");
            doldur();
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }
        void doldur()
        {
            dtgTanklar.DataSource = urun.tanklariGetir();
        }
        string[] txtBoxAdlar = { "TankAdi","Kapasite" };

        private void dtgTanklar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        static int tankId;
        private void dtgTanklar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tankId =Convert.ToInt32( dtgTanklar.CurrentRow.Cells[0].Value);
            txtTankAdi.Text = dtgTanklar.CurrentRow.Cells[1].Value.ToString();
            txtKapasite.Text = dtgTanklar.CurrentRow.Cells[4].Value.ToString();
            cmbUrunler.SelectedValue =Convert.ToInt32( dtgTanklar.CurrentRow.Cells[3].Value);

        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        csFormKontrol form = new csFormKontrol();
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (form.txtKontrol(txtBoxAdlar,pnlTank,this)==1)
            {
                urun.tankAdi = txtTankAdi.Text;
                urun.urunId = Convert.ToInt32(cmbUrunler.SelectedValue);
                urun.tankLimit = Convert.ToInt32(txtKapasite.Text);
                MetroMessageBox.Show(this, "Başarılı !", "Başarıyla eklendi !", MessageBoxButtons.OK, MessageBoxIcon.Question);

                urun.tankEkle();
                doldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (tankId > 0)
            {
                DialogResult dialog = new DialogResult();
                dialog = MetroMessageBox.Show(this, "Sil", txtTankAdi.Text + " adlı tankı silmek istediğinize emin misiniz ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialog == DialogResult.Yes)
                {
                    urun.tankId = tankId;
                    MetroMessageBox.Show(this, "Başarılı !", "Başarıyla silindi !", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    urun.tankSil();
                    tankId = 0;
                    doldur();
                }

            }
            else
            {
                MetroMessageBox.Show(this, "Hata !", "Lütfen bir tank seçin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (tankId>0)
            {
            urun.tankAdi = txtTankAdi.Text;
            urun.urunId = Convert.ToInt32(cmbUrunler.SelectedValue);
            urun.tankLimit = Convert.ToInt32(txtKapasite.Text);
            urun.tankId = tankId;
            }
            else
            {
                MetroMessageBox.Show(this, "Hata !", "Lütfen bir tank seçin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               if (formKontrol.txtKontrol(txtBoxAdlar, pnlTank, this) == 1)
                {
                    if (formKontrol.benzerKayitKontroluGuncelleme("t_tank", "tank_name", txtTankAdi.Text, "tank_id", tankId) < 1)
                    {
                        MetroMessageBox.Show(this, "Başarılı !", "Başarıyla güncellendi !", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        urun.tankGuncelle();
                        tankId = 0;
                        doldur();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Hata !", "Böyle bir kayıt mevcut", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
        }

        private void btnTankIslem_Click(object sender, EventArgs e)
        {
            frmTankIslem t = new frmTankIslem();
            t.Show();
        }
    }
}
