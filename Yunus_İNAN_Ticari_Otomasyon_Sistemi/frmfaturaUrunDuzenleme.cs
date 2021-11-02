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
    public partial class frmfaturaUrunDuzenleme : Form
    {
        public frmfaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();

        public string urun_ID;
        private void frmfaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            tx_urunID.Text = urun_ID;
            SqlCommand komut = new SqlCommand("select * from tbl_faturaDetay where faturaUrun_id=@p1",vt.baglanti());
            komut.Parameters.AddWithValue("@p1", urun_ID);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                tx_Fiyat.Text = dr[3].ToString();
                tx_Miktar.Text = dr[2].ToString();
                tx_Tutar.Text = dr[4].ToString();
                tx_urunAd.Text = dr[1].ToString();
                vt.baglanti().Close();
            }



        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            double miktar, tutar, fiyat; // tutarı kendi hesaplayacak bu yüzden 3 değişken tanımladık
            fiyat = Convert.ToDouble(tx_Fiyat.Text); //
            miktar = Convert.ToDouble(tx_Miktar.Text);
            tutar = miktar * fiyat; // fiyat ve miktarı çarpttık
            tx_Tutar.Text = tutar.ToString(); // tutarıda tutar textine attık
            SqlCommand komut = new SqlCommand("update tbl_faturaDetay set urunAd=@p1,urunMiktar=@p2,urunFiyat=@p3,Tutar=@p4 where faturaUrun_id=@p5", vt.baglanti());
            komut.Parameters.AddWithValue("@p1",tx_urunAd.Text);
            komut.Parameters.AddWithValue("@p2", tx_Miktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(tx_Fiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(tx_Tutar.Text));
            komut.Parameters.AddWithValue("@p5", tx_urunID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Değişikler Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_faturaDetay where faturaUrun_id=@p1", vt.baglanti());
            komut.Parameters.AddWithValue("@p1",tx_urunID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Ürün Başarıyla Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }
      
    }
}
