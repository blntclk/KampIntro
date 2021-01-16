using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                // in urunler = urunler dizisi elemanları, ortadaki urun = sıradaki elemanın takma ismi o anki elemana verilen takma isim
                //x de desek olurdu, bastaki de Urun veri tipi çünkü programalama tipi type-safe dir. var da yazabilirdik. Sonuçta arkaplanda 
                // var, Urun urun olacak. 

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("----------Metotlar------------");
            // instance - ornek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //encapsulation
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 17);

        }
    }
}


// Do not repeat yourself *** Kendini tekrar etme --- DRY --- Clean Code --- Best Practice
