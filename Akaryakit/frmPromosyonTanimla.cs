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
    public partial class frmPromosyonTanimla : MetroForm
    {
        public frmPromosyonTanimla()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }

        private void frmPromosyonTanimla_Load(object sender, EventArgs e)
        {
            doldur();
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }
        csUrunler urun = new csUrunler();
        csFormKontrol formkontrol = new csFormKontrol();
        void doldur()
        {
            dtgPromosyon.DataSource = urun.promosyonlariGetir() ;
        }
        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        string[] txtBoxAdlari = {"PromosyonAdi"};
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (formkontrol.txtKontrol(txtBoxAdlari,pnlPromosyon,this)==1)
            {
                urun.promosyonAdi = txtPromosyonAdi.Text;
                urun.promosyonLitre =Convert.ToInt32( cmbLitre.SelectedItem.ToString());
                urun.promosyonYuzdesi = Convert.ToInt32(cmbIndirim.SelectedItem.ToString().Split(' ')[1]);
                
                if (urun.promosyonEkle()==1)
                {
                    MetroMessageBox.Show(this, "Başarılı !", "Başarıyla eklendi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    doldur();
                }
            }
        }

        private void dtgPromosyon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblIndirimMiktari_Click(object sender, EventArgs e)
        {

        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static int promosyonId;
        private void dtgPromosyon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            promosyonId = Convert.ToInt32(dtgPromosyon.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (promosyonId<0)
            {
                MetroMessageBox.Show(this, "Hata !", "Lütfen promosyon seçiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(" ");
            }
            else
            {
                urun.promosyonId = promosyonId;
                urun.promosyonSil();
                MetroMessageBox.Show(this, "Başarılı !", "Başarıyla silindi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                promosyonId = 0;
                doldur();
            }
        }
    }
}
