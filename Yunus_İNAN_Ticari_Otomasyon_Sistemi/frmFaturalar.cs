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
    public partial class frmFaturalar : Form
    {
        public frmFaturalar()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select faturaBilgi_id as 'FATURA BİLGİ ID',faturaSeri as 'FATURA SERİ NO',faturasiraNo as 'FATURA SIRA NO',faturaTarih as 'FATURA TARİH',faturaSaat as 'FATURA SAAT',vergiDaire as 'VERGİ DAİRESİ',Alici as 'ALICI',faturateslimEden as 'FATURA TESLİM EDEN',faturateslimAlan as 'FATURA TESLİM ALAN' from tbl_faturaBilgi", vt.baglanti());
            da.Fill(dt);
            dgv_Faturalar.DataSource = dt;
        }
        private void frmFaturalar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try { 
         
                double miktar, tutar, fiyat; // tutarı kendi hesaplayacak bu yüzden 3 değişken tanımladık
                fiyat = Convert.ToDouble(tx_Fiyat.Text); //
                miktar = Convert.ToDouble(tx_Miktar.Text);
                tutar = miktar * fiyat; // fiyat ve miktarı çarpttık
                tx_Tutar.Text = tutar.ToString(); // tutarıda tutar textine attık
                SqlCommand komut2 = new SqlCommand("insert into tbl_faturaDetay(urunAd,urunMiktar,urunFiyat,Tutar,fatura_id) values(@p1,@p2,@p3,@p4,@p5)",vt.baglanti());
                komut2.Parameters.AddWithValue("@p1", tx_urunAd.Text);
                komut2.Parameters.AddWithValue("@p2", tx_Miktar.Text);
                komut2.Parameters.AddWithValue("@p3", tx_Fiyat.Text);
                komut2.Parameters.AddWithValue("@p4", tx_Tutar.Text);
                komut2.Parameters.AddWithValue("@p5", tx_faturadetayID.Text);
                komut2.ExecuteNonQuery();
                vt.baglanti().Close();
                MessageBox.Show("Faturaya Ait Ürün Sisteme Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        void Temizle()
        {
            tx_faturaID.Text = "";
            tx_Seri.Text = "";
            tx_siraNo.Text = "";
            mtx_Tarih.Text = "";
            mtx_Saat.Text = "";
            tx_vergiDaire.Text = "";
            tx_Alici.Text = "";
            tx_teslimEden.Text = "";
            tx_teslimAlan.Text = "";

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr !=null)
            {
                tx_faturaID.Text = dr["FATURA BİLGİ ID"].ToString();
                tx_Seri.Text = dr["FATURA SERİ NO"].ToString();
                tx_siraNo.Text = dr["FATURA SIRA NO"].ToString();
                mtx_Tarih.Text = dr["FATURA TARİH"].ToString();
                mtx_Saat.Text = dr["FATURA SAAT"].ToString();
                tx_vergiDaire.Text = dr["VERGİ DAİRESİ"].ToString();
                tx_Alici.Text = dr["ALICI"].ToString();
                tx_teslimEden.Text = dr["FATURA TESLİM EDEN"].ToString();
                tx_teslimAlan.Text = dr["FATURA TESLİM ALAN"].ToString();
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_kaydet2_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("insert into tbl_faturaBilgi(faturaSeri,faturasiraNo,faturaTarih,faturaSaat,vergiDaire,Alici,faturateslimEden,faturateslimAlan) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_Seri.Text);
            komut.Parameters.AddWithValue("@p2", tx_siraNo.Text);
            komut.Parameters.AddWithValue("@p3", mtx_Tarih.Text);
            komut.Parameters.AddWithValue("@p4", mtx_Saat.Text);
            komut.Parameters.AddWithValue("@p5", tx_vergiDaire.Text);
            komut.Parameters.AddWithValue("@p6", tx_Alici.Text);
            komut.Parameters.AddWithValue("@p7", tx_teslimEden.Text);
            komut.Parameters.AddWithValue("@p8", tx_teslimAlan.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Sisteme Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            }
            catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_Sil2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_faturaBilgi where faturaBilgi_id=@p1",vt.baglanti());
            komut.Parameters.AddWithValue("@p1",tx_faturaID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Silindi..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();

        }

        private void btn_Guncelle2_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("update tbl_faturaBilgi set faturaSeri=@p1,faturasiraNo=@p2,faturaTarih=@p3,faturaSaat=@p4,vergiDaire=@p5,Alici=@p6,faturateslimEden=@p7,faturateslimAlan=@p8 where faturaBilgi_id=@p9", vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_Seri.Text);
            komut.Parameters.AddWithValue("@p2", tx_siraNo.Text);
            komut.Parameters.AddWithValue("@p3", mtx_Tarih.Text);
            komut.Parameters.AddWithValue("@p4", mtx_Saat.Text);
            komut.Parameters.AddWithValue("@p5", tx_vergiDaire.Text);
            komut.Parameters.AddWithValue("@p6", tx_Alici.Text);
            komut.Parameters.AddWithValue("@p7", tx_teslimEden.Text);
            komut.Parameters.AddWithValue("@p8", tx_teslimAlan.Text);
            komut.Parameters.AddWithValue("@p9", tx_faturaID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            }
            catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaUrunDetay fr = new frmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr !=null)
            {
                fr.ID = dr["FATURA BİLGİ ID"].ToString();
            }
            fr.Show();
        }
    }
}
