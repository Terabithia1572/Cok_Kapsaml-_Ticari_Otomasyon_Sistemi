namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    partial class frmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiderler));
            this.btn_Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_Yıl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbx_Ay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rtx_Notlar = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Elektrik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Ekstra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Su = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Dogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tx_giderID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tx_Maaslar = new DevExpress.XtraEditors.TextEdit();
            this.tx_Internet = new DevExpress.XtraEditors.TextEdit();
            this.dgv_Giderler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Yıl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Ay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Elektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Ekstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Su.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Dogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_giderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Maaslar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Internet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Giderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Appearance.Options.UseFont = true;
            this.btn_Temizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Temizle.ImageOptions.SvgImage")));
            this.btn_Temizle.Location = new System.Drawing.Point(107, 560);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(215, 27);
            this.btn_Temizle.TabIndex = 21;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // cbx_Yıl
            // 
            this.cbx_Yıl.Location = new System.Drawing.Point(107, 93);
            this.cbx_Yıl.Name = "cbx_Yıl";
            this.cbx_Yıl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_Yıl.Properties.Appearance.Options.UseFont = true;
            this.cbx_Yıl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Yıl.Properties.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbx_Yıl.Size = new System.Drawing.Size(215, 24);
            this.cbx_Yıl.TabIndex = 3;
            // 
            // cbx_Ay
            // 
            this.cbx_Ay.Location = new System.Drawing.Point(107, 60);
            this.cbx_Ay.Name = "cbx_Ay";
            this.cbx_Ay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_Ay.Properties.Appearance.Options.UseFont = true;
            this.cbx_Ay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Ay.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cbx_Ay.Size = new System.Drawing.Size(215, 24);
            this.cbx_Ay.TabIndex = 2;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(15, 299);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(45, 18);
            this.labelControl11.TabIndex = 20;
            this.labelControl11.Text = "Ekstra:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(18, 392);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(43, 18);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Notlar:";
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
            // rtx_Notlar
            // 
            this.rtx_Notlar.Location = new System.Drawing.Point(107, 337);
            this.rtx_Notlar.Name = "rtx_Notlar";
            this.rtx_Notlar.Size = new System.Drawing.Size(215, 108);
            this.rtx_Notlar.TabIndex = 10;
            this.rtx_Notlar.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(15, 262);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Maaşlar:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(18, 228);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(58, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "İnternet:";
            // 
            // tx_Elektrik
            // 
            this.tx_Elektrik.Location = new System.Drawing.Point(107, 123);
            this.tx_Elektrik.Name = "tx_Elektrik";
            this.tx_Elektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Elektrik.Properties.Appearance.Options.UseFont = true;
            this.tx_Elektrik.Size = new System.Drawing.Size(215, 24);
            this.tx_Elektrik.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(15, 162);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(21, 18);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Su:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 195);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Doğalgaz:";
            // 
            // tx_Ekstra
            // 
            this.tx_Ekstra.Location = new System.Drawing.Point(107, 296);
            this.tx_Ekstra.Name = "tx_Ekstra";
            this.tx_Ekstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Ekstra.Properties.Appearance.Options.UseFont = true;
            this.tx_Ekstra.Size = new System.Drawing.Size(215, 24);
            this.tx_Ekstra.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 18);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Elektrik:";
            // 
            // tx_Su
            // 
            this.tx_Su.Location = new System.Drawing.Point(107, 156);
            this.tx_Su.Name = "tx_Su";
            this.tx_Su.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Su.Properties.Appearance.Options.UseFont = true;
            this.tx_Su.Size = new System.Drawing.Size(215, 24);
            this.tx_Su.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(19, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Yıl:";
            // 
            // tx_Dogalgaz
            // 
            this.tx_Dogalgaz.Location = new System.Drawing.Point(107, 192);
            this.tx_Dogalgaz.Name = "tx_Dogalgaz";
            this.tx_Dogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Dogalgaz.Properties.Appearance.Options.UseFont = true;
            this.tx_Dogalgaz.Size = new System.Drawing.Size(215, 24);
            this.tx_Dogalgaz.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ay:";
            // 
            // tx_giderID
            // 
            this.tx_giderID.Location = new System.Drawing.Point(107, 30);
            this.tx_giderID.Name = "tx_giderID";
            this.tx_giderID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_giderID.Properties.Appearance.Options.UseFont = true;
            this.tx_giderID.Size = new System.Drawing.Size(215, 24);
            this.tx_giderID.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Giderler ID:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tx_Maaslar);
            this.groupControl1.Controls.Add(this.tx_Internet);
            this.groupControl1.Controls.Add(this.btn_Temizle);
            this.groupControl1.Controls.Add(this.cbx_Yıl);
            this.groupControl1.Controls.Add(this.cbx_Ay);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btn_Guncelle);
            this.groupControl1.Controls.Add(this.btn_Sil);
            this.groupControl1.Controls.Add(this.btn_Kaydet);
            this.groupControl1.Controls.Add(this.rtx_Notlar);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.tx_Elektrik);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.tx_Ekstra);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.tx_Su);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tx_Dogalgaz);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.tx_giderID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1582, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(337, 609);
            this.groupControl1.TabIndex = 7;
            // 
            // tx_Maaslar
            // 
            this.tx_Maaslar.Location = new System.Drawing.Point(107, 259);
            this.tx_Maaslar.Name = "tx_Maaslar";
            this.tx_Maaslar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Maaslar.Properties.Appearance.Options.UseFont = true;
            this.tx_Maaslar.Size = new System.Drawing.Size(215, 24);
            this.tx_Maaslar.TabIndex = 8;
            // 
            // tx_Internet
            // 
            this.tx_Internet.Location = new System.Drawing.Point(107, 225);
            this.tx_Internet.Name = "tx_Internet";
            this.tx_Internet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Internet.Properties.Appearance.Options.UseFont = true;
            this.tx_Internet.Size = new System.Drawing.Size(215, 24);
            this.tx_Internet.TabIndex = 7;
            // 
            // dgv_Giderler
            // 
            this.dgv_Giderler.Location = new System.Drawing.Point(5, 12);
            this.dgv_Giderler.MainView = this.gridView1;
            this.dgv_Giderler.Name = "dgv_Giderler";
            this.dgv_Giderler.Size = new System.Drawing.Size(1571, 609);
            this.dgv_Giderler.TabIndex = 6;
            this.dgv_Giderler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgv_Giderler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // frmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 633);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgv_Giderler);
            this.Name = "frmGiderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.frmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Yıl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Ay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Elektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Ekstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Su.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Dogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_giderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Maaslar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Internet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Giderler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Temizle;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Yıl;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Ay;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private System.Windows.Forms.RichTextBox rtx_Notlar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit tx_Elektrik;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tx_Ekstra;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tx_Su;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tx_Dogalgaz;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tx_giderID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tx_Maaslar;
        private DevExpress.XtraEditors.TextEdit tx_Internet;
        private DevExpress.XtraGrid.GridControl dgv_Giderler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}