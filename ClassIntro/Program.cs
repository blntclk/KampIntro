using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Bülent";
            int yas = 33;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.kursunEgitmeni = "Bülent ÇOLAK";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.kursunEgitmeni = "Serhat";
            kurs2.izlenmeOrani = 61;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Phyton";
            kurs3.kursunEgitmeni = "Berkay";
            kurs3.izlenmeOrani = 34;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.kursunEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi);
            }
        }
    }

    class Kurs //object
    {
        public string kursAdi { get; set; }
        public string kursunEgitmeni { get; set; }
        public int izlenmeOrani { get; set; }

    }
}
