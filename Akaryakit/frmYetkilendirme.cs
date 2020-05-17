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
    public partial class frmYetkilendirme : MetroForm
    {
        public frmYetkilendirme()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        private void frmYetkilendirme_Load(object sender, EventArgs e)
        {
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
            dtgKisiSec.DataSource = kullanici.kullanicilariGetirInnerJoin();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            kullanici.kullaniciAd = txtAra.Text;
            dtgKisiSec.DataSource = kullanici.kullaniciArama();
        }
        static string statikKullaniciAdi;
        private void dtgKisiSec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            statikKullaniciAdi = dtgKisiSec.CurrentRow.Cells[2].Value.ToString();
            DataTable dt = new DataTable();
            kullanici.kullaniciNick = statikKullaniciAdi;
            dt = kullanici.sartliKullaniciNickGetir();

            frmYetkiVer yetki = new frmYetkiVer();
            int i;
            i = dtgKisiSec.SelectedCells[0].RowIndex;
            csFormArasiVeriler.kullaniciNick = dtgKisiSec.Rows[i].Cells[3].Value.ToString();
            csFormArasiVeriler.kullaniciYetkiAd = dtgKisiSec.Rows[i].Cells[7].Value.ToString();
            this.Hide();
            yetki.Show();
        }

        private void imgGeri_Click(object sender, EventArgs e)
        {
            frmYonetim yonetim = new frmYonetim();
            yonetim.Show();
            this.Close();
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
