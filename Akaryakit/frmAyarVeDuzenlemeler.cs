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
    public partial class frmAyarVeDuzenlemeler : MetroForm
    {
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        csTasarim tasarim = new csTasarim();
        csGenelGosterim genel = new csGenelGosterim();
        public frmAyarVeDuzenlemeler()
        {
            InitializeComponent();
            doldur();
            this.StyleManager = stlPanel;
        }
        public void doldur()
        {
            genel.cmbVeriEkle(cmbFormRenk, "t_design_color", "color_name", "color_id");
            genel.cmbVeriEkle(cmbFormArka, "t_design_back", "back_name", "back_id");
        }
        private void frmAyarVeDuzenlemeler_Load(object sender, EventArgs e)
        {
            cmbFormRenk.Text = tasarim.renkGetir();
            cmbFormArka.Text = tasarim.temaGetir();
        }

        private void btnStilKaydet_Click(object sender, EventArgs e)
        {
            tasarim.formRenkId = Convert.ToInt32(cmbFormRenk.SelectedValue.ToString());
            tasarim.formArkaRenkId = Convert.ToInt32(cmbFormArka.SelectedValue.ToString());
            if(tasarim.temaEkle()==1)
            {
                MetroMessageBox.Show(this, "Mesaj ", "Tema başarıyla eklendi..", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MetroMessageBox.Show(this, "Hata ! ", "Tema eklenirken bir sorunla karşılaşıldı ..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFormRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            stlPanel.Style=(MetroFramework.MetroColorStyle)Convert.ToInt32(cmbFormRenk.SelectedIndex);
        }

        private void cmbFormArka_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFormArka.SelectedIndex)
            {
                case 0:
                    stlPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case 1:
                    stlPanel.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
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

        private void btnTestWarning_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Test", "Test", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Test", "Test", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnAsterisk_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Test", "Test", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Test", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Test", "Test", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void btnExclamation_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Test", "Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }


    }
}
