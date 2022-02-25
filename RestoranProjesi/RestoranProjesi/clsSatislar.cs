using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranProjesi
{
    public class clsSatislar
    {
        int satisID;

        public int SatisID
        {
            get { return satisID; }
            set { satisID = value; }
        }
        int kullaniciID;

        public int KullaniciID
        {
            get { return kullaniciID; }
            set { kullaniciID = value; }
        }

        int odemeSekli;

        public int OdemeSekli
        {
            get { return odemeSekli; }
            set { odemeSekli = value; }
        }
        double fiyat;

        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        DateTime tarih;

        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        int masaNo;

        public int MasaNo
        {
            get { return masaNo; }
            set { masaNo = value; }
        }
        List<clsUrunler> urunler;

        public List<clsUrunler> Urunler
        {
            get { return urunler; }
            set { urunler = value; }
        }
        List<int> urunlerAdet;

        public List<int> UrunlerAdet
        {
            get { return urunlerAdet; }
            set { urunlerAdet = value; }
        }

        List<clsMenuler> menuler;


        public List<clsMenuler> Menuler
        {
            get { return menuler; }
            set { menuler = value; }
        }
        List<int> menulerAdet;
        public List<int> MenulerAdet
        {
            get { return menulerAdet; }
            set { menulerAdet = value; }
        }
    }
}
