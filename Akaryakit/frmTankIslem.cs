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
    public partial class frmTankIslem : MetroForm
    {
        public frmTankIslem()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;

        }
        csGenelGosterim genel = new csGenelGosterim();
        csUrunler urun = new csUrunler();
        private void frmTankIslem_Load(object sender, EventArgs e)
        {
            genel.cmbVeriEkle(cmbTankSec, "t_tank", "tank_name", "tank_id");
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }

        private void metroTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        csFormKontrol formkontrol = new csFormKontrol();
        string[] txtBoxAdlar={"Max","MevcutSeviye"};
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (formkontrol.txtKontrol(txtBoxAdlar, pnlTank, this) == 1)
            {
                DataTable dtb = new DataTable();
                dtb = urun.sartliTankGetir();

                double tankKapasite = 0;
                double tankSeviyesi = 0;
                double yeniToplamSeviye = 0;

                if (dtb.Rows.Count > 0)
                {
                    tankKapasite = Convert.ToDouble(dtb.Rows[0]["tank_capacity"]);
                    tankSeviyesi = Convert.ToDouble(dtb.Rows[0]["tank_level"]);
                    yeniToplamSeviye = Convert.ToDouble((tankSeviyesi + Convert.ToInt32(txtMax.Text)));
                }


                if (yeniToplamSeviye > tankKapasite)
                {
                    MetroMessageBox.Show(this, "Hata !", "Toplam limit max " + tankKapasite + " Litre olmalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    urun.tankDeger = Convert.ToDouble(txtMax.Text);
                    urun.tankaYakitEkle();
                    MetroMessageBox.Show(this, "Hata !", "Yakıt girişi sağlandı..", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    frmTank.ActiveForm.Refresh();
                }
            }
        }

        private void cmbTankSec_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbTankSec_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cmbTankSec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            urun.tankId =Convert.ToInt32(cmbTankSec.SelectedValue);
            DataTable dtb = new DataTable();
            dtb=urun.sartliTankGetir();
            double seviye = Convert.ToDouble(dtb.Rows[0]["tank_level"]);
            double kapasite = Convert.ToInt32(dtb.Rows[0]["tank_capacity"]);
            txtMevcutSeviye.Text =seviye.ToString();
            txtMax.Text = (kapasite - seviye).ToString() ;
        }

        private void pnlTank_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUrunAra_Click(object sender, EventArgs e)
        {

        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46
             && e.KeyChar != 8)
                e.Handled = true; 
        }
    }
}
