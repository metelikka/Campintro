using System;

namespace ödev2 { 

class Program
    {
        static void Main(string[] args)
        {
            const string AD = "ciguli";
            const string SIFRE = "123";
            const string Caaahar = "^";  

            const int DENEME_HAKKI = 3;

            int deneme = 0;
            string girilenAd, girilenSifre;
            while (deneme < DENEME_HAKKI)
            {
                Console.Write("Kullanıcı adı girin = ");
                girilenAd = Console.ReadLine();
                Console.Write("Şifreyi girin = ");
                girilenSifre = Console.ReadLine();

                if (girilenAd == AD && girilenSifre == Caaahar)
                {
                    Console.WriteLine("özel karakterler kullanılamaz");
                }
                
                else if (girilenAd == AD && girilenSifre == SIFRE )
                
                {
                    Console.WriteLine("Doğru kullanıcı adı ve şifre girdiniz.");
                    break; // while döngüsünden çık.
                }
                Console.WriteLine("Yanlış kullanıcı adı veya şifre girdiniz.");
                deneme++;
                Console.Write("Kalan hakkınız ");
                Console.WriteLine(DENEME_HAKKI - deneme);
            }
            Console.WriteLine("Çıkmak için bir tuşa basın.");
            Console.ReadKey();
        }
    }
}