using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5, UnitsInStock = 5,
                                            ProductName = "Kalem", UnitPrice = 35 }; //Alternatif gösterim yöntemi classlar için

            //Pascal case = Kelimelerin ilk harfi büyük yazılır. Camel Case = Kelimelerin ilk harfleri küçük yazılır.
            //Case sensitive = Küçük Büyük harf duyarlılığı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); // Kamera

            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi); // 100

            //int, double, bool.... değer tip
            //diziler, class, abstract class, interface .... referans tip
            // değer tiplerde sadece değer önemlidir. 

        }
    }
}
