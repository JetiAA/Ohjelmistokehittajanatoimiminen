using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjasto_tehtävä
{
    class Kirjantiedot
    {
        string kirjannimi;
        int sivumaara;
        string kirjailija;
        int arvio;
        int julkaisuvuosi;

        public Kirjantiedot(string knimi, string kirjoittaja, int sivut, int arvostelu, int julki)
        {
            kirjannimi = knimi;
            kirjailija = kirjoittaja;
            sivumaara = sivut;
            arvio = arvostelu;
            julkaisuvuosi = julki;
        }
        public string Naytakirjannimi()
        {
            return kirjannimi;
        }
        public string Naytakirjailija()
        {
            return kirjailija;
        }
        public int Naytasivut()
        {
            return sivumaara;
        }
        public int Naytarvostelu()
        {
            return arvio;
        }
        public int Naytajulkaisuvuosi()
        {
            return julkaisuvuosi;
        }
    }
}
