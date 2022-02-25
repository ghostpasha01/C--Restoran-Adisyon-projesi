using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranProjesi
{
    class clsAnlikSiparisler
    {
        int hareketID;

        public int HareketID
        {
            get { return hareketID; }
            set { hareketID = value; }
        }

        int masaNo;
        public int MasaNo
        {
            get { return masaNo; }
            set { masaNo = value; }
        }
        DateTime masaGiris;
        public DateTime MasaGiris
        {
            get { return masaGiris; }
            set { masaGiris = value; }
        }
        double masaTutari;
        public double MasaTutari
        {
            get { return masaTutari; }
            set { masaTutari = value; }
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
