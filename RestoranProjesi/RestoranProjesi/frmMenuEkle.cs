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
    public partial class frmMenuEkle : MetroFramework.Forms.MetroForm
    {
        public frmMenuEkle()
        {
            InitializeComponent();
        }
        Image gorselSecin;
        void fiyatHesapla()
        {
            double toplam = 0;
            for (int i = 0; i < dgvSecilenler.Rows.Count; i++)
            {
                double fiyat = double.Parse(dgvSecilenler.Rows[i].Cells[3].Value.ToString());
                int adet = int.Parse(dgvSecilenler.Rows[i].Cells[2].Value.ToString());
                toplam += (fiyat * adet);
            }
            lbToplamFiyat.Text = "Toplam Fiyat: " + toplam + "₺";
        }
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

        private void frmMenuEkle_Load(object sender, EventArgs e)
        {
            clsIslemler islem = new clsIslemler();
            dgvUrunler.DataSource = islem.urunler();
            dgvUrunler.Columns[0].Visible = false;
            dgvUrunler.Columns[3].Visible = false;
            dgvUrunler.Columns[4].Visible = false;
            dgvUrunler.Columns[5].Visible = false;
            dgvUrunler.Columns[1].HeaderText = "Ürün Adı";
            dgvUrunler.Columns[1].Width = 374;
            dgvUrunler.Columns[2].Width = 100;
            gorselSecin = pictureBox2.Image;
        }

        private void txtAranacak_TextChanged(object sender, EventArgs e)
        {
            clsIslemler islem = new clsIslemler();
            dgvUrunler.DataSource = islem.urunler(txtAranacak.Text);
        }

        private void dgvUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenID = int.Parse(dgvUrunler.SelectedRows[0].Cells[0].Value.ToString());
            string adi = dgvUrunler.SelectedRows[0].Cells[1].Value.ToString();
            double urunFiyat = double.Parse(dgvUrunler.SelectedRows[0].Cells[2].Value.ToString());

            bool varMi = false;
            for (int i = 0; i < dgvSecilenler.Rows.Count; i++)
            {
                if (int.Parse(dgvSecilenler.Rows[i].Cells[0].Value.ToString()) == secilenID)
                {
                    dgvSecilenler.Rows[i].Cells[2].Value = (int.Parse(dgvSecilenler.Rows[i].Cells[2].Value.ToString()) + 1).ToString();
                    varMi = true;
                }
            }
            if (!varMi)
            {
                dgvSecilenler.Rows.Add(secilenID, adi, 1, urunFiyat);
            }
            fiyatHesapla();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtFiyati.Text.Length > 0 && txtMenuAdi.Text.Length > 0 && txtGorselYolu.Text.Length > 0 && dgvSecilenler.Rows.Count > 0)
            {
                clsIslemler islem = new clsIslemler();
                clsMenuler menu = new clsMenuler();
                menu.Adi = txtMenuAdi.Text;
                menu.Fiyati = double.Parse(txtFiyati.Text);
                menu.SKullanilan = cbSKullanilan.Checked;
                List<clsUrunler> urunler = new List<clsUrunler>();
                List<int> urunlerAdet = new List<int>();
                for (int i = 0; i < dgvSecilenler.Rows.Count; i++)
                {
                    clsUrunler urun = new clsUrunler();
                    urun.ID = int.Parse(dgvSecilenler.Rows[i].Cells[0].Value.ToString());
                    urunler.Add(urun);
                    urunlerAdet.Add(int.Parse(dgvSecilenler.Rows[i].Cells[2].Value.ToString()));
                }
                menu.MenuIcerik = urunler;
                menu.MenuIcerikAdet = urunlerAdet;
                islem.menuEkle(menu, txtGorselYolu.Text);
                dgvSecilenler.Rows.Clear();
                txtFiyati.Clear();
                txtGorselYolu.Clear();
                pictureBox2.Image = gorselSecin;
                lbToplamFiyat.Text = "Toplam Fiyat: 0₺";
            }
            else MessageBox.Show("Boş alan bırakmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvSecilenler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSecilenler.Rows.RemoveAt(dgvSecilenler.SelectedRows[0].Index);
            fiyatHesapla();
        }
    }
}
