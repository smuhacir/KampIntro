using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Sukur";
            int yas = 38;

            Kurs kurs1 = new Kurs(); //buradaki kurs artık int yada string gibi bir değişken tipini belirtiyor. class bu işe yarıyor
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Emre";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "Özkan";
            kurs2.IzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c++";
            kurs3.Egitmen = "Serkan";
            kurs3.IzlenmeOrani = 62;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Java";
            kurs4.Egitmen = "Gizem";
            kurs4.IzlenmeOrani = 62;

            //Console.WriteLine(kurs1.Egitmen + " " + kurs1.KursAdi + " "+ "%"+ kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs [] {kurs1, kurs2, kurs3, kurs4 }; //burada Length yapılabilir mi?

            foreach (var kurs in kurslar) //kurs takma isim -- var varriant mı?
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " --> İzlenme Oranı % " + kurs.IzlenmeOrani);
            }


            Console.WriteLine("Bitti");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
