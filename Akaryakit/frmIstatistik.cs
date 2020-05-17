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
using Microsoft.VisualBasic;

namespace Akaryakit
{
    public partial class frmIstatistik : MetroForm
    {
        public frmIstatistik()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;

        }
        string[] gunler = {"Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar"};
        double[] gunSonuToplam = new double[8];
        private void frmIstatistik_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
            grf();
        }
        csFiyatlandirma fiyat = new csFiyatlandirma();
        static double toplam;
        void grf()
        {


            foreach (var series in chrSatislar.Series)
            {
                series.Points.Clear();
            }
            int j = 0;

            for (int i = 0; i < 8; i++)
            {

            }
            int sayac = 0;
            csTarihIslemleri.HaftaBilgileriAl();

            int ilkGun = Convert.ToInt32(csTarihIslemleri.HaftaninIlkGunu.Day);
            int sonGun = Convert.ToInt32(csTarihIslemleri.HaftaninSonGunu.Day);
            for (int i = ilkGun; i <= sonGun; i++)
            {
                fiyat.gun = ilkGun + sayac;
                fiyat.ay = DateTime.Now.Month;
                fiyat.yil = DateTime.Now.Year;

                DataTable dtb = new DataTable();
                dtb = fiyat.gunlukSatisListele();
                toplam = 0;
                for (int m = 0; m < dtb.Rows.Count; m++)
                {
                      toplam = toplam +(Convert.ToDouble(dtb.Rows[m]["Fiyat"]) * Convert.ToInt32(dtb.Rows[m]["Litre"]));
                }
                gunSonuToplam[sayac] = toplam;
                j++;
                chrSatislar.Series["Günler"].Points.Add(gunSonuToplam[sayac]);
                chrSatislar.Series["Günler"].Points[sayac].AxisLabel = fiyat.gun+"."+fiyat.ay+"."+fiyat.yil +Environment.NewLine + "("+gunler[sayac]+")";
                chrSatislar.ChartAreas[0].AxisX.LabelStyle.Angle = -70;
              sayac++;
            }
        }

        private void imgGeri_Click(object sender, EventArgs e)
        {
            frmYonetim yonetim = new frmYonetim();
            yonetim.Show();
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
