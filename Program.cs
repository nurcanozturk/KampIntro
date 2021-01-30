using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyatı = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyatı = 25;
            product2.Aciklama = "diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyatı);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("--------Methodlar------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("armut","yesıl armut",12,45);
            sepetManager.Ekle2("elma","yesil elma",12,14);
            sepetManager.Ekle2("karpuz","diyarbakır",12,4);




        }
    }
}



