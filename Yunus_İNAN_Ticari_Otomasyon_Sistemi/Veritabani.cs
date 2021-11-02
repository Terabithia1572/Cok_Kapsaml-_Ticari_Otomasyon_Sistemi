using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //sql kütüphanesi ekledik

namespace Yunus_İNAN_Ticari_Otomasyon_Sistemi
{
    class Veritabani //sınıfımızın Adı
    {
        public SqlConnection baglanti()//sınıfn içinde bir method oluşturucaz geriye değer döndüren method altı çizmesinin nedeni şuan geriye değer döndürmediği için
            //baglanti metodumuzun ismi
        {
            //şuan sql bağlantı adresi lazım bunu nerden alıcaz yukarda project database kısmından 

            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-GNHP86H;Initial Catalog=db_TicariOtomasyon;Integrated Security=True");
            //baglan nesnemin ismi
            baglan.Open(); //baglanaya ait open özelliği
            return baglan; //
        }
    }
}
