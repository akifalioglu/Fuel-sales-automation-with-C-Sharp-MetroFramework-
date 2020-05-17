namespace Akaryakit
{
    partial class frmYakitSeviye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYakitSeviye));
            this.pnlSeviye = new MetroFramework.Controls.MetroPanel();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSeviye
            // 
            this.pnlSeviye.HorizontalScrollbarBarColor = true;
            this.pnlSeviye.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSeviye.HorizontalScrollbarSize = 10;
            this.pnlSeviye.Location = new System.Drawing.Point(19, 64);
            this.pnlSeviye.Name = "pnlSeviye";
            this.pnlSeviye.Size = new System.Drawing.Size(953, 498);
            this.pnlSeviye.TabIndex = 0;
            this.pnlSeviye.VerticalScrollbarBarColor = true;
            this.pnlSeviye.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSeviye.VerticalScrollbarSize = 10;
            this.pnlSeviye.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSeviye_Paint);
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(943, 11);
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
            // frmYakitSeviye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 588);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlSeviye);
            this.Name = "frmYakitSeviye";
            this.Text = "Yakıt Seviyesi";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmYakitSeviye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlSeviye;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Components.MetroStyleManager stlPanel;

    }
}