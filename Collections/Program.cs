﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Bülent", "Murat", "Kerem" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //dizilerin sınırları olduğu için genelde işimize gelmez. Sonradan eleman ekleme işi sıkıntılıdır. 

            List<string> isimler2 = new List<string> {"Engin", "Bülent", "Murat", "Kerem" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            Console.ReadKey();
        }

        
    }

    
}
