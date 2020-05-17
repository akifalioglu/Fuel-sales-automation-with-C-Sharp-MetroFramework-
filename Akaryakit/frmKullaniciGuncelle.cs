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
using MetroFramework.Fonts;

namespace Akaryakit
{
    public partial class frmKullaniciGuncelle : MetroForm
    {
        public frmKullaniciGuncelle()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;
        }
        
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        csTasarim tasarim = new csTasarim();
        public static string statikKullaniciAdi;
        //Farklı methodlarda kullanmak üzere statik metodumuzu kullandık
        void baslangictaVeriGetir()
        {
            dtgKullanicilar.DataSource = kullanici.kullanicilariGetirInnerJoin();
            tasarim.formAcilistaRenkDegistir(stlPanel);
            tasarim.formAcilistaTemaDegistir(stlPanel);
        }
        private void frmKullaniciGuncelle_Load(object sender, EventArgs e)
        {
            baslangictaVeriGetir();
        }

        private void dtgKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            statikKullaniciAdi = dtgKullanicilar.CurrentRow.Cells[2].Value.ToString();
            DataTable dt = new DataTable();


            frmKullaniciGuncelleVeGonder kullaniciGuncelleVeGonder = new frmKullaniciGuncelleVeGonder();
            int i;
            i = dtgKullanicilar.CurrentRow.Index;
                csFormArasiVeriler.kullaniciAdi = dtgKullanicilar.Rows[i].Cells[0].Value.ToString();
                csFormArasiVeriler.kullaniciSoyad = dtgKullanicilar.Rows[i].Cells[1].Value.ToString();
                csFormArasiVeriler.kullaniciNick = dtgKullanicilar.Rows[i].Cells[2].Value.ToString();
                csFormArasiVeriler.kullaniciSifre = dtgKullanicilar.Rows[i].Cells[3].Value.ToString();
                csFormArasiVeriler.kullaniciTel = Convert.ToDouble(dtgKullanicilar.Rows[i].Cells[5].Value);
                kullanici.kullaniciId =Convert.ToInt32(dtgKullanicilar.Rows[i].Cells[0].Value);
                dt = kullanici.sartliKullaniciIdGetirTumu();
                csFormArasiVeriler.kullaniciId = Convert.ToInt32(dt.Rows[0]["user_id"]);
                csFormArasiVeriler.kullaniciAdres = dtgKullanicilar.Rows[i].Cells[5].Value.ToString();
                csFormArasiVeriler.kullaniciCinsiyet = dt.Rows[0]["user_gender"].ToString();
                csFormArasiVeriler.kullaniciYetkiId = Convert.ToInt32(dt.Rows[0]["user_auth"].ToString());

            this.Close();
            kullaniciGuncelleVeGonder.Show();
        }

        private void txtTelefon_Click(object sender, EventArgs e)
        {

        }

        private void txtAra_Click(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            kullanici.kullaniciAd=txtAra.Text;
            dtgKullanicilar.DataSource =kullanici.kullaniciArama();
        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgGeri_Click(object sender, EventArgs e)
        {
            frmYonetim yonetim = new frmYonetim();
            yonetim.Show();
            this.Close();
        }
    }
}
