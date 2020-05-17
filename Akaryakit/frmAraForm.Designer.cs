namespace Akaryakit
{
    partial class frmAraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraForm));
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.tlMuhasebe = new MetroFramework.Controls.MetroTile();
            this.tlYonetim = new MetroFramework.Controls.MetroTile();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(375, 16);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(29, 37);
            this.imgKapat.TabIndex = 36;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // tlMuhasebe
            // 
            this.tlMuhasebe.ActiveControl = null;
            this.tlMuhasebe.Location = new System.Drawing.Point(13, 63);
            this.tlMuhasebe.Name = "tlMuhasebe";
            this.tlMuhasebe.Size = new System.Drawing.Size(191, 140);
            this.tlMuhasebe.TabIndex = 37;
            this.tlMuhasebe.Text = "Muhasebe Paneli";
            this.tlMuhasebe.UseSelectable = true;
            this.tlMuhasebe.Click += new System.EventHandler(this.tlMuhasebe_Click);
            // 
            // tlYonetim
            // 
            this.tlYonetim.ActiveControl = null;
            this.tlYonetim.Location = new System.Drawing.Point(210, 63);
            this.tlYonetim.Name = "tlYonetim";
            this.tlYonetim.Size = new System.Drawing.Size(194, 140);
            this.tlYonetim.TabIndex = 37;
            this.tlYonetim.Text = "Standart Panel";
            this.tlYonetim.UseSelectable = true;
            this.tlYonetim.Click += new System.EventHandler(this.tlYonetim_Click);
            // 
            // stlPanel
            // 
            this.stlPanel.Owner = this;
            // 
            // frmAraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 241);
            this.ControlBox = false;
            this.Controls.Add(this.tlYonetim);
            this.Controls.Add(this.tlMuhasebe);
            this.Controls.Add(this.imgKapat);
            this.Name = "frmAraForm";
            this.Text = "Geçiş Formu";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmAraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Controls.MetroTile tlMuhasebe;
        private MetroFramework.Controls.MetroTile tlYonetim;
        private MetroFramework.Components.MetroStyleManager stlPanel;
    }
}