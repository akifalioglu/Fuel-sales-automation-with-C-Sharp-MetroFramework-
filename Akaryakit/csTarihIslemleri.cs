using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Akaryakit
{
    public class csTarihIslemleri
    {
        public static DateTime GunBaslangic, GunBitis;
        public static DateTime HaftaninIlkGunu, HaftaninSonGunu;
        public static DateTime AyinIlkGunu, AyinSonGunu;
        public static DateTime YilinIlkGunu, YilinSonGunu;

        public static void GunBilgileriniAl()
        {
            GunBaslangic = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
            GunBitis = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
        }
        public static void HaftaBilgileriAl()
        {
            DateTime dt = DateTime.Now;
            switch ((int)dt.DayOfWeek)
            {
                case 0://Haftanın ilk günü Pazar kabul edildiğinden
                    HaftaninIlkGunu = dt.AddDays(-6); // İçinde olduğumuz haftanın başı Pazartesi
                    HaftaninSonGunu = HaftaninIlkGunu.AddDays(6); // Sonraki haftanın başı Pazartesi
                    break;

                default:// Gün Pazar değilse;
                    HaftaninIlkGunu = dt.AddDays(1 - (int)dt.DayOfWeek); // İçinde olduğumuz haftanın başı Pazartesi
                    HaftaninSonGunu = HaftaninIlkGunu.AddDays(6); //  Sonraki haftanın başı Pazartesi
                    break;
            }
        }
        public static void AyBilgileriniAl()
        {
            AyinIlkGunu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Ay ilk günü
            AyinSonGunu = AyinIlkGunu.AddMonths(1).AddDays(-1);// Ay son günü
        }
        public static void YilBilgileriniAl()
        {
            YilinIlkGunu = new DateTime(DateTime.Now.Year, 1, 1); // Yılın ilk günü
            YilinSonGunu = YilinIlkGunu.AddYears(1).AddDays(-1); // Yılın son günü

        }
    }
}
