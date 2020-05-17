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
using MetroFramework.Controls;

namespace Akaryakit
{
    public partial class frmTest : MetroForm
    {
        public frmTest()
        {
            InitializeComponent();
        }
        csTasarim tasarim = new csTasarim();
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        csFormKontrol form = new csFormKontrol();

        public void frmTest_Load(object sender, EventArgs e)
        {
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
        }

        private void metroTile1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tasarim.temaGetir());
        }
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click_2(object sender, EventArgs e)
        {
        }

        private void pnlTest_Paint(object sender, PaintEventArgs e)
        {

        }
        csFormKontrol kontrol = new csFormKontrol();
        public void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_3(object sender, EventArgs e)
        {
            double hesap = 90.3;
            MessageBox.Show(hesap.ToString().Substring(0, 4));
        }
    }
}
