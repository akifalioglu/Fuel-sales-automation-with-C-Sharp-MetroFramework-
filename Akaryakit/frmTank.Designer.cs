namespace Akaryakit
{
    partial class frmTank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTank));
            this.txtTankAdi = new MetroFramework.Controls.MetroTextBox();
            this.cmbUrunler = new MetroFramework.Controls.MetroComboBox();
            this.lblUrunAdi = new MetroFramework.Controls.MetroLabel();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.btnDuzenle = new MetroFramework.Controls.MetroButton();
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            this.pnlTank = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTankIslem = new MetroFramework.Controls.MetroButton();
            this.txtKapasite = new MetroFramework.Controls.MetroTextBox();
            this.dtgTanklar = new MetroFramework.Controls.MetroGrid();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlTank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTanklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTankAdi
            // 
            // 
            // 
            // 
            this.txtTankAdi.CustomButton.Image = null;
            this.txtTankAdi.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtTankAdi.CustomButton.Name = "";
            this.txtTankAdi.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTankAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTankAdi.CustomButton.TabIndex = 1;
            this.txtTankAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTankAdi.CustomButton.UseSelectable = true;
            this.txtTankAdi.CustomButton.Visible = false;
            this.txtTankAdi.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTankAdi.Lines = new string[0];
            this.txtTankAdi.Location = new System.Drawing.Point(3, 15);
            this.txtTankAdi.MaxLength = 32767;
            this.txtTankAdi.Name = "txtTankAdi";
            this.txtTankAdi.PasswordChar = '\0';
            this.txtTankAdi.PromptText = "Tank Adı";
            this.txtTankAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTankAdi.SelectedText = "";
            this.txtTankAdi.SelectionLength = 0;
            this.txtTankAdi.SelectionStart = 0;
            this.txtTankAdi.ShortcutsEnabled = true;
            this.txtTankAdi.Size = new System.Drawing.Size(318, 27);
            this.txtTankAdi.TabIndex = 5;
            this.txtTankAdi.UseSelectable = true;
            this.txtTankAdi.WaterMark = "Tank Adı";
            this.txtTankAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTankAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.ItemHeight = 23;
            this.cmbUrunler.Location = new System.Drawing.Point(147, 86);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(173, 29);
            this.cmbUrunler.TabIndex = 6;
            this.cmbUrunler.UseSelectable = true;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(3, 90);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(138, 19);
            this.lblUrunAdi.TabIndex = 7;
            this.lblUrunAdi.Text = "Tankta Satılacak Ürün :";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(226, 147);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 34);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(125, 147);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(95, 34);
            this.btnDuzenle.TabIndex = 8;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseSelectable = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(8, 147);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 34);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseSelectable = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pnlTank
            // 
            this.pnlTank.Controls.Add(this.metroLabel1);
            this.pnlTank.Controls.Add(this.panel1);
            this.pnlTank.Controls.Add(this.btnDuzenle);
            this.pnlTank.Controls.Add(this.btnTankIslem);
            this.pnlTank.Controls.Add(this.btnEkle);
            this.pnlTank.Controls.Add(this.txtKapasite);
            this.pnlTank.Controls.Add(this.txtTankAdi);
            this.pnlTank.Controls.Add(this.btnSil);
            this.pnlTank.Controls.Add(this.cmbUrunler);
            this.pnlTank.Controls.Add(this.lblUrunAdi);
            this.pnlTank.HorizontalScrollbarBarColor = true;
            this.pnlTank.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTank.HorizontalScrollbarSize = 10;
            this.pnlTank.Location = new System.Drawing.Point(462, 66);
            this.pnlTank.Name = "pnlTank";
            this.pnlTank.Size = new System.Drawing.Size(335, 311);
            this.pnlTank.TabIndex = 9;
            this.pnlTank.VerticalScrollbarBarColor = true;
            this.pnlTank.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTank.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(147, 206);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Ya da";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 1);
            this.panel1.TabIndex = 9;
            // 
            // btnTankIslem
            // 
            this.btnTankIslem.Location = new System.Drawing.Point(8, 234);
            this.btnTankIslem.Name = "btnTankIslem";
            this.btnTankIslem.Size = new System.Drawing.Size(317, 34);
            this.btnTankIslem.TabIndex = 8;
            this.btnTankIslem.Text = "Tank\'a yakıt ekle.";
            this.btnTankIslem.UseSelectable = true;
            this.btnTankIslem.Click += new System.EventHandler(this.btnTankIslem_Click);
            // 
            // txtKapasite
            // 
            // 
            // 
            // 
            this.txtKapasite.CustomButton.Image = null;
            this.txtKapasite.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtKapasite.CustomButton.Name = "";
            this.txtKapasite.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtKapasite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKapasite.CustomButton.TabIndex = 1;
            this.txtKapasite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKapasite.CustomButton.UseSelectable = true;
            this.txtKapasite.CustomButton.Visible = false;
            this.txtKapasite.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtKapasite.Lines = new string[0];
            this.txtKapasite.Location = new System.Drawing.Point(3, 48);
            this.txtKapasite.MaxLength = 32767;
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.PasswordChar = '\0';
            this.txtKapasite.PromptText = "Tank Kapasitesi";
            this.txtKapasite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKapasite.SelectedText = "";
            this.txtKapasite.SelectionLength = 0;
            this.txtKapasite.SelectionStart = 0;
            this.txtKapasite.ShortcutsEnabled = true;
            this.txtKapasite.Size = new System.Drawing.Size(318, 27);
            this.txtKapasite.TabIndex = 5;
            this.txtKapasite.UseSelectable = true;
            this.txtKapasite.WaterMark = "Tank Kapasitesi";
            this.txtKapasite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKapasite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtgTanklar
            // 
            this.dtgTanklar.AllowUserToAddRows = false;
            this.dtgTanklar.AllowUserToDeleteRows = false;
            this.dtgTanklar.AllowUserToResizeRows = false;
            this.dtgTanklar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgTanklar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTanklar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgTanklar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTanklar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTanklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTanklar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTanklar.EnableHeadersVisualStyles = false;
            this.dtgTanklar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgTanklar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgTanklar.Location = new System.Drawing.Point(13, 66);
            this.dtgTanklar.Name = "dtgTanklar";
            this.dtgTanklar.ReadOnly = true;
            this.dtgTanklar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTanklar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTanklar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgTanklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTanklar.Size = new System.Drawing.Size(443, 311);
            this.dtgTanklar.TabIndex = 0;
            this.dtgTanklar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTanklar_CellClick);
            this.dtgTanklar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTanklar_CellContentClick);
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(767, 23);
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
            // frmTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 400);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlTank);
            this.Controls.Add(this.dtgTanklar);
            this.Name = "frmTank";
            this.Text = "Tank";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmTankEkle_Load);
            this.pnlTank.ResumeLayout(false);
            this.pnlTank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTanklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtTankAdi;
        private MetroFramework.Controls.MetroComboBox cmbUrunler;
        private MetroFramework.Controls.MetroLabel lblUrunAdi;
        private MetroFramework.Controls.MetroButton btnSil;
        private MetroFramework.Controls.MetroButton btnDuzenle;
        private MetroFramework.Controls.MetroButton btnEkle;
        private MetroFramework.Controls.MetroPanel pnlTank;
        private MetroFramework.Controls.MetroGrid dtgTanklar;
        private MetroFramework.Controls.MetroTextBox txtKapasite;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnTankIslem;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Components.MetroStyleManager stlPanel;
    }
}