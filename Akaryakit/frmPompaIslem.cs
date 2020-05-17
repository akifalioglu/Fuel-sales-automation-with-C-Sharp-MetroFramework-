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
    public partial class frmPompaIslem : MetroForm 
    {
        public frmPompaIslem()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }
        
        csGenelGosterim genel = new csGenelGosterim();
        csPompalar pompalar = new csPompalar();
        csFormKontrol formKontrol = new csFormKontrol();
        private void frmPompaIslem_Load(object sender, EventArgs e)
        {
            doldur();
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }
        void doldur()
        {
            dtgPompalar.DataSource = pompalar.pompaListele();
            dtgPompalar.Columns[0].Visible = false;
            dtgPompalar.Columns[1].Visible = false;
            dtgPompalar.Columns[1].Width = 190;
            dtgPompalar.Columns[2].Width = 190;
            genel.cmbVeriEkle(cmbPompadakiUrun,"t_product","prod_name","prod_id");
        }
        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void lblPompaNo_Click(object sender, EventArgs e)
        {

        }
        string[] txtBoxAdlar = { "PompaNo" };
        private void btnEkle_Click(object sender, EventArgs e)
        {
            pompalar.urunId =Convert.ToInt32(cmbPompadakiUrun.SelectedValue);
            pompalar.pompaNo = txtPompaNo.Text;
            if (formKontrol.txtKontrol(txtBoxAdlar, pnlPompa, this) == 1)
            {
                if (formKontrol.benzerKayitKontroluEkleme("t_pump", "pump_no", txtPompaNo.Text) > 0)
                {
                    MetroMessageBox.Show(this, "Hata !", "Aynı kayıt mevcut ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (pompalar.pompaEkle() == 1)
                    {
                        MetroMessageBox.Show(this, "Başarılı !", "Başarıyla eklendi ..", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        doldur();
                    }
                }
            }

        }

        private void dtgPompalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void imgGeri_Click(object sender, EventArgs e)
        {
            frmYonetim yonetim = new frmYonetim();
            yonetim.Show();
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            pompalar.urunId = Convert.ToInt32(cmbPompadakiUrun.SelectedValue);
            if (pompaId<=0)
            {
                MetroMessageBox.Show(this, "Hata !", "Bir pompa seçiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (formKontrol.txtKontrol(txtBoxAdlar, pnlPompa, this) == 1)
                {
                    if (formKontrol.benzerKayitKontroluGuncelleme("t_pump", "pump_no", txtPompaNo.Text,"pump_id",pompaId) <1)
                    {
                        pompalar.pompaNo = txtPompaNo.Text;
                        pompalar.pompaId = pompaId;
                        pompalar.pompaDuzenle();
                        MetroMessageBox.Show(this, "Başarılı !", "Başarıyla düzenlendi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        pompaId = 0;
                        doldur();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Hata !", "Böyle bir kayıt mevcut", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        static int pompaId;
        private void dtgPompalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pompaId =Convert.ToInt32(dtgPompalar.CurrentRow.Cells[0].Value.ToString());
            txtPompaNo.Text = dtgPompalar.CurrentRow.Cells[2].Value.ToString();
            cmbPompadakiUrun.SelectedValue = Convert.ToInt32(dtgPompalar.CurrentRow.Cells[1].Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (pompaId <= 0)
            {
                MetroMessageBox.Show(this, "Hata !", "Bir pompa seçiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pompalar.pompaId = pompaId;
                pompalar.pompaSil();
                pompaId = 0;
                doldur();
                MetroMessageBox.Show(this, "Başarılı !", "Başarıyla silindi", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
