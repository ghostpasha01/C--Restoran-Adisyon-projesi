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
    public partial class frmSatisDetay : MetroFramework.Forms.MetroForm
    {
        public frmSatisDetay()
        {
            InitializeComponent();
        }
        clsIslemler islem = new clsIslemler();
        void veriGetir(DateTime dt)
        {
            dgvSatislar.DataSource = islem.satisListele(dt);
            lblSatisSayisi.Text = "Satış Sayısı: " + dgvSatislar.Rows.Count;
            double hasilat = 0;
            for (int i = 0; i < dgvSatislar.Rows.Count; i++)
            {
                string odemeSekli = dgvSatislar.Rows[i].Cells[3].Value.ToString();
                if (odemeSekli == "0") odemeSekli = "Nakit";
                else if (odemeSekli == "1") odemeSekli = "Kredi Kartı";
                else odemeSekli = "İndirimli";
                hasilat += double.Parse(dgvSatislar.Rows[i].Cells[4].Value.ToString());
            }
            lblHasilat.Text = "Toplam Hasılat: " + hasilat + "₺";
            dgvSatislar.Columns[0].Visible = false;
            dgvSatislar.Columns[1].HeaderText = "Çalışan";
            dgvSatislar.Columns[2].HeaderText = "Masa No";
            dgvSatislar.Columns[3].HeaderText = "Ödeme Şekli";

        }

        private void frmSatisDetay_Load(object sender, EventArgs e)
        {
            veriGetir(DateTime.Now);
        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            veriGetir(dtTarih.Value);
        }
    }
}
