using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "d karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe Urun=var
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("***********");
            }

            Console.WriteLine("-------------Metodlar------------");

            //encapsulation * yapıyı daha düzenli ve komplike hale getirmek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // daha dağınık bir yapı
            sepetManager.Ekle2("armut", "Yeşil", 12, 12);
            sepetManager.Ekle2("elma", "sarı", 12, 15);
            sepetManager.Ekle2("karpuz", "kırmızı", 12, 14);

        }
    }
}
