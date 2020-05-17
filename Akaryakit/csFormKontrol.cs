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
using MetroFramework;

namespace Akaryakit
{
    class csFormKontrol
    {
        public csFormKontrol()
        {

        }
        csBaglanti db = new csBaglanti();
        public int txtKontrol(string[] txtBoxAdlar, MetroPanel pnl, MetroForm frm)
        {
            int i = 0;

            while (i < txtBoxAdlar.Length)
            {
                MetroTextBox txtBox = (MetroTextBox)pnl.Controls.Find("txt" + txtBoxAdlar[i], true)[0];
                if (txtBox.Text == string.Empty)
                {
                    MetroMessageBox.Show(frm, "Hata !", txtBoxAdlar[i] + " alanı boş olamaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else if (txtBox.Text != string.Empty)
                {
                    i++;
                }
            }
            if (txtBoxAdlar.Length == i)
            {
                return 1;
            }
            return 0;
        }
        public int txtKontrol(string[] txtBoxAdlar, MetroPanel pnl, MetroForm frm, MetroTabControl tb)
        {
            int i = 0;

            while (i < txtBoxAdlar.Length)
            {
                MetroTextBox txtBox = (MetroTextBox)tb.Controls.Find("txt" + txtBoxAdlar[i], true)[0];
                if (txtBox.Text == string.Empty)
                {
                    MetroMessageBox.Show(frm, "Hata !", " Alanların hepsi doldurulmalı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else if (txtBox.Text != string.Empty)
                {
                    i++;
                }
            }
            if (txtBoxAdlar.Length == i)
            {
                return 1;
            }
            return 0;
        }
        public bool txtTurStringKontrol(string[] txtBoxAdlar, MetroPanel pnl,MetroForm frm)
        {
            int i = 0;

            while (i < txtBoxAdlar.Length)
            {
                MetroTextBox txtBox = (MetroTextBox)pnl.Controls.Find("txt" + txtBoxAdlar[i], true)[0];


                double x;
                int y;
                if (int.TryParse(txtBox.Text, out y))
                {
                    i++;
                }
                else if (double.TryParse(txtBox.Text, out x))
                {
                    return true;
                }
                else
                {
                    MetroMessageBox.Show(frm, "Hata !", txtBoxAdlar[i] + " alanı metinsel ifade içeremez !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (txtBoxAdlar.Length == i)
            {
                return true;
            }
            return false;
        }
        public bool txtTurIntegerKontrol(string[] txtBoxAdlar, MetroPanel pnl, MetroForm frm)
        {
            int i = 0;

            while (i < txtBoxAdlar.Length)
            {
                MetroTextBox txtBox = (MetroTextBox)pnl.Controls.Find("txt" + txtBoxAdlar[i], true)[0];


                double x;
                int y;
                if (int.TryParse(txtBox.Text, out y))
                {
                    MetroMessageBox.Show(frm, "Hata !", txtBoxAdlar[i] + " alanı sayısal ifade olamaz !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (double.TryParse(txtBox.Text, out x))
                {
                    MetroMessageBox.Show(frm, "Hata !", txtBoxAdlar[i] + " alanı ondalıklı ifade içeremez !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    i++;
                }
            }
            if (txtBoxAdlar.Length == i)
            {
                return true;
            }
            return false;
        }
        public bool degerKontrol(MetroTextBox txt,int _lenght,string _name,MetroForm frm)
        {
                if (txt.Text.Length != _lenght)
                {
                    MetroMessageBox.Show(frm,"Hata !",_name +" alanı " + _lenght + " karakter olmalıdır.." , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
        }
     
        public bool ikiTexboxDegerKontrolu(MetroTextBox txtBir, MetroTextBox txtIki, MetroForm  frm,string degerAdlari)
        {
            if(txtBir.Text !=txtIki.Text)
            {
                MetroMessageBox.Show(frm, "Hata !", degerAdlari+" alanı ile aynı olmalıdır", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        public int benzerKayitKontroluEkleme(string tabloAd, string parametre, object deger)
        {
            try
            {
                Convert.ToInt32(deger);
            }
            catch (FormatException)
            {
                return db.tekSorguGetirSayisal("SELECT Count(" + parametre + ") FROM " + tabloAd + " WHERE " + parametre + " = '" + deger + "'");
            }
            return db.tekSorguGetirSayisal("SELECT Count(" + parametre + ") FROM " + tabloAd + " WHERE " + parametre + " = " + deger + "");
        }
        public int benzerKayitKontroluGuncelleme(string tabloAd, string parametre, string deger,string kosul, int kosulKarsiligi)
        {
            return db.tekSorguGetirSayisal("SELECT Count(" + parametre + ") FROM " + tabloAd + " WHERE " + parametre + " IN( '" + deger + "') AND "+kosul+" <> " +kosulKarsiligi);
        }

        public void txtTemizle(MetroPanel pnl)
        {
            foreach (Control item in pnl.Controls)
            
                if (item is MetroTextBox)
                {
                    MetroTextBox tbox = (MetroTextBox)item;
                    tbox.Clear();
                }
        }
    }     
}
