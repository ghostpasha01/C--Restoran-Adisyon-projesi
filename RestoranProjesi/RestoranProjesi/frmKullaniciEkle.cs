using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
namespace RestoranProjesi
{
    public partial class frmKullaniciEkle : MetroFramework.Forms.MetroForm
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            clsIslemler islemler = new clsIslemler();
            if (islemler.kayitOlustur(txtAd.text, txtSoyad.text, txtKAdi.text, txtSifre.text) == true) MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else MessageBox.Show("Kayıt işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtAd.text = "";
            txtKAdi.text = "";
            txtSifre.text = "";
            txtSoyad.text = "";
            txtAd.Focus();
        }
    }
}
