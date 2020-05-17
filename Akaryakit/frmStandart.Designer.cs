namespace Akaryakit
{
    partial class frmStandart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStandart));
            this.tlSatisEkle = new MetroFramework.Controls.MetroTile();
            this.tlRakip = new MetroFramework.Controls.MetroTile();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tlIstatistik = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // tlSatisEkle
            // 
            this.tlSatisEkle.ActiveControl = null;
            this.tlSatisEkle.Location = new System.Drawing.Point(132, 63);
            this.tlSatisEkle.Name = "tlSatisEkle";
            this.tlSatisEkle.Size = new System.Drawing.Size(160, 75);
            this.tlSatisEkle.TabIndex = 0;
            this.tlSatisEkle.Text = "Satış Ekle";
            this.tlSatisEkle.UseSelectable = true;
            this.tlSatisEkle.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // tlRakip
            // 
            this.tlRakip.ActiveControl = null;
            this.tlRakip.Location = new System.Drawing.Point(298, 63);
            this.tlRakip.Name = "tlRakip";
            this.tlRakip.Size = new System.Drawing.Size(160, 75);
            this.tlRakip.TabIndex = 0;
            this.tlRakip.Text = "Rakiplerimin Satışları";
            this.tlRakip.UseSelectable = true;
            this.tlRakip.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(673, 11);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(29, 37);
            this.imgKapat.TabIndex = 33;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // stlPanel
            // 
            this.stlPanel.Owner = this;
            // 
            // tlIstatistik
            // 
            this.tlIstatistik.ActiveControl = null;
            this.tlIstatistik.Location = new System.Drawing.Point(132, 144);
            this.tlIstatistik.Name = "tlIstatistik";
            this.tlIstatistik.Size = new System.Drawing.Size(326, 83);
            this.tlIstatistik.TabIndex = 34;
            this.tlIstatistik.Text = "İstatistikler";
            this.tlIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlIstatistik.TileImage = ((System.Drawing.Image)(resources.GetObject("tlIstatistik.TileImage")));
            this.tlIstatistik.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlIstatistik.UseSelectable = true;
            this.tlIstatistik.UseTileImage = true;
            this.tlIstatistik.Click += new System.EventHandler(this.tlIstatistik_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(464, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(147, 164);
            this.metroTile2.TabIndex = 35;
            this.metroTile2.Text = "Yakıt Seviyesi";
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // frmStandart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 334);
            this.ControlBox = false;
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.tlIstatistik);
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.tlRakip);
            this.Controls.Add(this.tlSatisEkle);
            this.Name = "frmStandart";
            this.Text = "İşçi Paneli";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tlSatisEkle;
        private MetroFramework.Controls.MetroTile tlRakip;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Components.MetroStyleManager stlPanel;
        private MetroFramework.Controls.MetroTile tlIstatistik;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}