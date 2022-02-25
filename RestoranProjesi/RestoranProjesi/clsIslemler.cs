using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace RestoranProjesi
{
    class clsIslemler
    {
        static SqlConnection baglanti = new SqlConnection(@"Data Source=HP-BILGISAYAR\SQLEXPRESS;Initial Catalog=Restoran;Integrated Security=True");
        static SqlCommand komut;
        static SqlDataReader reader;

        public static clsKullanicilar girisKontrol(string kAdi, string sifre)
        {
            clsKullanicilar kullanici = new clsKullanicilar();
            kullanici.Tipi = -1;
            baglanti.Open();
            komut = new SqlCommand("select * from Kullanicilar where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre", baglanti);
            komut.Parameters.AddWithValue("@KullaniciAdi", kAdi);
            komut.Parameters.AddWithValue("@Sifre", sifre);
            reader = komut.ExecuteReader();//id adi soyadi kadi sifre tip
            if (reader.Read())
            {
                kullanici.Id = int.Parse(reader[0].ToString());
                kullanici.Adi = reader[1].ToString();
                kullanici.Soyadi = reader[2].ToString();
                kullanici.KullaniciAdi = reader[3].ToString();
                kullanici.Sifre = reader[4].ToString();
                kullanici.Tipi = int.Parse(reader[5].ToString());
                baglanti.Close();
                return kullanici;
            }
            baglanti.Close();
            return kullanici;
        }

        public bool kayitOlustur(string ad, string soyad, string kAdi, string sifre)
        {
            baglanti.Open();//0 eleman 1 patron
            komut = new SqlCommand("select * from Kullanicilar where KullaniciAdi=@KullaniciAdi", baglanti);
            komut.Parameters.AddWithValue("@KullaniciAdi", kAdi);
            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                baglanti.Close();
                return false;
            }
            reader.Close();
            komut = new SqlCommand("insert into Kullanicilar(Adi,Soyadi,KullaniciAdi,Sifre,KullaniciTipi) values(@Adi,@Soyadi,@KullaniciAdi,@Sifre,@KullaniciTipi)", baglanti);
            komut.Parameters.AddWithValue("@Adi", ad);
            komut.Parameters.AddWithValue("@Soyadi", soyad);
            komut.Parameters.AddWithValue("@KullaniciAdi", kAdi);
            komut.Parameters.AddWithValue("@Sifre", sifre);
            komut.Parameters.AddWithValue("@KullaniciTipi", 0);
            komut.ExecuteNonQuery();
            baglanti.Close();
            return true;
        }
        public void urunEkle(clsUrunler urun, string resimYolu)
        {
            baglanti.Open();
            FileStream fs = new FileStream(resimYolu, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            komut = new SqlCommand("insert into Urunler(UrunAdi,Fiyat,UrunGorsel,KategoriID,SKullanilan) values(@UrunAdi,@Fiyat,@UrunGorsel,@KategoriID,@SKullanilan)", baglanti);
            komut.Parameters.AddWithValue("@UrunAdi", urun.Adi);
            komut.Parameters.AddWithValue("@Fiyat", urun.Fiyati);
            komut.Parameters.Add("@UrunGorsel", SqlDbType.Image, resim.Length).Value = resim;
            komut.Parameters.AddWithValue("@KategoriID", urun.Kategori);
            komut.Parameters.AddWithValue("@SKullanilan", urun.SKullanilan);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void menuEkle(clsMenuler menu, string resimYolu)
        {
            baglanti.Open();
            FileStream fs = new FileStream(resimYolu, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            komut = new SqlCommand("insert into Menuler(MenuAdi,MenuFiyati,MenuGorsel,SKullanilan) values(@MenuAdi,@MenuFiyati,@MenuGorsel,@SKullanilan)", baglanti);
            komut.Parameters.AddWithValue("@MenuAdi", menu.Adi);
            komut.Parameters.AddWithValue("@MenuFiyati", menu.Fiyati);
            komut.Parameters.Add("@MenuGorsel", SqlDbType.Image, resim.Length).Value = resim;
            komut.Parameters.AddWithValue("@SKullanilan", menu.SKullanilan);
            komut.ExecuteNonQuery();
            komut = new SqlCommand("select top 1 * from Menuler order by MenuID DESC", baglanti);
            reader = komut.ExecuteReader();
            reader.Read();
            int id = int.Parse(reader[0].ToString());
            reader.Close();
            for (int i = 0; i < menu.MenuIcerik.Count; i++)
            {
                komut = new SqlCommand("insert into MenuIcerik(MenuID,UrunID,Adet) values(@MenuID,@UrunID,@Adet)", baglanti);
                komut.Parameters.AddWithValue("@MenuID", id);
                komut.Parameters.AddWithValue("@UrunID", menu.MenuIcerik[i].ID);
                komut.Parameters.AddWithValue("@Adet", menu.MenuIcerikAdet[i]);
                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            MessageBox.Show("Menü başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public List<clsUrunler> urunListele(int kategoriID)
        {
            List<clsUrunler> urunler = new List<clsUrunler>();
            baglanti.Open();
            komut = new SqlCommand("select * from Urunler where KategoriID=@KategoriID", baglanti);
            komut.Parameters.AddWithValue("@KategoriID", kategoriID);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                clsUrunler urun = new clsUrunler();
                urun.ID = int.Parse(reader[0].ToString());
                urun.Adi = reader[1].ToString();
                urun.Fiyati = double.Parse(reader[2].ToString());
                urun.Kategori = int.Parse(reader[4].ToString());
                urun.SKullanilan = Convert.ToBoolean(reader[5].ToString());
                byte[] resimData = reader[3] as byte[];
                MemoryStream ms = new MemoryStream();
                ms.Write(resimData, 0, resimData.Length);
                Image image = Image.FromStream(ms);
                urun.Fotografi = image;
                urunler.Add(urun);
            }
            reader.Close();
            baglanti.Close();
            return urunler;
        }
        public List<clsMenuler> menuListele()
        {
            List<clsMenuler> menuler = new List<clsMenuler>();
            baglanti.Open();
            komut = new SqlCommand("select * from Menuler", baglanti);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                clsMenuler menu = new clsMenuler();
                menu.ID = int.Parse(reader[0].ToString());
                menu.Adi = reader[1].ToString();
                menu.Fiyati = double.Parse(reader[2].ToString());
                menu.SKullanilan = Convert.ToBoolean(reader[4].ToString());
                byte[] resimData = reader[3] as byte[];
                MemoryStream ms = new MemoryStream();
                ms.Write(resimData, 0, resimData.Length);
                Image image = Image.FromStream(ms);
                menu.Fotografi = image;
                menuler.Add(menu);
            }
            reader.Close();
            baglanti.Close();
            return menuler;
        }
        public DataTable urunler()
        {
            baglanti.Open();
            komut = new SqlCommand("select * from Urunler", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }
        public DataTable urunler(string adi)
        {
            baglanti.Open();
            komut = new SqlCommand("select * from Urunler where UrunAdi like '%" + adi + "%'", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }
        public List<clsAnlikSiparisler> siparislerListele()
        {
            List<clsAnlikSiparisler> siparisler = new List<clsAnlikSiparisler>();
            baglanti.Open();
            komut = new SqlCommand("select * from Siparisler", baglanti);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                clsAnlikSiparisler siparis = new clsAnlikSiparisler();
                siparis.HareketID = int.Parse(reader[0].ToString());
                siparis.MasaNo = int.Parse(reader[1].ToString());
                siparis.MasaGiris = Convert.ToDateTime(reader[2].ToString());
                siparis.MasaTutari = double.Parse(reader[3].ToString());
                siparis.Urunler = new List<clsUrunler>();
                siparis.UrunlerAdet = new List<int>();
                SqlConnection baglanti2 = new SqlConnection(@"Data Source=HP-BILGISAYAR\SQLEXPRESS;Initial Catalog=Restoran;Integrated Security=True");
                baglanti2.Open();
                SqlCommand komut2 = new SqlCommand("select SiparisU.UrunID,Urunler.UrunAdi,Urunler.Fiyat,SiparisU.Adet from SiparisU inner join Urunler on Urunler.UrunID=SiparisU.UrunID where SiparisU.HareketID=@HareketID", baglanti2);
                komut2.Parameters.AddWithValue("@HareketID", siparis.HareketID);
                SqlDataReader reader2 = komut2.ExecuteReader();
                while (reader2.Read())
                {
                    clsUrunler urun = new clsUrunler();
                    urun.ID = int.Parse(reader2[0].ToString());
                    urun.Adi = reader2[1].ToString();
                    urun.Fiyati = double.Parse(reader2[2].ToString());
                    siparis.Urunler.Add(urun);
                    siparis.UrunlerAdet.Add(int.Parse(reader2[3].ToString()));
                }
                reader2.Close();
                siparis.Menuler = new List<clsMenuler>();
                siparis.MenulerAdet = new List<int>();
                komut2 = new SqlCommand("select SiparisM.MenuID,Menuler.MenuAdi,Menuler.MenuFiyati,SiparisM.Adet from SiparisM inner join Menuler on Menuler.MenuID=SiparisM.MenuID where SiparisM.HareketID=@HareketID", baglanti2);
                komut2.Parameters.AddWithValue("@HareketID", siparis.HareketID);
                reader2 = komut2.ExecuteReader();
                while (reader2.Read())
                {
                    clsMenuler menu = new clsMenuler();
                    menu.ID = int.Parse(reader2[0].ToString());
                    menu.Adi = reader2[1].ToString();
                    menu.Fiyati = double.Parse(reader2[2].ToString());
                    siparis.Menuler.Add(menu);
                    siparis.MenulerAdet.Add(int.Parse(reader2[3].ToString()));
                }
                reader2.Close();
                baglanti2.Close();
                siparisler.Add(siparis);
            }
            reader.Close();
            baglanti.Close();
            return siparisler;
        }

        public void hesapAc(int masaNo)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into Siparisler(MasaNo) values(" + masaNo + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void hesapKapat(int siparisID, clsSatislar satis)
        {
            baglanti.Open();
            komut = new SqlCommand("insert into Satislar(KullaniciID,Fiyat,OdemeSekli,MasaNo) values (@KullaniciID,@Fiyat,@OdemeSekli,@MasaNo)", baglanti);
            komut.Parameters.AddWithValue("@KullaniciID", satis.KullaniciID);
            komut.Parameters.AddWithValue("@Fiyat", satis.Fiyat);
            komut.Parameters.AddWithValue("@OdemeSekli", satis.OdemeSekli);
            komut.Parameters.AddWithValue("@MasaNo", satis.MasaNo);
            komut.ExecuteNonQuery();
            komut = new SqlCommand("select top 1 * from Satislar order by SatisID DESC", baglanti);
            reader = komut.ExecuteReader();
            reader.Read();
            int satisID = int.Parse(reader[0].ToString());
            reader.Close();
            for (int i = 0; i < satis.Menuler.Count; i++)
            {
                komut = new SqlCommand("insert into SatisIcerikM(SatisID,MenuID,Adet) values(@SatisID,@MenuID,@Adet)", baglanti);
                komut.Parameters.AddWithValue("@SatisID", satisID);
                komut.Parameters.AddWithValue("@MenuID", satis.Menuler[i].ID);
                komut.Parameters.AddWithValue("@Adet", satis.MenulerAdet[i]);
                komut.ExecuteNonQuery();
            }
            for (int i = 0; i < satis.Urunler.Count; i++)
            {
                komut = new SqlCommand("insert into SatisIcerikU(SatisID,UrunID,Adet) values(@SatisID,@UrunID,@Adet)", baglanti);
                komut.Parameters.AddWithValue("@SatisID", satisID);
                komut.Parameters.AddWithValue("@UrunID", satis.Urunler[i].ID);
                komut.Parameters.AddWithValue("@Adet", satis.UrunlerAdet[i]);
                komut.ExecuteNonQuery();
            }
            komut = new SqlCommand("delete from Siparisler where HareketID=@HareketID", baglanti);
            komut.Parameters.AddWithValue("@HareketID", siparisID);
            komut.ExecuteNonQuery();
            komut = new SqlCommand("delete from SiparisU where HareketID=@HareketID", baglanti);
            komut.Parameters.AddWithValue("@HareketID", siparisID);
            komut.ExecuteNonQuery();
            komut = new SqlCommand("delete from SiparisM where HareketID=@HareketID", baglanti);
            komut.Parameters.AddWithValue("@HareketID", siparisID);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public void siparisEkle(int siparisID, int tip, int urunID)
        {
            baglanti.Open();
            if (tip == 0)
            {
                komut = new SqlCommand("insert into SiparisU(HareketID,UrunID,Adet) values(@HareketID,@UrunID,@Adet)", baglanti);
                komut.Parameters.AddWithValue("@HareketID", siparisID);
                komut.Parameters.AddWithValue("@UrunID", urunID);
                komut.Parameters.AddWithValue("@Adet", 1);
            }
            else
            {
                komut = new SqlCommand("insert into SiparisM(HareketID,MenuID,Adet) values(@HareketID,@MenuID,@Adet)", baglanti);
                komut.Parameters.AddWithValue("@HareketID", siparisID);
                komut.Parameters.AddWithValue("@MenuID", urunID);
                komut.Parameters.AddWithValue("@Adet", 1);
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            siparisTutariGuncelle(siparisID);

        }
        public void siparisGuncelle(int siparisID, int tip, int urunID)
        {
            baglanti.Open();
            if (tip == 0)
            {
                komut = new SqlCommand("update SiparisU set Adet=Adet+1 where HareketID=@HareketID and UrunID=@UrunID", baglanti);
                komut.Parameters.AddWithValue("@HareketID", siparisID);
                komut.Parameters.AddWithValue("@UrunID", urunID);
            }
            else
            {
                komut = new SqlCommand("update SiparisM set Adet=Adet+1 where HareketID=@HareketID and MenuID=@MenuID", baglanti);
                komut.Parameters.AddWithValue("@HareketID", siparisID);
                komut.Parameters.AddWithValue("@MenuID", urunID);
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            siparisTutariGuncelle(siparisID);
        }
        public void siparisTutariGuncelle(int siparisID)
        {
            double toplam = 0;
            baglanti.Open();
            komut = new SqlCommand("select SiparisU.Adet,Urunler.Fiyat from SiparisU inner join Urunler on SiparisU.UrunID=Urunler.UrunID where SiparisU.HareketID=@HareketID", baglanti);
            komut.Parameters.AddWithValue("@HareketID", siparisID);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                toplam += (double.Parse(reader[0].ToString()) * double.Parse(reader[1].ToString()));
            }
            reader.Close();
            komut = new SqlCommand("select SiparisM.Adet,Menuler.MenuFiyati from SiparisM inner join Menuler on SiparisM.MenuID=Menuler.MenuID where SiparisM.HareketID=@HareketID", baglanti);
            komut.Parameters.AddWithValue("@HareketID", siparisID);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                toplam += (double.Parse(reader[0].ToString()) * double.Parse(reader[1].ToString()));
            }
            reader.Close();
            komut = new SqlCommand("update Siparisler set MasaTutari=@MasaTutari where HareketID=@HareketID", baglanti);
            komut.Parameters.AddWithValue("@MasaTutari", toplam);
            komut.Parameters.AddWithValue("@HareketID", siparisID);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void siparisSil(int siparisID, int tip, int urunID)
        {
            baglanti.Open();
            if (tip == 0)
            {
                komut = new SqlCommand("delete from SiparisU where HareketID=@HareketID and UrunID=@UrunID", baglanti);
                komut.Parameters.AddWithValue("@HareketID", siparisID);
                komut.Parameters.AddWithValue("@UrunID", urunID);
            }
            else
            {
                komut = new SqlCommand("delete from SiparisM where HareketID=@HareketID and MenuID=@MenuID", baglanti);
                komut.Parameters.AddWithValue("@HareketID", siparisID);
                komut.Parameters.AddWithValue("@MenuID", urunID);
            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            siparisTutariGuncelle(siparisID);
        }

        public double gunlukHasilat()
        {
            baglanti.Open();
            komut = new SqlCommand("select sum(Fiyat) from Satislar where Month(GETDATE())=Month(Tarih) and Day(GETDATE())=Day(Tarih) and Year(GETDATE())=Year(Tarih)", baglanti);
            reader = komut.ExecuteReader();
            reader.Read();
            double hasilat = 0;
            if (reader[0].ToString() != "")
                hasilat = double.Parse(reader[0].ToString());
            reader.Close();
            baglanti.Close();
            return hasilat;
        }
        public double aylikHasilat()
        {
            baglanti.Open();
            komut = new SqlCommand("select sum(Fiyat) from Satislar where Month(GETDATE())=Month(Tarih) and Year(GETDATE())=Year(Tarih)", baglanti);
            reader = komut.ExecuteReader();
            reader.Read();
            double hasilat = 0;
            if (reader[0].ToString() != "")
                hasilat = double.Parse(reader[0].ToString());
            reader.Close();
            baglanti.Close();
            return hasilat;
        }
        public string ayinElemani()
        {
            baglanti.Open();
            komut = new SqlCommand("select count(*),Kullanicilar.Adi+' '+Kullanicilar.Soyadi from Satislar inner join Kullanicilar on Kullanicilar.KullaniciID=Satislar.KullaniciID  where Month(GETDATE())=Month(Satislar.Tarih) and Year(GETDATE())=Year(Satislar.Tarih) group by Satislar.KullaniciID,Kullanicilar.Adi+' '+Kullanicilar.Soyadi order by Count(*) desc", baglanti);
            reader = komut.ExecuteReader();
            reader.Read();
            string eleman = reader[1].ToString();
            reader.Close();
            baglanti.Close();
            return eleman;
        }
        public List<string> yillikVeri()
        {
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            List<string> veri = new List<string>();
            baglanti.Open();
            for (int i = 1; i < 13; i++)
            {
                string satir = aylar[i - 1];
                komut = new SqlCommand("select sum(Fiyat) from Satislar where @Ay=Month(Tarih) and @Yil=Year(Tarih)", baglanti);
                komut.Parameters.AddWithValue("@Ay", i);
                komut.Parameters.AddWithValue("@Yil", DateTime.Now.Year);
                reader = komut.ExecuteReader();
                reader.Read();
                satir += ";" + reader[0].ToString();
                if (reader[0].ToString() == "") satir += "0";
                veri.Add(satir);
                reader.Close();
            }
            baglanti.Close();
            return veri;
        }

        public DataTable satisListele(DateTime tarih)
        {
            baglanti.Open();
            komut = new SqlCommand("select Satislar.SatisID,Kullanicilar.Adi+' '+Kullanicilar.Soyadi,Satislar.MasaNo,Satislar.OdemeSekli,Satislar.Fiyat from Satislar inner join Kullanicilar on Kullanicilar.KullaniciID=Satislar.KullaniciID where  Month(@Tarih)=Month(Satislar.Tarih) and Day(@Tarih)=Day(Satislar.Tarih) and Year(@Tarih)=Year(Satislar.Tarih)", baglanti);
            komut.Parameters.AddWithValue("@Tarih", tarih);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            baglanti.Close();
            return dt;

        }
    }
}
