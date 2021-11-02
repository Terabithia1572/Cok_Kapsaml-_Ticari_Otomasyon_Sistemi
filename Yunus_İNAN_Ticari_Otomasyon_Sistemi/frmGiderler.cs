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
    public partial class frmGiderler : Form
    {
        public frmGiderler()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select gider_id,Ay as 'AY',YIL,Elektrik as 'ELEKTRİK',Su as 'SU',Dogalgaz as 'DOĞALGAZ',Internet as 'İNTERNET',Maaslar as 'MAAŞLAR',Ekstra as 'EKSTRA',notlar as 'NOTLAR'  from tbl_giderler", vt.baglanti());
            da.Fill(dt);
            dgv_Giderler.DataSource = dt;
        }
        void Temizle()
        {
            tx_giderID.Text = "";
            tx_Dogalgaz.Text = "";
            tx_Ekstra.Text = "";
            tx_Elektrik.Text = "";
            tx_Internet.Text = "";
            tx_Maaslar.Text = "";
            tx_Su.Text = "";
            rtx_Notlar.Text = "";
            cbx_Ay.Text = "";
            cbx_Yıl.Text = "";
        }

        private void frmGiderler_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("insert into tbl_Giderler(Ay,YIL,Elektrik,Su,Dogalgaz,Internet,Maaslar,Ekstra,Notlar) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", vt.baglanti());
            komut.Parameters.AddWithValue("@p1",cbx_Ay.Text);
            komut.Parameters.AddWithValue("@p2", cbx_Yıl.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(tx_Elektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(tx_Su.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(tx_Dogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(tx_Internet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(tx_Maaslar.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(tx_Ekstra.Text));
            komut.Parameters.AddWithValue("@p9", rtx_Notlar.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();

            DialogResult r = new DialogResult();
            r = MessageBox.Show("Gider Bilgisi Eklensin mi ?", "Uyarı", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Gider Bilgisi Başarıyla Eklendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else
            {
                MessageBox.Show("Gider Bilgisi Eklenmedi İşlem Kullanıcı Tarafından İptal Edildi...");
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr !=null)
            {
                tx_Dogalgaz.Text = dr["DOĞALGAZ"].ToString();
                cbx_Ay.Text = dr["AY"].ToString();
                cbx_Yıl.Text = dr["YIL"].ToString();
                tx_Ekstra.Text = dr["EKSTRA"].ToString();
                tx_Elektrik.Text = dr["ELEKTRİK"].ToString();
                tx_giderID.Text = dr["gider_id"].ToString();
                tx_Internet.Text = dr["İNTERNET"].ToString();
                tx_Maaslar.Text = dr["MAAŞLAR"].ToString();
                tx_Su.Text = dr["SU"].ToString();
                rtx_Notlar.Text = dr["NOTLAR"].ToString();
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_Giderler where gider_id=@p1",vt.baglanti());
            komut.Parameters.AddWithValue("@p1",tx_giderID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            Listele();
            MessageBox.Show("Gider Başarıyla Silindi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand komut = new SqlCommand("update tbl_Giderler set Ay=@p1,YIL=@p2,Elektrik=@p3,Su=@p4,Dogalgaz=@p5,Internet=@p6,Maaslar=@p7,Ekstra=@p8,Notlar=@p9 where gider_id=@p10",vt.baglanti());
            komut.Parameters.AddWithValue("@p1", cbx_Ay.Text);
            komut.Parameters.AddWithValue("@p2", cbx_Yıl.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(tx_Elektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(tx_Su.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(tx_Dogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(tx_Internet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(tx_Maaslar.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(tx_Ekstra.Text));
            komut.Parameters.AddWithValue("@p9", rtx_Notlar.Text);
            komut.Parameters.AddWithValue("@p10", tx_giderID.Text);
            komut.ExecuteNonQuery();
            vt.baglanti().Close();
            Listele();
            MessageBox.Show("Gider Bilgisi Başarıyla Güncellendi..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
