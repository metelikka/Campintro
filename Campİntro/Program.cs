﻿using System;

namespace Campİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği 
            //Console.writeLine("Kategori");
            //Do not repeat yourself - Kendini tekrarlama
            //Kategorietiketi bir değer tutucudur yani , alias

            string kategoriEtiketi = "Kategori";
            int öğrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Artış butonu");
               
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Azalış Oku");

            }
            else
            {
                Console.WriteLine("Değişmedi butonu ");
            }
            
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);
        }

    }
}
