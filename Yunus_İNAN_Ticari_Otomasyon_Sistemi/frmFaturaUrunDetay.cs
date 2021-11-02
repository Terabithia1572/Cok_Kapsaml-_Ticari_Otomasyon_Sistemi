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
    public partial class frmFaturaUrunDetay : Form
    {
        public frmFaturaUrunDetay()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        public string ID;

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_faturaDetay where fatura_id='"+ID+"'",vt.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmfaturaUrunDuzenleme fr = new frmfaturaUrunDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr !=null)
            {
                fr.urun_ID = dr["faturaUrun_id"].ToString();
            }
            fr.Show();
           // this.Hide();

        }
    }
}
