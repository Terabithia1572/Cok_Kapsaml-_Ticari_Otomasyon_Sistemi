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
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }

        Veritabani vt = new Veritabani();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"select personel_id,personelAd as 'PERSONEL AD',personelSoyad as 'PERSONEL SOYAD',Telefon,TC,Mail,IL as 'İL',Ilce as 'İLÇE',Adres,personelGorev as 'PERSONEL GÖREV' from tbl_Personeller",vt.baglanti());
            da.Fill(dt);
            dgv_Personeller.DataSource = dt;
        }

        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("select sehir from tbl_iller", vt.baglanti());
            SqlDataReader dr = komut.ExecuteReader(); //verileri okutacağımız için SqlDataReader Komutunu kullandık dr komut kümesi ile ilişkendirdik
            while (dr.Read()) //okuma işlemi sürdükçe demek ne yapıcak okuma sürdükçe 
            {
                cbx_IL.Properties.Items.Add(dr[0]); //dr den gelen 0.indeks demek
            }
            vt.baglanti().Close(); //baglanti kapattık burda
        }

        void Temizle()
        {
            tx_Ad.Text = "";
            tx_Soyad.Text = "";
            tx_personelID.Text = "";
            tx_Gorev.Text = "";
            tx_Mail.Text = "";
            mtx_TC.Text = "";
            mtx_Telefon1.Text = "";
            cbx_IL.Text = "";
            cbx_Ilce.Text = "";
            rtx_Adres.Text = "";
        }

        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListesi();
            Temizle();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
         try { 
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Personel Bilgileri Eklensin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(r==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("insert into tbl_Personeller(personelAd,personelSoyad,Telefon,TC,Mail,IL,Ilce,Adres,personelGorev) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", vt.baglanti());
                komut.Parameters.AddWithValue("@p1", tx_Ad.Text);
                komut.Parameters.AddWithValue("@p2", tx_Soyad.Text);
                komut.Parameters.AddWithValue("@p3", mtx_Telefon1.Text);
                komut.Parameters.AddWithValue("@p4", mtx_TC.Text);
                komut.Parameters.AddWithValue("@p5", tx_Mail.Text);
                komut.Parameters.AddWithValue("@p6", cbx_IL.Text);
                komut.Parameters.AddWithValue("@p7", cbx_Ilce.Text);
                komut.Parameters.AddWithValue("@p8", rtx_Adres.Text);
                komut.Parameters.AddWithValue("@p9", tx_Gorev.Text);
                komut.ExecuteNonQuery();
                vt.baglanti().Close();
                MessageBox.Show("Personel Bilgileri Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Personel Bilgileri Eklenmedi İşlem kullanıcı Tarafından İptal Edildi..","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            Listele();
            Temizle();
            }
            catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void cbx_IL_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ili seçtiğimiz zaman o ile ait bize ilçeleri göstermesi için üstünne çift tıkladık
            //ve kodumuzu yazıyoruz 
            cbx_Ilce.Properties.Items.Clear(); //Bir şehir seçtiğimizde illere ait ilçelerde kayıtlı kalıyordu bu sayede seçtiğimizde temizleyerek sadece o ile ait ilçeleri gösterecek
            SqlCommand komut = new SqlCommand("Select ilce from tbl_Ilceler where sehir=@p1", vt.baglanti()); //sorguyu sql den çektik ilce sorgusunu daha sonra 
            komut.Parameters.AddWithValue("@p1", cbx_IL.SelectedIndex + 1); // seçtiğimiz ilin bi altındaki illere ait ilçeleri çekiyordu +1 yazarak indis sayısına göre o illere ait ilçeleri çektik
            SqlDataReader dr = komut.ExecuteReader(); //Bir ya da birden fazla satırların sonuç olarak döneceği sorgularda SqlCommand' ın ExecuteReader özelliği kullanılmaktadır. ExecuteReader geriye SqlDataReader tipinde veri döndürmektedir. SqlDataReader, sadece okunabilir olarak kullanılmaktadır. Satır satır okuma işlemi yapılmaktadır.
            while (dr.Read()) //okuma işlemi sürdükçe alttaki kodda yazılanı uygulayacak
            {
                cbx_Ilce.Properties.Items.Add(dr[0]);

            }
            vt.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr !=null)
            {
                tx_Ad.Text = dr["PERSONEL AD"].ToString();
                tx_Soyad.Text = dr["PERSONEL SOYAD"].ToString();
                tx_personelID.Text = dr["personel_id"].ToString();
                tx_Gorev.Text = dr["PERSONEL GÖREV"].ToString();
                tx_Mail.Text = dr["Mail"].ToString();
                cbx_IL.Text = dr["İL"].ToString();
                cbx_Ilce.Text = dr["İLÇE"].ToString();
                mtx_TC.Text = dr["TC"].ToString();
                mtx_Telefon1.Text = dr["Telefon"].ToString();
                rtx_Adres.Text = dr["Adres"].ToString();
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
           
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Personel Bilgileri Silinsin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from tbl_Personeller where personel_id=@p1", vt.baglanti());
                komut.Parameters.AddWithValue("@p1", tx_personelID.Text);
                komut.ExecuteNonQuery();
                vt.baglanti().Close();
                MessageBox.Show("Personel Bilgileri Başarıyla Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Personel Bilgileri Silinmedi İşlem kullanıcı Tarafından İptal Edildi..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Listele();
            Temizle();

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
        
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Personel Bilgileri Güncellensin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand(@"update tbl_Personeller set personelAd=@p1,personelSoyad=@p2,Telefon=@p3,TC=@p4,Mail=@p5,IL=@p6,Ilce=@p7,Adres=@p8,personelGorev=@p9 where personel_id=@p10", vt.baglanti());
                komut.Parameters.AddWithValue("@p1", tx_Ad.Text);
                komut.Parameters.AddWithValue("@p2", tx_Soyad.Text);
                komut.Parameters.AddWithValue("@p3", mtx_Telefon1.Text);
                komut.Parameters.AddWithValue("@p4", mtx_TC.Text);
                komut.Parameters.AddWithValue("@p5", tx_Mail.Text);
                komut.Parameters.AddWithValue("@p6", cbx_IL.Text);
                komut.Parameters.AddWithValue("@p7", cbx_Ilce.Text);
                komut.Parameters.AddWithValue("@p8", rtx_Adres.Text);
                komut.Parameters.AddWithValue("@p9", tx_Gorev.Text);
                komut.Parameters.AddWithValue("@p10", tx_personelID.Text);
                komut.ExecuteNonQuery();
                vt.baglanti().Close();
                MessageBox.Show("Personel Bilgileri Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Personel Bilgileri Güncellenmedi İşlem kullanıcı Tarafından İptal Edildi..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Listele();
            Temizle();
            }
            catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
