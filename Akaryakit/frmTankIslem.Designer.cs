namespace Akaryakit
{
    partial class frmTankIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTankIslem));
            this.lblSeviye = new MetroFramework.Controls.MetroLabel();
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            this.pnlTank = new MetroFramework.Controls.MetroPanel();
            this.txtMax = new MetroFramework.Controls.MetroTextBox();
            this.txtMevcutSeviye = new MetroFramework.Controls.MetroTextBox();
            this.cmbTankSec = new MetroFramework.Controls.MetroComboBox();
            this.libMiktar = new MetroFramework.Controls.MetroLabel();
            this.lblMevcutSeviye = new MetroFramework.Controls.MetroLabel();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlTank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeviye
            // 
            this.lblSeviye.AutoSize = true;
            this.lblSeviye.Location = new System.Drawing.Point(65, 42);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(58, 19);
            this.lblSeviye.TabIndex = 6;
            this.lblSeviye.Text = "Tank Seç";
            // 
            // btnEkle
            // 
            this.btnEkle.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEkle.Location = new System.Drawing.Point(276, 148);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(92, 38);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseSelectable = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pnlTank
            // 
            this.pnlTank.Controls.Add(this.txtMax);
            this.pnlTank.Controls.Add(this.txtMevcutSeviye);
            this.pnlTank.Controls.Add(this.cmbTankSec);
            this.pnlTank.Controls.Add(this.btnEkle);
            this.pnlTank.Controls.Add(this.libMiktar);
            this.pnlTank.Controls.Add(this.lblMevcutSeviye);
            this.pnlTank.Controls.Add(this.lblSeviye);
            this.pnlTank.HorizontalScrollbarBarColor = true;
            this.pnlTank.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTank.HorizontalScrollbarSize = 10;
            this.pnlTank.Location = new System.Drawing.Point(149, 63);
            this.pnlTank.Name = "pnlTank";
            this.pnlTank.Size = new System.Drawing.Size(465, 307);
            this.pnlTank.TabIndex = 8;
            this.pnlTank.VerticalScrollbarBarColor = true;
            this.pnlTank.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTank.VerticalScrollbarSize = 10;
            this.pnlTank.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTank_Paint);
            // 
            // txtMax
            // 
            // 
            // 
            // 
            this.txtMax.CustomButton.Image = null;
            this.txtMax.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.txtMax.CustomButton.Name = "";
            this.txtMax.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMax.CustomButton.TabIndex = 1;
            this.txtMax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMax.CustomButton.UseSelectable = true;
            this.txtMax.CustomButton.Visible = false;
            this.txtMax.Lines = new string[0];
            this.txtMax.Location = new System.Drawing.Point(138, 114);
            this.txtMax.MaxLength = 32767;
            this.txtMax.Name = "txtMax";
            this.txtMax.PasswordChar = '\0';
            this.txtMax.PromptText = "Max";
            this.txtMax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMax.SelectedText = "";
            this.txtMax.SelectionLength = 0;
            this.txtMax.SelectionStart = 0;
            this.txtMax.ShortcutsEnabled = true;
            this.txtMax.Size = new System.Drawing.Size(230, 28);
            this.txtMax.TabIndex = 9;
            this.txtMax.UseSelectable = true;
            this.txtMax.WaterMark = "Max";
            this.txtMax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMax_KeyPress);
            // 
            // txtMevcutSeviye
            // 
            // 
            // 
            // 
            this.txtMevcutSeviye.CustomButton.Image = null;
            this.txtMevcutSeviye.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.txtMevcutSeviye.CustomButton.Name = "";
            this.txtMevcutSeviye.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMevcutSeviye.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMevcutSeviye.CustomButton.TabIndex = 1;
            this.txtMevcutSeviye.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMevcutSeviye.CustomButton.UseSelectable = true;
            this.txtMevcutSeviye.CustomButton.Visible = false;
            this.txtMevcutSeviye.Enabled = false;
            this.txtMevcutSeviye.Lines = new string[0];
            this.txtMevcutSeviye.Location = new System.Drawing.Point(138, 80);
            this.txtMevcutSeviye.MaxLength = 32767;
            this.txtMevcutSeviye.Name = "txtMevcutSeviye";
            this.txtMevcutSeviye.PasswordChar = '\0';
            this.txtMevcutSeviye.PromptText = "Mevcut Seviye";
            this.txtMevcutSeviye.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMevcutSeviye.SelectedText = "";
            this.txtMevcutSeviye.SelectionLength = 0;
            this.txtMevcutSeviye.SelectionStart = 0;
            this.txtMevcutSeviye.ShortcutsEnabled = true;
            this.txtMevcutSeviye.Size = new System.Drawing.Size(230, 28);
            this.txtMevcutSeviye.TabIndex = 9;
            this.txtMevcutSeviye.UseSelectable = true;
            this.txtMevcutSeviye.WaterMark = "Mevcut Seviye";
            this.txtMevcutSeviye.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMevcutSeviye.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbTankSec
            // 
            this.cmbTankSec.FormattingEnabled = true;
            this.cmbTankSec.ItemHeight = 23;
            this.cmbTankSec.Location = new System.Drawing.Point(138, 37);
            this.cmbTankSec.Name = "cmbTankSec";
            this.cmbTankSec.Size = new System.Drawing.Size(230, 29);
            this.cmbTankSec.TabIndex = 8;
            this.cmbTankSec.UseSelectable = true;
            this.cmbTankSec.SelectedIndexChanged += new System.EventHandler(this.cmbTankSec_SelectedIndexChanged);
            this.cmbTankSec.SelectionChangeCommitted += new System.EventHandler(this.cmbTankSec_SelectionChangeCommitted);
            this.cmbTankSec.SelectedValueChanged += new System.EventHandler(this.cmbTankSec_SelectedValueChanged);
            // 
            // libMiktar
            // 
            this.libMiktar.AutoSize = true;
            this.libMiktar.Location = new System.Drawing.Point(70, 114);
            this.libMiktar.Name = "libMiktar";
            this.libMiktar.Size = new System.Drawing.Size(53, 19);
            this.libMiktar.TabIndex = 6;
            this.libMiktar.Text = "Miktar :";
            // 
            // lblMevcutSeviye
            // 
            this.lblMevcutSeviye.AutoSize = true;
            this.lblMevcutSeviye.Location = new System.Drawing.Point(25, 80);
            this.lblMevcutSeviye.Name = "lblMevcutSeviye";
            this.lblMevcutSeviye.Size = new System.Drawing.Size(98, 19);
            this.lblMevcutSeviye.TabIndex = 6;
            this.lblMevcutSeviye.Text = "Mevcut Seviye :";
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(665, 24);
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
            // frmTankIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 393);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlTank);
            this.Name = "frmTankIslem";
            this.Text = "Tank Yakıt Girişi";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmTankIslem_Load);
            this.pnlTank.ResumeLayout(false);
            this.pnlTank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblSeviye;
        private MetroFramework.Controls.MetroButton btnEkle;
        private MetroFramework.Controls.MetroPanel pnlTank;
        private MetroFramework.Controls.MetroComboBox cmbTankSec;
        private MetroFramework.Controls.MetroTextBox txtMevcutSeviye;
        private MetroFramework.Controls.MetroLabel lblMevcutSeviye;
        private MetroFramework.Controls.MetroTextBox txtMax;
        private MetroFramework.Controls.MetroLabel libMiktar;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Components.MetroStyleManager stlPanel;
    }
}