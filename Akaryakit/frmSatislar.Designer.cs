namespace Akaryakit
{
    partial class frmSatislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatislar));
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            this.pnlSatislar = new MetroFramework.Controls.MetroPanel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblNot = new MetroFramework.Controls.MetroLabel();
            this.cmbKullanici = new MetroFramework.Controls.MetroComboBox();
            this.cmbPompaSec = new MetroFramework.Controls.MetroComboBox();
            this.txtUrun = new MetroFramework.Controls.MetroTextBox();
            this.txtPlaka = new MetroFramework.Controls.MetroTextBox();
            this.txtFiyat = new MetroFramework.Controls.MetroTextBox();
            this.txtIndirim = new MetroFramework.Controls.MetroTextBox();
            this.txtAraToplam = new MetroFramework.Controls.MetroTextBox();
            this.txtTutar = new MetroFramework.Controls.MetroTextBox();
            this.txtLitre = new MetroFramework.Controls.MetroTextBox();
            this.dtgSatislar = new MetroFramework.Controls.MetroGrid();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlSatislar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(567, 384);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(211, 38);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Hesapla ve Ekle";
            this.btnEkle.UseSelectable = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pnlSatislar
            // 
            this.pnlSatislar.Controls.Add(this.metroLabel10);
            this.pnlSatislar.Controls.Add(this.metroLabel9);
            this.pnlSatislar.Controls.Add(this.metroLabel8);
            this.pnlSatislar.Controls.Add(this.metroLabel7);
            this.pnlSatislar.Controls.Add(this.metroLabel6);
            this.pnlSatislar.Controls.Add(this.metroLabel5);
            this.pnlSatislar.Controls.Add(this.metroLabel4);
            this.pnlSatislar.Controls.Add(this.metroLabel3);
            this.pnlSatislar.Controls.Add(this.metroLabel2);
            this.pnlSatislar.Controls.Add(this.metroLabel1);
            this.pnlSatislar.Controls.Add(this.lblNot);
            this.pnlSatislar.Controls.Add(this.cmbKullanici);
            this.pnlSatislar.Controls.Add(this.cmbPompaSec);
            this.pnlSatislar.Controls.Add(this.txtUrun);
            this.pnlSatislar.Controls.Add(this.txtPlaka);
            this.pnlSatislar.Controls.Add(this.txtFiyat);
            this.pnlSatislar.Controls.Add(this.txtIndirim);
            this.pnlSatislar.Controls.Add(this.txtAraToplam);
            this.pnlSatislar.Controls.Add(this.txtTutar);
            this.pnlSatislar.Controls.Add(this.txtLitre);
            this.pnlSatislar.Controls.Add(this.dtgSatislar);
            this.pnlSatislar.Controls.Add(this.btnEkle);
            this.pnlSatislar.HorizontalScrollbarBarColor = true;
            this.pnlSatislar.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSatislar.HorizontalScrollbarSize = 10;
            this.pnlSatislar.Location = new System.Drawing.Point(29, 64);
            this.pnlSatislar.Name = "pnlSatislar";
            this.pnlSatislar.Size = new System.Drawing.Size(788, 460);
            this.pnlSatislar.TabIndex = 1;
            this.pnlSatislar.VerticalScrollbarBarColor = true;
            this.pnlSatislar.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSatislar.VerticalScrollbarSize = 10;
            this.pnlSatislar.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(468, 322);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(83, 19);
            this.metroLabel10.TabIndex = 7;
            this.metroLabel10.Text = "Ara toplam :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(468, 359);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(44, 19);
            this.metroLabel9.TabIndex = 7;
            this.metroLabel9.Text = "Tutar :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(465, 252);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "İndirim  :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(465, 219);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Litre :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(465, 188);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Fiyat :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(465, 155);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Plaka :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(465, 120);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Kullanıcı :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(465, 87);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Ürün :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(465, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Pompa seç :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Red;
            this.metroLabel1.Location = new System.Drawing.Point(567, 278);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 38);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Not : İndirimler bir sonraki \r\nsatışta geçerlilik kazanır";
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.ForeColor = System.Drawing.Color.Red;
            this.lblNot.Location = new System.Drawing.Point(512, 7);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(266, 38);
            this.lblNot.TabIndex = 5;
            this.lblNot.Text = "Not : İndirimlerin geçerli olması için mevcut \r\nalınan yakıt 2 katı olmalıdır.";
            this.lblNot.UseCustomForeColor = true;
            // 
            // cmbKullanici
            // 
            this.cmbKullanici.FormattingEnabled = true;
            this.cmbKullanici.ItemHeight = 23;
            this.cmbKullanici.Location = new System.Drawing.Point(567, 114);
            this.cmbKullanici.Name = "cmbKullanici";
            this.cmbKullanici.PromptText = "Kullanıcı Seç :";
            this.cmbKullanici.Size = new System.Drawing.Size(211, 29);
            this.cmbKullanici.TabIndex = 4;
            this.cmbKullanici.UseSelectable = true;
            this.cmbKullanici.SelectedIndexChanged += new System.EventHandler(this.cmbPompaSec_SelectedIndexChanged);
            this.cmbKullanici.SelectionChangeCommitted += new System.EventHandler(this.cmbPompaSec_SelectionChangeCommitted);
            this.cmbKullanici.VisibleChanged += new System.EventHandler(this.cmbPompaSec_VisibleChanged);
            // 
            // cmbPompaSec
            // 
            this.cmbPompaSec.FormattingEnabled = true;
            this.cmbPompaSec.ItemHeight = 23;
            this.cmbPompaSec.Location = new System.Drawing.Point(567, 48);
            this.cmbPompaSec.Name = "cmbPompaSec";
            this.cmbPompaSec.PromptText = "Pompa Seç :";
            this.cmbPompaSec.Size = new System.Drawing.Size(211, 29);
            this.cmbPompaSec.TabIndex = 4;
            this.cmbPompaSec.UseSelectable = true;
            this.cmbPompaSec.SelectedIndexChanged += new System.EventHandler(this.cmbPompaSec_SelectedIndexChanged);
            this.cmbPompaSec.SelectionChangeCommitted += new System.EventHandler(this.cmbPompaSec_SelectionChangeCommitted);
            this.cmbPompaSec.VisibleChanged += new System.EventHandler(this.cmbPompaSec_VisibleChanged);
            // 
            // txtUrun
            // 
            // 
            // 
            // 
            this.txtUrun.CustomButton.Image = null;
            this.txtUrun.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtUrun.CustomButton.Name = "";
            this.txtUrun.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUrun.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrun.CustomButton.TabIndex = 1;
            this.txtUrun.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrun.CustomButton.UseSelectable = true;
            this.txtUrun.CustomButton.Visible = false;
            this.txtUrun.Enabled = false;
            this.txtUrun.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUrun.Lines = new string[0];
            this.txtUrun.Location = new System.Drawing.Point(567, 83);
            this.txtUrun.MaxLength = 32767;
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.PasswordChar = '\0';
            this.txtUrun.PromptText = "Ürün";
            this.txtUrun.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrun.SelectedText = "";
            this.txtUrun.SelectionLength = 0;
            this.txtUrun.SelectionStart = 0;
            this.txtUrun.ShortcutsEnabled = true;
            this.txtUrun.Size = new System.Drawing.Size(211, 27);
            this.txtUrun.TabIndex = 3;
            this.txtUrun.UseSelectable = true;
            this.txtUrun.WaterMark = "Ürün";
            this.txtUrun.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrun.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPlaka
            // 
            // 
            // 
            // 
            this.txtPlaka.CustomButton.Image = null;
            this.txtPlaka.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtPlaka.CustomButton.Name = "";
            this.txtPlaka.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPlaka.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlaka.CustomButton.TabIndex = 1;
            this.txtPlaka.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlaka.CustomButton.UseSelectable = true;
            this.txtPlaka.CustomButton.Visible = false;
            this.txtPlaka.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPlaka.Lines = new string[0];
            this.txtPlaka.Location = new System.Drawing.Point(567, 149);
            this.txtPlaka.MaxLength = 32767;
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.PasswordChar = '\0';
            this.txtPlaka.PromptText = "Plaka";
            this.txtPlaka.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlaka.SelectedText = "";
            this.txtPlaka.SelectionLength = 0;
            this.txtPlaka.SelectionStart = 0;
            this.txtPlaka.ShortcutsEnabled = true;
            this.txtPlaka.Size = new System.Drawing.Size(211, 27);
            this.txtPlaka.TabIndex = 3;
            this.txtPlaka.UseSelectable = true;
            this.txtPlaka.WaterMark = "Plaka";
            this.txtPlaka.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlaka.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlaka.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            // 
            // txtFiyat
            // 
            // 
            // 
            // 
            this.txtFiyat.CustomButton.Image = null;
            this.txtFiyat.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtFiyat.CustomButton.Name = "";
            this.txtFiyat.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtFiyat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiyat.CustomButton.TabIndex = 1;
            this.txtFiyat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiyat.CustomButton.UseSelectable = true;
            this.txtFiyat.CustomButton.Visible = false;
            this.txtFiyat.Enabled = false;
            this.txtFiyat.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFiyat.Lines = new string[0];
            this.txtFiyat.Location = new System.Drawing.Point(567, 182);
            this.txtFiyat.MaxLength = 32767;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.PasswordChar = '\0';
            this.txtFiyat.PromptText = "Birim Fiyat";
            this.txtFiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiyat.SelectedText = "";
            this.txtFiyat.SelectionLength = 0;
            this.txtFiyat.SelectionStart = 0;
            this.txtFiyat.ShortcutsEnabled = true;
            this.txtFiyat.Size = new System.Drawing.Size(211, 27);
            this.txtFiyat.TabIndex = 3;
            this.txtFiyat.UseSelectable = true;
            this.txtFiyat.WaterMark = "Birim Fiyat";
            this.txtFiyat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiyat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIndirim
            // 
            // 
            // 
            // 
            this.txtIndirim.CustomButton.Image = null;
            this.txtIndirim.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtIndirim.CustomButton.Name = "";
            this.txtIndirim.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtIndirim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIndirim.CustomButton.TabIndex = 1;
            this.txtIndirim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIndirim.CustomButton.UseSelectable = true;
            this.txtIndirim.CustomButton.Visible = false;
            this.txtIndirim.Enabled = false;
            this.txtIndirim.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIndirim.Lines = new string[0];
            this.txtIndirim.Location = new System.Drawing.Point(567, 248);
            this.txtIndirim.MaxLength = 32767;
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.PasswordChar = '\0';
            this.txtIndirim.PromptText = "İndirim";
            this.txtIndirim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIndirim.SelectedText = "";
            this.txtIndirim.SelectionLength = 0;
            this.txtIndirim.SelectionStart = 0;
            this.txtIndirim.ShortcutsEnabled = true;
            this.txtIndirim.Size = new System.Drawing.Size(211, 27);
            this.txtIndirim.TabIndex = 3;
            this.txtIndirim.UseSelectable = true;
            this.txtIndirim.WaterMark = "İndirim";
            this.txtIndirim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIndirim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIndirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIndirim_KeyPress);
            // 
            // txtAraToplam
            // 
            // 
            // 
            // 
            this.txtAraToplam.CustomButton.Image = null;
            this.txtAraToplam.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtAraToplam.CustomButton.Name = "";
            this.txtAraToplam.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAraToplam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAraToplam.CustomButton.TabIndex = 1;
            this.txtAraToplam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAraToplam.CustomButton.UseSelectable = true;
            this.txtAraToplam.CustomButton.Visible = false;
            this.txtAraToplam.Enabled = false;
            this.txtAraToplam.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAraToplam.Lines = new string[0];
            this.txtAraToplam.Location = new System.Drawing.Point(567, 318);
            this.txtAraToplam.MaxLength = 32767;
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.PasswordChar = '\0';
            this.txtAraToplam.PromptText = "Tutar";
            this.txtAraToplam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAraToplam.SelectedText = "";
            this.txtAraToplam.SelectionLength = 0;
            this.txtAraToplam.SelectionStart = 0;
            this.txtAraToplam.ShortcutsEnabled = true;
            this.txtAraToplam.Size = new System.Drawing.Size(211, 27);
            this.txtAraToplam.TabIndex = 3;
            this.txtAraToplam.UseSelectable = true;
            this.txtAraToplam.WaterMark = "Tutar";
            this.txtAraToplam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAraToplam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTutar
            // 
            // 
            // 
            // 
            this.txtTutar.CustomButton.Image = null;
            this.txtTutar.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtTutar.CustomButton.Name = "";
            this.txtTutar.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTutar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTutar.CustomButton.TabIndex = 1;
            this.txtTutar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTutar.CustomButton.UseSelectable = true;
            this.txtTutar.CustomButton.Visible = false;
            this.txtTutar.Enabled = false;
            this.txtTutar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTutar.Lines = new string[0];
            this.txtTutar.Location = new System.Drawing.Point(567, 351);
            this.txtTutar.MaxLength = 32767;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.PasswordChar = '\0';
            this.txtTutar.PromptText = "Tutar";
            this.txtTutar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTutar.SelectedText = "";
            this.txtTutar.SelectionLength = 0;
            this.txtTutar.SelectionStart = 0;
            this.txtTutar.ShortcutsEnabled = true;
            this.txtTutar.Size = new System.Drawing.Size(211, 27);
            this.txtTutar.TabIndex = 3;
            this.txtTutar.UseSelectable = true;
            this.txtTutar.WaterMark = "Tutar";
            this.txtTutar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTutar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLitre
            // 
            // 
            // 
            // 
            this.txtLitre.CustomButton.Image = null;
            this.txtLitre.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtLitre.CustomButton.Name = "";
            this.txtLitre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtLitre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLitre.CustomButton.TabIndex = 1;
            this.txtLitre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLitre.CustomButton.UseSelectable = true;
            this.txtLitre.CustomButton.Visible = false;
            this.txtLitre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLitre.Lines = new string[0];
            this.txtLitre.Location = new System.Drawing.Point(567, 215);
            this.txtLitre.MaxLength = 6;
            this.txtLitre.Name = "txtLitre";
            this.txtLitre.PasswordChar = '\0';
            this.txtLitre.PromptText = "Litre";
            this.txtLitre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLitre.SelectedText = "";
            this.txtLitre.SelectionLength = 0;
            this.txtLitre.SelectionStart = 0;
            this.txtLitre.ShortcutsEnabled = true;
            this.txtLitre.Size = new System.Drawing.Size(211, 27);
            this.txtLitre.TabIndex = 3;
            this.txtLitre.UseSelectable = true;
            this.txtLitre.WaterMark = "Litre";
            this.txtLitre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLitre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLitre.TextChanged += new System.EventHandler(this.txtLitre_TextChanged);
            this.txtLitre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLitre_KeyPress);
            // 
            // dtgSatislar
            // 
            this.dtgSatislar.AllowUserToAddRows = false;
            this.dtgSatislar.AllowUserToDeleteRows = false;
            this.dtgSatislar.AllowUserToResizeRows = false;
            this.dtgSatislar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgSatislar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSatislar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgSatislar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSatislar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSatislar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgSatislar.EnableHeadersVisualStyles = false;
            this.dtgSatislar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgSatislar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgSatislar.Location = new System.Drawing.Point(7, 48);
            this.dtgSatislar.Name = "dtgSatislar";
            this.dtgSatislar.ReadOnly = true;
            this.dtgSatislar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSatislar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgSatislar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSatislar.Size = new System.Drawing.Size(452, 331);
            this.dtgSatislar.TabIndex = 2;
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(778, 11);
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
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 547);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.pnlSatislar);
            this.Name = "frmSatislar";
            this.Text = "Satışlar";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmSatislar_Load);
            this.pnlSatislar.ResumeLayout(false);
            this.pnlSatislar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEkle;
        private MetroFramework.Controls.MetroPanel pnlSatislar;
        private MetroFramework.Controls.MetroGrid dtgSatislar;
        private MetroFramework.Controls.MetroComboBox cmbPompaSec;
        private MetroFramework.Controls.MetroTextBox txtLitre;
        private MetroFramework.Controls.MetroTextBox txtFiyat;
        private MetroFramework.Controls.MetroTextBox txtPlaka;
        private MetroFramework.Controls.MetroTextBox txtTutar;
        private MetroFramework.Controls.MetroTextBox txtUrun;
        private MetroFramework.Controls.MetroLabel lblNot;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Controls.MetroTextBox txtIndirim;
        private MetroFramework.Controls.MetroComboBox cmbKullanici;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtAraToplam;
        private MetroFramework.Components.MetroStyleManager stlPanel;
    }
}