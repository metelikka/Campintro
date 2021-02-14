using System;

namespace ödev
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("1.Sınav notunuzu giriniz");

            int Sinav1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.Sınav notunuzu giriniz");

            int Sinav2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3.Sınav notunuzu giriniz");

            int Sinav3 = int.Parse(Console.ReadLine());

            Console.WriteLine("4.Sınav notunuzu giriniz");

            int Sinav4 = int.Parse(Console.ReadLine());

            Console.WriteLine("5.Sınav notunuzu giriniz");

            int Sinav5 = int.Parse(Console.ReadLine());

            Console.WriteLine("6.Sınav notunuzu giriniz");

            int Sinav6 = int.Parse(Console.ReadLine());

            Console.WriteLine("7.Sınav notunuzu giriniz");

            int Sinav7 = int.Parse(Console.ReadLine());


            int not = Sinav1 + Sinav2 + Sinav3 + Sinav4 + Sinav5 + Sinav6 + Sinav7 ;

            int blme = 7;

            int Sonuc = not / blme;
            
            Console.WriteLine("ORTALAMAN");
            
            Console.WriteLine(Sonuc);


            if (Sonuc <= 49) { Console.WriteLine("kaldın"); }

               

            else if (Sonuc <= 100) { Console.WriteLine("geçtiniz"); }

             










        }
        }
} 
