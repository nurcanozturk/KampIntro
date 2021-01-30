using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Baslangıc Icın Temel Kurs";
            string kurs3 = "Java";

            //array
            
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Baslangıc Icın Temel Kurs" ,
                "Java", "python","c#"};          



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu = footer");
        }
    }
}
