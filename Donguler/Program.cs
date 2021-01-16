using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programalamaya Başlangıç için temel Kurs";
            string kurs3 = "Java";

            // array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", "Programalamaya Başlangıç için temel Kurs", "Java", "Phyton", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            // Genelde dizileri dönmek için foreach kullanırız ama for da kullanırsan sorun olmaz.
            foreach (string kurs in kurslar)// kurs aslında alias başka bir şey de yazabiliriz..
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
