using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranProjesi
{
    public partial class frmHesapKapat : MetroFramework.Forms.MetroForm
    {
        public frmHesapKapat()
        {
            InitializeComponent();
        }

        public clsSatislar satis;
        public int siparisID;
        private void frmHesapKapat_Load(object sender, EventArgs e)
        {
            lblMasa.Text = "MASA" + satis.MasaNo;
            lblTutar.Text = satis.Fiyat + "₺";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clsIslemler islem = new clsIslemler();
            if((sender as Button).Tag.ToString()=="2")
            {
                satis.Fiyat = double.Parse(txtTutar.Text);
            }
            satis.OdemeSekli = int.Parse((sender as Button).Tag.ToString());
            islem.hesapKapat(siparisID, satis);
            this.Close();
        }
    }
}
