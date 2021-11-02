namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.timersaatTarih = new System.Windows.Forms.Timer(this.components);
            this.lbl_Saat = new MetroFramework.Controls.MetroLabel();
            this.lbl_Tarih = new MetroFramework.Controls.MetroLabel();
            this.notifyIconTicari = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_kullanici = new MetroFramework.Components.MetroToolTip();
            this.btn_mailGonder = new MetroFramework.Controls.MetroButton();
            this.btn_sifremiUnuttum = new MetroFramework.Controls.MetroButton();
            this.chbx_sifreGoster = new MetroFramework.Controls.MetroCheckBox();
            this.btn_Giris = new MetroFramework.Controls.MetroTile();
            this.tx_Sifre = new MetroFramework.Controls.MetroTextBox();
            this.tx_kullaniciAd = new MetroFramework.Controls.MetroTextBox();
            this.chbx_beniHatirla = new System.Windows.Forms.CheckBox();
            this.chbx_windowsIleBaslama = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_Sifre = new MetroFramework.Controls.MetroLabel();
            this.lbl_Telefon = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(398, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 69;
            this.metroLabel2.Text = "Tarih:";
            // 
            // timersaatTarih
            // 
            this.timersaatTarih.Interval = 1000;
            this.timersaatTarih.Tick += new System.EventHandler(this.timersaatTarih_Tick);
            // 
            // lbl_Saat
            // 
            this.lbl_Saat.AutoSize = true;
            this.lbl_Saat.Location = new System.Drawing.Point(443, 144);
            this.lbl_Saat.Name = "lbl_Saat";
            this.lbl_Saat.Size = new System.Drawing.Size(0, 0);
            this.lbl_Saat.TabIndex = 68;
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Location = new System.Drawing.Point(443, 111);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(0, 0);
            this.lbl_Tarih.TabIndex = 67;
            // 
            // notifyIconTicari
            // 
            this.notifyIconTicari.ContextMenuStrip = this.metroContextMenu1;
            this.notifyIconTicari.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTicari.Icon")));
            this.notifyIconTicari.Text = "Taksi Durak İşlemleri";
            this.notifyIconTicari.Visible = true;
            this.notifyIconTicari.DoubleClick += new System.EventHandler(this.notifyIconTicari_DoubleClick);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.gizleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(153, 92);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.Click += new System.EventHandler(this.gösterToolStripMenuItem_Click);
            // 
            // gizleToolStripMenuItem
            // 
            this.gizleToolStripMenuItem.Name = "gizleToolStripMenuItem";
            this.gizleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gizleToolStripMenuItem.Text = "Gizle";
            this.gizleToolStripMenuItem.Click += new System.EventHandler(this.gizleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // tp_kullanici
            // 
            this.tp_kullanici.Style = MetroFramework.MetroColorStyle.Blue;
            this.tp_kullanici.StyleManager = null;
            this.tp_kullanici.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btn_mailGonder
            // 
            this.btn_mailGonder.Location = new System.Drawing.Point(420, 253);
            this.btn_mailGonder.Name = "btn_mailGonder";
            this.btn_mailGonder.Size = new System.Drawing.Size(113, 32);
            this.btn_mailGonder.TabIndex = 63;
            this.btn_mailGonder.Text = "Mail Gönder";
            this.tp_kullanici.SetToolTip(this.btn_mailGonder, "Mail Gönderir");
            this.btn_mailGonder.UseSelectable = true;
            // 
            // btn_sifremiUnuttum
            // 
            this.btn_sifremiUnuttum.Location = new System.Drawing.Point(290, 324);
            this.btn_sifremiUnuttum.Name = "btn_sifremiUnuttum";
            this.btn_sifremiUnuttum.Size = new System.Drawing.Size(113, 32);
            this.btn_sifremiUnuttum.TabIndex = 62;
            this.btn_sifremiUnuttum.Text = "Şifremi Unuttum ?";
            this.tp_kullanici.SetToolTip(this.btn_sifremiUnuttum, "Şifremi Unuttum Açmak İçin Tıklayın");
            this.btn_sifremiUnuttum.UseSelectable = true;
            // 
            // chbx_sifreGoster
            // 
            this.chbx_sifreGoster.AutoSize = true;
            this.chbx_sifreGoster.Location = new System.Drawing.Point(123, 324);
            this.chbx_sifreGoster.Name = "chbx_sifreGoster";
            this.chbx_sifreGoster.Size = new System.Drawing.Size(92, 15);
            this.chbx_sifreGoster.TabIndex = 61;
            this.chbx_sifreGoster.Text = "Şifreyi Göster";
            this.tp_kullanici.SetToolTip(this.chbx_sifreGoster, "Şifreyi Gösterir");
            this.chbx_sifreGoster.UseSelectable = true;
            this.chbx_sifreGoster.CheckedChanged += new System.EventHandler(this.chbx_sifreGoster_CheckedChanged);
            // 
            // btn_Giris
            // 
            this.btn_Giris.ActiveControl = null;
            this.btn_Giris.Location = new System.Drawing.Point(123, 362);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(280, 53);
            this.btn_Giris.TabIndex = 60;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Giris.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Giris.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tp_kullanici.SetToolTip(this.btn_Giris, "Giriş Yapmak İçin Tıklayın");
            this.btn_Giris.UseSelectable = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // tx_Sifre
            // 
            // 
            // 
            // 
            this.tx_Sifre.CustomButton.Image = null;
            this.tx_Sifre.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.tx_Sifre.CustomButton.Name = "";
            this.tx_Sifre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_Sifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_Sifre.CustomButton.TabIndex = 1;
            this.tx_Sifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_Sifre.CustomButton.UseSelectable = true;
            this.tx_Sifre.CustomButton.Visible = false;
            this.tx_Sifre.DisplayIcon = true;
            this.tx_Sifre.Lines = new string[0];
            this.tx_Sifre.Location = new System.Drawing.Point(123, 291);
            this.tx_Sifre.MaxLength = 32767;
            this.tx_Sifre.Name = "tx_Sifre";
            this.tx_Sifre.PasswordChar = '\0';
            this.tx_Sifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_Sifre.SelectedText = "";
            this.tx_Sifre.SelectionLength = 0;
            this.tx_Sifre.SelectionStart = 0;
            this.tx_Sifre.ShortcutsEnabled = true;
            this.tx_Sifre.Size = new System.Drawing.Size(280, 26);
            this.tx_Sifre.TabIndex = 59;
            this.tp_kullanici.SetToolTip(this.tx_Sifre, "Şifre En Az 6 Karakter");
            this.tx_Sifre.UseSelectable = true;
            this.tx_Sifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_Sifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tx_kullaniciAd
            // 
            // 
            // 
            // 
            this.tx_kullaniciAd.CustomButton.Image = null;
            this.tx_kullaniciAd.CustomButton.Location = new System.Drawing.Point(256, 2);
            this.tx_kullaniciAd.CustomButton.Name = "";
            this.tx_kullaniciAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tx_kullaniciAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tx_kullaniciAd.CustomButton.TabIndex = 1;
            this.tx_kullaniciAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tx_kullaniciAd.CustomButton.UseSelectable = true;
            this.tx_kullaniciAd.CustomButton.Visible = false;
            this.tx_kullaniciAd.DisplayIcon = true;
            this.tx_kullaniciAd.Lines = new string[0];
            this.tx_kullaniciAd.Location = new System.Drawing.Point(123, 223);
            this.tx_kullaniciAd.MaxLength = 32767;
            this.tx_kullaniciAd.Name = "tx_kullaniciAd";
            this.tx_kullaniciAd.PasswordChar = '\0';
            this.tx_kullaniciAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tx_kullaniciAd.SelectedText = "";
            this.tx_kullaniciAd.SelectionLength = 0;
            this.tx_kullaniciAd.SelectionStart = 0;
            this.tx_kullaniciAd.ShortcutsEnabled = true;
            this.tx_kullaniciAd.Size = new System.Drawing.Size(280, 26);
            this.tx_kullaniciAd.TabIndex = 58;
            this.tp_kullanici.SetToolTip(this.tx_kullaniciAd, "Kullanıcı Adı Yazarak Giriş Yapılmalı");
            this.tx_kullaniciAd.UseSelectable = true;
            this.tx_kullaniciAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tx_kullaniciAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chbx_beniHatirla
            // 
            this.chbx_beniHatirla.AutoSize = true;
            this.chbx_beniHatirla.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbx_beniHatirla.Location = new System.Drawing.Point(420, 300);
            this.chbx_beniHatirla.Name = "chbx_beniHatirla";
            this.chbx_beniHatirla.Size = new System.Drawing.Size(83, 17);
            this.chbx_beniHatirla.TabIndex = 57;
            this.chbx_beniHatirla.Text = "Beni Hatırla:";
            this.tp_kullanici.SetToolTip(this.chbx_beniHatirla, "Beni Hatırla");
            this.chbx_beniHatirla.UseVisualStyleBackColor = true;
            // 
            // chbx_windowsIleBaslama
            // 
            this.chbx_windowsIleBaslama.AutoSize = true;
            this.chbx_windowsIleBaslama.Location = new System.Drawing.Point(398, 60);
            this.chbx_windowsIleBaslama.Name = "chbx_windowsIleBaslama";
            this.chbx_windowsIleBaslama.Size = new System.Drawing.Size(132, 15);
            this.chbx_windowsIleBaslama.TabIndex = 56;
            this.chbx_windowsIleBaslama.Text = "Windows ile başlasın";
            this.tp_kullanici.SetToolTip(this.chbx_windowsIleBaslama, "Bilgisayar Başlarken Bu Uygulamada Açılır");
            this.chbx_windowsIleBaslama.UseSelectable = true;
            this.chbx_windowsIleBaslama.CheckedChanged += new System.EventHandler(this.chbx_windowsIleBaslama_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(398, 144);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 70;
            this.metroLabel1.Text = "Saat:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(123, 266);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(38, 19);
            this.lbl_Sifre.TabIndex = 54;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(123, 201);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(82, 19);
            this.lbl_Telefon.TabIndex = 53;
            this.lbl_Telefon.Text = "Kullanıcı Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yunus_İNAN_Ticari_Otomasyon_Sistemi.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(152, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 138);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 449);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbl_Saat);
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_mailGonder);
            this.Controls.Add(this.btn_sifremiUnuttum);
            this.Controls.Add(this.chbx_sifreGoster);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.tx_Sifre);
            this.Controls.Add(this.tx_kullaniciAd);
            this.Controls.Add(this.chbx_beniHatirla);
            this.Controls.Add(this.chbx_windowsIleBaslama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_Telefon);
            this.Name = "frmAdmin";
            this.Text = "KULLANICI GİRİŞİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Timer timersaatTarih;
        private MetroFramework.Controls.MetroLabel lbl_Saat;
        private MetroFramework.Controls.MetroLabel lbl_Tarih;
        private System.Windows.Forms.NotifyIcon notifyIconTicari;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private MetroFramework.Components.MetroToolTip tp_kullanici;
        private MetroFramework.Controls.MetroButton btn_mailGonder;
        private MetroFramework.Controls.MetroButton btn_sifremiUnuttum;
        private MetroFramework.Controls.MetroCheckBox chbx_sifreGoster;
        private MetroFramework.Controls.MetroTile btn_Giris;
        private MetroFramework.Controls.MetroTextBox tx_Sifre;
        public MetroFramework.Controls.MetroTextBox tx_kullaniciAd;
        private System.Windows.Forms.CheckBox chbx_beniHatirla;
        private MetroFramework.Controls.MetroCheckBox chbx_windowsIleBaslama;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lbl_Sifre;
        private MetroFramework.Controls.MetroLabel lbl_Telefon;
    }
}