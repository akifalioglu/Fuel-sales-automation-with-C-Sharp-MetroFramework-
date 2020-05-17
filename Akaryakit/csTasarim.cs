using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;

namespace Akaryakit
{
    public class csTasarim
    {
        csBaglanti db = new csBaglanti();
        public int formRenkId { get; set; }
        public int formArkaRenkId { get; set; }
        public csTasarim()
        {
            this.formRenkId = -1;
            this.formArkaRenkId = -1;
        }

        public int temaEkle()
        {
            return db.veriEkleGuncelleSil("INSERT INTO t_design(design_color_id,design_back_id) values ('" + this.formRenkId + "','" + this.formArkaRenkId + "')");
        }
        public string temaGetir()
        {
            return db.tekSorguGetir("SELECT t_design_back.back_name FROM t_design_color INNER JOIN (t_design_back INNER JOIN t_design ON t_design_back.back_id = t_design.design_back_id) ON t_design_color.color_id = t_design.design_color_id ORDER BY t_design.design_id DESC");
        }
        public string renkGetir()
        {
            return db.tekSorguGetir("SELECT t_design_color.color_name FROM t_design_color INNER JOIN (t_design_back INNER JOIN t_design ON t_design_back.back_id = t_design.design_back_id) ON t_design_color.color_id = t_design.design_color_id ORDER BY t_design.design_id DESC");
        }
        public void formAcilistaTemaDegistir(MetroStyleManager stlPanel)
        {
            switch (this.temaGetir())
            {
                case "Dark":
                    stlPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case "Light":
                    stlPanel.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
        }
        public void formAcilistaRenkDegistir(MetroStyleManager stlPanel)
        {
            switch(this.renkGetir())
            {
                case "Black":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Black;
                    break;
                case "White":
                    stlPanel.Style = MetroFramework.MetroColorStyle.White;
                    break;
                case "Silver":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Silver;
                    break;
                case "Blue":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
                case "Green":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Green;
                    break;
                case "Lime":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Lime;
                    break;
                case "Teal":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Teal;
                    break;
                case "Orange":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Orange;
                    break;
                case "Brown":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Brown;
                    break;
                case "Pink":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Pink;
                    break;
                case "Magenta":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Magenta;
                    break;
                case "Purple":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Purple;
                    break;
                case "Red":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Red;
                    break;
                case "Yellow":
                    stlPanel.Style = MetroFramework.MetroColorStyle.Yellow;
                    break;
                default:
                    stlPanel.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
            }
        }
    }
}
