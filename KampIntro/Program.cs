using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtkiketi = "Kategori";

            int ogrenciSayisi = 32000;

            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi = true; //bu alan normalde fonksiyondan gelir örn: sistemeGirisYapmisMi(bu alana db yazılır gibi düşün);

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtkiketi);

            



        }
    }
}
