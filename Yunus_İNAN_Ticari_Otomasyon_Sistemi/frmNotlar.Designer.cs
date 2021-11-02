namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    partial class frmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotlar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgv_Notlar = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rtx_Detay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Baslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Olusturan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Hitap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.mtx_Saat = new System.Windows.Forms.MaskedTextBox();
            this.mtx_Tarih = new System.Windows.Forms.MaskedTextBox();
            this.tx_notID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Baslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Olusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Hitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_notID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgv_Notlar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // dgv_Notlar
            // 
            this.dgv_Notlar.Location = new System.Drawing.Point(5, 12);
            this.dgv_Notlar.MainView = this.gridView1;
            this.dgv_Notlar.Name = "dgv_Notlar";
            this.dgv_Notlar.Size = new System.Drawing.Size(1571, 609);
            this.dgv_Notlar.TabIndex = 4;
            this.dgv_Notlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgv_Notlar.DoubleClick += new System.EventHandler(this.dgv_Notlar_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Temizle);
            this.groupControl1.Controls.Add(this.btn_Guncelle);
            this.groupControl1.Controls.Add(this.btn_Sil);
            this.groupControl1.Controls.Add(this.btn_Kaydet);
            this.groupControl1.Controls.Add(this.rtx_Detay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.tx_Baslik);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.tx_Olusturan);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tx_Hitap);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.mtx_Saat);
            this.groupControl1.Controls.Add(this.mtx_Tarih);
            this.groupControl1.Controls.Add(this.tx_notID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1582, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(337, 609);
            this.groupControl1.TabIndex = 5;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Appearance.Options.UseFont = true;
            this.btn_Temizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Temizle.ImageOptions.SvgImage")));
            this.btn_Temizle.Location = new System.Drawing.Point(107, 560);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(215, 27);
            this.btn_Temizle.TabIndex = 22;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Appearance.Options.UseFont = true;
            this.btn_Guncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Guncelle.ImageOptions.SvgImage")));
            this.btn_Guncelle.Location = new System.Drawing.Point(107, 527);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(215, 27);
            this.btn_Guncelle.TabIndex = 18;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Appearance.Options.UseFont = true;
            this.btn_Sil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Sil.ImageOptions.SvgImage")));
            this.btn_Sil.Location = new System.Drawing.Point(107, 494);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(215, 27);
            this.btn_Sil.TabIndex = 17;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Appearance.Options.UseFont = true;
            this.btn_Kaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Kaydet.ImageOptions.SvgImage")));
            this.btn_Kaydet.Location = new System.Drawing.Point(107, 461);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(215, 27);
            this.btn_Kaydet.TabIndex = 16;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // rtx_Detay
            // 
            this.rtx_Detay.Location = new System.Drawing.Point(105, 227);
            this.rtx_Detay.Name = "rtx_Detay";
            this.rtx_Detay.Size = new System.Drawing.Size(215, 108);
            this.rtx_Detay.TabIndex = 6;
            this.rtx_Detay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(15, 190);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 18);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Hitap:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(15, 273);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Detay:";
            // 
            // tx_Baslik
            // 
            this.tx_Baslik.Location = new System.Drawing.Point(107, 127);
            this.tx_Baslik.Name = "tx_Baslik";
            this.tx_Baslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Baslik.Properties.Appearance.Options.UseFont = true;
            this.tx_Baslik.Size = new System.Drawing.Size(215, 24);
            this.tx_Baslik.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 18);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Başlık:";
            // 
            // tx_Olusturan
            // 
            this.tx_Olusturan.Location = new System.Drawing.Point(107, 157);
            this.tx_Olusturan.Name = "tx_Olusturan";
            this.tx_Olusturan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Olusturan.Properties.Appearance.Options.UseFont = true;
            this.tx_Olusturan.Size = new System.Drawing.Size(215, 24);
            this.tx_Olusturan.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Saat:";
            // 
            // tx_Hitap
            // 
            this.tx_Hitap.Location = new System.Drawing.Point(107, 187);
            this.tx_Hitap.Name = "tx_Hitap";
            this.tx_Hitap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Hitap.Properties.Appearance.Options.UseFont = true;
            this.tx_Hitap.Size = new System.Drawing.Size(215, 24);
            this.tx_Hitap.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Oluşturan:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tarih:";
            // 
            // mtx_Saat
            // 
            this.mtx_Saat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtx_Saat.Location = new System.Drawing.Point(107, 95);
            this.mtx_Saat.Mask = "00:00";
            this.mtx_Saat.Name = "mtx_Saat";
            this.mtx_Saat.Size = new System.Drawing.Size(215, 26);
            this.mtx_Saat.TabIndex = 2;
            this.mtx_Saat.ValidatingType = typeof(System.DateTime);
            // 
            // mtx_Tarih
            // 
            this.mtx_Tarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtx_Tarih.Location = new System.Drawing.Point(107, 60);
            this.mtx_Tarih.Mask = "00/00/0000";
            this.mtx_Tarih.Name = "mtx_Tarih";
            this.mtx_Tarih.Size = new System.Drawing.Size(215, 26);
            this.mtx_Tarih.TabIndex = 1;
            this.mtx_Tarih.ValidatingType = typeof(System.DateTime);
            // 
            // tx_notID
            // 
            this.tx_notID.Location = new System.Drawing.Point(107, 30);
            this.tx_notID.Name = "tx_notID";
            this.tx_notID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_notID.Properties.Appearance.Options.UseFont = true;
            this.tx_notID.Size = new System.Drawing.Size(215, 24);
            this.tx_notID.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Not ID:";
            // 
            // frmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 633);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgv_Notlar);
            this.Name = "frmNotlar";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.frmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Baslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Olusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Hitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_notID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dgv_Notlar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private System.Windows.Forms.RichTextBox rtx_Detay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tx_Baslik;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tx_Olusturan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tx_Hitap;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox mtx_Saat;
        private System.Windows.Forms.MaskedTextBox mtx_Tarih;
        private DevExpress.XtraEditors.TextEdit tx_notID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Temizle;
    }
}