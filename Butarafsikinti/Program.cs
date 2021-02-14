using System;

namespace Butarafsikinti

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Ternary Operatörü
            bool medeniHal = false;


            string mesaj = medeniHal ? "vay canına " : "deme lan öyle ";

            Console.WriteLine(mesaj);

            Console.WriteLine("lütfen bir sayı yazınız");

            int sayi = int.Parse(Console.ReadLine());


            int sonuç = sayi < 3 ? sayi * 5 :
                (sayi > 3 && sayi < 9 ? sayi * 3 :
                (sayi >= 9 && sayi % 2 == 0) ? sayi * 10 :
                (sayi % 2 == 1 ? sayi : -1));

            Console.WriteLine("sonuç " + sonuç);


            string HavaDurumu = Console.ReadLine();

            Console.WriteLine(HavaDurumu == "yağmurlu" ? "Şemsiye almalısın" : (HavaDurumu == "Güneşli" ? "Bol bol d vitamini alman dileğiyle..." : "Yağmur yağabilir"));


            int sicaklik = int.Parse(Console.ReadLine());

            int sonuçç = sicaklik > 1 && sicaklik < 100 ? 30 : (sicaklik > 101 && sicaklik < 200 ? 50 : 150);
            Console.WriteLine(sonuçç);


            //while döngüsü 

            int i = 1;


            while (i <= 10)
            {
                Console.WriteLine("while döngüsü");
                i++;
            }
            Console.ReadKey();
               


        }
    }
}
