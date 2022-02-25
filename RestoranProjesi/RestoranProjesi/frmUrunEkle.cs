using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
namespace RestoranProjesi
{
    public partial class frmUrunEkle : MetroFramework.Forms.MetroForm
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        Image gorselSecin;
        private void txtGorselYolu_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            open.Title = "Lütfen ürün görselini seçiniz.";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtGorselYolu.Text = open.FileName;
                pictureBox2.ImageLocation = txtGorselYolu.Text;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtFiyati.Text.Length > 0 && txtUrunAdi.Text.Length > 0 && txtGorselYolu.Text.Length > 0 && cmbKategori.SelectedIndex >= 0)
            {
                clsUrunler urun = new clsUrunler();
                clsIslemler islem = new clsIslemler();
                urun.Adi = txtUrunAdi.Text;
                urun.Fiyati = double.Parse(txtFiyati.Text);
                urun.Kategori = cmbKategori.SelectedIndex;
                urun.SKullanilan = cbSKullanilan.Checked;
                islem.urunEkle(urun, txtGorselYolu.Text);
                txtFiyati.Clear();
                txtUrunAdi.Clear();
                cbSKullanilan.Checked = false;
                cmbKategori.SelectedIndex = -1;
                txtGorselYolu.Clear();
                pictureBox2.Image = gorselSecin;
            }
            else MessageBox.Show("Boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            gorselSecin = pictureBox2.Image;
        }
    }
}
