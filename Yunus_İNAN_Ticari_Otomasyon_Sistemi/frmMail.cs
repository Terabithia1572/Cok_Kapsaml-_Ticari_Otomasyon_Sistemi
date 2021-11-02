using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }
        public string Mail; //global bir mail değişkeni oluşturduk
        private void frmMail_Load(object sender, EventArgs e)
        {
            tx_mailAdres.Text = Mail; //label 1 e ise mailden gelen değeri aktar dedik
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage(); //mailmesaj sıfından bir mesaj nesnesi türettik
            SmtpClient istemci = new SmtpClient(); //smpt Simple Mail transfer Protocol'den Geliyor Client ise istemci demek istemci nesnesi türettik hani kapıyı tıklatma gibi işlem yapıyoruz
            istemci.Credentials = new NetworkCredential("legendys65293@gmail.com","Yunus6565");//Credentials kimlik diye geçiyor istemcinin kimliği birinci tırnak içine mail adresimiz 2.tırnak içine şifremizi yazıyoruz
            istemci.Port = 587; // Türkiyede kullanılan port numarası 
            istemci.Host = "smtp.gmail.com";//istemci sunucusu demek
            istemci.EnableSsl = true; // yol boyunca şifrelensin mi yani korunsun mu evet dedik true ile
            mesaj.To.Add(rtx_Mesaj.Text); //mesajım içerisine ekle demek kimden göndericem mesaj atan kişiden mesajın kime gönderiileceği
            mesaj.From = new MailAddress("legendys65293@gmail.com"); // buda bizim kendi mail adresimiz kimden gönderildiği
            mesaj.Subject = tx_Konu.Text;
            mesaj.IsBodyHtml = true;
            mesaj.Body = rtx_Mesaj.Text;
            istemci.Send(mesaj);
        }
    }
}
