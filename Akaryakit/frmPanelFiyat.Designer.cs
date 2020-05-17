namespace Akaryakit
{
    partial class frmPanelFiyat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelFiyat));
            this.pnlFiyat = new MetroFramework.Controls.MetroPanel();
            this.lblAciklama = new MetroFramework.Controls.MetroLabel();
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            this.lblFiyatUc = new MetroFramework.Controls.MetroLabel();
            this.lblFiyatIki = new MetroFramework.Controls.MetroLabel();
            this.lblFiyatBir = new MetroFramework.Controls.MetroLabel();
            this.btnFiyatUc = new MetroFramework.Controls.MetroButton();
            this.btnFiyatIki = new MetroFramework.Controls.MetroButton();
            this.btnFiyatBir = new MetroFramework.Controls.MetroButton();
            this.cmbFiyatUc = new MetroFramework.Controls.MetroComboBox();
            this.cmbFiyatIki = new MetroFramework.Controls.MetroComboBox();
            this.cmbFiyatBir = new MetroFramework.Controls.MetroComboBox();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlFiyat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiyat
            // 
            this.pnlFiyat.Controls.Add(this.lblAciklama);
            this.pnlFiyat.Controls.Add(this.btnEkle);
            this.pnlFiyat.Controls.Add(this.lblFiyatUc);
            this.pnlFiyat.Controls.Add(this.lblFiyatIki);
            this.pnlFiyat.Controls.Add(this.lblFiyatBir);
            this.pnlFiyat.Controls.Add(this.btnFiyatUc);
            this.pnlFiyat.Controls.Add(this.btnFiyatIki);
            this.pnlFiyat.Controls.Add(this.btnFiyatBir);
            this.pnlFiyat.Controls.Add(this.cmbFiyatUc);
            this.pnlFiyat.Controls.Add(this.cmbFiyatIki);
            this.pnlFiyat.Controls.Add(this.cmbFiyatBir);
            this.pnlFiyat.HorizontalScrollbarBarColor = true;
            this.pnlFiyat.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlFiyat.HorizontalScrollbarSize = 10;
            this.pnlFiyat.Location = new System.Drawing.Point(20, 56);
            this.pnlFiyat.Name = "pnlFiyat";
            this.pnlFiyat.Size = new System.Drawing.Size(686, 328);
            this.pnlFiyat.TabIndex = 0;
            this.pnlFiyat.UseCustomForeColor = true;
            this.pnlFiyat.VerticalScrollbarBarColor = true;
            this.pnlFiyat.VerticalScrollbarHighlightOnWheel = false;
            this.pnlFiyat.VerticalScrollbarSize = 10;
            this.pnlFiyat.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFiyat_Paint);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAciklama.ForeColor = System.Drawing.Color.Red;
            this.lblAciklama.Location = new System.Drawing.Point(121, 38);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(445, 25);
            this.lblAciklama.TabIndex = 9;
            this.lblAciklama.Text = "# . . Fiyat panosunda görüntülenecek fiyatları seçiniz. . . #";
            this.lblAciklama.UseCustomForeColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Location = new System.Drawing.Point(457, 103);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(204, 186);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Paneli Güncelle";
            this.btnEkle.UseSelectable = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblFiyatUc
            // 
            this.lblFiyatUc.AutoSize = true;
            this.lblFiyatUc.Location = new System.Drawing.Point(17, 265);
            this.lblFiyatUc.Name = "lblFiyatUc";
            this.lblFiyatUc.Size = new System.Drawing.Size(53, 19);
            this.lblFiyatUc.TabIndex = 7;
            this.lblFiyatUc.Text = "Alan 3 :";
            this.lblFiyatUc.Click += new System.EventHandler(this.lblFiyatBir_Click);
            // 
            // lblFiyatIki
            // 
            this.lblFiyatIki.AutoSize = true;
            this.lblFiyatIki.Location = new System.Drawing.Point(17, 182);
            this.lblFiyatIki.Name = "lblFiyatIki";
            this.lblFiyatIki.Size = new System.Drawing.Size(53, 19);
            this.lblFiyatIki.TabIndex = 7;
            this.lblFiyatIki.Text = "Alan 2 :";
            this.lblFiyatIki.Click += new System.EventHandler(this.lblFiyatBir_Click);
            // 
            // lblFiyatBir
            // 
            this.lblFiyatBir.AutoSize = true;
            this.lblFiyatBir.Location = new System.Drawing.Point(17, 106);
            this.lblFiyatBir.Name = "lblFiyatBir";
            this.lblFiyatBir.Size = new System.Drawing.Size(51, 19);
            this.lblFiyatBir.TabIndex = 7;
            this.lblFiyatBir.Text = "Alan 1 :";
            this.lblFiyatBir.Click += new System.EventHandler(this.lblFiyatBir_Click);
            // 
            // btnFiyatUc
            // 
            this.btnFiyatUc.Location = new System.Drawing.Point(315, 261);
            this.btnFiyatUc.Name = "btnFiyatUc";
            this.btnFiyatUc.Size = new System.Drawing.Size(123, 29);
            this.btnFiyatUc.TabIndex = 6;
            this.btnFiyatUc.UseSelectable = true;
            // 
            // btnFiyatIki
            // 
            this.btnFiyatIki.Location = new System.Drawing.Point(315, 178);
            this.btnFiyatIki.Name = "btnFiyatIki";
            this.btnFiyatIki.Size = new System.Drawing.Size(123, 29);
            this.btnFiyatIki.TabIndex = 6;
            this.btnFiyatIki.UseSelectable = true;
            // 
            // btnFiyatBir
            // 
            this.btnFiyatBir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiyatBir.Location = new System.Drawing.Point(315, 103);
            this.btnFiyatBir.Name = "btnFiyatBir";
            this.btnFiyatBir.Size = new System.Drawing.Size(123, 29);
            this.btnFiyatBir.TabIndex = 6;
            this.btnFiyatBir.UseSelectable = true;
            // 
            // cmbFiyatUc
            // 
            this.cmbFiyatUc.FormattingEnabled = true;
            this.cmbFiyatUc.ItemHeight = 23;
            this.cmbFiyatUc.Location = new System.Drawing.Point(74, 261);
            this.cmbFiyatUc.Name = "cmbFiyatUc";
            this.cmbFiyatUc.Size = new System.Drawing.Size(235, 29);
            this.cmbFiyatUc.TabIndex = 5;
            this.cmbFiyatUc.UseSelectable = true;
            this.cmbFiyatUc.SelectedIndexChanged += new System.EventHandler(this.cmbFiyatUc_SelectedIndexChanged);
            // 
            // cmbFiyatIki
            // 
            this.cmbFiyatIki.FormattingEnabled = true;
            this.cmbFiyatIki.ItemHeight = 23;
            this.cmbFiyatIki.Location = new System.Drawing.Point(74, 178);
            this.cmbFiyatIki.Name = "cmbFiyatIki";
            this.cmbFiyatIki.Size = new System.Drawing.Size(235, 29);
            this.cmbFiyatIki.TabIndex = 5;
            this.cmbFiyatIki.UseSelectable = true;
            this.cmbFiyatIki.SelectedIndexChanged += new System.EventHandler(this.cmbFiyatIki_SelectedIndexChanged);
            // 
            // cmbFiyatBir
            // 
            this.cmbFiyatBir.FormattingEnabled = true;
            this.cmbFiyatBir.ItemHeight = 23;
            this.cmbFiyatBir.Location = new System.Drawing.Point(74, 103);
            this.cmbFiyatBir.Name = "cmbFiyatBir";
            this.cmbFiyatBir.Size = new System.Drawing.Size(235, 29);
            this.cmbFiyatBir.TabIndex = 5;
            this.cmbFiyatBir.UseSelectable = true;
            this.cmbFiyatBir.SelectedIndexChanged += new System.EventHandler(this.cmbFiyatBir_SelectedIndexChanged);
            this.cmbFiyatBir.SelectionChangeCommitted += new System.EventHandler(this.cmbFiyatBir_SelectionChangeCommitted);
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(677, 13);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(29, 37);
            this.imgKapat.TabIndex = 34;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // stlPanel
            // 
            this.stlPanel.Owner = this;
            // 
            // frmPanelFiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 407);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlFiyat);
            this.Name = "frmPanelFiyat";
            this.Text = "Panel Fiyatları";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmPanelFiyat_Load);
            this.pnlFiyat.ResumeLayout(false);
            this.pnlFiyat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlFiyat;
        private MetroFramework.Controls.MetroButton btnFiyatBir;
        private MetroFramework.Controls.MetroComboBox cmbFiyatBir;
        private MetroFramework.Controls.MetroLabel lblFiyatBir;
        private MetroFramework.Controls.MetroButton btnFiyatUc;
        private MetroFramework.Controls.MetroButton btnFiyatIki;
        private MetroFramework.Controls.MetroComboBox cmbFiyatUc;
        private MetroFramework.Controls.MetroComboBox cmbFiyatIki;
        private MetroFramework.Controls.MetroLabel lblFiyatUc;
        private MetroFramework.Controls.MetroLabel lblFiyatIki;
        private MetroFramework.Controls.MetroButton btnEkle;
        private MetroFramework.Controls.MetroLabel lblAciklama;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Components.MetroStyleManager stlPanel;
    }
}