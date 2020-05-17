namespace Akaryakit
{
    partial class frmMuhasebe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuhasebe));
            this.pnlMuhasebe = new MetroFramework.Controls.MetroPanel();
            this.tlPanelFiyat = new MetroFramework.Controls.MetroTile();
            this.tlUrunIslem = new MetroFramework.Controls.MetroTile();
            this.tlYakitSeviye = new MetroFramework.Controls.MetroTile();
            this.tlSatisRapor = new MetroFramework.Controls.MetroTile();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tlPompaIslem = new MetroFramework.Controls.MetroTile();
            this.tlSatislar = new MetroFramework.Controls.MetroTile();
            this.tlIstatistik = new MetroFramework.Controls.MetroTile();
            this.tlGunsonu = new MetroFramework.Controls.MetroTile();
            this.tlPromosyon = new MetroFramework.Controls.MetroTile();
            this.tlTank = new MetroFramework.Controls.MetroTile();
            this.pnlMuhasebe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMuhasebe
            // 
            this.pnlMuhasebe.Controls.Add(this.tlPromosyon);
            this.pnlMuhasebe.Controls.Add(this.tlTank);
            this.pnlMuhasebe.Controls.Add(this.tlGunsonu);
            this.pnlMuhasebe.Controls.Add(this.tlIstatistik);
            this.pnlMuhasebe.Controls.Add(this.tlSatislar);
            this.pnlMuhasebe.Controls.Add(this.tlPompaIslem);
            this.pnlMuhasebe.Controls.Add(this.tlPanelFiyat);
            this.pnlMuhasebe.Controls.Add(this.tlUrunIslem);
            this.pnlMuhasebe.Controls.Add(this.tlYakitSeviye);
            this.pnlMuhasebe.Controls.Add(this.tlSatisRapor);
            this.pnlMuhasebe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMuhasebe.HorizontalScrollbarBarColor = true;
            this.pnlMuhasebe.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMuhasebe.HorizontalScrollbarSize = 10;
            this.pnlMuhasebe.Location = new System.Drawing.Point(20, 60);
            this.pnlMuhasebe.Name = "pnlMuhasebe";
            this.pnlMuhasebe.Size = new System.Drawing.Size(846, 446);
            this.pnlMuhasebe.TabIndex = 33;
            this.pnlMuhasebe.VerticalScrollbarBarColor = true;
            this.pnlMuhasebe.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMuhasebe.VerticalScrollbarSize = 10;
            // 
            // tlPanelFiyat
            // 
            this.tlPanelFiyat.ActiveControl = null;
            this.tlPanelFiyat.Enabled = false;
            this.tlPanelFiyat.Location = new System.Drawing.Point(364, 59);
            this.tlPanelFiyat.Name = "tlPanelFiyat";
            this.tlPanelFiyat.Size = new System.Drawing.Size(280, 164);
            this.tlPanelFiyat.TabIndex = 8;
            this.tlPanelFiyat.Text = "Panel Fiyatları";
            this.tlPanelFiyat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlPanelFiyat.TileImage = ((System.Drawing.Image)(resources.GetObject("tlPanelFiyat.TileImage")));
            this.tlPanelFiyat.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tlPanelFiyat.UseSelectable = true;
            this.tlPanelFiyat.UseTileImage = true;
            this.tlPanelFiyat.Click += new System.EventHandler(this.tlPanelFiyat_Click);
            // 
            // tlUrunIslem
            // 
            this.tlUrunIslem.ActiveControl = null;
            this.tlUrunIslem.Enabled = false;
            this.tlUrunIslem.Location = new System.Drawing.Point(31, 229);
            this.tlUrunIslem.Name = "tlUrunIslem";
            this.tlUrunIslem.Size = new System.Drawing.Size(198, 101);
            this.tlUrunIslem.TabIndex = 7;
            this.tlUrunIslem.Text = "Ürün İşlemleri";
            this.tlUrunIslem.TileImage = ((System.Drawing.Image)(resources.GetObject("tlUrunIslem.TileImage")));
            this.tlUrunIslem.UseSelectable = true;
            this.tlUrunIslem.UseTileImage = true;
            this.tlUrunIslem.Click += new System.EventHandler(this.tlUrunIslem_Click);
            // 
            // tlYakitSeviye
            // 
            this.tlYakitSeviye.ActiveControl = null;
            this.tlYakitSeviye.Location = new System.Drawing.Point(189, 59);
            this.tlYakitSeviye.Name = "tlYakitSeviye";
            this.tlYakitSeviye.Size = new System.Drawing.Size(169, 164);
            this.tlYakitSeviye.TabIndex = 3;
            this.tlYakitSeviye.Text = "Yakıt Seviyesi";
            this.tlYakitSeviye.TileImage = ((System.Drawing.Image)(resources.GetObject("tlYakitSeviye.TileImage")));
            this.tlYakitSeviye.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tlYakitSeviye.UseSelectable = true;
            this.tlYakitSeviye.UseTileImage = true;
            this.tlYakitSeviye.Click += new System.EventHandler(this.tlYakitSeviye_Click);
            // 
            // tlSatisRapor
            // 
            this.tlSatisRapor.ActiveControl = null;
            this.tlSatisRapor.Enabled = false;
            this.tlSatisRapor.Location = new System.Drawing.Point(31, 59);
            this.tlSatisRapor.Name = "tlSatisRapor";
            this.tlSatisRapor.Size = new System.Drawing.Size(152, 164);
            this.tlSatisRapor.TabIndex = 2;
            this.tlSatisRapor.Text = "Satış Raporları";
            this.tlSatisRapor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlSatisRapor.TileImage = ((System.Drawing.Image)(resources.GetObject("tlSatisRapor.TileImage")));
            this.tlSatisRapor.UseSelectable = true;
            this.tlSatisRapor.UseTileImage = true;
            this.tlSatisRapor.Click += new System.EventHandler(this.tlSatisRapor_Click);
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(832, 17);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(29, 37);
            this.imgKapat.TabIndex = 35;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // stlPanel
            // 
            this.stlPanel.Owner = this;
            // 
            // tlPompaIslem
            // 
            this.tlPompaIslem.ActiveControl = null;
            this.tlPompaIslem.Location = new System.Drawing.Point(235, 229);
            this.tlPompaIslem.Name = "tlPompaIslem";
            this.tlPompaIslem.Size = new System.Drawing.Size(161, 101);
            this.tlPompaIslem.TabIndex = 10;
            this.tlPompaIslem.Text = "Pompa İşlemleri";
            this.tlPompaIslem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlPompaIslem.TileImage = ((System.Drawing.Image)(resources.GetObject("tlPompaIslem.TileImage")));
            this.tlPompaIslem.UseSelectable = true;
            this.tlPompaIslem.UseTileImage = true;
            this.tlPompaIslem.Click += new System.EventHandler(this.tlPompaIslem_Click);
            // 
            // tlSatislar
            // 
            this.tlSatislar.ActiveControl = null;
            this.tlSatislar.Location = new System.Drawing.Point(402, 229);
            this.tlSatislar.Name = "tlSatislar";
            this.tlSatislar.Size = new System.Drawing.Size(242, 101);
            this.tlSatislar.TabIndex = 13;
            this.tlSatislar.Text = "Satış Yap";
            this.tlSatislar.TileImage = ((System.Drawing.Image)(resources.GetObject("tlSatislar.TileImage")));
            this.tlSatislar.UseSelectable = true;
            this.tlSatislar.UseTileImage = true;
            this.tlSatislar.Click += new System.EventHandler(this.tlSatislar_Click);
            // 
            // tlIstatistik
            // 
            this.tlIstatistik.ActiveControl = null;
            this.tlIstatistik.Location = new System.Drawing.Point(650, 59);
            this.tlIstatistik.Name = "tlIstatistik";
            this.tlIstatistik.Size = new System.Drawing.Size(176, 128);
            this.tlIstatistik.TabIndex = 14;
            this.tlIstatistik.Text = "İstatistikler";
            this.tlIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlIstatistik.TileImage = ((System.Drawing.Image)(resources.GetObject("tlIstatistik.TileImage")));
            this.tlIstatistik.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlIstatistik.UseSelectable = true;
            this.tlIstatistik.UseTileImage = true;
            this.tlIstatistik.Click += new System.EventHandler(this.tlIstatistik_Click);
            // 
            // tlGunsonu
            // 
            this.tlGunsonu.ActiveControl = null;
            this.tlGunsonu.Location = new System.Drawing.Point(650, 193);
            this.tlGunsonu.Name = "tlGunsonu";
            this.tlGunsonu.Size = new System.Drawing.Size(176, 137);
            this.tlGunsonu.TabIndex = 15;
            this.tlGunsonu.Text = "Günsonu İşlemleri";
            this.tlGunsonu.TileImage = ((System.Drawing.Image)(resources.GetObject("tlGunsonu.TileImage")));
            this.tlGunsonu.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlGunsonu.UseSelectable = true;
            this.tlGunsonu.UseTileImage = true;
            this.tlGunsonu.Click += new System.EventHandler(this.tlGunsonu_Click);
            // 
            // tlPromosyon
            // 
            this.tlPromosyon.ActiveControl = null;
            this.tlPromosyon.Location = new System.Drawing.Point(255, 336);
            this.tlPromosyon.Name = "tlPromosyon";
            this.tlPromosyon.Size = new System.Drawing.Size(141, 101);
            this.tlPromosyon.TabIndex = 16;
            this.tlPromosyon.Text = "Promosyon İşlemleri";
            this.tlPromosyon.TileImage = ((System.Drawing.Image)(resources.GetObject("tlPromosyon.TileImage")));
            this.tlPromosyon.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlPromosyon.UseSelectable = true;
            this.tlPromosyon.UseTileImage = true;
            this.tlPromosyon.Click += new System.EventHandler(this.tlPromosyon_Click);
            // 
            // tlTank
            // 
            this.tlTank.ActiveControl = null;
            this.tlTank.Location = new System.Drawing.Point(402, 336);
            this.tlTank.Name = "tlTank";
            this.tlTank.Size = new System.Drawing.Size(121, 101);
            this.tlTank.TabIndex = 17;
            this.tlTank.Text = "Tank İşlemleri";
            this.tlTank.TileImage = ((System.Drawing.Image)(resources.GetObject("tlTank.TileImage")));
            this.tlTank.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlTank.UseSelectable = true;
            this.tlTank.UseTileImage = true;
            this.tlTank.Click += new System.EventHandler(this.tlTank_Click);
            // 
            // frmMuhasebe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 526);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlMuhasebe);
            this.Name = "frmMuhasebe";
            this.Text = "Muhasebeci Paneli";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmMuhasebe_Load);
            this.pnlMuhasebe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Controls.MetroPanel pnlMuhasebe;
        private MetroFramework.Controls.MetroTile tlPanelFiyat;
        private MetroFramework.Controls.MetroTile tlUrunIslem;
        private MetroFramework.Controls.MetroTile tlYakitSeviye;
        private MetroFramework.Controls.MetroTile tlSatisRapor;
        private MetroFramework.Components.MetroStyleManager stlPanel;
        private MetroFramework.Controls.MetroTile tlPompaIslem;
        private MetroFramework.Controls.MetroTile tlSatislar;
        private MetroFramework.Controls.MetroTile tlIstatistik;
        private MetroFramework.Controls.MetroTile tlGunsonu;
        private MetroFramework.Controls.MetroTile tlPromosyon;
        private MetroFramework.Controls.MetroTile tlTank;
    }
}