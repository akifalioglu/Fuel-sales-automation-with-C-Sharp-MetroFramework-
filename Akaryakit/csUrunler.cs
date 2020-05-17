using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakit
{
    class csUrunler
    {
        csBaglanti db= new csBaglanti();
        public string urunAdi { get; set; }
        public double urunFiyati { get; set; }
        public int urunId { get; set; }
        public int tankId { get; set; }
        public string tankAdi { get; set; }
        public int tankLimit { get; set; }
        public double tankDeger { get; set; }
        public int panelBirinciDeger { get; set; }
        public int paneIkinciDeger { get; set; }
        public int panelUcuncuDeger { get; set; }
        public double yapilanSatisLitre { get; set; }
        public int promosyonLitre { get; set; }
        public int promosyonId { get; set; }
        public string promosyonAdi { get; set; }
        public int promosyonYuzdesi { get; set; }


        public csUrunler()
        {
            this.urunAdi= string.Empty;
            this.urunId = -1;
            this.urunFiyati=0;
            this.panelUcuncuDeger = -1;
            this.panelBirinciDeger = -1;
            this.paneIkinciDeger = -1;
        }

        public int urunEkle()
        {
            return db.veriEkleGuncelleSil("INSERT INTO t_product (prod_name,prod_cost)  VALUES ('"+this.urunAdi+"',"+this.urunFiyati.ToString().Replace(',','.')+")");
        }
        public int urunGuncelle()
        {
            return db.veriEkleGuncelleSil("UPDATE t_product SET prod_name='" + this.urunAdi + "' , prod_cost= " + this.urunFiyati.ToString().Replace(',', '.')+ " WHERE prod_id = " + this.urunId + "");
        }
        public int urunSil()
        {
            return db.veriEkleGuncelleSil("DELETE FROM t_product WHERE prod_id = "+ this.urunId +"");
        }
        public DataTable urunleriGetir()
        {
            return db.sonucListele("SELECT prod_id , prod_name as [Ürün Adı], prod_cost as [Ürün Fiyatı] FROM t_product");
        }
        public DataTable urunGetir()
        {
            return db.sonucListele("SELECT prod_id , prod_name as [Ürün Adı], prod_cost as [Ürün Fiyatı] FROM t_product WHERE prod_id = "+this.urunId);
        }
        public DataTable urunArama()
        {
            return db.sonucListele("SELECT prod_id , prod_name as [Ürün Adı] FROM t_product WHERE prod_name LIKE '%" + this.urunAdi + "%'");
        }
        public DataTable tanklariGetir()
        {
            return db.sonucListele("SELECT * FROM t_tank WHERE tank_is_deleted=false");
        }
        public int tankEkle()
        {
            return db.veriEkleGuncelleSil("INSERT INTO t_tank(tank_name,tank_prod,tank_capacity) VALUES ('" + this.tankAdi + "'," + this.urunId + "," + this.tankLimit + ")");
        }
        public int tankGuncelle()
        {
            return db.veriEkleGuncelleSil("UPDATE t_tank SET tank_name ='" + this.tankAdi + "', tank_prod=" + this.urunId + ",tank_capacity=" + this.tankLimit +" Where tank_id="+this.tankId);
        }
        public DataTable sartliTankGetir()
        {
            return db.sonucListele("SELECT * FROM t_tank WHERE tank_id= "+this.tankId);
        }
        public int tankaYakitEkle()
        {
            return db.veriEkleGuncelleSil("UPDATE t_tank SET tank_level=(tank_level+"+this.tankDeger+") WHERE tank_id = "+this.tankId);
        }

        public DataTable tekUrunGetir()
        {
            return db.sonucListele("SELECT * FROM t_product WHERE prod_id =" + this.urunId);
        }
        public DataTable panelFiyatlariniGetir()
        {
            return db.sonucListele("SELECT * FROM t_panel");
        }
        public int panelFiyatGuncelle()
        {
            return db.veriEkleGuncelleSil("UPDATE t_panel SET panel_first="+this.panelBirinciDeger + ", panel_second="+this.paneIkinciDeger+", panel_third="+this.panelUcuncuDeger);
        }
        public int urunStokAzalt()
        {
            return db.veriEkleGuncelleSil("UPDATE t_tank SET tank_level =tank_level - "+this.yapilanSatisLitre.ToString().Replace(',','.') + " WHERE tank_id=" + this.tankId);
        }
        public DataTable uruneGoreTankGetir()
        {
            return db.sonucListele("SELECT * FROM t_tank WHERE tank_prod="+this.urunId);
        }
        public DataTable promosyonlariGetir()
        {
            return db.sonucListele("SELECT * FROM t_promotion WHERE pro_is_deleted=false");
        }
        public int promosyonEkle()
        {
            return db.veriEkleGuncelleSil("INSERT INTO t_promotion(pro_name,pro_sale,pro_liter) VALUES ('"+this.promosyonAdi+"',"+this.promosyonYuzdesi+","+this.promosyonLitre.ToString().Replace(',','.')+")");
        }
        public int promosyonKullanim()
        {
            return db.veriEkleGuncelleSil("UPDATE t_promotions SET pro_is_used=true WHERE pro_id=" + this.promosyonId);
        }
        public int promosyonSil()
        {
            return db.veriEkleGuncelleSil("UPDATE t_promotion SET pro_is_deleted=true WHERE pro_id=" + this.promosyonId);
        }
        public int tankSil()
        {
           return db.veriEkleGuncelleSil("UPDATE t_tank SET tank_is_deleted=true WHERE tank_id="+this.tankId);
        }

    }
}
