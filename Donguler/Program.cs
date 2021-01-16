using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //degisken
            string kurs1 = "yazilim kursu1";
            string kurs2 = "yazilim kursu2";
            string kurs3 = "yazilim kursu3";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine("manuel degisken bitti");
            


            //array - diziler liste şeklinde verilen veriler için tüm liste elemanları bu değişkende tutulabilir
            
            string[] kurslar = new string[] { "yazilim kursu1", "yazilim kursu2", "yazilim kursu3", "yazilim kursu4" }; 
                        
            for (int i = 0; i<kurslar.Length; i++) //length sonuna kadar yazdırması için yani kaç kurs eklersek ekleyelim sonuna kadar sayacak
            //for (int i = 1; i<10; i=i+2) //fonksiyon: i 1 ise ve 10 dan küçükse 2 şerli arttır. i yerine b c f kafana göre ne yazarsan
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string x in kurslar) //dizi - array temelli yapıları tek tek dönmek için //x aliastır abc de yazabilirsin
            {
                Console.WriteLine(x); 
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
