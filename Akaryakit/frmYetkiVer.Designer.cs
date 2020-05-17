namespace Akaryakit
{
    partial class frmYetkiVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYetkiVer));
            this.lblYetkiKisi = new MetroFramework.Controls.MetroLabel();
            this.btnGuncelle = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmbYetki = new MetroFramework.Controls.MetroComboBox();
            this.lblYetki = new MetroFramework.Controls.MetroLabel();
            this.lblMevcut = new MetroFramework.Controls.MetroLabel();
            this.lblKisi = new MetroFramework.Controls.MetroLabel();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYetkiKisi
            // 
            this.lblYetkiKisi.AutoSize = true;
            this.lblYetkiKisi.Location = new System.Drawing.Point(28, 21);
            this.lblYetkiKisi.Name = "lblYetkiKisi";
            this.lblYetkiKisi.Size = new System.Drawing.Size(152, 19);
            this.lblYetkiKisi.TabIndex = 1;
            this.lblYetkiKisi.Text = "Yetkisi Değiştirilecek Kişi :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(28, 201);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(313, 38);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Yetkiyi Güncelle";
            this.btnGuncelle.UseSelectable = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cmbYetki);
            this.metroPanel1.Controls.Add(this.lblYetki);
            this.metroPanel1.Controls.Add(this.lblMevcut);
            this.metroPanel1.Controls.Add(this.lblKisi);
            this.metroPanel1.Controls.Add(this.lblYetkiKisi);
            this.metroPanel1.Controls.Add(this.btnGuncelle);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(196, 78);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(358, 260);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmbYetki
            // 
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.ItemHeight = 23;
            this.cmbYetki.Location = new System.Drawing.Point(28, 121);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(313, 29);
            this.cmbYetki.TabIndex = 3;
            this.cmbYetki.UseSelectable = true;
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(186, 49);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(29, 19);
            this.lblYetki.TabIndex = 1;
            this.lblYetki.Text = "ssss";
            // 
            // lblMevcut
            // 
            this.lblMevcut.AutoSize = true;
            this.lblMevcut.Location = new System.Drawing.Point(28, 49);
            this.lblMevcut.Name = "lblMevcut";
            this.lblMevcut.Size = new System.Drawing.Size(96, 19);
            this.lblMevcut.TabIndex = 1;
            this.lblMevcut.Text = "Mevcut Yetkisi :";
            // 
            // lblKisi
            // 
            this.lblKisi.AutoSize = true;
            this.lblKisi.Location = new System.Drawing.Point(186, 21);
            this.lblKisi.Name = "lblKisi";
            this.lblKisi.Size = new System.Drawing.Size(29, 19);
            this.lblKisi.TabIndex = 1;
            this.lblKisi.Text = "ssss";
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(688, 15);
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
            // frmYetkiVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 382);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmYetkiVer";
            this.Text = "Verilecek Yetkiyi Seç";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmYetkiVer_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblYetkiKisi;
        private MetroFramework.Controls.MetroButton btnGuncelle;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblMevcut;
        private MetroFramework.Controls.MetroLabel lblYetki;
        private MetroFramework.Controls.MetroLabel lblKisi;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Controls.MetroComboBox cmbYetki;
        private MetroFramework.Components.MetroStyleManager stlPanel;
    }
}