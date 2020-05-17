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
    public partial class frmGunsonu : MetroForm
    {
        public frmGunsonu()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }
        csFiyatlandirma fiyat = new csFiyatlandirma();
        private void frmGunsonu_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
            doldur();
        }
        static double toplam;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGunsonu_Click(object sender, EventArgs e)
        {

        }
        void doldur()
        {
            DataTable dtb = new DataTable();

            fiyat.gun = DateTime.Now.Day;
            fiyat.ay = DateTime.Now.Month;
            fiyat.yil = DateTime.Now.Year;

            dtb = fiyat.gunlukSatisListele();
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                string eleman = dtb.Rows[i]["Kullanıcı Adı"] + " adlı kişi " + dtb.Rows[i]["Litre"] + " litre " + dtb.Rows[i]["Ürün"] + " " + dtb.Rows[i]["Plaka"] + " plakalı araca satış yaptı";
                toplam = toplam + (Convert.ToDouble(dtb.Rows[i]["Fiyat"]) * Convert.ToInt32(dtb.Rows[i]["Litre"]));
                lstGunsonu.Items.Add(eleman);
            }
            lblTutar.Text = toplam.ToString();
            csFormArasiVeriler.gunSonuToplam=lblTutar.Text;
        }
        private void pnlGunsonu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            frmHesapIslemleri hesap = new frmHesapIslemleri();
            hesap.Show();
        }
        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
