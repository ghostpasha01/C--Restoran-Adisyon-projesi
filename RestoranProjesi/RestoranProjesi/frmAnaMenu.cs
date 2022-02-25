using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ns1;
namespace RestoranProjesi
{
    public partial class frmAnaMenu : MetroFramework.Forms.MetroForm
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }
        public clsKullanicilar kullanici;
        string secilen = null;
        Button secilenB = null;
        List<clsAnlikSiparisler> siparisler;
        private void frmAnaMenu_Load(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();
            lblKullanici.Text = kullanici.Adi + " " + kullanici.Soyadi;
            urunListele();
            menuListele();
            sKullanilanListele();
            siparisListele();
            if(kullanici.Tipi==0)
            {
                btnMenuEkle.Enabled = false;
                btnRaporlar.Enabled = false;
                btnUrunEkle.Enabled = false;
                btnSatislar.Enabled = false;
            }
        }

        void siparisListele()
        {
            clsIslemler islem = new clsIslemler();
            siparisler = islem.siparislerListele();
            foreach (Control item in pnlMasalar.Controls)
            {
                if (item is Button) ((Button)item).ImageIndex = 0;
            }
            for (int i = 0; i < siparisler.Count; i++)
            {
                foreach (Control item in pnlMasalar.Controls)
                {
                    if (item is Button)
                    {
                        if (int.Parse(((Button)item).Tag.ToString()) == siparisler[i].MasaNo)
                        {
                            ((Button)item).ImageIndex = 1;
                            break;
                        }
                    }
                }
            }
        }
        void sKullanilanListele()
        {
            pnlSKullanilanlar.Controls.Clear();
            clsIslemler islem = new clsIslemler();
            int pbX = 68, pbY = 37;
            int lbX = 68, lbY = 136;
            for (int j = 0; j < 7; j++)
            {
                List<clsUrunler> urunler = islem.urunListele(j);
                for (int i = 0; i < urunler.Count; i++)
                {
                    if (urunler[i].SKullanilan)
                    {
                        PictureBox urunGorsel = new PictureBox();
                        urunGorsel.Size = new Size(100, 100);
                        urunGorsel.Tag = urunler[i].ID + ";" + urunler[i].Fiyati;
                        urunGorsel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        urunGorsel.SizeMode = PictureBoxSizeMode.StretchImage;
                        urunGorsel.Image = urunler[i].Fotografi;
                        urunGorsel.Location = new Point(pbX, pbY);
                        urunGorsel.DoubleClick += delegate (object sender2, EventArgs e)
                        {
                            gorselClick(sender2, e, 0);
                        };
                        Label urunAd = new Label();
                        urunAd.Tag = urunler[i].ID + ";" + urunler[i].Fiyati;
                        urunAd.BackColor = Color.Orange;
                        urunAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        urunAd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                        urunAd.Location = new Point(lbX, lbY);
                        urunAd.Size = new Size(100, 32);
                        urunAd.Text = urunler[i].Adi;
                        urunAd.DoubleClick += delegate (object sender2, EventArgs e)
                        {
                            gorselClick(sender2, e, 0);
                        };
                        urunAd.TextAlign = ContentAlignment.MiddleCenter;
                        pnlSKullanilanlar.Controls.Add(urunGorsel);
                        pnlSKullanilanlar.Controls.Add(urunAd);
                        pbX += 109;
                        lbX += 109;
                        if (lbX > 722)
                        {
                            pbX = 68;
                            lbX = 68;
                            pbY += 147;
                            lbY += 147;
                        }
                    }
                }
            }
            List<clsMenuler> menuler = islem.menuListele();
            for (int i = 0; i < menuler.Count; i++)
            {
                if (menuler[i].SKullanilan)
                {
                    PictureBox menuGorsel = new PictureBox();
                    menuGorsel.Size = new Size(100, 100);
                    menuGorsel.Tag = menuler[i].ID + ";" + menuler[i].Fiyati;
                    menuGorsel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    menuGorsel.SizeMode = PictureBoxSizeMode.StretchImage;
                    menuGorsel.Image = menuler[i].Fotografi;
                    menuGorsel.Location = new Point(pbX, pbY);
                    menuGorsel.DoubleClick += delegate (object sender2, EventArgs e)
                    {
                        gorselClick(sender2, e, 1);
                    };
                    Label menuAd = new Label();
                    menuAd.Tag = menuler[i].ID + ";" + menuler[i].Fiyati;
                    menuAd.BackColor = ColorTranslator.FromHtml("#EF5350");
                    menuAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    menuAd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                    menuAd.Location = new Point(lbX, lbY);
                    menuAd.Size = new Size(100, 32);
                    menuAd.Text = menuler[i].Adi;
                    menuAd.DoubleClick += delegate (object sender2, EventArgs e)
                    {
                        gorselClick(sender2, e, 1);
                    };
                    menuAd.TextAlign = ContentAlignment.MiddleCenter;
                    pnlSKullanilanlar.Controls.Add(menuGorsel);
                    pnlSKullanilanlar.Controls.Add(menuAd);
                    pbX += 109;
                    lbX += 109;
                    if (lbX > 722)
                    {
                        pbX = 68;
                        lbX = 68;
                        pbY += 147;
                        lbY += 147;
                    }
                }
            }
        }
        void menuListele()
        {
            pnlMenuler.Controls.Clear();
            clsIslemler islem = new clsIslemler();
            List<clsMenuler> menuler = islem.menuListele();
            int pbX = 68, pbY = 37;
            int lbX = 68, lbY = 136;
            for (int i = 0; i < menuler.Count; i++)
            {

                PictureBox menuGorsel = new PictureBox();
                menuGorsel.Size = new Size(100, 100);
                menuGorsel.Tag = menuler[i].ID + ";" + menuler[i].Fiyati;
                menuGorsel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                menuGorsel.SizeMode = PictureBoxSizeMode.StretchImage;
                menuGorsel.Image = menuler[i].Fotografi;
                menuGorsel.DoubleClick += delegate (object sender2, EventArgs e)
                {
                    gorselClick(sender2, e, 1);
                };
                menuGorsel.Location = new Point(pbX, pbY);
                Label menuAd = new Label();
                menuAd.Tag = menuler[i].ID + ";" + menuler[i].Fiyati;
                menuAd.BackColor = ColorTranslator.FromHtml("#EF5350");
                menuAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                menuAd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                menuAd.Location = new Point(lbX, lbY);
                menuAd.Size = new Size(100, 32);
                menuAd.Text = menuler[i].Adi;
                menuAd.DoubleClick += delegate (object sender2, EventArgs e)
                {
                    gorselClick(sender2, e, 1);
                };
                menuAd.TextAlign = ContentAlignment.MiddleCenter;
                pnlMenuler.Controls.Add(menuGorsel);
                pnlMenuler.Controls.Add(menuAd);
                pbX += 109;
                lbX += 109;
                if (lbX > 722)
                {
                    pbX = 68;
                    lbX = 68;
                    pbY += 147;
                    lbY += 147;
                }
            }
        }
        void urunListele()
        {
            pnlAnaYemekler.Controls.Clear();
            pnlCorbalar.Controls.Clear();
            pnlEtYemekleri.Controls.Clear();
            pnlIcecekler.Controls.Clear();
            pnlSalatalar.Controls.Clear();
            pnlTatlilar.Controls.Clear();
            pnlIcecekler.Controls.Clear();
            string[] kategoriler = { "Çorbalar", "Et Yemekleri", "İçecekler", "Ana Yemekler", "Sebze ve Meyve", "Salatalar", "Tatlılar" };
            clsIslemler islem = new clsIslemler();
            for (int j = 0; j < kategoriler.Length; j++)
            {
                List<clsUrunler> urunler = islem.urunListele(j);
                int pbX = 68, pbY = 37;
                int lbX = 68, lbY = 136;
                for (int i = 0; i < urunler.Count; i++)
                {
                    TabPage eklenecek = new TabPage();
                    foreach (Control item in metroTabControl1.Controls)
                    {
                        if (item.Tag != null)
                        {
                            if (item.Tag.ToString() == kategoriler[urunler[i].Kategori])
                                eklenecek = (TabPage)item;
                        }

                    }
                    Panel eklenecekPanel = (Panel)eklenecek.Controls[0];
                    PictureBox urunGorsel = new PictureBox();
                    urunGorsel.Size = new Size(100, 100);
                    urunGorsel.Tag = urunler[i].ID + ";" + urunler[i].Fiyati;
                    urunGorsel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    urunGorsel.SizeMode = PictureBoxSizeMode.StretchImage;
                    urunGorsel.Image = urunler[i].Fotografi;
                    urunGorsel.Location = new Point(pbX, pbY);
                    urunGorsel.DoubleClick += delegate (object sender2, EventArgs e)
                    {
                        gorselClick(sender2, e, 0);
                    };
                    Label urunAd = new Label();
                    urunAd.Tag = urunler[i].ID + ";" + urunler[i].Fiyati;
                    urunAd.BackColor = Color.Orange;
                    urunAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    urunAd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(162)));
                    urunAd.Location = new Point(lbX, lbY);
                    urunAd.Size = new Size(100, 32);
                    urunAd.Text = urunler[i].Adi;
                    urunAd.DoubleClick += delegate (object sender2, EventArgs e)
                    {
                        gorselClick(sender2, e, 0);
                    };
                    urunAd.TextAlign = ContentAlignment.MiddleCenter;
                    eklenecekPanel.Controls.Add(urunGorsel);
                    eklenecekPanel.Controls.Add(urunAd);
                    pbX += 109;
                    lbX += 109;
                    if (lbX > 722)
                    {
                        pbX = 68;
                        lbX = 68;
                        pbY += 147;
                        lbY += 147;
                    }
                }
            }

        }

        private void gorselClick(object sender, EventArgs e, int tip)//0 urun 1 menu
        {
            if (secilenB != null && secilenB.ImageIndex == 1)
            {
                string[] tag = (sender as Control).Tag.ToString().Split(';');
                int siparisID = -1;
                for (int i = 0; i < siparisler.Count; i++)
                {
                    if (siparisler[i].MasaNo == int.Parse(secilenB.Tag.ToString()))
                    {
                        siparisID = siparisler[i].HareketID;
                        break;
                    }
                }
                clsIslemler islem = new clsIslemler();
                bool varMi = false;
                for (int i = 0; i < dgvSecilenler.Rows.Count; i++)
                {
                    if (dgvSecilenler.Rows[i].Cells[0].Value.ToString() == tag[0] && dgvSecilenler.Rows[i].Cells[4].Value.ToString() == tip.ToString())
                    {
                        varMi = true;
                        break;
                    }
                }
                if (!varMi)
                {
                    islem.siparisEkle(siparisID, tip, int.Parse(tag[0]));
                }
                else
                {
                    islem.siparisGuncelle(siparisID, tip, int.Parse(tag[0]));
                }
                siparisListele();
                button5_Click(secilenB, e);
            }
            else MessageBox.Show("Masa seçilmemiş veya hesap açılmamış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvSecilenler.Rows.Clear();
            lblDakika.Text = "";
            lblTutar.Text = "";
            secilenB = sender as Button;
            secilen = secilenB.Text;
            lblSecilen.Text = secilen;
            if (secilen != null) panel1.Enabled = true;
            if (secilenB.ImageIndex == 1)
            {
                for (int i = 0; i < siparisler.Count; i++)
                {
                    if (siparisler[i].MasaNo == int.Parse(secilenB.Tag.ToString()))
                    {
                        TimeSpan dakikaFarki = new TimeSpan();
                        DateTime dt = DateTime.Now;
                        dakikaFarki = dt - siparisler[i].MasaGiris;
                        lblDakika.Text = Math.Ceiling(dakikaFarki.TotalMinutes) + " dakika önce";
                        lblTutar.Text = siparisler[i].MasaTutari + "₺";
                        for (int j = 0; j < siparisler[i].Urunler.Count; j++)//0 urun 1 menu
                        {
                            clsUrunler urun = siparisler[i].Urunler[j];
                            dgvSecilenler.Rows.Add(urun.ID, urun.Adi, siparisler[i].UrunlerAdet[j], urun.Fiyati, 0);
                        }
                        for (int j = 0; j < siparisler[i].Menuler.Count; j++)//0 urun 1 menu
                        {
                            clsMenuler menu = siparisler[i].Menuler[j];
                            dgvSecilenler.Rows.Add(menu.ID, menu.Adi, siparisler[i].MenulerAdet[j], menu.Fiyati, 1);
                        }
                        break;
                    }
                }
            }

        }
        private void bunifuTileButton3_MouseLeave(object sender, EventArgs e)
        {
            (sender as BunifuTileButton).ForeColor = Color.Black;
        }

        private void bunifuTileButton2_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as BunifuTileButton).ForeColor = ColorTranslator.FromHtml("#D11141");
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle();
            frm.ShowDialog();
            urunListele();
            sKullanilanListele();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            frmMenuEkle frm = new frmMenuEkle();
            frm.ShowDialog();
            menuListele();
            sKullanilanListele();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (secilenB.ImageIndex == 0)
            {
                clsIslemler islem = new clsIslemler();
                islem.hesapAc(int.Parse(secilenB.Tag.ToString()));
                siparisListele();
                secilenB.PerformClick();
            }
            else MessageBox.Show("Masa dolu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvSecilenler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSecilenler.SelectedRows.Count > 0)
            {
                clsIslemler islem = new clsIslemler();
                int urunID = int.Parse(dgvSecilenler.SelectedRows[0].Cells[0].Value.ToString());
                int tip = int.Parse(dgvSecilenler.SelectedRows[0].Cells[4].Value.ToString());
                int siparisID = -1;
                for (int i = 0; i < siparisler.Count; i++)
                {
                    if (siparisler[i].MasaNo == int.Parse(secilenB.Tag.ToString()))
                    {
                        siparisID = siparisler[i].HareketID;
                        break;
                    }
                }
                islem.siparisSil(siparisID, tip, urunID);
                siparisListele();
                secilenB.PerformClick();
            }
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            if(secilenB!=null && secilenB.ImageIndex==1)
            {
                frmHesapKapat frm = new frmHesapKapat();
                int masaNo = int.Parse(secilenB.Tag.ToString());
                clsSatislar satis = new clsSatislar();
                for (int i = 0; i < siparisler.Count; i++)
                {
                    if (siparisler[i].MasaNo == masaNo)
                    {
                        satis.MasaNo = masaNo;
                        satis.KullaniciID = kullanici.Id;
                        satis.Menuler = siparisler[i].Menuler;
                        satis.MenulerAdet = siparisler[i].MenulerAdet;
                        satis.Urunler = siparisler[i].Urunler;
                        satis.UrunlerAdet = siparisler[i].UrunlerAdet;
                        satis.Fiyat = siparisler[i].MasaTutari;
                        frm.siparisID = siparisler[i].HareketID;
                        break;
                    }
                }
                frm.satis = satis;
                frm.ShowDialog();
                siparisListele();
                dgvSecilenler.Rows.Clear();
                lblDakika.Text = "";
                lblTutar.Text = "";
                secilenB = null;
                secilen = "";
                lblSecilen.Text = "Seçilmemiş";
                panel1.Enabled = false;

            }
            else MessageBox.Show("Masa boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            frm.ShowDialog();
        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            frmSatisDetay frm = new frmSatisDetay();
            frm.ShowDialog();
        }
    }
}
