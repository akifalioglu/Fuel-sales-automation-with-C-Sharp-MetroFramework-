namespace Akaryakit
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.lblGiris = new System.Windows.Forms.Label();
            this.lnkYeniKayit = new MetroFramework.Controls.MetroLink();
            this.pnlGiris = new MetroFramework.Controls.MetroPanel();
            this.txtKullaniciSifre = new MetroFramework.Controls.MetroTextBox();
            this.txtKullaniciAd = new MetroFramework.Controls.MetroTextBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // stlPanel
            // 
            this.stlPanel.Owner = this;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiris.Highlight = true;
            this.btnGiris.Location = new System.Drawing.Point(71, 197);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(222, 35);
            this.btnGiris.Style = MetroFramework.MetroColorStyle.White;
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseCustomBackColor = true;
            this.btnGiris.UseCustomForeColor = true;
            this.btnGiris.UseSelectable = true;
            this.btnGiris.UseStyleColors = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.Location = new System.Drawing.Point(129, 65);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(101, 25);
            this.lblGiris.TabIndex = 5;
            this.lblGiris.Text = "Giriş Yap";
            // 
            // lnkYeniKayit
            // 
            this.lnkYeniKayit.Location = new System.Drawing.Point(152, 238);
            this.lnkYeniKayit.Name = "lnkYeniKayit";
            this.lnkYeniKayit.Size = new System.Drawing.Size(63, 23);
            this.lnkYeniKayit.TabIndex = 3;
            this.lnkYeniKayit.Text = "Yeni Kayıt";
            this.lnkYeniKayit.UseSelectable = true;
            this.lnkYeniKayit.Click += new System.EventHandler(this.lnkYeniKayit_Click);
            // 
            // pnlGiris
            // 
            this.pnlGiris.BackColor = System.Drawing.Color.White;
            this.pnlGiris.Controls.Add(this.txtKullaniciSifre);
            this.pnlGiris.Controls.Add(this.txtKullaniciAd);
            this.pnlGiris.Controls.Add(this.lnkYeniKayit);
            this.pnlGiris.Controls.Add(this.lblGiris);
            this.pnlGiris.Controls.Add(this.imgUser);
            this.pnlGiris.Controls.Add(this.btnGiris);
            this.pnlGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGiris.HorizontalScrollbarBarColor = true;
            this.pnlGiris.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlGiris.HorizontalScrollbarSize = 10;
            this.pnlGiris.Location = new System.Drawing.Point(20, 60);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(357, 319);
            this.pnlGiris.TabIndex = 1;
            this.pnlGiris.VerticalScrollbarBarColor = true;
            this.pnlGiris.VerticalScrollbarHighlightOnWheel = false;
            this.pnlGiris.VerticalScrollbarSize = 10;
            this.pnlGiris.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGiris_Paint);
            // 
            // txtKullaniciSifre
            // 
            // 
            // 
            // 
            this.txtKullaniciSifre.CustomButton.BackColor = System.Drawing.Color.Gray;
            this.txtKullaniciSifre.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtKullaniciSifre.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtKullaniciSifre.CustomButton.Name = "";
            this.txtKullaniciSifre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtKullaniciSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKullaniciSifre.CustomButton.TabIndex = 1;
            this.txtKullaniciSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKullaniciSifre.CustomButton.UseCustomBackColor = true;
            this.txtKullaniciSifre.CustomButton.UseSelectable = true;
            this.txtKullaniciSifre.CustomButton.UseVisualStyleBackColor = false;
            this.txtKullaniciSifre.DisplayIcon = true;
            this.txtKullaniciSifre.Icon = ((System.Drawing.Image)(resources.GetObject("txtKullaniciSifre.Icon")));
            this.txtKullaniciSifre.Lines = new string[0];
            this.txtKullaniciSifre.Location = new System.Drawing.Point(71, 155);
            this.txtKullaniciSifre.MaxLength = 32767;
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.PromptText = "Şifre..";
            this.txtKullaniciSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciSifre.SelectedText = "";
            this.txtKullaniciSifre.SelectionLength = 0;
            this.txtKullaniciSifre.SelectionStart = 0;
            this.txtKullaniciSifre.ShortcutsEnabled = true;
            this.txtKullaniciSifre.ShowButton = true;
            this.txtKullaniciSifre.Size = new System.Drawing.Size(222, 27);
            this.txtKullaniciSifre.TabIndex = 1;
            this.txtKullaniciSifre.UseSelectable = true;
            this.txtKullaniciSifre.WaterMark = "Şifre..";
            this.txtKullaniciSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKullaniciSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullaniciSifre.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtKullaniciSifre_ButtonClick);
            // 
            // txtKullaniciAd
            // 
            // 
            // 
            // 
            this.txtKullaniciAd.CustomButton.Image = null;
            this.txtKullaniciAd.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtKullaniciAd.CustomButton.Name = "";
            this.txtKullaniciAd.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtKullaniciAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKullaniciAd.CustomButton.TabIndex = 1;
            this.txtKullaniciAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKullaniciAd.CustomButton.UseSelectable = true;
            this.txtKullaniciAd.CustomButton.Visible = false;
            this.txtKullaniciAd.DisplayIcon = true;
            this.txtKullaniciAd.Icon = ((System.Drawing.Image)(resources.GetObject("txtKullaniciAd.Icon")));
            this.txtKullaniciAd.Lines = new string[0];
            this.txtKullaniciAd.Location = new System.Drawing.Point(71, 113);
            this.txtKullaniciAd.MaxLength = 32767;
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.PasswordChar = '\0';
            this.txtKullaniciAd.PromptText = "Kullanıcı Adı...";
            this.txtKullaniciAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciAd.SelectedText = "";
            this.txtKullaniciAd.SelectionLength = 0;
            this.txtKullaniciAd.SelectionStart = 0;
            this.txtKullaniciAd.ShortcutsEnabled = true;
            this.txtKullaniciAd.Size = new System.Drawing.Size(222, 27);
            this.txtKullaniciAd.TabIndex = 0;
            this.txtKullaniciAd.UseSelectable = true;
            this.txtKullaniciAd.WaterMark = "Kullanıcı Adı...";
            this.txtKullaniciAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKullaniciAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullaniciAd.Click += new System.EventHandler(this.txtKullaniciAd_Click);
            // 
            // imgUser
            // 
            this.imgUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(152, 8);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(51, 54);
            this.imgUser.TabIndex = 4;
            this.imgUser.TabStop = false;
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(345, 17);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(29, 37);
            this.imgKapat.TabIndex = 32;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 399);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlGiris);
            this.Name = "frmGiris";
            this.Text = "Giriş Paneli";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager stlPanel;
        private MetroFramework.Controls.MetroTextBox txtKullaniciAd;
        private MetroFramework.Controls.MetroTextBox txtKullaniciSifre;
        private MetroFramework.Controls.MetroButton btnGiris;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.Label lblGiris;
        private MetroFramework.Controls.MetroLink lnkYeniKayit;
        private MetroFramework.Controls.MetroPanel pnlGiris;
        private System.Windows.Forms.PictureBox imgKapat;
    }
}

