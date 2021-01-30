using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi:" + product.Adi);

        }
        public void Ekle2(string productAdi, string Aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Sepete eklendi:" + productAdi);


        }
    }
}
