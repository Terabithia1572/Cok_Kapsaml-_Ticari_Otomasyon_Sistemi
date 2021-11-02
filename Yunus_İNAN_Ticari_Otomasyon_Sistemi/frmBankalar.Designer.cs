namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    partial class frmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankalar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgv_Bankalar = new DevExpress.XtraGrid.GridControl();
            this.cbx_Ilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbx_IL = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.mtx_Yetkili = new System.Windows.Forms.MaskedTextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.mtx_hesapNo = new System.Windows.Forms.MaskedTextBox();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Sube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tx_hesapTur = new DevExpress.XtraEditors.TextEdit();
            this.tx_bankaAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.mtx_Tarih = new System.Windows.Forms.MaskedTextBox();
            this.mtx_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.mtx_IBAN = new System.Windows.Forms.MaskedTextBox();
            this.tx_bankaID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bankalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_IL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Sube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_hesapTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_bankaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_bankaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgv_Bankalar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // dgv_Bankalar
            // 
            this.dgv_Bankalar.Location = new System.Drawing.Point(5, 12);
            this.dgv_Bankalar.MainView = this.gridView1;
            this.dgv_Bankalar.Name = "dgv_Bankalar";
            this.dgv_Bankalar.Size = new System.Drawing.Size(1571, 609);
            this.dgv_Bankalar.TabIndex = 4;
            this.dgv_Bankalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cbx_Ilce
            // 
            this.cbx_Ilce.Location = new System.Drawing.Point(107, 120);
            this.cbx_Ilce.Name = "cbx_Ilce";
            this.cbx_Ilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_Ilce.Properties.Appearance.Options.UseFont = true;
            this.cbx_Ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Ilce.Size = new System.Drawing.Size(215, 24);
            this.cbx_Ilce.TabIndex = 3;
            // 
            // cbx_IL
            // 
            this.cbx_IL.Location = new System.Drawing.Point(107, 89);
            this.cbx_IL.Name = "cbx_IL";
            this.cbx_IL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_IL.Properties.Appearance.Options.UseFont = true;
            this.cbx_IL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_IL.Size = new System.Drawing.Size(215, 24);
            this.cbx_IL.TabIndex = 2;
            this.cbx_IL.SelectedIndexChanged += new System.EventHandler(this.cbx_IL_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(18, 343);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(82, 18);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Hesap Türü:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.btn_Temizle);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.mtx_Yetkili);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.mtx_hesapNo);
            this.groupControl1.Controls.Add(this.cbx_Ilce);
            this.groupControl1.Controls.Add(this.cbx_IL);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btn_Guncelle);
            this.groupControl1.Controls.Add(this.btn_Sil);
            this.groupControl1.Controls.Add(this.btn_Kaydet);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.tx_Sube);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.tx_hesapTur);
            this.groupControl1.Controls.Add(this.tx_bankaAd);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.mtx_Tarih);
            this.groupControl1.Controls.Add(this.mtx_Telefon);
            this.groupControl1.Controls.Add(this.mtx_IBAN);
            this.groupControl1.Controls.Add(this.tx_bankaID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1582, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(337, 609);
            this.groupControl1.TabIndex = 5;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(107, 371);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "Firma Seçiniz Lütfen..";
            this.lookUpEdit1.Size = new System.Drawing.Size(215, 24);
            this.lookUpEdit1.TabIndex = 27;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Appearance.Options.UseFont = true;
            this.btn_Temizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Temizle.ImageOptions.SvgImage")));
            this.btn_Temizle.Location = new System.Drawing.Point(107, 520);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(215, 27);
            this.btn_Temizle.TabIndex = 19;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(18, 373);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(41, 18);
            this.labelControl13.TabIndex = 26;
            this.labelControl13.Text = "Firma:";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(15, 247);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(41, 18);
            this.labelControl11.TabIndex = 24;
            this.labelControl11.Text = "Yetkili:";
            // 
            // mtx_Yetkili
            // 
            this.mtx_Yetkili.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtx_Yetkili.Location = new System.Drawing.Point(107, 244);
            this.mtx_Yetkili.Name = "mtx_Yetkili";
            this.mtx_Yetkili.Size = new System.Drawing.Size(215, 26);
            this.mtx_Yetkili.TabIndex = 7;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(15, 215);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(69, 18);
            this.labelControl12.TabIndex = 22;
            this.labelControl12.Text = "Hesap No:";
            // 
            // mtx_hesapNo
            // 
            this.mtx_hesapNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtx_hesapNo.Location = new System.Drawing.Point(107, 212);
            this.mtx_hesapNo.Name = "mtx_hesapNo";
            this.mtx_hesapNo.Size = new System.Drawing.Size(215, 26);
            this.mtx_hesapNo.TabIndex = 6;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Appearance.Options.UseFont = true;
            this.btn_Guncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Guncelle.ImageOptions.SvgImage")));
            this.btn_Guncelle.Location = new System.Drawing.Point(107, 487);
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
            this.btn_Sil.Location = new System.Drawing.Point(107, 454);
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
            this.btn_Kaydet.Location = new System.Drawing.Point(107, 421);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(215, 27);
            this.btn_Kaydet.TabIndex = 16;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(15, 126);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "İlçe:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(18, 92);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(13, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "İl:";
            // 
            // tx_Sube
            // 
            this.tx_Sube.Location = new System.Drawing.Point(107, 150);
            this.tx_Sube.Name = "tx_Sube";
            this.tx_Sube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Sube.Properties.Appearance.Options.UseFont = true;
            this.tx_Sube.Size = new System.Drawing.Size(215, 24);
            this.tx_Sube.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(18, 311);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 18);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Tarih:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(15, 153);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Şube:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 183);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 18);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "IBAN:";
            // 
            // tx_hesapTur
            // 
            this.tx_hesapTur.Location = new System.Drawing.Point(107, 340);
            this.tx_hesapTur.Name = "tx_hesapTur";
            this.tx_hesapTur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_hesapTur.Properties.Appearance.Options.UseFont = true;
            this.tx_hesapTur.Size = new System.Drawing.Size(215, 24);
            this.tx_hesapTur.TabIndex = 10;
            // 
            // tx_bankaAd
            // 
            this.tx_bankaAd.Location = new System.Drawing.Point(107, 60);
            this.tx_bankaAd.Name = "tx_bankaAd";
            this.tx_bankaAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_bankaAd.Properties.Appearance.Options.UseFont = true;
            this.tx_bankaAd.Size = new System.Drawing.Size(215, 24);
            this.tx_bankaAd.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 284);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Telefon :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Banka Adı:";
            // 
            // mtx_Tarih
            // 
            this.mtx_Tarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtx_Tarih.Location = new System.Drawing.Point(107, 308);
            this.mtx_Tarih.Mask = "00/00/0000";
            this.mtx_Tarih.Name = "mtx_Tarih";
            this.mtx_Tarih.Size = new System.Drawing.Size(215, 26);
            this.mtx_Tarih.TabIndex = 9;
            this.mtx_Tarih.ValidatingType = typeof(System.DateTime);
            // 
            // mtx_Telefon
            // 
            this.mtx_Telefon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtx_Telefon.Location = new System.Drawing.Point(107, 276);
            this.mtx_Telefon.Mask = "(999) 000-0000";
            this.mtx_Telefon.Name = "mtx_Telefon";
            this.mtx_Telefon.Size = new System.Drawing.Size(215, 26);
            this.mtx_Telefon.TabIndex = 8;
            // 
            // mtx_IBAN
            // 
            this.mtx_IBAN.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtx_IBAN.Location = new System.Drawing.Point(107, 180);
            this.mtx_IBAN.Name = "mtx_IBAN";
            this.mtx_IBAN.Size = new System.Drawing.Size(215, 26);
            this.mtx_IBAN.TabIndex = 5;
            // 
            // tx_bankaID
            // 
            this.tx_bankaID.Location = new System.Drawing.Point(107, 30);
            this.tx_bankaID.Name = "tx_bankaID";
            this.tx_bankaID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_bankaID.Properties.Appearance.Options.UseFont = true;
            this.tx_bankaID.Size = new System.Drawing.Size(215, 24);
            this.tx_bankaID.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Banka ID:";
            // 
            // frmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 633);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgv_Bankalar);
            this.Name = "frmBankalar";
            this.Text = "BANKALAR";
            this.Load += new System.EventHandler(this.frmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bankalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_IL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Sube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_hesapTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_bankaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_bankaID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dgv_Bankalar;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Ilce;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_IL;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit tx_Sube;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tx_hesapTur;
        private DevExpress.XtraEditors.TextEdit tx_bankaAd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox mtx_Tarih;
        private System.Windows.Forms.MaskedTextBox mtx_Telefon;
        private System.Windows.Forms.MaskedTextBox mtx_IBAN;
        private DevExpress.XtraEditors.TextEdit tx_bankaID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.MaskedTextBox mtx_Yetkili;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.MaskedTextBox mtx_hesapNo;
        private DevExpress.XtraEditors.SimpleButton btn_Temizle;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}