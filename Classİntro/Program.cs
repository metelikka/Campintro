using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C++";
            kurs1.KursunEgitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.KursunEgitmen = "Mete";
            kurs2.İzlenmeOrani = 22;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "javalama";
            kurs3.KursunEgitmen = "Metemama";
            kurs3.İzlenmeOrani = 35;



            Kurs[] kurslar = new Kurs[] {kurs1 ,kurs2 ,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.KursunEgitmen + " " + kurs.İzlenmeOrani );
                Console.WriteLine(kurs.KursunEgitmen);
                Console.WriteLine(kurs.İzlenmeOrani);

            }
            
            
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string KursunEgitmen { get; set; }

        public int İzlenmeOrani { get; set; }

        public double İzleyiciler { get; set; }


    }

}


