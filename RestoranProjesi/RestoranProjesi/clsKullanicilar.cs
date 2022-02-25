using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranProjesi
{
    public class clsKullanicilar
    {
        int id;
        public int Id
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
        string soyadi;

        public string Soyadi
        {
            get { return soyadi; }
            set { soyadi = value; }
        }
        string kullaniciAdi;

        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }
        string sifre;

        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        int tipi;

        public int Tipi
        {
            get { return tipi; }
            set { tipi = value; }
        }
    }
}
