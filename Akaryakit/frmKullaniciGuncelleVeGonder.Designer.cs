namespace Akaryakit
{
    partial class frmKullaniciGuncelleVeGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGuncelleVeGonder));
            this.cmbYetki = new MetroFramework.Controls.MetroComboBox();
            this.cmbCinsiyet = new MetroFramework.Controls.MetroComboBox();
            this.btnGuncelle = new MetroFramework.Controls.MetroButton();
            this.lblKullaniciId = new MetroFramework.Controls.MetroLabel();
            this.pnlDuzenle = new MetroFramework.Controls.MetroPanel();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNick = new MetroFramework.Controls.MetroTextBox();
            this.txtAdres = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefon = new MetroFramework.Controls.MetroTextBox();
            this.txtSoyad = new MetroFramework.Controls.MetroTextBox();
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.pnlDuzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYetki
            // 
            this.cmbYetki.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbYetki.ForeColor = System.Drawing.Color.DimGray;
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.ItemHeight = 23;
            this.cmbYetki.Location = new System.Drawing.Point(14, 312);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.PromptText = "Yetkilendirme";
            this.cmbYetki.Size = new System.Drawing.Size(315, 29);
            this.cmbYetki.TabIndex = 28;
            this.cmbYetki.UseSelectable = true;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.ItemHeight = 23;
            this.cmbCinsiyet.Location = new System.Drawing.Point(351, 312);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.PromptText = "Cinsiyet Seçiniz...";
            this.cmbCinsiyet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCinsiyet.Size = new System.Drawing.Size(322, 29);
            this.cmbCinsiyet.TabIndex = 26;
            this.cmbCinsiyet.UseSelectable = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGuncelle.Location = new System.Drawing.Point(175, 353);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(156, 44);
            this.btnGuncelle.Style = MetroFramework.MetroColorStyle.White;
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseCustomBackColor = true;
            this.btnGuncelle.UseSelectable = true;
            this.btnGuncelle.UseStyleColors = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Location = new System.Drawing.Point(14, 30);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(126, 19);
            this.lblKullaniciId.TabIndex = 29;
            this.lblKullaniciId.Text = "Kullanıcı Numarası : ";
            // 
            // pnlDuzenle
            // 
            this.pnlDuzenle.Controls.Add(this.btnSil);
            this.pnlDuzenle.Controls.Add(this.txtSifre);
            this.pnlDuzenle.Controls.Add(this.lblKullaniciId);
            this.pnlDuzenle.Controls.Add(this.cmbYetki);
            this.pnlDuzenle.Controls.Add(this.pictureBox2);
            this.pnlDuzenle.Controls.Add(this.cmbCinsiyet);
            this.pnlDuzenle.Controls.Add(this.txtNick);
            this.pnlDuzenle.Controls.Add(this.txtAdres);
            this.pnlDuzenle.Controls.Add(this.txtTelefon);
            this.pnlDuzenle.Controls.Add(this.txtSoyad);
            this.pnlDuzenle.Controls.Add(this.txtAd);
            this.pnlDuzenle.Controls.Add(this.btnGuncelle);
            this.pnlDuzenle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDuzenle.HorizontalScrollbarBarColor = true;
            this.pnlDuzenle.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDuzenle.HorizontalScrollbarSize = 10;
            this.pnlDuzenle.Location = new System.Drawing.Point(20, 60);
            this.pnlDuzenle.Name = "pnlDuzenle";
            this.pnlDuzenle.Size = new System.Drawing.Size(681, 443);
            this.pnlDuzenle.TabIndex = 30;
            this.pnlDuzenle.VerticalScrollbarBarColor = true;
            this.pnlDuzenle.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDuzenle.VerticalScrollbarSize = 10;
            this.pnlDuzenle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDuzenle_Paint);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSil.Location = new System.Drawing.Point(351, 353);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(156, 44);
            this.btnSil.Style = MetroFramework.MetroColorStyle.White;
            this.btnSil.TabIndex = 31;
            this.btnSil.Text = "Sil";
            this.btnSil.UseCustomBackColor = true;
            this.btnSil.UseSelectable = true;
            this.btnSil.UseStyleColors = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtSifre
            // 
            // 
            // 
            // 
            this.txtSifre.CustomButton.Image = null;
            this.txtSifre.CustomButton.Location = new System.Drawing.Point(287, 2);
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
            this.txtSifre.Location = new System.Drawing.Point(14, 278);
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
            this.txtSifre.Size = new System.Drawing.Size(315, 30);
            this.txtSifre.TabIndex = 30;
            this.txtSifre.UseSelectable = true;
            this.txtSifre.WaterMark = "Şifre Giriniz..";
            this.txtSifre.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(293, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // txtNick
            // 
            // 
            // 
            // 
            this.txtNick.CustomButton.Image = null;
            this.txtNick.CustomButton.Location = new System.Drawing.Point(289, 2);
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
            this.txtNick.Location = new System.Drawing.Point(14, 168);
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
            this.txtNick.Size = new System.Drawing.Size(317, 30);
            this.txtNick.Style = MetroFramework.MetroColorStyle.Red;
            this.txtNick.TabIndex = 19;
            this.txtNick.UseSelectable = true;
            this.txtNick.WaterMark = "Nick Giriniz..";
            this.txtNick.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNick.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAdres.CustomButton.Image = null;
            this.txtAdres.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.txtAdres.CustomButton.Name = "";
            this.txtAdres.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtAdres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdres.CustomButton.TabIndex = 1;
            this.txtAdres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdres.CustomButton.UseSelectable = true;
            this.txtAdres.CustomButton.Visible = false;
            this.txtAdres.DisplayIcon = true;
            this.txtAdres.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAdres.Icon = ((System.Drawing.Image)(resources.GetObject("txtAdres.Icon")));
            this.txtAdres.Lines = new string[0];
            this.txtAdres.Location = new System.Drawing.Point(351, 206);
            this.txtAdres.MaxLength = 80;
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
            this.txtAdres.Size = new System.Drawing.Size(322, 100);
            this.txtAdres.TabIndex = 25;
            this.txtAdres.UseSelectable = true;
            this.txtAdres.WaterMark = "Adres Giriniz..";
            this.txtAdres.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtAdres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelefon
            // 
            // 
            // 
            // 
            this.txtTelefon.CustomButton.Image = null;
            this.txtTelefon.CustomButton.Location = new System.Drawing.Point(294, 2);
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
            this.txtTelefon.Location = new System.Drawing.Point(351, 168);
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
            this.txtTelefon.Size = new System.Drawing.Size(322, 30);
            this.txtTelefon.TabIndex = 24;
            this.txtTelefon.UseSelectable = true;
            this.txtTelefon.WaterMark = "Telefon Giriniz..";
            this.txtTelefon.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTelefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSoyad
            // 
            // 
            // 
            // 
            this.txtSoyad.CustomButton.Image = null;
            this.txtSoyad.CustomButton.Location = new System.Drawing.Point(289, 2);
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
            this.txtSoyad.Location = new System.Drawing.Point(14, 242);
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
            this.txtSoyad.Size = new System.Drawing.Size(317, 30);
            this.txtSoyad.TabIndex = 23;
            this.txtSoyad.UseSelectable = true;
            this.txtSoyad.WaterMark = "Soyad Giriniz..";
            this.txtSoyad.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSoyad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAd
            // 
            // 
            // 
            // 
            this.txtAd.CustomButton.Image = null;
            this.txtAd.CustomButton.Location = new System.Drawing.Point(289, 2);
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
            this.txtAd.Location = new System.Drawing.Point(14, 206);
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
            this.txtAd.Size = new System.Drawing.Size(317, 30);
            this.txtAd.TabIndex = 22;
            this.txtAd.UseSelectable = true;
            this.txtAd.WaterMark = "Ad Giriniz..";
            this.txtAd.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txtAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // stlPanel
            // 
            this.stlPanel.Owner = this;
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(669, 7);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(29, 37);
            this.imgKapat.TabIndex = 31;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // frmKullaniciGuncelleVeGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 523);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlDuzenle);
            this.Name = "frmKullaniciGuncelleVeGonder";
            this.Text = "Kullanıcı Düzenleme Sayfası";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.csKullaniciGuncelleVeGonder_Load);
            this.pnlDuzenle.ResumeLayout(false);
            this.pnlDuzenle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbYetki;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroComboBox cmbCinsiyet;
        private MetroFramework.Controls.MetroTextBox txtNick;
        private MetroFramework.Controls.MetroTextBox txtAdres;
        private MetroFramework.Controls.MetroTextBox txtTelefon;
        private MetroFramework.Controls.MetroTextBox txtSoyad;
        private MetroFramework.Controls.MetroTextBox txtAd;
        private MetroFramework.Controls.MetroButton btnGuncelle;
        private MetroFramework.Controls.MetroLabel lblKullaniciId;
        private MetroFramework.Controls.MetroPanel pnlDuzenle;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private MetroFramework.Controls.MetroButton btnSil;
        private MetroFramework.Components.MetroStyleManager stlPanel;
        private System.Windows.Forms.PictureBox imgKapat;
    }
}