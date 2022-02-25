using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RestoranProjesi
{
    public partial class frmRaporlar : MetroFramework.Forms.MetroForm
    {
        public frmRaporlar()
        {
            InitializeComponent();
        }
        clsIslemler islem = new clsIslemler();

        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            lblGunluk.Text = islem.gunlukHasilat() + " ₺";
            lblAylık.Text = islem.aylikHasilat() + " ₺";
            lblAyinElemani.Text = islem.ayinElemani();
            chart1.Series.Clear();
            chart1.Titles.Add("Aylık Veriler");
            Series seri = chart1.Series.Add("Aylık Hasılat");
            seri.ChartType = SeriesChartType.Spline;
            List<string> veri = islem.yillikVeri();
            for (int i = 0; i < veri.Count; i++)
            {
                string []ayrilmisVeri = veri[i].Split(';');
                seri.Points.AddXY(ayrilmisVeri[0], double.Parse(ayrilmisVeri[1]));
            }
        }
    }
}
