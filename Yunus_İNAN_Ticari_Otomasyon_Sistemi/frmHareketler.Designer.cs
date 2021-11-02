namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    partial class frmHareketler
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.dgv_Musteriler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.dgv_Firmalar = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.dgv_Stoklar = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Musteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Firmalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1924, 633);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.dgv_Musteriler);
            this.xtraTabPage1.ImageOptions.Image = global::Yunus_İNAN_Ticari_Otomasyon_Sistemi.Properties.Resources.customer_32x32;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1922, 589);
            this.xtraTabPage1.Text = "MÜŞTERİ HAREKETLERİ";
            // 
            // dgv_Musteriler
            // 
            this.dgv_Musteriler.Location = new System.Drawing.Point(-1, 0);
            this.dgv_Musteriler.MainView = this.gridView1;
            this.dgv_Musteriler.Name = "dgv_Musteriler";
            this.dgv_Musteriler.Size = new System.Drawing.Size(1923, 605);
            this.dgv_Musteriler.TabIndex = 5;
            this.dgv_Musteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgv_Musteriler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.dgv_Firmalar);
            this.xtraTabPage2.ImageOptions.Image = global::Yunus_İNAN_Ticari_Otomasyon_Sistemi.Properties.Resources.firma_3_32x32;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1922, 589);
            this.xtraTabPage2.Text = "FİRMA HAREKETLERİ";
            // 
            // dgv_Firmalar
            // 
            this.dgv_Firmalar.Location = new System.Drawing.Point(0, 0);
            this.dgv_Firmalar.MainView = this.gridView2;
            this.dgv_Firmalar.Name = "dgv_Firmalar";
            this.dgv_Firmalar.Size = new System.Drawing.Size(1923, 607);
            this.dgv_Firmalar.TabIndex = 6;
            this.dgv_Firmalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.dgv_Firmalar;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.dgv_Stoklar);
            this.xtraTabPage3.ImageOptions.Image = global::Yunus_İNAN_Ticari_Otomasyon_Sistemi.Properties.Resources.stock_32x32;
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1922, 589);
            this.xtraTabPage3.Text = "STOK HAREKETLERİ";
            // 
            // dgv_Stoklar
            // 
            this.dgv_Stoklar.Location = new System.Drawing.Point(0, 0);
            this.dgv_Stoklar.MainView = this.gridView3;
            this.dgv_Stoklar.Name = "dgv_Stoklar";
            this.dgv_Stoklar.Size = new System.Drawing.Size(1923, 597);
            this.dgv_Stoklar.TabIndex = 6;
            this.dgv_Stoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.GridControl = this.dgv_Stoklar;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // frmHareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 633);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmHareketler";
            this.Text = "HAREKETLER";
            this.Load += new System.EventHandler(this.frmHareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Musteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Firmalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl dgv_Musteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl dgv_Firmalar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl dgv_Stoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}