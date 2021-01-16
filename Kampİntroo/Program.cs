using System;

namespace Kampİntroo
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety=tip güvenliği
            //do not repeat yourself

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOranı);
        }
    }
}
