using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows;
namespace Akaryakit
{
    class csTabloOlustur
    {
        csKullaniciIslemleri kullanici = new csKullaniciIslemleri();
        public int herSayfadakiSonuc { get; set; }
        public int mevcutSayfa { get; set; }
        public csTabloOlustur()
        {
            this.herSayfadakiSonuc = 6;
            //Default değerimiz 6 her sayfada 6 sonuç olacak
            this.mevcutSayfa = 1;
            //Varsayılan saffayı hatalar olmaması için 1 verdik
        }
        public void formSifirla(MetroLink lnk, MetroForm frm)
        {
            frm.Controls.Remove(lnk);
        }
        public void sayfalama()
        {
            DataTable dtbTumKullanicilar = new DataTable();
            //Tüm kullanıcılarımızı çekiyoruz
            dtbTumKullanicilar = kullanici.kullanicilarinHepsiniGetir();
            kullanici.herSayfadakiSonuc = this.herSayfadakiSonuc;
            kullanici.mevcutSayfa = this.mevcutSayfa;
            int toplamKullanici = dtbTumKullanicilar.Rows.Count;
            decimal sayfaSayisi = Math.Ceiling((decimal)toplamKullanici / this.herSayfadakiSonuc);
            //MessageBox.Show("toplam  : " + toplamKullanici + " var ve "+ sayfaSayisi +" tane sayfa vardır


        }

        public void olustur(MetroForm frm)
        {
            DataTable dtbSinirli = new DataTable();
            //Sadece  görüntülennecek kkullanıcıları getiriyoruz 
            kullanici.herSayfadakiSonuc = this.herSayfadakiSonuc;
            dtbSinirli = kullanici.kullanicilariGetirSinirli();



            MetroTile tlyatay = new MetroTile();
            tlyatay.Location = new System.Drawing.Point(22, 140);
            tlyatay.Name = "metroyty";
            tlyatay.Size = new System.Drawing.Size((frm.Width-(frm.Width*6/100)), 1);

            frm.Controls.Add(tlyatay);

            int boyut = frm.Width / dtbSinirli.Columns.Count;
            for (int i = 0; i < dtbSinirli.Columns.Count; i++)
            {

                // Link oluşturma
                // 
                MetroLink lnk = new MetroLink();
                lnk.Location = new System.Drawing.Point(i * boyut + 5, 100);
                lnk.Name = "lnk" + dtbSinirli.Columns[i].ToString();
                lnk.Size = new System.Drawing.Size(70, 20);
                lnk.Text = dtbSinirli.Columns[i].ToString();
                lnk.UseSelectable = true;
                frm.Controls.Add(lnk);
                // 
                for (int j = 0; j < dtbSinirli.Rows.Count; j++)
                {
                    MetroLabel lbl = new MetroLabel();

                    // Label oluştur
                    // 
                    lbl.Location = new System.Drawing.Point(i * boyut + 15, 150 + (j * 40));
                    lbl.Name = "lbl" + j;
                    lbl.Size = new System.Drawing.Size(70, 20);
                    lbl.Text = dtbSinirli.Rows[j][i].ToString();
                    ////////////////////


                    frm.Controls.Add(lbl);
                }

                // çizgi dikey
                // 
                MetroTile tl = new MetroTile();
                tl.Location = new System.Drawing.Point(i * boyut - 1, 100);
                tl.Name = "metroTile1" + i;
                tl.Size = new System.Drawing.Size(1, 264);
                frm.Controls.Add(tl);
            }
        }
    }
}
