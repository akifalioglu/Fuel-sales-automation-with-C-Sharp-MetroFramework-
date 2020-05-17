namespace Akaryakit
{
    partial class frmIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIstatistik));
            this.chrSatislar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imgKapat = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.stlPanel = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chrSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // chrSatislar
            // 
            chartArea1.Name = "ChartArea1";
            this.chrSatislar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrSatislar.Legends.Add(legend1);
            this.chrSatislar.Location = new System.Drawing.Point(58, 80);
            this.chrSatislar.Name = "chrSatislar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Günler";
            this.chrSatislar.Series.Add(series1);
            this.chrSatislar.Size = new System.Drawing.Size(659, 288);
            this.chrSatislar.TabIndex = 5;
            // 
            // imgKapat
            // 
            this.imgKapat.Image = ((System.Drawing.Image)(resources.GetObject("imgKapat.Image")));
            this.imgKapat.Location = new System.Drawing.Point(748, 19);
            this.imgKapat.Name = "imgKapat";
            this.imgKapat.Size = new System.Drawing.Size(29, 37);
            this.imgKapat.TabIndex = 34;
            this.imgKapat.TabStop = false;
            this.imgKapat.Click += new System.EventHandler(this.imgKapat_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(70, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "Tl Bazlı Satış :";
            // 
            // stlPanel
            // 
            this.stlPanel.Owner = this;
            // 
            // frmIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 437);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.imgKapat);
            this.Controls.Add(this.chrSatislar);
            this.Name = "frmIstatistik";
            this.Text = "İstatistikler";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stlPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrSatislar;
        private System.Windows.Forms.PictureBox imgKapat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager stlPanel;
    }
}