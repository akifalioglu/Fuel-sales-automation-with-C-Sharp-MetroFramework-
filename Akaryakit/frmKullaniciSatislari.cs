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
    public partial class frmKullaniciSatislari : MetroForm
    {
        public frmKullaniciSatislari()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }

        private void frmKullaniciSatislari_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
            doldur();
        }
        static double toplam = 0;
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        void doldur()
        {
            dtgKullanicilar.DataSource = kullanici.kullanicilariGetirInnerJoin();
        }
        void satisGetir(int id)
        {
            DataTable dtb = new DataTable();
            csFiyatlandirma fiyat = new csFiyatlandirma();
            fiyat.gun = DateTime.Now.Day;
            fiyat.ay = DateTime.Now.Month;
            fiyat.yil = DateTime.Now.Year;
            fiyat.kullaniciId = id;
            dtb = fiyat.kullaniciGunlukSatisListele();
            if (dtb.Rows.Count > 0)
            {
                lstSatislar.Items.Clear();
                lblTutar.Text = "";
                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    string eleman = dtb.Rows[i]["Kullanıcı Adı"] + " adlı kişi " + dtb.Rows[i]["Litre"] + " litre " + dtb.Rows[i]["Ürün"] + " " + dtb.Rows[i]["Plaka"] + " plakalı araca satış yaptı";
                    toplam = toplam + (Convert.ToDouble(dtb.Rows[i]["Fiyat"]) * Convert.ToInt32(dtb.Rows[i]["Litre"]));
                    lstSatislar.Items.Add(eleman);
                }
                lblTutar.Text = toplam.ToString();
            }
            else
            {
                lstSatislar.Items.Clear();
                lstSatislar.Items.Add("SATIŞ BİLGİSİ YOK");
                lblTutar.Text = "";

            }
        }

        private void dtgKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            satisGetir((int)dtgKullanicilar.CurrentRow.Cells["Numara"].Value);
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
