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
    public partial class frmHareketler : Form
    {
        public frmHareketler()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();

        void firmaHareketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec firmaHareketler",vt.baglanti());
            da.Fill(dt);
            dgv_Firmalar.DataSource = dt;
        }
        void musteriHareketler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec musteriHareketler", vt.baglanti());
            da.Fill(dt);
            dgv_Musteriler.DataSource = dt;
        }
    

        private void frmHareketler_Load(object sender, EventArgs e)
        {
            firmaHareketleri();
            musteriHareketler();
        }
    }
}
