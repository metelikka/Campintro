using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "prgoramlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array - dizi 

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı" , 
                "prgoramlamaya başlangıç için temel kurs","Java" , "phyton"};




            for (int i = 0; i <kurslar.Length; i += 2)
            {
                Console.WriteLine(kurslar[i]);



            }

            //for (int i = 1; i <= 10; i = i + 2)
               //for (int i = 1; i <= 10; i+=2)

            Console.WriteLine   ("bu üstteki bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu footer");

            


        }
    }
}
