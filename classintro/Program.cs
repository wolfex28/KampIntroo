using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //classı çağır
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "okan";
            kurs1.izlenme = 40;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "ali";
            kurs2.izlenme = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berk";
            kurs3.izlenme = 80;

            Kurs[] kurslar = new Kurs[]
            {kurs1, kurs2,kurs3  };
            //string tutumak yerine class tuttuk...

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi + " " + item.Egitmen + " " + item.izlenme);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenme { get; set; }
    }
}
