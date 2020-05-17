using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakit
{ 
    class csBaglanti
    {
        public OleDbConnection Baglanti()
        {
            string query = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=proje.mdb";
            OleDbConnection db = new OleDbConnection(query);
            return db;
        }
        public DataTable sonucListele(string sorgu)
        {
            OleDbConnection db = this.Baglanti();
            db.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter(sorgu, db);
            DataTable dtb = new DataTable();
            adap.Fill(dtb);
            db.Close();
            return dtb;
        }
        public string tekSorguGetir(string sorgu)
        {
            OleDbConnection db = this.Baglanti();
            string deger;
            OleDbCommand cmd = new OleDbCommand(sorgu, db);
            db.Open();
            deger = cmd.ExecuteScalar().ToString();
            db.Close();
            return deger;
        }
        public int tekSorguGetirSayisal(string sorgu)
        {
            OleDbConnection db = this.Baglanti();
            int deger;
            OleDbCommand cmd = new OleDbCommand(sorgu, db);
            db.Open();
            deger = (int)cmd.ExecuteScalar();
            db.Close();
            return deger;
        }
        public int veriEkleGuncelleSil(string sorgu)
        {
            OleDbConnection db = this.Baglanti();
            db.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, db);
            int mod;
            mod= komut.ExecuteNonQuery();
            return mod;
        }
    }
}
