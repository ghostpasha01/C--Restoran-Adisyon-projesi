using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranProjesi
{
   public class clsMenuler
    {
        int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        string adi;

        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }
        Image fotografi;

        public Image Fotografi
        {
            get { return fotografi; }
            set { fotografi = value; }
        }
        double fiyati;

        public double Fiyati
        {
            get { return fiyati; }
            set { fiyati = value; }
        }
        List<clsUrunler> menuIcerik;

        public List<clsUrunler> MenuIcerik
        {
            get { return menuIcerik; }
            set { menuIcerik = value; }
        }
        List<int> menuIcerikAdet;

        public List<int> MenuIcerikAdet
        {
            get { return menuIcerikAdet; }
            set { menuIcerikAdet = value; }
        }
        bool sKullanilan;
        public bool SKullanilan
        {
            get { return sKullanilan; }
            set { sKullanilan = value; }
        }
    }
}
