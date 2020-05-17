using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akaryakit
{
    class csGenelGosterim
    {
        csBaglanti db = new csBaglanti();

        public void cmbVeriEkle(ComboBox cmb, string tabloAd, string gorunenDeger, string gizliDeger)
        {
            cmb.DataSource = db.sonucListele("select " + gizliDeger + " , " + gorunenDeger + " from " + tabloAd);
            cmb.DisplayMember = gorunenDeger;
            cmb.ValueMember = gizliDeger;
        }
        public void cmbVeriEkleSartli(ComboBox cmb, string tabloAd, string gorunenDeger, string gizliDeger, string kosul ,object deger)
        {
            cmb.DataSource = db.sonucListele("SELECT " + gizliDeger + " , " + gorunenDeger + " FROM " + tabloAd +" WHERE "+kosul +" = "+ deger);
            cmb.DisplayMember = gorunenDeger;
            cmb.ValueMember = gizliDeger;
        }
    }
}
