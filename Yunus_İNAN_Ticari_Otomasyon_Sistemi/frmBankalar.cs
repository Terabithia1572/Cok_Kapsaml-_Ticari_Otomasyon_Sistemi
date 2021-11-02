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
    public partial class frmBankalar : Form
    {
        public frmBankalar()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"execute bankaBilgiler", vt.baglanti()); //procedure kullandık burada nasıl yaptık Create Prodecure bankaBilgiler as 
                                                                                        //Create Procedure bankaBilgiler
                                                                                                        //as
                                                                            //select bankaAd as 'BANKA AD',tbl_Bankalar.IL as 'İL',tbl_Bankalar.Ilce as 'İLÇE',bankaSube as 'BANKA ŞUBE',
                                                                            //Iban as 'IBAN',hesapNo as 'HESAP NO',Yetkili as 'YETKİLİ',
                                                                            //tbl_bankalar.TELEFON,hesapTarih as 'HESAP TARİHİ',hesapTur as 'HESAP TÜRÜ',firmaAd as 'FİRMA AD'
                                                                            //from
                                                                            //tbl_Bankalar inner join tbl_Firmalar
                                                                            //on
                                                                            //tbl_Bankalar.Firma_id = tbl_Firmalar.Firma_id

                                                                            //execute bankaBilgiler
            da.Fill(dt);
            dgv_Bankalar.DataSource = dt;
        }

        void sehirListesi()
        {
            SqlCommand komut = new SqlCommand("select sehir from tbl_iller", vt.baglanti());
            SqlDataReader dr = komut.ExecuteReader(); //verileri okutacağımız için SqlDataReader Komutunu kullandık dr komut kümesi ile ilişkendirdik
            while (dr.Read()) //okuma işlemi sürdükçe demek ne yapıcak okuma sürdükçe 
            {
                cbx_IL.Properties.Items.Add(dr[0]); //dr den gelen 0.indeks demek
            }
            vt.baglanti().Close(); //baglanti kapattık burda/
        }

        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select firma_id,firmaAd from tbl_Firmalar",vt.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "firma_id";
            lookUpEdit1.Properties.DisplayMember = "firmaAd";
            lookUpEdit1.Properties.DataSource = dt;           

        }
        void Temizle()
        {
            tx_bankaAd.Text = "";
            tx_bankaID.Text = "";
            tx_hesapTur.Text = "";
            tx_Sube.Text = "";
            mtx_hesapNo.Text = "";
            mtx_IBAN.Text = "";
            mtx_Tarih.Text = "";
            mtx_Telefon.Text = "";
            mtx_Yetkili.Text = "";
            cbx_IL.Text = "";
            cbx_Ilce.Text = "";
            
            lookUpEdit1.Text="";
        }

        private void frmBankalar_Load(object sender, EventArgs e)
        {
            Listele();
            sehirListesi();
           firmaListesi();
            Temizle();
            
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut =new SqlCommand("insert into tbl_Bankalar (bankaAd,IL,Ilce,bankaSube,Iban,hesapNo,Yetkili,TELEFON,hesapTarih,hesapTur,Firma_id) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_bankaAd.Text);
            komut.Parameters.AddWithValue("@p2", cbx_IL.Text);
            komut.Parameters.AddWithValue("@p3", cbx_Ilce.Text);
            komut.Parameters.AddWithValue("@p4", tx_Sube.Text);
            komut.Parameters.AddWithValue("@p5", mtx_IBAN.Text);
            komut.Parameters.AddWithValue("@p6", mtx_hesapNo.Text);
            komut.Parameters.AddWithValue("@p7", mtx_Yetkili.Text);
            komut.Parameters.AddWithValue("@p8", mtx_Telefon.Text);
            komut.Parameters.AddWithValue("@p9", mtx_Tarih.Text);
            komut.Parameters.AddWithValue("@p10", tx_hesapTur.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            Listele();
            vt.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                tx_bankaAd.Text = dr["BANKA AD"].ToString();
                tx_bankaID.Text = dr["banka_id"].ToString();
                tx_hesapTur.Text = dr["HESAP TÜRÜ"].ToString();
                tx_Sube.Text = dr["BANKA ŞUBE"].ToString();
                mtx_hesapNo.Text = dr["HESAP NO"].ToString();
                mtx_IBAN.Text = dr["IBAN"].ToString();
                mtx_Tarih.Text = dr["HESAP TARİHİ"].ToString();
                mtx_Telefon.Text = dr["TELEFON"].ToString();
                mtx_Yetkili.Text = dr["YETKİLİ"].ToString();
                cbx_IL.Text = dr["İL"].ToString();
                cbx_Ilce.Text = dr["İLÇE"].ToString();
                lookUpEdit1.Text = dr["FİRMA AD"].ToString();

            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_Bankalar where banka_id=@p1",vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_bankaID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            Temizle();
            MessageBox.Show("Banka bilgisi Sistemden Silindi...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            Listele();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("update tbl_Bankalar set bankaAd=@p1,IL=@p2,Ilce=@p3,bankaSube=@p4,Iban=@p5,hesapNo=@p6,Yetkili=@p7,TELEFON=@p8,hesapTarih=@p9,hesapTur=@p10,Firma_id=@p11 where banka_id=@p12", vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_bankaAd.Text);
            komut.Parameters.AddWithValue("@p2", cbx_IL.Text);
            komut.Parameters.AddWithValue("@p3", cbx_Ilce.Text);
            komut.Parameters.AddWithValue("@p4", tx_Sube.Text);
            komut.Parameters.AddWithValue("@p5", mtx_IBAN.Text);
            komut.Parameters.AddWithValue("@p6", mtx_hesapNo.Text);
            komut.Parameters.AddWithValue("@p7", mtx_Yetkili.Text);
            komut.Parameters.AddWithValue("@p8", mtx_Telefon.Text);
            komut.Parameters.AddWithValue("@p9", mtx_Tarih.Text);
            komut.Parameters.AddWithValue("@p10", tx_hesapTur.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@p12", tx_bankaID.Text);
            komut.ExecuteNonQuery();
            Listele();
            vt.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
