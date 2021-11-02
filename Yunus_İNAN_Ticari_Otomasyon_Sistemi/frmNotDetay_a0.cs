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
    public partial class frmNotDetay_a0 : Form
    {
        public frmNotDetay_a0()
        {
            InitializeComponent();
        }
        public string metin;
        private void frmNotDetay_a0_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = metin;
        }
    }
}
