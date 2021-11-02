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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select musteri_id,musteriAd as 'MÜŞTERİ ADI',musteriSoyad as 'MÜŞTERİ SOYAD',Telefon as 'TELEFON',Telefon2 as 'TELEFON 2',TC,Mail,IL as 'İL',Ilce as 'İLÇE',Adres,vergiDaire as 'VERGİ DAİRESİ' from tbl_Musteriler", vt.baglanti());
            da.Fill(dt);
            dgv_Musteriler.DataSource = dt;
        }
        void Temizle()
        {
            tx_musteriID.Text = "";
            tx_Ad.Text = "";
            tx_Soyad.Text = "";
            tx_Mail.Text = "";
            mtx_Telefon1.Text = "";
            mtx_Telefon2.Text = "";
            cbx_IL.Text = "";
            cbx_Ilce.Text = "";
            rtx_Adres.Text = "";
            tx_vergiDairesi.Text = "";
            mtx_TC.Text = "";

        }

        void sehirListesi()
        {
            SqlCommand komut=new SqlCommand("select sehir from tbl_iller", vt.baglanti());
            SqlDataReader dr = komut.ExecuteReader(); //verileri okutacağımız için SqlDataReader Komutunu kullandık dr komut kümesi ile ilişkendirdik
            while(dr.Read()) //okuma işlemi sürdükçe demek ne yapıcak okuma sürdükçe 
            {
                cbx_IL.Properties.Items.Add(dr[0]); //dr den gelen 0.indeks demek
            }
            vt.baglanti().Close(); //baglanti kapattık burda
        }
        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListesi();
            Temizle();
        }

        private void cbx_IL_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ili seçtiğimiz zaman o ile ait bize ilçeleri göstermesi için üstünne çift tıkladık
            //ve kodumuzu yazıyoruz 
            cbx_Ilce.Properties.Items.Clear(); //Bir şehir seçtiğimizde illere ait ilçelerde kayıtlı kalıyordu bu sayede seçtiğimizde temizleyerek sadece o ile ait ilçeleri gösterecek
            SqlCommand komut = new SqlCommand("Select ilce from tbl_Ilceler where sehir=@p1",vt.baglanti()); //sorguyu sql den çektik ilce sorgusunu daha sonra 
            komut.Parameters.AddWithValue("@p1",cbx_IL.SelectedIndex+1); // seçtiğimiz ilin bi altındaki illere ait ilçeleri çekiyordu +1 yazarak indis sayısına göre o illere ait ilçeleri çektik
            SqlDataReader dr = komut.ExecuteReader(); //Bir ya da birden fazla satırların sonuç olarak döneceği sorgularda SqlCommand' ın ExecuteReader özelliği kullanılmaktadır. ExecuteReader geriye SqlDataReader tipinde veri döndürmektedir. SqlDataReader, sadece okunabilir olarak kullanılmaktadır. Satır satır okuma işlemi yapılmaktadır.
            while (dr.Read()) //okuma işlemi sürdükçe alttaki kodda yazılanı uygulayacak
            {
                cbx_Ilce.Properties.Items.Add(dr[0]);

            }
            vt.baglanti().Close();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("insert into tbl_musteriler(musteriAd,musteriSoyad,Telefon,Telefon2,TC,Mail,IL,Ilce,Adres,vergiDaire) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_Ad.Text);
            komut.Parameters.AddWithValue("@p2", tx_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", mtx_Telefon1.Text);
            komut.Parameters.AddWithValue("@p4", mtx_Telefon2.Text);
            komut.Parameters.AddWithValue("@p5", mtx_TC.Text);
            komut.Parameters.AddWithValue("@p6", tx_Mail.Text);
            komut.Parameters.AddWithValue("@p7", cbx_IL.Text);
            komut.Parameters.AddWithValue("@p8", cbx_Ilce.Text);
            komut.Parameters.AddWithValue("@p9", rtx_Adres.Text);
            komut.Parameters.AddWithValue("@p10", tx_vergiDairesi.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            }
            catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                tx_musteriID.Text = dr["musteri_id"].ToString();
                tx_Ad.Text = dr["MÜŞTERİ ADI"].ToString();
                tx_Soyad.Text = dr["MÜŞTERİ SOYAD"].ToString();
                tx_Mail.Text = dr["Mail"].ToString();
                mtx_Telefon1.Text = dr["TELEFON"].ToString();
                mtx_Telefon2.Text = dr["TELEFON 2"].ToString();
                cbx_IL.Text = dr["İL"].ToString();
                cbx_Ilce.Text = dr["İLÇE"].ToString();
                rtx_Adres.Text = dr["Adres"].ToString();
                tx_vergiDairesi.Text = dr["VERGİ DAİRESİ"].ToString();
                mtx_TC.Text = dr["TC"].ToString();


            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_Musteriler where musteri_id=@p1",vt.baglanti());
            komut.Parameters.AddWithValue("@p1",tx_musteriID.Text);
            komut.ExecuteNonQuery(); //ExecuteNonQuery ne yapıyordu üç temel DML komutunda insert update delete tablo üzerinde değişiklik olduğu zaman ekle sil güncellede tablo üzerinde değişiklik olduğu zaman çalışıyordu

            // komut.ExecuteReader() bu ne yapıyordu bu da select sorgusunda çalışıyordu 
            vt.baglanti().Close();
            //   MessageBox.Show("Müşteri Silindi..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Devam etmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                MessageBox.Show("Müşteri Silindi..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (d == DialogResult.No)
            {
                MessageBox.Show("Müşteri Silinmedi .");
                return;
            }

            Listele();


        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("update tbl_Musteriler set musteriAd=@p1,musteriSoyad=@p2,Telefon=@p3,Telefon2=@p4,TC=@p5,Mail=@p6,IL=@p7,Ilce=@p8,Adres=@p9,vergiDaire=@p10 where musteri_id=@p11",vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_Ad.Text);
            komut.Parameters.AddWithValue("@p2", tx_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", mtx_Telefon1.Text);
            komut.Parameters.AddWithValue("@p4", mtx_Telefon2.Text);
            komut.Parameters.AddWithValue("@p5", mtx_TC.Text);
            komut.Parameters.AddWithValue("@p6", tx_Mail.Text);
            komut.Parameters.AddWithValue("@p7", cbx_IL.Text);
            komut.Parameters.AddWithValue("@p8", cbx_Ilce.Text);
            komut.Parameters.AddWithValue("@p9", rtx_Adres.Text);
            komut.Parameters.AddWithValue("@p10", tx_vergiDairesi.Text);
            komut.Parameters.AddWithValue("p11", tx_musteriID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Müşteri Bilgileri Güncellenecek Devam etmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                MessageBox.Show("Müşteri Bilgileri Güncellendi..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (d == DialogResult.No)
            {
                MessageBox.Show("Müşteri Güncellenmedi .");
                return;
            }

            Listele();
            }
            catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
