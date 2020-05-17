namespace Akaryakit
{
    partial class frmKullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciEkle));
            this.pnlKullaniciEkle = new MetroFramework.Controls.MetroPanel();
            this.cmbYetki = new MetroFramework.Controls.MetroComboBox();
            this.cmbCinsiyet = new MetroFramework.Controls.MetroComboBox();
            this.txtAdres = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefon = new MetroFramework.Controls.MetroTextBox();
            this.txtSoyad = new MetroFramework.Controls.MetroTextBox();
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.txtSifreTekrar = new MetroFramework.Controls.MetroTextBox();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.txtNick = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.pnlKullaniciEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKullaniciEkle
            // 
            this.pnlKullaniciEkle.BackColor = System.Drawing.Color.White;
            this.pnlKullaniciEkle.Controls.Add(this.cmbYetki);
            this.pnlKullaniciEkle.Controls.Add(this.cmbCinsiyet);
            this.pnlKullaniciEkle.Controls.Add(this.txtAdres);
            this.pnlKullaniciEkle.Controls.Add(this.txtTelefon);
            this.pnlKullaniciEkle.Controls.Add(this.txtSoyad);
            this.pnlKullaniciEkle.Controls.Add(this.txtAd);
            this.pnlKullaniciEkle.Controls.Add(this.btnKaydet);
            this.pnlKullaniciEkle.Controls.Add(this.txtSifreTekrar);
            this.pnlKullaniciEkle.Controls.Add(this.txtSifre);
            this.pnlKullaniciEkle.Controls.Add(this.txtNick);
            this.pnlKullaniciEkle.Controls.Add(this.pictureBox1);
            this.pnlKullaniciEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKullaniciEkle.HorizontalScrollbarBarColor = true;
            this.pnlKullaniciEkle.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlKullaniciEkle.HorizontalScrollbarSize = 10;
            this.pnlKullaniciEkle.Location = new System.Drawing.Point(20, 60);
            this.pnlKullaniciEkle.Name = "pnlKullaniciEkle";
            this.pnlKullaniciEkle.Size = new System.Drawing.Size(705, 434);
            this.pnlKullaniciEkle.TabIndex = 0;
            this.pnlKullaniciEkle.VerticalScrollbarBarColor = true;
            this.pnlKullaniciEkle.VerticalScrollbarHighlightOnWheel = false;
            this.pnlKullaniciEkle.VerticalScrollbarSize = 10;
            // 
            // cmbYetki
            // 
            this.cmbYetki.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.ItemHeight = 23;
            this.cmbYetki.Location = new System.Drawing.Point(352, 299);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.PromptText = "Yetki Seçiniz...";
            this.cmbYetki.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbYetki.Size = new System.Drawing.Size(290, 29);
            this.cmbYetki.TabIndex = 8;
            this.cmbYetki.UseSelectable = true;
            this.cmbYetki.SelectedIndexChanged += new System.EventHandler(this.cmbCinsiyet_SelectedIndexChanged);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.ItemHeight = 23;
            this.cmbCinsiyet.Location = new System.Drawing.Point(352, 264);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.PromptText = "Cinsiyet Seçiniz...";
            this.cmbCinsiyet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCinsiyet.Size = new System.Drawing.Size(290, 29);
            this.cmbCinsiyet.TabIndex = 8;
            this.cmbCinsiyet.UseSelectable = true;
            this.cmbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbCinsiyet_SelectedIndexChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAdres.CustomButton.Image = null;
            this.txtAdres.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtAdres.CustomButton.Name = "";
            this.txtAdres.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.txtAdres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdres.CustomButton.TabIndex = 1;
            this.txtAdres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdres.CustomButton.UseSelectable = true;
            this.txtAdres.CustomButton.Visible = false;
            this.txtAdres.DisplayIcon = true;
            this.txtAdres.Icon = ((System.Drawing.Image)(resources.GetObject("txtAdres.Icon")));
            this.txtAdres.Lines = new string[0];
            this.txtAdres.Location = new System.Drawing.Point(352, 189);
            this.txtAdres.MaxLength = 40;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.PasswordChar = '\0';
            this.txtAdres.PromptText = "Adres Giriniz..";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdres.SelectedText = "";
            this.txtAdres.SelectionLength = 0;
            this.txtAdres.SelectionStart = 0;
            this.txtAdres.ShortcutsEnabled = true;
            this.txtAdres.ShowClearButton = true;
            this.txtAdres.Size = new System.Drawing.Size(291, 65);
            this.txtAdres.TabIndex = 7;
            this.txtAdres.UseSelectable = true;
            this.txtAdres.WaterMark = "Adres Giriniz..";
            this.txtAdres.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtAdres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdres.Click += new System.EventHandler(this.txtAdres_Click);
            // 
            // txtTelefon
            // 
            // 
            // 
            // 
            this.txtTelefon.CustomButton.Image = null;
            this.txtTelefon.CustomButton.Location = new System.Drawing.Point(263, 2);
            this.txtTelefon.CustomButton.Name = "";
            this.txtTelefon.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTelefon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefon.CustomButton.TabIndex = 1;
            this.txtTelefon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefon.CustomButton.UseSelectable = true;
            this.txtTelefon.CustomButton.Visible = false;
            this.txtTelefon.DisplayIcon = true;
            this.txtTelefon.Icon = ((System.Drawing.Image)(resources.GetObject("txtTelefon.Icon")));
            this.txtTelefon.Lines = new string[0];
            this.txtTelefon.Location = new System.Drawing.Point(352, 151);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PasswordChar = '\0';
            this.txtTelefon.PromptText = "Telefon Giriniz..";
            this.txtTelefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefon.SelectedText = "";
            this.txtTelefon.SelectionLength = 0;
            this.txtTelefon.SelectionStart = 0;
            this.txtTelefon.ShortcutsEnabled = true;
            this.txtTelefon.ShowClearButton = true;
            this.txtTelefon.Size = new System.Drawing.Size(291, 30);
            this.txtTelefon.TabIndex = 6;
            this.txtTelefon.UseSelectable = true;
            this.txtTelefon.WaterMark = "Telefon Giriniz..";
            this.txtTelefon.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTelefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefon.TextChanged += new System.EventHandler(this.txtTelefon_TextChanged);
            this.txtTelefon.Click += new System.EventHandler(this.txtTelefon_Click);
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtSoyad
            // 
            // 
            // 
            // 
            this.txtSoyad.CustomButton.Image = null;
            this.txtSoyad.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.txtSoyad.CustomButton.Name = "";
            this.txtSoyad.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoyad.CustomButton.TabIndex = 1;
            this.txtSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoyad.CustomButton.UseSelectable = true;
            this.txtSoyad.CustomButton.Visible = false;
            this.txtSoyad.DisplayIcon = true;
            this.txtSoyad.Icon = ((System.Drawing.Image)(resources.GetObject("txtSoyad.Icon")));
            this.txtSoyad.Lines = new string[0];
            this.txtSoyad.Location = new System.Drawing.Point(61, 224);
            this.txtSoyad.MaxLength = 8;
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PasswordChar = '\0';
            this.txtSoyad.PromptText = "Soyad Giriniz..";
            this.txtSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoyad.SelectedText = "";
            this.txtSoyad.SelectionLength = 0;
            this.txtSoyad.SelectionStart = 0;
            this.txtSoyad.ShortcutsEnabled = true;
            this.txtSoyad.ShowClearButton = true;
            this.txtSoyad.Size = new System.Drawing.Size(270, 30);
            this.txtSoyad.TabIndex = 3;
            this.txtSoyad.UseSelectable = true;
            this.txtSoyad.WaterMark = "Soyad Giriniz..";
            this.txtSoyad.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSoyad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoyad.Click += new System.EventHandler(this.txtSoyad_Click);
            // 
            // txtAd
            // 
            // 
            // 
            // 
            this.txtAd.CustomButton.Image = null;
            this.txtAd.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.txtAd.CustomButton.Name = "";
            this.txtAd.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAd.CustomButton.TabIndex = 1;
            this.txtAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAd.CustomButton.UseSelectable = true;
            this.txtAd.CustomButton.Visible = false;
            this.txtAd.DisplayIcon = true;
            this.txtAd.Icon = ((System.Drawing.Image)(resources.GetObject("txtAd.Icon")));
            this.txtAd.Lines = new string[0];
            this.txtAd.Location = new System.Drawing.Point(61, 188);
            this.txtAd.MaxLength = 8;
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.PromptText = "Ad Giriniz..";
            this.txtAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAd.SelectedText = "";
            this.txtAd.SelectionLength = 0;
            this.txtAd.SelectionStart = 0;
            this.txtAd.ShortcutsEnabled = true;
            this.txtAd.ShowClearButton = true;
            this.txtAd.Size = new System.Drawing.Size(270, 30);
            this.txtAd.TabIndex = 2;
            this.txtAd.UseSelectable = true;
            this.txtAd.WaterMark = "Ad Giriniz..";
            this.txtAd.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAd.Click += new System.EventHandler(this.txtAd_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.SkyBlue;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnKaydet.Location = new System.Drawing.Point(61, 385);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(583, 35);
            this.btnKaydet.Style = MetroFramework.MetroColorStyle.White;
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseCustomBackColor = true;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.UseStyleColors = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSifreTekrar
            // 
            // 
            // 
            // 
            this.txtSifreTekrar.CustomButton.Image = null;
            this.txtSifreTekrar.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txtSifreTekrar.CustomButton.Name = "";
            this.txtSifreTekrar.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSifreTekrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSifreTekrar.CustomButton.TabIndex = 1;
            this.txtSifreTekrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSifreTekrar.CustomButton.UseSelectable = true;
            this.txtSifreTekrar.CustomButton.Visible = false;
            this.txtSifreTekrar.DisplayIcon = true;
            this.txtSifreTekrar.Icon = ((System.Drawing.Image)(resources.GetObject("txtSifreTekrar.Icon")));
            this.txtSifreTekrar.Lines = new string[0];
            this.txtSifreTekrar.Location = new System.Drawing.Point(60, 301);
            this.txtSifreTekrar.MaxLength = 11;
            this.txtSifreTekrar.Multiline = true;
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '\0';
            this.txtSifreTekrar.PromptText = "Şifreyi Tekrar Giriniz..";
            this.txtSifreTekrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifreTekrar.SelectedText = "";
            this.txtSifreTekrar.SelectionLength = 0;
            this.txtSifreTekrar.SelectionStart = 0;
            this.txtSifreTekrar.ShortcutsEnabled = true;
            this.txtSifreTekrar.Size = new System.Drawing.Size(270, 31);
            this.txtSifreTekrar.TabIndex = 5;
            this.txtSifreTekrar.UseSelectable = true;
            this.txtSifreTekrar.WaterMark = "Şifreyi Tekrar Giriniz..";
            this.txtSifreTekrar.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSifreTekrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifreTekrar.Click += new System.EventHandler(this.txtSifre_Click);
            // 
            // txtSifre
            // 
            // 
            // 
            // 
            this.txtSifre.CustomButton.Image = null;
            this.txtSifre.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.txtSifre.CustomButton.Name = "";
            this.txtSifre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSifre.CustomButton.TabIndex = 1;
            this.txtSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSifre.CustomButton.UseSelectable = true;
            this.txtSifre.CustomButton.Visible = false;
            this.txtSifre.DisplayIcon = true;
            this.txtSifre.Icon = ((System.Drawing.Image)(resources.GetObject("txtSifre.Icon")));
            this.txtSifre.Lines = new string[0];
            this.txtSifre.Location = new System.Drawing.Point(61, 264);
            this.txtSifre.MaxLength = 11;
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.PromptText = "Şifre Giriniz..";
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(270, 30);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.UseSelectable = true;
            this.txtSifre.WaterMark = "Şifre Giriniz..";
            this.txtSifre.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            // 
            // txtNick
            // 
            // 
            // 
            // 
            this.txtNick.CustomButton.Image = null;
            this.txtNick.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.txtNick.CustomButton.Name = "";
            this.txtNick.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNick.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNick.CustomButton.TabIndex = 1;
            this.txtNick.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNick.CustomButton.UseSelectable = true;
            this.txtNick.CustomButton.Visible = false;
            this.txtNick.DisplayIcon = true;
            this.txtNick.Icon = ((System.Drawing.Image)(resources.GetObject("txtNick.Icon")));
            this.txtNick.Lines = new string[0];
            this.txtNick.Location = new System.Drawing.Point(61, 150);
            this.txtNick.MaxLength = 8;
            this.txtNick.Multiline = true;
            this.txtNick.Name = "txtNick";
            this.txtNick.PasswordChar = '\0';
            this.txtNick.PromptText = "Nick Giriniz..";
            this.txtNick.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNick.SelectedText = "";
            this.txtNick.SelectionLength = 0;
            this.txtNick.SelectionStart = 0;
            this.txtNick.ShortcutsEnabled = true;
            this.txtNick.ShowClearButton = true;
            this.txtNick.Size = new System.Drawing.Size(270, 30);
            this.txtNick.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNick.TabIndex = 1;
            this.txtNick.UseSelectable = true;
            this.txtNick.WaterMark = "Nick Giriniz..";
            this.txtNick.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNick.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNick.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtNick.Click += new System.EventHandler(this.txtNick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(285, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // stlPanel
            // 
            this.stlPanel.Owner = this;
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(696, 17);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(29, 37);
            this.imgKapat.TabIndex = 32;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // frmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 514);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlKullaniciEkle);
            this.Name = "frmKullaniciEkle";
            this.Text = "Yeni Kayıt";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmKullaniciEkle_Load);
            this.pnlKullaniciEkle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlKullaniciEkle;
        private MetroFramework.Controls.MetroTextBox txtNick;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroTextBox txtAdres;
        private MetroFramework.Controls.MetroTextBox txtTelefon;
        private MetroFramework.Controls.MetroTextBox txtSoyad;
        private MetroFramework.Controls.MetroTextBox txtAd;
        private MetroFramework.Controls.MetroComboBox cmbCinsiyet;
        private MetroFramework.Components.MetroStyleManager stlPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtSifreTekrar;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Controls.MetroComboBox cmbYetki;
    }
}