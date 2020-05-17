using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakit
{
    class csFiyatlandirma
    {
        csBaglanti db = new csBaglanti();
        public int urunId { get; set; }
        public int pompaId { get; set; }
        public double urunFiyat { get; set; }
        public string plaka { get; set; }
        public string urunAdi { get; set; }
        public double litre { get; set; }
        public double promosyonLitre { get; set; }
        public int promosyonId { get; set; }
        public int promosyonUrun { get; set; }
        public int satisiYapanId { get; set; }
        public string gunSonuSatis { get; set; }
        public string satisZamani { get; set; }
        public int  kullaniciId{ get; set; }
        public int gun { get; set; }
        public int ay { get; set; }
        public int yil { get; set; }


        public int fiyatEkle()
        {
            return db.veriEkleGuncelleSil("UPDATE t_product SET prod_cost=('"+ this.urunFiyat + "') WHERE prod_id="+this.urunId);
        }
        public DataTable satisGuncelfiyat()
        {
            return db.sonucListele("SELECT * FROM t_product LEFT JOIN t_pump ON t_product.prod_id=t_pump.pump_prod_id WHERE t_pump.pump_id=" + this.pompaId);
        }
        public int satisEkle()
        {
            return db.veriEkleGuncelleSil("INSERT INTO t_sales(sales_plate,sales_prod,sales_liter,sales_user_id) VALUES ('"+this.plaka+"',"+this.urunId+","+this.litre.ToString().Replace(',','.')+","+this.satisiYapanId+")");
        }
        public DataTable satisListele()
        {
            return db.sonucListele("SELECT * FROM t_sales");
        }
        public DataTable gunlukSatisListele()
        {
            return db.sonucListele("Select s.sales_plate as [Plaka], s.sales_liter as [Litre],s.sales_time as [Zaman],p.prod_name as [Ürün], p.prod_cost as [Fiyat],u.user_name as [Kullanıcı Adı] from (t_sales as s LEFT JOIN t_product as p ON p.prod_id=s.sales_prod )LEFT JOIN t_users as u ON s.sales_user_id = u.user_id WHERE  (YEAR(s.sales_time)=" + this.yil + ") and (MONTH(s.sales_time) = " + this.ay + ") and (DAY(s.sales_time) = " + this.gun + ")");
        }
        public DataTable kullaniciGunlukSatisListele()
        {
            return db.sonucListele("Select s.sales_plate as [Plaka], s.sales_liter as [Litre],s.sales_time as [Zaman],p.prod_name as [Ürün], p.prod_cost as [Fiyat],u.user_name as [Kullanıcı Adı] from (t_sales as s LEFT JOIN t_product as p ON p.prod_id=s.sales_prod )LEFT JOIN t_users as u ON s.sales_user_id = u.user_id WHERE  (YEAR(s.sales_time)=" + this.yil + ") and (MONTH(s.sales_time) = " + this.ay + ") and (DAY(s.sales_time) = " + this.gun + ") and u.user_id="+this.kullaniciId);
        }
        public DataTable aylikSatisListele()
        {
            return db.sonucListele("Select s.sales_plate as [Plaka], s.sales_liter as [Litre],s.sales_time as [Zaman],p.prod_name as [Ürün], p.prod_cost as [Fiyat],u.user_name as [Kullanıcı Adı] from (t_sales as s LEFT JOIN t_product as p ON p.prod_id=s.sales_prod )LEFT JOIN t_users as u ON s.sales_user_id = u.user_id WHERE  (YEAR(s.sales_time)=" + this.yil + ") and (MONTH(s.sales_time) = " + this.ay + ")");
        }
        public DataTable yillikSatisListele()
        {
            return db.sonucListele("Select s.sales_plate as [Plaka], s.sales_liter as [Litre],s.sales_time as [Zaman],p.prod_name as [Ürün], p.prod_cost as [Fiyat],u.user_name as [Kullanıcı Adı] from (t_sales as s LEFT JOIN t_product as p ON p.prod_id=s.sales_prod )LEFT JOIN t_users as u ON s.sales_user_id = u.user_id WHERE  (YEAR(s.sales_time)=" + this.yil + ")");
        }

        public int gunSonuEkle()
        {
            return db.veriEkleGuncelleSil("INSERT INTO t_end_of_day (day_money) VALUES ("+this.gunSonuSatis+")");
        }
        public double indirimHesap()
        {
            int indirimtutariYuzde = 0;
            DataTable dtb = new DataTable();
            dtb = db.sonucListele("SELECT * FROM t_promotion WHERE pro_liter< "+this.litre.ToString().Replace(',','.')+" ORDER BY pro_liter DESC");
            if (dtb.Rows.Count>0)
            {
                indirimtutariYuzde = Convert.ToInt32(dtb.Rows[0]["pro_sale"]);
            }
            else
            {
                indirimtutariYuzde = 0;
            }
            double hesapla = (this.litre  / 100)*indirimtutariYuzde;
            return hesapla;
        }
        public int promosyonSahiplendir()
        {
            return db.veriEkleGuncelleSil("INSERT INTO t_promotions(pro_plate,pro_users,pro_liter) VALUES ('" + this.plaka + "'," + this.satisiYapanId + ","+this.promosyonLitre.ToString().Replace(',','.')+")");
        }
        public DataTable promosyonLitreGetir()
        {
            return db.sonucListele("SELECT * FROM t_promotions WHERE pro_plate  = '"+this.plaka+"' and pro_is_used=false");
        }
        public int promosyonKullanim()
        {
            return db.veriEkleGuncelleSil("UPDATE t_promotions SET pro_is_used=true WHERE pro_id ="+this.promosyonId);
        }
    }
}
