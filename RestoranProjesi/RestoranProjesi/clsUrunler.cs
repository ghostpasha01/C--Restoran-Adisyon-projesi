﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranProjesi
{
    public class clsUrunler
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
        double fiyati;

        public double Fiyati
        {
            get { return fiyati; }
            set { fiyati = value; }
        }
        Image fotografi;

        public Image Fotografi
        {
            get { return fotografi; }
            set { fotografi = value; }
        }
        int kategori;

        public int Kategori
        {
            get { return kategori; }
            set { kategori = value; }
        }
        bool sKullanilan;
        public bool SKullanilan
        {
            get { return sKullanilan; }
            set { sKullanilan = value; }
        }


    }
}
