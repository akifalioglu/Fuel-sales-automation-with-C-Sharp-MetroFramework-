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
using System.IO;
using Microsoft.VisualBasic;

namespace Akaryakit
{
    public partial class frmSatisRapor : MetroForm
    {
        csUrunler urun = new csUrunler();
        csFiyatlandirma f = new csFiyatlandirma();
        public frmSatisRapor()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }

        private void frmSatisRapor_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }
        string dosyaYoluSec(string tur)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                dialog.Description = "Lütfen aşağıdaki listeden bir dizin seçiniz."; 
                dialog.RootFolder = Environment.SpecialFolder.Desktop; 
                return (dialog.SelectedPath + "/"+tur+".xlsx");
            }

            return "1";
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
                csFiyatlandirma fiyat = new csFiyatlandirma();
                DataTable dtb = new DataTable();
                fiyat.yil = DateTime.Now.Year;
                fiyat.ay = DateTime.Now.Month;
                fiyat.gun = DateTime.Now.Day;
                dtb = fiyat.gunlukSatisListele();
                dtb.ExportToExcel(dosyaYoluSec("gunlukrapor"));
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            csFiyatlandirma fiyat = new csFiyatlandirma();
            DataTable dtb = new DataTable();
            fiyat.yil = DateTime.Now.Year;
            fiyat.ay  = DateTime.Now.Month;

            dtb = fiyat.aylikSatisListele();

            dtb.ExportToExcel(dosyaYoluSec("aylikrapor"));
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tlYillik_Click(object sender, EventArgs e)
        {
            csFiyatlandirma fiyat = new csFiyatlandirma();
            DataTable dtb = new DataTable();
            fiyat.yil = DateTime.Now.Year;
            fiyat.ay = DateTime.Now.Month;

            dtb = fiyat.yillikSatisListele();

            dtb.ExportToExcel(dosyaYoluSec("yillikrapor"));
        }
    }
}
