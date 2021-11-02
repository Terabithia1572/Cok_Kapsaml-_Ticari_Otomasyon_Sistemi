namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    partial class frmPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersoneller));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgv_Personeller = new DevExpress.XtraGrid.GridControl();
            this.cbx_Ilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbx_IL = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rtx_Adres = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Mail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Gorev = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Soyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.mtx_TC = new System.Windows.Forms.MaskedTextBox();
            this.mtx_Telefon1 = new System.Windows.Forms.MaskedTextBox();
            this.tx_personelID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_IL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Gorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_personelID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgv_Personeller;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // dgv_Personeller
            // 
            this.dgv_Personeller.Location = new System.Drawing.Point(5, 12);
            this.dgv_Personeller.MainView = this.gridView1;
            this.dgv_Personeller.Name = "dgv_Personeller";
            this.dgv_Personeller.Size = new System.Drawing.Size(1571, 609);
            this.dgv_Personeller.TabIndex = 4;
            this.dgv_Personeller.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cbx_Ilce
            // 
            this.cbx_Ilce.Location = new System.Drawing.Point(107, 256);
            this.cbx_Ilce.Name = "cbx_Ilce";
            this.cbx_Ilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_Ilce.Properties.Appearance.Options.UseFont = true;
            this.cbx_Ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Ilce.Size = new System.Drawing.Size(215, 24);
            this.cbx_Ilce.TabIndex = 8;
            // 
            // cbx_IL
            // 
            this.cbx_IL.Location = new System.Drawing.Point(107, 225);
            this.cbx_IL.Name = "cbx_IL";
            this.cbx_IL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbx_IL.Properties.Appearance.Options.UseFont = true;
            this.cbx_IL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_IL.Size = new System.Drawing.Size(215, 24);
            this.cbx_IL.TabIndex = 7;
            this.cbx_IL.SelectedIndexChanged += new System.EventHandler(this.cbx_IL_SelectedIndexChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(15, 299);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(44, 18);
            this.labelControl11.TabIndex = 20;
            this.labelControl11.Text = "Görev:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(18, 392);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(42, 18);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Adres:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Temizle);
            this.groupControl1.Controls.Add(this.cbx_Ilce);
            this.groupControl1.Controls.Add(this.cbx_IL);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btn_Guncelle);
            this.groupControl1.Controls.Add(this.btn_Sil);
            this.groupControl1.Controls.Add(this.btn_Kaydet);
            this.groupControl1.Controls.Add(this.rtx_Adres);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.tx_Mail);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.tx_Gorev);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.tx_Soyad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tx_Ad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.mtx_TC);
            this.groupControl1.Controls.Add(this.mtx_Telefon1);
            this.groupControl1.Controls.Add(this.tx_personelID);
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
            this.btn_Temizle.TabIndex = 21;
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
            // rtx_Adres
            // 
            this.rtx_Adres.Location = new System.Drawing.Point(107, 337);
            this.rtx_Adres.Name = "rtx_Adres";
            this.rtx_Adres.Size = new System.Drawing.Size(215, 108);
            this.rtx_Adres.TabIndex = 10;
            this.rtx_Adres.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(15, 262);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "İlçe:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(18, 228);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(13, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "İl:";
            // 
            // tx_Mail
            // 
            this.tx_Mail.Location = new System.Drawing.Point(107, 192);
            this.tx_Mail.Name = "tx_Mail";
            this.tx_Mail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Mail.Properties.Appearance.Options.UseFont = true;
            this.tx_Mail.Size = new System.Drawing.Size(215, 24);
            this.tx_Mail.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(15, 162);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(24, 18);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "TC:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 195);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Mail:";
            // 
            // tx_Gorev
            // 
            this.tx_Gorev.Location = new System.Drawing.Point(107, 296);
            this.tx_Gorev.Name = "tx_Gorev";
            this.tx_Gorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Gorev.Properties.Appearance.Options.UseFont = true;
            this.tx_Gorev.Size = new System.Drawing.Size(215, 24);
            this.tx_Gorev.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 18);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Telefon:";
            // 
            // tx_Soyad
            // 
            this.tx_Soyad.Location = new System.Drawing.Point(107, 90);
            this.tx_Soyad.Name = "tx_Soyad";
            this.tx_Soyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Soyad.Properties.Appearance.Options.UseFont = true;
            this.tx_Soyad.Size = new System.Drawing.Size(215, 24);
            this.tx_Soyad.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Soyad:";
            // 
            // tx_Ad
            // 
            this.tx_Ad.Location = new System.Drawing.Point(107, 60);
            this.tx_Ad.Name = "tx_Ad";
            this.tx_Ad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Ad.Properties.Appearance.Options.UseFont = true;
            this.tx_Ad.Size = new System.Drawing.Size(215, 24);
            this.tx_Ad.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ad:";
            // 
            // mtx_TC
            // 
            this.mtx_TC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtx_TC.Location = new System.Drawing.Point(107, 159);
            this.mtx_TC.Mask = "00000000000";
            this.mtx_TC.Name = "mtx_TC";
            this.mtx_TC.Size = new System.Drawing.Size(215, 26);
            this.mtx_TC.TabIndex = 5;
            // 
            // mtx_Telefon1
            // 
            this.mtx_Telefon1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtx_Telefon1.Location = new System.Drawing.Point(107, 123);
            this.mtx_Telefon1.Mask = "(999) 000-0000";
            this.mtx_Telefon1.Name = "mtx_Telefon1";
            this.mtx_Telefon1.Size = new System.Drawing.Size(215, 26);
            this.mtx_Telefon1.TabIndex = 3;
            // 
            // tx_personelID
            // 
            this.tx_personelID.Location = new System.Drawing.Point(107, 30);
            this.tx_personelID.Name = "tx_personelID";
            this.tx_personelID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_personelID.Properties.Appearance.Options.UseFont = true;
            this.tx_personelID.Size = new System.Drawing.Size(215, 24);
            this.tx_personelID.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel ID:";
            // 
            // frmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 633);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgv_Personeller);
            this.Name = "frmPersoneller";
            this.Text = "PERSONELLER";
            this.Load += new System.EventHandler(this.frmPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Personeller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_IL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Gorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_personelID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dgv_Personeller;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_Ilce;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_IL;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Temizle;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton btn_Kaydet;
        private System.Windows.Forms.RichTextBox rtx_Adres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit tx_Mail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tx_Gorev;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tx_Soyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tx_Ad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox mtx_TC;
        private System.Windows.Forms.MaskedTextBox mtx_Telefon1;
        private DevExpress.XtraEditors.TextEdit tx_personelID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}