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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        Veritabani vt = new Veritabani(); //
    

        void Listele() //geriye değer döndürmeyen method
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select urun_id as 'ÜRÜN ID',urunAd as 'ÜRÜN ADI',urunMarka as 'ÜRÜNÜN MARKASI',urunModel as 'ÜRÜNÜN MODELİ',urunYil as 'ÜRÜN YIL',urunAdet as 'ÜRÜN ADEDİ',urunalisFiyat as 'ÜRÜN ALIŞ FİYATI',urunsatisFiyat as 'ÜRÜN SATIŞ FİYATI',urunDetay as 'ÜRÜN DETAY' from tbl_Urunler", vt.baglanti());
            da.Fill(dt);
            dgv_Urunler.DataSource = dt;
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
           
            Listele();
            Temizle();
        }
        void Temizle()
        {
            tx_urunID.Text = "";
            tx_Ad.Text = "";
            tx_Marka.Text = "";
            tx_Model.Text = "";
            mtx_Yil.Text = "";
            nmr_Adet.Value = 0;
            tx_alisFiyat.Text = "";
            tx_satisFiyat.Text = "";
            rtx_Detay.Text = "";
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try { 
            //baglanti kısmı açık olduğu için baglantıyı tekrar açmamıza gerek yok
            //Verileri Kaydetme 
            SqlCommand komut = new SqlCommand(@"insert into tbl_Urunler(urunAd,urunMarka,urunModel,urunYil,urunAdet,urunalisFiyat,urunsatisFiyat,urunDetay) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",vt.baglanti());
            //@p1,@p2... dememizin sebebi parametre 1 den alacak parametre 2 den alacak anlamında

            komut.Parameters.AddWithValue("@p1", tx_Ad.Text); //Değer olarak ekleteceğiz @p1 nerden gelen değer Ürün Adından Gelen Değer
            komut.Parameters.AddWithValue("@p2",tx_Marka.Text);
            komut.Parameters.AddWithValue("@p3",tx_Model.Text);
            komut.Parameters.AddWithValue("@p4",mtx_Yil.Text);
            // komut.Parameters.AddWithValue("@p5", decimal.Parse((nmr_Adet.Value).ToString());//Adet kısmına veritabanı ile aynı olan dönüşümü ypamamız lazım mesela veritabanında Decimal olarak Tutuluyor burda da bönüşüm yapmamız laızm
            //decimal.parse dediğimizde decimale dönüştür anlamında yazdık nmr.Adet'ten gelen değeri decimale dönüştür demek
            komut.Parameters.AddWithValue("@p5",int.Parse((nmr_Adet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6",decimal.Parse(tx_alisFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(tx_satisFiyat.Text));
            komut.Parameters.AddWithValue("@p8",rtx_Detay.Text);
            komut.ExecuteNonQuery(); //ne yaspıyor dml komutlarını gerçekleştiriyor yani sorguyu çalıştır sonra 
            vt.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //verileri ekledikten sonra verilerimizi listeleyelim demek
            Listele();
            }catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }


        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from tbl_Urunler where urun_id=@p1",vt.baglanti());
            komutsil.Parameters.AddWithValue("@p1", tx_urunID.Text);
            komutsil.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Ürün Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //Datarow Sınıfından dr nesnesi türettik getDataRow dediğimiz kısım veri satırımız al demek Get almak demek row satır demek data veri demek yani kısacası o veriyi al demek ondan sonra buraya row handled kısmını yazın yani indeks numaraısnı yazıcaz alıcağımız satırın indeksi gibi nasıl alıcaz grid viewdeki seçilen değeri alıcaz demek bunuda gridView1.FocusedRowHandle yaptık
            tx_urunID.Text = dr["ÜRÜN ID"].ToString();
            tx_Ad.Text = dr["ÜRÜN ADI"].ToString();
            tx_Marka.Text = dr["ÜRÜNÜN MARKASI"].ToString();
            tx_Model.Text = dr["ÜRÜNÜN MODELİ"].ToString();
            mtx_Yil.Text = dr["ÜRÜN YIL"].ToString();
            nmr_Adet.Value = decimal.Parse(dr["ÜRÜN ADEDİ"].ToString());
            tx_alisFiyat.Text = dr["ÜRÜN ALIŞ FİYATI"].ToString();
            tx_satisFiyat.Text = dr["ÜRÜN SATIŞ FİYATI"].ToString();
            rtx_Detay.Text = dr["ÜRÜN DETAY"].ToString();

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("update tbl_urunler set urunAd=@p1,urunMarka=@p2,urunModel=@p3,urunYil=@p4,urunAdet=@p5,urunalisFiyat=@p6,urunsatisFiyat=@p7,urunDetay=@p8 where urun_id=@p9",vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_Ad.Text); //Değer olarak ekleteceğiz @p1 nerden gelen değer Ürün Adından Gelen Değer
            komut.Parameters.AddWithValue("@p2", tx_Marka.Text);
            komut.Parameters.AddWithValue("@p3", tx_Model.Text);
            komut.Parameters.AddWithValue("@p4", mtx_Yil.Text);
            // komut.Parameters.AddWithValue("@p5", decimal.Parse((nmr_Adet.Value).ToString());//Adet kısmına veritabanı ile aynı olan dönüşümü ypamamız lazım mesela veritabanında Decimal olarak Tutuluyor burda da bönüşüm yapmamız laızm
            //decimal.parse dediğimizde decimale dönüştür anlamında yazdık nmr.Adet'ten gelen değeri decimale dönüştür demek
            komut.Parameters.AddWithValue("@p5", int.Parse((nmr_Adet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(tx_alisFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(tx_satisFiyat.Text));
            komut.Parameters.AddWithValue("@p8", rtx_Detay.Text);
            komut.Parameters.Add("@p9",tx_urunID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
