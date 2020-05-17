using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akaryakit
{
    public class csKullaniciIslemleri
    {
        csBaglanti db = new csBaglanti();
        public int kullaniciId{ get; set; }
        public int kullaniciCinsiyet { get; set; }
        public int kullaniciYetkiId { get; set; }
        public string kullaniciAd { get; set; }
        public string kullaniciSifre { get; set; }
        public string kullaniciNick { get; set; }
        public string kullaniciSoyad { get; set; }
        public long kullaniciTel { get; set; }
        public string kullaniciAdres { get; set; }
        public static string kullaniciFormAd { get; set; }
        public int herSayfadakiSonuc { get; set; }
        public int mevcutSayfa { get; set; }
        public csKullaniciIslemleri()
        {
            this.kullaniciId = -1;
            this.kullaniciAd = string.Empty;
            this.kullaniciSifre = string.Empty;
            this.kullaniciNick = string.Empty;
            this.kullaniciSoyad = string.Empty;
            this.kullaniciTel = -1;
            this.kullaniciAdres = string.Empty;
            kullaniciFormAd = "false";
        }
        
        public int girisKontrol()
        {
            int deger = 0;
            DataTable dt = new DataTable();

            dt=db.sonucListele("SELECT * from t_users where user_nick='" + this.kullaniciAd + "' and user_password='" + this.kullaniciSifre+"'");

            if (dt.Rows.Count >= 1)
            {
                bool silinme = Convert.ToBoolean(dt.Rows[0]["user_is_deleted"]);
                int sonuc = Convert.ToInt32( dt.Rows[0]["user_auth"]);

                if (sonuc==1 && silinme ==false)
                {
                    deger = 1;
                }
                else if (sonuc==2 && silinme==false)
                {
                    deger = 2;
                }
                else if (sonuc == 3 && silinme == false)
                {
                    deger = 3;
                }
                else if (sonuc == 4 && silinme == false)
                {
                    deger = 4;
                }
                else
                {
                    deger = 5;
                }
            }
            else
            {
                deger = 0;
            }
            
            return deger;
        }


        public int kullaniciEkle ()
        {
            return db.veriEkleGuncelleSil("INSERT INTO t_users(user_nick,user_name,user_surname,user_password,user_tel,user_location,user_auth,user_gender) values ('" + this.kullaniciNick + "','" + this.kullaniciAd + "','" + this.kullaniciSoyad + "','" + this.kullaniciSifre + "','" + this.kullaniciTel + "','" + this.kullaniciAdres + "','" + this.kullaniciYetkiId + "','" + this.kullaniciCinsiyet  +"')");
        }

        public DataTable kullanicilariGetirInnerJoin()
        {
            return db.sonucListele("SELECT u.user_id as [Numara] , u.user_name as [Adı], u.user_surname as [Soyadı], u.user_nick as [Takma Adı], u.user_password as [Şifre], u.user_tel as [Telefon], u.user_location as [Adres], t_auth.auth_name as [Yetkisi], t_gender.gender_type as [Cinsiyeti] FROM ((t_users AS u) LEFT JOIN t_auth ON  u.user_auth=t_auth.auth_id)  LEFT JOIN t_gender on u.user_gender=t_gender.gender_id WHERE user_is_deleted=false");
        }
        public DataTable sartliKullaniciIdGetir()
        {
            return db.sonucListele("SELECT u.user_id as [Numara], u.user_name as [Adı], u.user_surname as [Soyadı], u.user_nick as [Takma Adı], u.user_password as [Şifre], u.user_tel as [Telefon], u.user_location as [Konum], t_auth.auth_name as [Yetkisi], t_gender.gender_type as [Cinsiyeti] FROM ((t_users AS u) LEFT JOIN t_auth ON  u.user_auth=t_auth.auth_id)  LEFT JOIN t_gender on u.user_gender=t_gender.gender_id WHERE u.user_id=" + this.kullaniciId);
        }
        public DataTable sartliKullaniciIdGetirTumu()
        {
            return db.sonucListele("SELECT * FROM ((t_users AS u) LEFT JOIN t_auth ON  u.user_auth=t_auth.auth_id)  LEFT JOIN t_gender on u.user_gender=t_gender.gender_id WHERE u.user_id=" + this.kullaniciId + "");
        }
        public DataTable sartliKullaniciNickGetir()
        {
            return db.sonucListele("SELECT * FROM ((t_users AS u) LEFT JOIN t_auth ON  u.user_auth=t_auth.auth_id)  LEFT JOIN t_gender on u.user_gender=t_gender.gender_id WHERE u.user_nick='" + this.kullaniciNick + "'");
        }
        public DataTable kullanicilarinHepsiniGetir()
        {
            return db.sonucListele("SELECT * FROM t_users");
        }
        public DataTable kullaniciArama()
        {
            return db.sonucListele("SELECT u.user_name as [Adı], u.user_surname as [Soyadı], u.user_nick as [Takma Adı], u.user_password as [Şifre], u.user_tel as [Telefon], u.user_location as [Adres], t_auth.auth_name as [Yetkisi], t_gender.gender_type as [Cinsiyeti] FROM ((t_users AS u) LEFT JOIN t_auth ON  u.user_auth=t_auth.auth_id)  LEFT JOIN t_gender on u.user_gender=t_gender.gender_id WHERE u.user_name LIKE '%" +this.kullaniciAd+ "%'");
        }

        public int kullaniciGuncelle()
        {
            return db.veriEkleGuncelleSil("UPDATE t_users SET user_name='"+this.kullaniciAd+"',user_password='"+this.kullaniciSifre+"', user_nick='"+this.kullaniciNick+"',user_surname='"+this.kullaniciSoyad+"',  user_tel="+this.kullaniciTel+",user_location='"+this.kullaniciAdres+"',user_gender= "+this.kullaniciCinsiyet+",user_auth="+this.kullaniciYetkiId+" WHERE user_id="+this.kullaniciId+"");
        }
        public int kullaniciSil()
        {
            return db.veriEkleGuncelleSil("UPDATE t_users SET user_is_deleted=true WHERE user_id = "+this.kullaniciId);
        }
        public int yetkiGuncelle()
        {
            return db.veriEkleGuncelleSil("UPDATE t_users SET user_auth = "+this.kullaniciYetkiId+" WHERE user_nick= '"+this.kullaniciNick+"'");
        }
        public int yetkiKontrol()
        {
            DataTable dtb = new DataTable();
            dtb = db.sonucListele("SELECT user_auth FROM t_users WHERE user_id="+this.kullaniciId);
            int yetki = Convert.ToInt32(dtb.Rows[0][0]);
            return yetki;
        }
    }
}
