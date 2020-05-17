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
using MetroFramework.Controls;
using System.Threading;

namespace Akaryakit
{
    public partial class frmPanelFiyat : MetroForm
    {
        public frmPanelFiyat()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }

        csGenelGosterim genel = new csGenelGosterim();
        private void frmPanelFiyat_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
            genel.cmbVeriEkle(cmbFiyatBir, "t_product", "prod_name", "prod_id");
            genel.cmbVeriEkle(cmbFiyatIki, "t_product", "prod_name", "prod_id");
            genel.cmbVeriEkle(cmbFiyatUc, "t_product", "prod_name", "prod_id");
            deger++;
            panelComboSec();
        }
        csUrunler urun = new csUrunler();
        private void metroButton1_Click(object sender, EventArgs e)
        {
        }
        void panelComboSec()
        {
            DataTable dtbPanel = new DataTable();
            dtbPanel = urun.panelFiyatlariniGetir();

            if (Convert.ToBoolean(dtbPanel.Rows[0][0])==true)
            {
                cmbFiyatBir.SelectedValue=Convert.ToInt32(dtbPanel.Rows[0][1]);
                cmbFiyatIki.SelectedValue=Convert.ToInt32(dtbPanel.Rows[0][2]);
                cmbFiyatUc.SelectedValue=Convert.ToInt32(dtbPanel.Rows[0][3]);

                DataTable dt1 = new DataTable();
                urun.urunId = Convert.ToInt32(dtbPanel.Rows[0][1]);
                dt1=urun.tekUrunGetir();
                btnFiyatBir.Text= dt1.Rows[0][2].ToString();

                DataTable dt2 = new DataTable();
                urun.urunId = Convert.ToInt32(dtbPanel.Rows[0][2]);
                dt2=urun.tekUrunGetir();
                btnFiyatIki.Text = dt2.Rows[0][2].ToString();

                DataTable dt3 = new DataTable();
                urun.urunId = Convert.ToInt32(dtbPanel.Rows[0][3]);
                dt3=urun.tekUrunGetir();
                btnFiyatUc.Text = dt3.Rows[0][2].ToString();

            }
        }
        private void lblFiyatBir_Click(object sender, EventArgs e)
        {

        }

        private void pnlFiyat_Paint(object sender, PaintEventArgs e)
        {

        }
        static int deger = -1;
        
        static int idBir;
        static int idIki;
        static int idUc;

        private void cmbFiyatBir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deger !=-1)
            {
                idBir = Convert.ToInt32(cmbFiyatBir.SelectedValue);
                DataTable dtb = new DataTable();
                urun.urunId = idBir;
                dtb = urun.tekUrunGetir();
                btnFiyatBir.Text = dtb.Rows[0]["prod_cost"].ToString();
            }

        }

        private void cmbFiyatIki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deger != -1)
            {
                idIki = Convert.ToInt32(cmbFiyatIki.SelectedValue);
                DataTable dtb = new DataTable();
                urun.urunId = idIki;
                dtb = urun.tekUrunGetir();
                btnFiyatIki.Text = dtb.Rows[0]["prod_cost"].ToString();
            }
        }

        private void cmbFiyatUc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deger != -1)
            {
                idUc = Convert.ToInt32(cmbFiyatUc.SelectedValue);
                DataTable dtb = new DataTable();
                urun.urunId = idUc;
                dtb = urun.tekUrunGetir();
                btnFiyatUc.Text = dtb.Rows[0]["prod_cost"].ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnFiyatBir.Text == string.Empty || btnFiyatIki.Text == string.Empty || btnFiyatUc.Text == string.Empty)
            {
                MessageBox.Show("Alanlar boş olamaz !");
            }
            else
            {
                if (idBir == idIki || idBir == idUc || idIki == idUc)
                {
                    MessageBox.Show("Bir panele iki aynı ürün eklenemez !");
                }
                else
                {
                    urun.panelBirinciDeger = Convert.ToInt32(cmbFiyatBir.SelectedValue);
                    urun.paneIkinciDeger = Convert.ToInt32(cmbFiyatIki.SelectedValue);
                    urun.panelUcuncuDeger = Convert.ToInt32(cmbFiyatUc.SelectedValue);
                    if (urun.panelFiyatGuncelle()==1)
                    {
                        MetroMessageBox.Show(this, "Başarılı !", "Panel güncellendi ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Hata !", "Güncellenmedi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cmbFiyatBir_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            deger = -1;
            this.Close();

        }
    }
}
