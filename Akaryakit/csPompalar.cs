using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakit
{
    class csPompalar
    {

        csBaglanti db = new csBaglanti();
        public int urunId { get; set; }
        public string pompaNo { get; set; }
        public int pompaId { get; set; }
        public int pompaEkle ()
        {
            return db.veriEkleGuncelleSil("INSERT INTO t_pump(pump_no,pump_prod_id) VALUES ('"+pompaNo+"',"+urunId+")");
        }
        public DataTable pompaListele()
        {
            return db.sonucListele("SELECT  pump_id ,pump_prod_id, pump_no as [Pompa Numarası], prod_name as [Pompadaki Satılan Ürün] FROM t_pump LEFT JOIN t_product ON t_pump.pump_prod_id = t_product.prod_id");
        }
        public int pompaSil()
        {
            return db.veriEkleGuncelleSil("DELETE FROM t_pump WHERE pump_id="+this.pompaId);
        }
        public int pompaDuzenle()
        {
            return db.veriEkleGuncelleSil("UPDATE t_pump SET pump_no ='"+this.pompaNo+"' , pump_prod_id="+this.urunId+" Where pump_id=+"+this.pompaId);
        }
    }
}
