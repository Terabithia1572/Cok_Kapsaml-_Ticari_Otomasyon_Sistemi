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

namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    public partial class frmRehber : Form
    {
        public frmRehber()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        void listeleMusteriler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"select musteriAd as 'MÜŞTERİ AD',musteriSoyad as 'MÜŞTERİ SOYAD',Telefon,Telefon2,Mail from tbl_Musteriler", vt.baglanti());
            da.Fill(dt);
            dgv_Musteriler.DataSource = dt;
            
        }

        void listeleFirmalar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"select firmaAd as 'FİRMA AD',yetkiliadSoyad as 'YETKİLİ ADSOYAD',Telefon,Telefon2,Telefon3,Mail,Fax from tbl_Firmalar", vt.baglanti());
            da.Fill(dt);
            dgv_Firmalar.DataSource = dt;
        }
        private void frmRehber_Load(object sender, EventArgs e)
        {
            listeleMusteriler();
            listeleFirmalar();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmMail frm = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //seçtiğimiz satırın verisini dr ye aktaracak

            if(dr !=null) //eğer dr farklıysa null'dan yani bilinmeyen bir değer değilse o zaman ne yapsın 
            {
                frm.Mail = dr["Mail"].ToString(); // o zaman frm.Mail frm ne burda mail sınıfı içinde bir nesne diğer formdaki mail değişkeni dr den gelen mail kısmı anlamında
                // frm nesnemi gösterme kodunu aşağıda yazdık
            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frmMail fm = new frmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if(dr !=null)
            {
                fm.Mail = dr["Mail"].ToString();
            }
            fm.Show();
        }
    }
}
