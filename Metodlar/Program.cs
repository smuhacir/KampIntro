using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";
            urun1.stokAdedi = 30;

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.stokAdedi = 20;

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (var urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("********************");

            }

            Console.WriteLine("----------Metodlar--------------");

            SepetMaganer sepetMaganer = new SepetMaganer();

            sepetMaganer.Ekle(urun1);
            sepetMaganer.Ekle(urun2);


           
        }
    }
}


//sepete ekle mesela metoddur, birden fazla yerde kullanılır 