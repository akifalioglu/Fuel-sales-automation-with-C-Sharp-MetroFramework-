namespace Akaryakit
{
    partial class frmKullaniciGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGuncelle));
            this.cmbYetki = new MetroFramework.Controls.MetroComboBox();
            this.dtgKullanicilar = new MetroFramework.Controls.MetroGrid();
            this.txtAra = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            this.imgKapat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.cmbYetki.Location = new System.Drawing.Point(182, -55);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.PromptText = "Yetkilendirme";
            this.cmbYetki.Size = new System.Drawing.Size(183, 29);
            this.cmbYetki.TabIndex = 6;
            this.cmbYetki.UseSelectable = true;
            // 
            // dtgKullanicilar
            // 
            this.dtgKullanicilar.AllowUserToAddRows = false;
            this.dtgKullanicilar.AllowUserToDeleteRows = false;
            this.dtgKullanicilar.AllowUserToResizeRows = false;
            this.dtgKullanicilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgKullanicilar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgKullanicilar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgKullanicilar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgKullanicilar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgKullanicilar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgKullanicilar.EnableHeadersVisualStyles = false;
            this.dtgKullanicilar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgKullanicilar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgKullanicilar.Location = new System.Drawing.Point(28, 143);
            this.dtgKullanicilar.Name = "dtgKullanicilar";
            this.dtgKullanicilar.ReadOnly = true;
            this.dtgKullanicilar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgKullanicilar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgKullanicilar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgKullanicilar.Size = new System.Drawing.Size(845, 230);
            this.dtgKullanicilar.TabIndex = 19;
            this.dtgKullanicilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKullanicilar_CellContentClick);
            // 
            // txtAra
            // 
            // 
            // 
            // 
            this.txtAra.CustomButton.Image = null;
            this.txtAra.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.txtAra.CustomButton.Name = "";
            this.txtAra.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtAra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAra.CustomButton.TabIndex = 1;
            this.txtAra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAra.CustomButton.UseSelectable = true;
            this.txtAra.CustomButton.Visible = false;
            this.txtAra.DisplayIcon = true;
            this.txtAra.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAra.Icon = ((System.Drawing.Image)(resources.GetObject("txtAra.Icon")));
            this.txtAra.Lines = new string[0];
            this.txtAra.Location = new System.Drawing.Point(243, 63);
            this.txtAra.MaxLength = 32767;
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.PromptText = "Aranacak Kelimeyi Yazınız...";
            this.txtAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAra.SelectedText = "";
            this.txtAra.SelectionLength = 0;
            this.txtAra.SelectionStart = 0;
            this.txtAra.ShortcutsEnabled = true;
            this.txtAra.Size = new System.Drawing.Size(405, 41);
            this.txtAra.TabIndex = 20;
            this.txtAra.Tag = "";
            this.txtAra.UseSelectable = true;
            this.txtAra.WaterMark = "Aranacak Kelimeyi Yazınız...";
            this.txtAra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAra.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            this.txtAra.Click += new System.EventHandler(this.txtAra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, -164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // stlPanel
            // 
            this.stlPanel.Owner = this;
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(855, 8);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(29, 37);
            this.imgKapat.TabIndex = 32;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // frmKullaniciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 384);
            this.ControlBox = false;
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dtgKullanicilar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbYetki);
            this.Name = "frmKullaniciGuncelle";
            this.Text = "Kullanıcı Güncelle";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmKullaniciGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbYetki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid dtgKullanicilar;
        private MetroFramework.Controls.MetroTextBox txtAra;
        private MetroFramework.Components.MetroStyleManager stlPanel;
        private System.Windows.Forms.PictureBox imgKapat;
    }
}