namespace Akaryakit
{
    partial class frmGunsonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGunsonu));
            this.pnlGunsonu = new MetroFramework.Controls.MetroPanel();
            this.btnHesapFormu = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblTutar = new MetroFramework.Controls.MetroLabel();
            this.lblToplam = new MetroFramework.Controls.MetroLabel();
            this.lstGunsonu = new System.Windows.Forms.ListBox();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlGunsonu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGunsonu
            // 
            this.pnlGunsonu.Controls.Add(this.btnHesapFormu);
            this.pnlGunsonu.Controls.Add(this.metroLabel1);
            this.pnlGunsonu.Controls.Add(this.lblTutar);
            this.pnlGunsonu.Controls.Add(this.lblToplam);
            this.pnlGunsonu.Controls.Add(this.lstGunsonu);
            this.pnlGunsonu.HorizontalScrollbarBarColor = true;
            this.pnlGunsonu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlGunsonu.HorizontalScrollbarSize = 10;
            this.pnlGunsonu.Location = new System.Drawing.Point(23, 63);
            this.pnlGunsonu.Name = "pnlGunsonu";
            this.pnlGunsonu.Size = new System.Drawing.Size(825, 327);
            this.pnlGunsonu.TabIndex = 0;
            this.pnlGunsonu.VerticalScrollbarBarColor = true;
            this.pnlGunsonu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlGunsonu.VerticalScrollbarSize = 10;
            this.pnlGunsonu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGunsonu_Paint);
            // 
            // btnHesapFormu
            // 
            this.btnHesapFormu.Location = new System.Drawing.Point(244, 237);
            this.btnHesapFormu.Name = "btnHesapFormu";
            this.btnHesapFormu.Size = new System.Drawing.Size(577, 41);
            this.btnHesapFormu.TabIndex = 7;
            this.btnHesapFormu.Text = "Hesap durumuna geç";
            this.btnHesapFormu.UseSelectable = true;
            this.btnHesapFormu.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(179, 248);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(16, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "tl";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(105, 248);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(37, 19);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "Tutar";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(8, 248);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(91, 19);
            this.lblToplam.TabIndex = 5;
            this.lblToplam.Text = "Toplam Tutar :";
            // 
            // lstGunsonu
            // 
            this.lstGunsonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstGunsonu.FormattingEnabled = true;
            this.lstGunsonu.ItemHeight = 18;
            this.lstGunsonu.Location = new System.Drawing.Point(8, 47);
            this.lstGunsonu.Name = "lstGunsonu";
            this.lstGunsonu.Size = new System.Drawing.Size(813, 184);
            this.lstGunsonu.TabIndex = 4;
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(815, 8);
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
            // frmGunsonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 413);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlGunsonu);
            this.Name = "frmGunsonu";
            this.Text = "Günsonu Hesapla";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmGunsonu_Load);
            this.pnlGunsonu.ResumeLayout(false);
            this.pnlGunsonu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlGunsonu;
        private System.Windows.Forms.ListBox lstGunsonu;
        private MetroFramework.Controls.MetroLabel lblTutar;
        private MetroFramework.Controls.MetroLabel lblToplam;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnHesapFormu;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Components.MetroStyleManager stlPanel;
    }
}