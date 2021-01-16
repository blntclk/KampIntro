using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // Do not repeat yourself
            // değer tutucu => kategori etiketi => alias

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false; // true ve false değerlerini alır
            double dolarBugun = 7.35;
            double dolarDun = 7.45;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış");
            }
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Eşit");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            Console.ReadKey();
            
        }
    }
}
