using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    public partial class frmAdmin : MetroFramework.Forms.MetroForm
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_Admin where kullaniciAd=@p1 and Sifre=@p2", vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_kullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", tx_Sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                frmAnaModul fr = new frmAnaModul();
                
                fr.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı Girdiniz..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            vt.baglanti().Close();

            if (chbx_beniHatirla.Checked == true)
            {
                Ayarlar.Default.beniHatirla = true;
                Ayarlar.Default.tcNo = tx_kullaniciAd.Text;
                Ayarlar.Default.sifre = tx_Sifre.Text;
                Ayarlar.Default.Save();
            }
            else
            {
                Ayarlar.Default.Reset();
            }

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            timersaatTarih.Start();
            if (Ayarlar.Default.beniHatirla == true)
            {
                chbx_beniHatirla.Checked = true;
                tx_kullaniciAd.Text = Ayarlar.Default.tcNo;
                tx_Sifre.Text = Ayarlar.Default.sifre;
            }
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue("KullaniciGirisi").ToString() == "\"" + Application.ExecutablePath + "\"")
                {
                    chbx_windowsIleBaslama.Checked = true;
                }
            }
            catch
            { }

            tx_Sifre.PasswordChar = '●';
        }

        private void chbx_windowsIleBaslama_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_windowsIleBaslama.Checked)
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("KullaniciGirisi", "\"" + Application.ExecutablePath + "\"");
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("KullaniciGirisi");
            }
        }

        private void chbx_sifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_sifreGoster.Checked == true)
                tx_Sifre.PasswordChar = '\0';
            else
                tx_Sifre.PasswordChar = '●';
        }

        private void notifyIconTicari_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.Show();
            else
                this.Hide();
        }

        private void timersaatTarih_Tick(object sender, EventArgs e)
        {
            lbl_Tarih.Text = DateTime.Now.ToLongDateString();
            lbl_Saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
