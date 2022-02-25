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
    public partial class frmGirisEkrani : MetroFramework.Forms.MetroForm
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void frmGirisEkrani_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            clsKullanicilar kullanici=clsIslemler.girisKontrol(txtKAdi.Text, txtSifre.Text);
            if(kullanici.Tipi==-1)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKAdi.Text = "";
                txtSifre.Text = "";
                txtKAdi.Focus();
            }
            else
            {
                frmAnaMenu frm = new frmAnaMenu();
                frm.kullanici = kullanici;
                this.Hide();
                frm.ShowDialog();
                Application.Exit();
            }


        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frm = new frmKullaniciEkle();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
