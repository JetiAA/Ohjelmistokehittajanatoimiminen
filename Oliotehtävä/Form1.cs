using System;

namespace Kirjasto
{
    class Program
    {
        static void Main(string[] args)
        {
        alku:

            Console.WriteLine("Minkä kirjan haluat?");

            Console.WriteLine("Kirjoita (E) jos haluat Elä rohkeasti, (L) jos taru sormusten herrasta taikka (S) jolloin saat muumien taikatalven");
            string kirjain = Console.ReadLine();

            Kirjantiedot kirja1 = new Kirjantiedot("Elä rohkeasti", "Jojo moyes", 90, 5, 2018);
            Kirjantiedot kirja2 = new Kirjantiedot("Lopun jälkeen", "Clare mackintosh", 85, 4, 2019);
            Kirjantiedot kirja3 = new Kirjantiedot("Sirkka", "anni saastamoinen", 68, 4, 2019);

            if (kirjain == "E")
            {
                Console.WriteLine(kirja1.Naytakirjannimi());
                Console.WriteLine(kirja1.Naytakirjailija());
                Console.WriteLine(kirja1.Naytasivut());
                Console.WriteLine(kirja1.Naytarvostelu());
                Console.WriteLine(kirja1.Naytajulkaisuvuosi());
            }
            else if (kirjain == "L")
            {
                Console.WriteLine(kirja2.Naytakirjannimi());
                Console.WriteLine(kirja2.Naytakirjailija());
                Console.WriteLine(kirja2.Naytasivut());
                Console.WriteLine(kirja2.Naytarvostelu());
                Console.WriteLine(kirja2.Naytajulkaisuvuosi());
            }
            else if (kirjain == "S")
            {
                Console.WriteLine(kirja3.Naytakirjannimi());
                Console.WriteLine(kirja3.Naytakirjailija());
                Console.WriteLine(kirja3.Naytasivut());
                Console.WriteLine(kirja3.Naytarvostelu());
                Console.WriteLine(kirja3.Naytajulkaisuvuosi());
            }
            else
            {
                Console.WriteLine("Olet syöttänyt väärän kirjaimen palataan alkuun");
                goto alku;
            }

        lainaus:

            Console.WriteLine("Halutako lainata vai palauttaa kirjan? kirjoita (l) tai (p) ilman sulkuja");
            string lp = Console.ReadLine();

            if (lp == "l")
            {
                Console.WriteLine("Olet lainannut kirjan!");
            }
            else if (lp == "p")
            {
                Console.WriteLine("Olet palauttanut kirjan!");
            }
            else
            {
                Console.WriteLine("On tapahtunut virhe, takaisin alkuun.");
                goto lainaus;
            }

        cp3:
            Console.WriteLine("Haluatko suorittaa ohjelman uudestaan?");
            Console.WriteLine("Kirjoita k jos haluat ja e jos et");
            string uudestaan = Console.ReadLine();

            if (uudestaan == "k" || uudestaan == "K")
            {
                goto alku;
            }
            else if (uudestaan == "e" || uudestaan == "E")
            {
                Console.WriteLine("Kiito!");
            }
            else
            {
                Console.WriteLine("kokeilisitko uudestaan kirjoittaa "K" tai "E" ");
                goto cp3;
            }
        }
    }
}