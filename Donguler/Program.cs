using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            string[] kurslar = new string[]
            {
                "Yazılım Kursu"
                ,"java kursu"
                ,"temel kurs"
                ,"python"
            };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("foreachta");

            //foreach for only array
            foreach (string Kurs in kurslar)
            {
                Console.WriteLine(Kurs);

            }
        }
    }
}
