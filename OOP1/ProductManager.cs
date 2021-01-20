using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation -- 50 tane parametre girmek yerine, özelliklerin tamamını içeren classı 
        //kümülatif olarak parametre şeklinde göndermemiz durumu

        //void tipi: Git görevi yaptır, ama sonucu ile ilgilenmiyorum.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi.");     
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }

        //public int Topla(int sayi1, int sayi2) // sonucu geri döndürür. return var
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2) // sonucu geri döndürmez. return kabul etmez.
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}

        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;
        //}
    }
}
