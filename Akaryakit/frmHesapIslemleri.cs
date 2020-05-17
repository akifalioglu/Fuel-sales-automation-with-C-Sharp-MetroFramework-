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
    public partial class frmHesapIslemleri : MetroForm
    {
        public frmHesapIslemleri()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;

        }

        private void frmHesapIslemleri_Load(object sender, EventArgs e)
        {
            txtToplam.Text = csFormArasiVeriler.gunSonuToplam;
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtToplam_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtToplam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true; 
        }

        private void txtPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true; 
        }

        private void txtNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true; 
        }

        private void txtVeresiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true; 
        }

        private void txtIndirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true; 
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double toplamGelmesiGereken;
            double toplamSatis=Convert.ToDouble(txtToplam.Text);
            double acikDurumu;
            toplamGelmesiGereken = Convert.ToDouble(txtPos.Text) + Convert.ToDouble(txtNakit.Text) + Convert.ToDouble(txtVeresiye.Text) - Convert.ToDouble(txtIndirim.Text);
            acikDurumu = toplamSatis - toplamGelmesiGereken;

            if (acikDurumu < toplamSatis)
            {
                lblDurum.Text = acikDurumu.ToString();
            }
        }
    }
}
