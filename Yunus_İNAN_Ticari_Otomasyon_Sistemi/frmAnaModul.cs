using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    public partial class frmAnaModul : Form
    {
        public frmAnaModul()
        {
            InitializeComponent();
        }
        frmUrunler fr;//global ürünler formunu tanımladık
        private void btn_Urunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr==null) { //burada if fr==nul yapmamızın sebebi kullanıcı eğer ki ürünler formu açık değilse sürekli açması diye bu kodu yazdık
            fr = new frmUrunler();
            fr.MdiParent = this;
            fr.Show();
        }
        }
        frmMusteriler mus;
        private void btn_Musteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(mus==null)
            {
                mus = new frmMusteriler();
                mus.MdiParent = this;
                mus.Show();
            }
        }

        frmFirmalar frm;
        private void btn_Firmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm==null)
            {
                frm = new frmFirmalar();
                frm.MdiParent = this;
                frm.Show();
            }

        }

        frmPersoneller p;
        private void btn_Personeller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(p==null)
            {
                p = new frmPersoneller();
                p.MdiParent = this;
                p.Show();
            }
        }
        frmRehber r;
        private void btn_Rehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(r==null)
            {
                r = new frmRehber();
                r.MdiParent = this;
                r.Show();
            }

        }
        frmGiderler g;
        private void btn_Giderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(g==null)
            {
                g = new frmGiderler();
                g.MdiParent = this;
                g.Show();
            }
        }
        frmBankalar b;
        private void btn_Bankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(b==null)
            {
                b = new frmBankalar();
                b.MdiParent = this;
                b.Show();
            }
        }

        frmFaturalar ft;
        private void btn_Faturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ft==null)
            {
                ft = new frmFaturalar();
                ft.MdiParent = this;
                ft.Show();
            }
        }
        frmNotlar nt;
        private void btn_Notlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(nt==null)
            {
                nt = new frmNotlar();
                nt.MdiParent = this;
                nt.Show();
            }
        }

        private void frmAnaModul_Load(object sender, EventArgs e)
        {
          //  btn_anaSayfa.LargeImages.ToString();
        }
        frmHareketler fh;
        private void btn_Hareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fh ==null)
            {
                fh = new frmHareketler();
                fh.MdiParent = this;
                fh.Show();
            }
        }
    }
}
