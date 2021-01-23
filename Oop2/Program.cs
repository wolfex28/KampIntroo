using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.MusteriNo = "12345";
            musteri1.Adi = "okan";
            musteri1.Soyadi = "kurt";
            musteri1.TcNo = "111111111";

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "123456";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



            //Gerçek- Tüzel
            //SOLID
        }
    }
}
