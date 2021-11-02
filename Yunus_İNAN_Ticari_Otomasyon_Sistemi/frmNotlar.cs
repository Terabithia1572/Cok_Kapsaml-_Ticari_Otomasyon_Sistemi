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
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select not_id as 'NOT ID',notTarih as 'NOT TARİHİ',notSaat as 'NOT SAAT',notBaslik as 'NOT BAŞLIĞI',notDetay as 'NOT DETAY',notOlusturan as 'NOTU OLUŞTURAN',notHitap as 'NOT HİTAP' from tbl_Notlar", vt.baglanti());
            da.Fill(dt);
            dgv_Notlar.DataSource = dt;
        }

        void Temizle()
        {
            mtx_Tarih.Text = "";
            tx_notID.Text = "";
            mtx_Saat.Text = "";
            tx_Baslik.Text = "";
            rtx_Detay.Text = "";
            tx_Olusturan.Text = "";
            tx_Hitap.Text = "";
        }

        private void frmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("insert into tbl_Notlar (notTarih,notSaat,notBaslik,notDetay,notOlusturan,notHitap) values(@p1,@p2,@p3,@p4,@p5,@p6)",vt.baglanti());
            komut.Parameters.AddWithValue("@p1",mtx_Tarih.Text);
            komut.Parameters.AddWithValue("@p2", mtx_Saat.Text);
            komut.Parameters.AddWithValue("@p3", tx_Baslik.Text);
            komut.Parameters.AddWithValue("@p4", rtx_Detay.Text);
            komut.Parameters.AddWithValue("@p5", tx_Olusturan.Text);
            komut.Parameters.AddWithValue("@p6", tx_Hitap.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Not Bilgisi Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if(dr !=null)
            {
                mtx_Tarih.Text = dr["NOT TARİHİ"].ToString();
                tx_notID.Text = dr["NOT ID"].ToString();
                mtx_Saat.Text = dr["NOT SAAT"].ToString();
                tx_Baslik.Text = dr["NOT BAŞLIĞI"].ToString();
                rtx_Detay.Text = dr["NOT DETAY"].ToString();
                tx_Olusturan.Text = dr["NOTU OLUŞTURAN"].ToString();
                tx_Hitap.Text = dr["NOT HİTAP"].ToString();
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_Notlar where not_id=@p1",vt.baglanti());
            komut.Parameters.AddWithValue("@p1", tx_notID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Not Sistemden Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("update tbl_Notlar set notTarih=@p1,notSaat=@p2,notBaslik=@p3,notDetay=@p4,notOlusturan=@p5,notHitap=@p6 where not_id=@p7",vt.baglanti());
            komut.Parameters.AddWithValue("@p1", mtx_Tarih.Text);
            komut.Parameters.AddWithValue("@p2", mtx_Saat.Text);
            komut.Parameters.AddWithValue("@p3", tx_Baslik.Text);
            komut.Parameters.AddWithValue("@p4", rtx_Detay.Text);
            komut.Parameters.AddWithValue("@p5", tx_Olusturan.Text);
            komut.Parameters.AddWithValue("@p6", tx_Hitap.Text);
            komut.Parameters.AddWithValue("@p7", tx_notID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            MessageBox.Show("Not Bilgisi Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            }
            catch
            {
                MessageBox.Show("Ekleme Yaparken Herhangi Bir Alan Boş Bırakmayınız Temzile Butonuna veya Bir Alan Seçip Eklemeye Çalışın..", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        
        private void dgv_Notlar_DoubleClick(object sender, EventArgs e)
        {
            frmNotDetay_a0 fd = new frmNotDetay_a0();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr !=null)
            {
                fd.metin = dr["NOT DETAY"].ToString();
            }
            fd.Show();
        }
    }
}
