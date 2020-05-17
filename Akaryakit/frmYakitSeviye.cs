using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;


namespace Akaryakit
{
    public partial class frmYakitSeviye : MetroForm
    {
        public frmYakitSeviye()
        {
            InitializeComponent();
            this.StyleManager = stlPanel;

        }

        private void frmYakitSeviye_Load(object sender, EventArgs e)
        {
            seviyeOlustur();
            csTasarim tasarim = new csTasarim();
            tasarim.formAcilistaTemaDegistir(stlPanel);
            tasarim.formAcilistaRenkDegistir(stlPanel);
        }
        csUrunler urun = new csUrunler();
        void seviyeOlustur()
        {

            DataTable dt = new DataTable();
            dt = urun.tanklariGetir();
            int x = 0, y = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double tankKapasite = Convert.ToDouble(dt.Rows[i]["tank_capacity"]); 
                double tankSeviye = Convert.ToDouble(dt.Rows[i]["tank_level"]);
                double hesap = (tankSeviye / (tankKapasite / 100));
                MetroProgressSpinner prg = new MetroProgressSpinner();
                prg.Location = new System.Drawing.Point(x*(330+0), y*(250+0));
                prg.Name = "prg"+dt.Rows[i]["tank_id"].ToString();
                prg.Size = new System.Drawing.Size(200, 200);
                prg.Spinning = false;
                prg.TabIndex = 2;
                prg.Maximum = Convert.ToInt32(tankKapasite);
                prg.Value = Convert.ToInt32(tankSeviye);
                prg.Minimum = 0;
                pnlSeviye.Controls.Add(prg);

                x++;
                if (x>=3)
                {
                    y++;
                    x = 0;
                }

                MetroLabel lbl = new MetroLabel();
                lbl.Location = new System.Drawing.Point(70, 70);
                lbl.Name = "prg" + dt.Rows[i]["tank_id"].ToString();
                lbl.Size = new System.Drawing.Size(80, 30);
                lbl.Text = dt.Rows[i]["tank_name"].ToString().Split(' ')[0].ToUpper();
                prg.Controls.Add(lbl); 
                
                MetroLabel lblYuzde = new MetroLabel();
                lblYuzde.Location = new System.Drawing.Point(70, 100);
                lblYuzde.Name = "prg" + dt.Rows[i]["tank_id"].ToString();
                lblYuzde.Size = new System.Drawing.Size(70, 30);
                lblYuzde.FontWeight = MetroFramework.MetroLabelWeight.Bold;
                int nereyeKadarAlsın = 4;
                if (hesap==100)
                {
                    nereyeKadarAlsın = 3;
                }
                else if (hesap == 0)
                {
                    nereyeKadarAlsın = 0;
                }
                else if (hesap.ToString().Length==1)
                {
                    nereyeKadarAlsın = 1;
                }

                lblYuzde.Text ="(% "+hesap.ToString().Substring(0,nereyeKadarAlsın)+")";
                prg.Controls.Add(lblYuzde);


            }
        }

        private void pnlSeviye_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
