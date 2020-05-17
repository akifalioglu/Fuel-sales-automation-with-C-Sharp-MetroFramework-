using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Office;
using MetroFramework;
using System.Windows.Forms;

namespace Akaryakit
{
    public static class csExcellRapor
    {
        public static void ExportToExcel(this DataTable dtb, string dosyaKonumu = null)
        {
            try
            {
                if (dtb == null || dtb.Columns.Count == 0)
                    throw new Exception("kaynak boş !");
                var excellUygulama = new Microsoft.Office.Interop.Excel.Application();
                excellUygulama.Workbooks.Add();

                Microsoft.Office.Interop.Excel._Worksheet mevcutSayfa = excellUygulama.ActiveSheet;
                int s = 1;
                Microsoft.Office.Interop.Excel.Range secilen;
                string[] harfler = { "A", "B", "C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U"};
                secilen = mevcutSayfa.get_Range(harfler[0]+1, harfler[dtb.Columns.Count-1]+1);
                secilen.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);

                for (int a = 0; a < dtb.Columns.Count; a++)
                {
                    mevcutSayfa.Cells[1, s]=dtb.Columns[a].ColumnName;
                    mevcutSayfa.Cells[1, s].ColumnWidth = 20;
                    s++;
                }
                
                for (var i = 0; i < dtb.Columns.Count; i++)
                {
                    mevcutSayfa.Cells[2, i + 1] = dtb.Columns[i].ColumnName;
                }

                for (var i = 0; i < dtb.Rows.Count; i++)
                {
                    for (var j = 0; j < dtb.Columns.Count; j++)
                    {
                        mevcutSayfa.Cells[i + 2, j + 1] = dtb.Rows[i][j];
                    }
                }

                
                if (!string.IsNullOrEmpty(dosyaKonumu))
                {
                    try
                    {
                        mevcutSayfa.SaveAs(dosyaKonumu);
                        excellUygulama.Quit();
                        frmSatisRapor frm = new frmSatisRapor();
                        MetroMessageBox.Show(frm, "Mesaj ", "Tema başarıyla eklendi..", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Dosya kaydedilmedi lütfen konumu doğru seçtiğinize emin olun. . .\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excellUygulama.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hata : \n" + ex.Message);
            }
        }
    }
}
