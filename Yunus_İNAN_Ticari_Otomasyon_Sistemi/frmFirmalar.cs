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
    public partial class frmFirmalar : Form
    {
        public frmFirmalar()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"select firma_id,firmaAd as 'FİRMA ADI',firmayetkiliStatu as 'FİRMA YETKİLİ STATÜSÜ',yetkiliadSoyad as 'YETKİLİ ADSOYAD',yetkiliTC as 'YETKİLİ TC',firmaSektor as 'FİRMA SEKTÖR',Telefon,Telefon2,Telefon3,Mail,Fax,IL as 'İL',Ilce as 'İLÇE',vergiDaire as 'VERGİ DAİRESİ',Adres,ozelKod1,ozelKod2,ozelKod3 from tbl_Firmalar",vt.baglanti());
            da.Fill(dt);
            dgv_Firmalar.DataSource = dt;
            
        }

        void Temizle()
        {
            tx_Ad.Text = "";
            tx_firmaID.Text = "";
            tx_Kod1.Text = "";
            tx_Kod2.Text = "";
            tx_Kod3.Text = "";
            tx_Mail.Text = "";
            tx_Sektor.Text = "";
            tx_vergiDairesi.Text = "";
            tx_Yetkili.Text = "";
            tx_yetkiliGorev.Text = "";
            mtx_Fax.Text = "";
            mtx_TC.Text = "";
            mtx_Telefon1.Text = "";
            mtx_Telefon2.Text = "";
            mtx_Telefon3.Text = "";
            rtx_Adres.Text = "";
            
            cbx_IL.SelectedIndex = -1;
            cbx_Ilce.SelectedIndex = -1;
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

        void carikodAciklamalar()
        {
            SqlCommand komut = new SqlCommand("select firmaKod1 from tbl_kodlar",vt.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                rtx_ozelKod1.Text = dr[0].ToString();
            }
            vt.baglanti().Close();
        }
        private void frmFirmalar_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListesi();
            Temizle();
            carikodAciklamalar();
        }
        

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr !=null)
            {
                tx_Ad.Text = dr["FİRMA ADI"].ToString();
                tx_firmaID.Text = dr["firma_id"].ToString();
                tx_Kod1.Text = dr["ozelKod1"].ToString();
                tx_Kod2.Text = dr["ozelKod2"].ToString();
                tx_Kod3.Text = dr["ozelKod3"].ToString();
                tx_Mail.Text = dr["Mail"].ToString();
                tx_Sektor.Text = dr["FİRMA SEKTÖR"].ToString();
                tx_vergiDairesi.Text = dr["VERGİ DAİRESİ"].ToString();
                tx_Yetkili.Text = dr["YETKİLİ ADSOYAD"].ToString();
                tx_yetkiliGorev.Text = dr["FİRMA YETKİLİ STATÜSÜ"].ToString();
                mtx_Fax.Text = dr["Fax"].ToString();
                mtx_TC.Text = dr["YETKİLİ TC"].ToString();
                mtx_Telefon1.Text = dr["Telefon"].ToString();
                mtx_Telefon2.Text = dr["Telefon2"].ToString();
                mtx_Telefon3.Text = dr["Telefon3"].ToString();
                cbx_IL.Text = dr["İL"].ToString();
                cbx_Ilce.Text = dr["İLÇE"].ToString();
                rtx_Adres.Text = dr["Adres"].ToString();
                rtx_ozelKod1.Text = dr["ozelKod1"].ToString();
                rtx_ozelKod2.Text = dr["ozelKod2"].ToString();
                rtx_ozelKod3.Text = dr["ozelKod3"].ToString();

            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
    
            try { 
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Firma Bilgisi Eklensin mi ?", "Uyarı", MessageBoxButtons.YesNo);
            if(r==DialogResult.Yes)
            {
            SqlCommand komut = new SqlCommand(@"insert into tbl_Firmalar(firmaAd,firmayetkiliStatu,yetkiliadSoyad,yetkiliTC,firmaSektor,Telefon,Telefon2,Telefon3,Mail,Fax,IL,Ilce,vergiDaire,Adres,ozelKod1,ozelKod2,ozelKod3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_Ad.Text);
            komut.Parameters.AddWithValue("@p2", tx_yetkiliGorev.Text);
            komut.Parameters.AddWithValue("@p3", tx_Yetkili.Text);
            komut.Parameters.AddWithValue("@p4", mtx_TC.Text);
            komut.Parameters.AddWithValue("@p5", tx_Sektor.Text);
            komut.Parameters.AddWithValue("@p6", mtx_Telefon1.Text);
            komut.Parameters.AddWithValue("@p7", mtx_Telefon2.Text);
            komut.Parameters.AddWithValue("@p8", mtx_Telefon3.Text);
            komut.Parameters.AddWithValue("@p9", tx_Mail.Text);
            komut.Parameters.AddWithValue("@p10", mtx_Fax.Text);
            komut.Parameters.AddWithValue("@p11", cbx_IL.Text);
            komut.Parameters.AddWithValue("@p12", cbx_Ilce.Text);
            komut.Parameters.AddWithValue("@p13", tx_vergiDairesi.Text);
            komut.Parameters.AddWithValue("@p14", rtx_Adres.Text);
            komut.Parameters.AddWithValue("@p15", rtx_ozelKod1.Text);
            komut.Parameters.AddWithValue("@p16", rtx_ozelKod2.Text);
            komut.Parameters.AddWithValue("@p17", rtx_ozelKod3.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
          
                MessageBox.Show("Firma Bilgisi Başarıyla Eklendi..","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Firma Bilgisi Eklenmedi İşlem Kullanıcı Tarafından İptal Edildi...");
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

        private void btn_Sil_Click(object sender, EventArgs e)
        {
          
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Silme İşlemi Gerçekleştirmek İstiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if(r==DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand(@"delete from tbl_Firmalar where firma_id=@p1", vt.baglanti());
                komut.Parameters.AddWithValue("@p1", tx_firmaID.Text);
                komut.ExecuteNonQuery();
                vt.baglanti().Close();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silme İşlemi Kullanıcı Tarafından İptal Edildi..","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Listele();
            Temizle();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
         try {   
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Firma Bilgisi Güncellensin mi ?", "Uyarı", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand(@"update tbl_Firmalar set firmaAd=@p1,firmayetkiliStatu=@p2,yetkiliadSoyad=@p3,yetkiliTC=@p4,firmaSektor=@p5,Telefon=@p6,Telefon2=@p7,Telefon3=@p8,Mail=@p9,Fax=@p10,IL=@p11,Ilce=@p12,vergiDaire=@p13,Adres=@p14,ozelKod1=@p15,ozelKod2=@p16,ozelKod3=@p17 where firma_id=@p18", vt.baglanti());
                komut.Parameters.AddWithValue("@p1", tx_Ad.Text);
                komut.Parameters.AddWithValue("@p2", tx_yetkiliGorev.Text);
                komut.Parameters.AddWithValue("@p3", tx_Yetkili.Text);
                komut.Parameters.AddWithValue("@p4", mtx_TC.Text);
                komut.Parameters.AddWithValue("@p5", tx_Sektor.Text);
                komut.Parameters.AddWithValue("@p6", mtx_Telefon1.Text);
                komut.Parameters.AddWithValue("@p7", mtx_Telefon2.Text);
                komut.Parameters.AddWithValue("@p8", mtx_Telefon3.Text);
                komut.Parameters.AddWithValue("@p9", tx_Mail.Text);
                komut.Parameters.AddWithValue("@p10", mtx_Fax.Text);
                komut.Parameters.AddWithValue("@p11", cbx_IL.Text);
                komut.Parameters.AddWithValue("@p12", cbx_Ilce.Text);
                komut.Parameters.AddWithValue("@p13", tx_vergiDairesi.Text);
                komut.Parameters.AddWithValue("@p14", rtx_Adres.Text);
                komut.Parameters.AddWithValue("@p15", rtx_ozelKod1.Text);
                komut.Parameters.AddWithValue("@p16", rtx_ozelKod2.Text);
                komut.Parameters.AddWithValue("@p17", rtx_ozelKod3.Text);
                komut.Parameters.AddWithValue("@p18", tx_firmaID.Text);
                komut.ExecuteNonQuery();
                vt.baglanti().Close();
                MessageBox.Show("Firma Bilgisi Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Firma Bilgisi Güncellenmedi İşlem Kullanıcı Tarafından İptal Edildi...");
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

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
