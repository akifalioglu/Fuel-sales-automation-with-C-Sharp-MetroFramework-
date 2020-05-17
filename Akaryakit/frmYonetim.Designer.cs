namespace Akaryakit
{
    partial class frmYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYonetim));
            this.pnlYonetim = new MetroFramework.Controls.MetroPanel();
            this.tlSatislar = new MetroFramework.Controls.MetroTile();
            this.tlUrunler = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tlIstatistik = new MetroFramework.Controls.MetroTile();
            this.tlKullaniciGuncelle = new MetroFramework.Controls.MetroTile();
            this.tlKullaniciEkle = new MetroFramework.Controls.MetroTile();
            this.tlPanelFiyat = new MetroFramework.Controls.MetroTile();
            this.tlPompaIslem = new MetroFramework.Controls.MetroTile();
            this.tlPromosyon = new MetroFramework.Controls.MetroTile();
            this.tlGunsonu = new MetroFramework.Controls.MetroTile();
            this.tlTank = new MetroFramework.Controls.MetroTile();
            this.tlAyarVeDuzenleme = new MetroFramework.Controls.MetroTile();
            this.tlYetkilendirme = new MetroFramework.Controls.MetroTile();
            this.tlSatisRapor = new MetroFramework.Controls.MetroTile();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.pnlYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlYonetim
            // 
            this.pnlYonetim.Controls.Add(this.tlSatislar);
            this.pnlYonetim.Controls.Add(this.tlUrunler);
            this.pnlYonetim.Controls.Add(this.metroTile2);
            this.pnlYonetim.Controls.Add(this.tlIstatistik);
            this.pnlYonetim.Controls.Add(this.tlKullaniciGuncelle);
            this.pnlYonetim.Controls.Add(this.tlKullaniciEkle);
            this.pnlYonetim.Controls.Add(this.tlPanelFiyat);
            this.pnlYonetim.Controls.Add(this.tlPompaIslem);
            this.pnlYonetim.Controls.Add(this.tlPromosyon);
            this.pnlYonetim.Controls.Add(this.tlGunsonu);
            this.pnlYonetim.Controls.Add(this.tlTank);
            this.pnlYonetim.Controls.Add(this.tlAyarVeDuzenleme);
            this.pnlYonetim.Controls.Add(this.tlYetkilendirme);
            this.pnlYonetim.Controls.Add(this.tlSatisRapor);
            this.pnlYonetim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlYonetim.HorizontalScrollbarBarColor = true;
            this.pnlYonetim.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlYonetim.HorizontalScrollbarSize = 10;
            this.pnlYonetim.Location = new System.Drawing.Point(0, 60);
            this.pnlYonetim.Name = "pnlYonetim";
            this.pnlYonetim.Size = new System.Drawing.Size(867, 498);
            this.pnlYonetim.TabIndex = 7;
            this.pnlYonetim.VerticalScrollbarBarColor = true;
            this.pnlYonetim.VerticalScrollbarHighlightOnWheel = false;
            this.pnlYonetim.VerticalScrollbarSize = 10;
            this.pnlYonetim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlYonetim_Paint);
            // 
            // tlSatislar
            // 
            this.tlSatislar.ActiveControl = null;
            this.tlSatislar.Location = new System.Drawing.Point(626, 223);
            this.tlSatislar.Name = "tlSatislar";
            this.tlSatislar.Size = new System.Drawing.Size(224, 101);
            this.tlSatislar.TabIndex = 12;
            this.tlSatislar.Text = "Satış Yap";
            this.tlSatislar.TileImage = ((System.Drawing.Image)(resources.GetObject("tlSatislar.TileImage")));
            this.tlSatislar.UseSelectable = true;
            this.tlSatislar.UseTileImage = true;
            this.tlSatislar.Click += new System.EventHandler(this.tlSatislar_Click);
            // 
            // tlUrunler
            // 
            this.tlUrunler.ActiveControl = null;
            this.tlUrunler.Location = new System.Drawing.Point(422, 223);
            this.tlUrunler.Name = "tlUrunler";
            this.tlUrunler.Size = new System.Drawing.Size(198, 101);
            this.tlUrunler.TabIndex = 11;
            this.tlUrunler.Text = "Ürün İşlemleri";
            this.tlUrunler.TileImage = ((System.Drawing.Image)(resources.GetObject("tlUrunler.TileImage")));
            this.tlUrunler.UseSelectable = true;
            this.tlUrunler.UseTileImage = true;
            this.tlUrunler.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(703, 53);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(147, 164);
            this.metroTile2.TabIndex = 10;
            this.metroTile2.Text = "Yakıt Seviyesi";
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // tlIstatistik
            // 
            this.tlIstatistik.ActiveControl = null;
            this.tlIstatistik.Location = new System.Drawing.Point(183, 330);
            this.tlIstatistik.Name = "tlIstatistik";
            this.tlIstatistik.Size = new System.Drawing.Size(134, 101);
            this.tlIstatistik.TabIndex = 4;
            this.tlIstatistik.Text = "İstatistikler";
            this.tlIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlIstatistik.TileImage = ((System.Drawing.Image)(resources.GetObject("tlIstatistik.TileImage")));
            this.tlIstatistik.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlIstatistik.UseSelectable = true;
            this.tlIstatistik.UseTileImage = true;
            this.tlIstatistik.Click += new System.EventHandler(this.tlIstatistik_Click);
            // 
            // tlKullaniciGuncelle
            // 
            this.tlKullaniciGuncelle.ActiveControl = null;
            this.tlKullaniciGuncelle.Location = new System.Drawing.Point(194, 223);
            this.tlKullaniciGuncelle.Name = "tlKullaniciGuncelle";
            this.tlKullaniciGuncelle.Size = new System.Drawing.Size(222, 101);
            this.tlKullaniciGuncelle.TabIndex = 4;
            this.tlKullaniciGuncelle.Text = "Kullanıcı Güncelleme ve Silme";
            this.tlKullaniciGuncelle.TileImage = ((System.Drawing.Image)(resources.GetObject("tlKullaniciGuncelle.TileImage")));
            this.tlKullaniciGuncelle.UseSelectable = true;
            this.tlKullaniciGuncelle.UseTileImage = true;
            this.tlKullaniciGuncelle.Click += new System.EventHandler(this.tlKullaniciGuncelle_Click);
            // 
            // tlKullaniciEkle
            // 
            this.tlKullaniciEkle.ActiveControl = null;
            this.tlKullaniciEkle.Location = new System.Drawing.Point(36, 53);
            this.tlKullaniciEkle.Name = "tlKullaniciEkle";
            this.tlKullaniciEkle.Size = new System.Drawing.Size(152, 117);
            this.tlKullaniciEkle.TabIndex = 1;
            this.tlKullaniciEkle.Text = "Kullanıcı Ekle";
            this.tlKullaniciEkle.TileImage = ((System.Drawing.Image)(resources.GetObject("tlKullaniciEkle.TileImage")));
            this.tlKullaniciEkle.UseSelectable = true;
            this.tlKullaniciEkle.UseTileImage = true;
            this.tlKullaniciEkle.Click += new System.EventHandler(this.tlKullaniciEkle_Click);
            // 
            // tlPanelFiyat
            // 
            this.tlPanelFiyat.ActiveControl = null;
            this.tlPanelFiyat.Location = new System.Drawing.Point(536, 53);
            this.tlPanelFiyat.Name = "tlPanelFiyat";
            this.tlPanelFiyat.Size = new System.Drawing.Size(159, 164);
            this.tlPanelFiyat.TabIndex = 8;
            this.tlPanelFiyat.Text = "Panel Fiyatları";
            this.tlPanelFiyat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlPanelFiyat.TileImage = ((System.Drawing.Image)(resources.GetObject("tlPanelFiyat.TileImage")));
            this.tlPanelFiyat.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tlPanelFiyat.UseSelectable = true;
            this.tlPanelFiyat.UseTileImage = true;
            this.tlPanelFiyat.Click += new System.EventHandler(this.tlPanelFiyat_Click);
            // 
            // tlPompaIslem
            // 
            this.tlPompaIslem.ActiveControl = null;
            this.tlPompaIslem.Location = new System.Drawing.Point(369, 134);
            this.tlPompaIslem.Name = "tlPompaIslem";
            this.tlPompaIslem.Size = new System.Drawing.Size(161, 83);
            this.tlPompaIslem.TabIndex = 6;
            this.tlPompaIslem.Text = "Pompa İşlemleri";
            this.tlPompaIslem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlPompaIslem.TileImage = ((System.Drawing.Image)(resources.GetObject("tlPompaIslem.TileImage")));
            this.tlPompaIslem.UseSelectable = true;
            this.tlPompaIslem.UseTileImage = true;
            this.tlPompaIslem.Click += new System.EventHandler(this.tlPompaIslem_Click);
            // 
            // tlPromosyon
            // 
            this.tlPromosyon.ActiveControl = null;
            this.tlPromosyon.Location = new System.Drawing.Point(577, 330);
            this.tlPromosyon.Name = "tlPromosyon";
            this.tlPromosyon.Size = new System.Drawing.Size(141, 101);
            this.tlPromosyon.TabIndex = 7;
            this.tlPromosyon.Text = "Promosyon İşlemleri";
            this.tlPromosyon.TileImage = ((System.Drawing.Image)(resources.GetObject("tlPromosyon.TileImage")));
            this.tlPromosyon.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlPromosyon.UseSelectable = true;
            this.tlPromosyon.UseTileImage = true;
            this.tlPromosyon.Click += new System.EventHandler(this.tlPromosyon_Click);
            // 
            // tlGunsonu
            // 
            this.tlGunsonu.ActiveControl = null;
            this.tlGunsonu.Location = new System.Drawing.Point(450, 330);
            this.tlGunsonu.Name = "tlGunsonu";
            this.tlGunsonu.Size = new System.Drawing.Size(121, 101);
            this.tlGunsonu.TabIndex = 7;
            this.tlGunsonu.Text = "Günsonu İşlemleri";
            this.tlGunsonu.TileImage = ((System.Drawing.Image)(resources.GetObject("tlGunsonu.TileImage")));
            this.tlGunsonu.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlGunsonu.UseSelectable = true;
            this.tlGunsonu.UseTileImage = true;
            this.tlGunsonu.Click += new System.EventHandler(this.tlGunsonu_Click);
            // 
            // tlTank
            // 
            this.tlTank.ActiveControl = null;
            this.tlTank.Location = new System.Drawing.Point(323, 330);
            this.tlTank.Name = "tlTank";
            this.tlTank.Size = new System.Drawing.Size(121, 101);
            this.tlTank.TabIndex = 7;
            this.tlTank.Text = "Tank İşlemleri";
            this.tlTank.TileImage = ((System.Drawing.Image)(resources.GetObject("tlTank.TileImage")));
            this.tlTank.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlTank.UseSelectable = true;
            this.tlTank.UseTileImage = true;
            this.tlTank.Click += new System.EventHandler(this.tlTank_Click);
            // 
            // tlAyarVeDuzenleme
            // 
            this.tlAyarVeDuzenleme.ActiveControl = null;
            this.tlAyarVeDuzenleme.Location = new System.Drawing.Point(194, 53);
            this.tlAyarVeDuzenleme.Name = "tlAyarVeDuzenleme";
            this.tlAyarVeDuzenleme.Size = new System.Drawing.Size(169, 164);
            this.tlAyarVeDuzenleme.TabIndex = 3;
            this.tlAyarVeDuzenleme.Text = "Ayarlar - Düzenlemeler";
            this.tlAyarVeDuzenleme.TileImage = ((System.Drawing.Image)(resources.GetObject("tlAyarVeDuzenleme.TileImage")));
            this.tlAyarVeDuzenleme.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tlAyarVeDuzenleme.UseSelectable = true;
            this.tlAyarVeDuzenleme.UseTileImage = true;
            this.tlAyarVeDuzenleme.Click += new System.EventHandler(this.tlAyarVeDuzenleme_Click);
            // 
            // tlYetkilendirme
            // 
            this.tlYetkilendirme.ActiveControl = null;
            this.tlYetkilendirme.Location = new System.Drawing.Point(369, 53);
            this.tlYetkilendirme.Name = "tlYetkilendirme";
            this.tlYetkilendirme.Size = new System.Drawing.Size(161, 75);
            this.tlYetkilendirme.TabIndex = 5;
            this.tlYetkilendirme.Text = "Yetkilendirme";
            this.tlYetkilendirme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlYetkilendirme.TileImage = ((System.Drawing.Image)(resources.GetObject("tlYetkilendirme.TileImage")));
            this.tlYetkilendirme.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlYetkilendirme.UseSelectable = true;
            this.tlYetkilendirme.UseTileImage = true;
            this.tlYetkilendirme.Click += new System.EventHandler(this.tlYetkilendirme_Click);
            // 
            // tlSatisRapor
            // 
            this.tlSatisRapor.ActiveControl = null;
            this.tlSatisRapor.Location = new System.Drawing.Point(36, 176);
            this.tlSatisRapor.Name = "tlSatisRapor";
            this.tlSatisRapor.Size = new System.Drawing.Size(152, 148);
            this.tlSatisRapor.TabIndex = 2;
            this.tlSatisRapor.Text = "Satış Raporları";
            this.tlSatisRapor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlSatisRapor.TileImage = ((System.Drawing.Image)(resources.GetObject("tlSatisRapor.TileImage")));
            this.tlSatisRapor.UseSelectable = true;
            this.tlSatisRapor.UseTileImage = true;
            this.tlSatisRapor.Click += new System.EventHandler(this.tlSatisRapor_Click);
            // 
            // stlPanel
            // 
            this.stlPanel.Owner = this;
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(838, 12);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(29, 37);
            this.imgKapat.TabIndex = 32;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // frmYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 578);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlYonetim);
            this.Name = "frmYonetim";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Admin Paneli";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmYonetim_Load);
            this.pnlYonetim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tlSatisRapor;
        private MetroFramework.Controls.MetroTile tlYetkilendirme;
        private MetroFramework.Controls.MetroTile tlAyarVeDuzenleme;
        private MetroFramework.Controls.MetroTile tlPompaIslem;
        private MetroFramework.Controls.MetroTile tlPanelFiyat;
        private MetroFramework.Controls.MetroPanel pnlYonetim;
        private MetroFramework.Components.MetroStyleManager stlPanel;
        private MetroFramework.Controls.MetroTile tlKullaniciGuncelle;
        private MetroFramework.Controls.MetroTile tlKullaniciEkle;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Controls.MetroTile tlTank;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile tlIstatistik;
        private MetroFramework.Controls.MetroTile tlUrunler;
        private MetroFramework.Controls.MetroTile tlSatislar;
        private MetroFramework.Controls.MetroTile tlGunsonu;
        private MetroFramework.Controls.MetroTile tlPromosyon;
    }
}