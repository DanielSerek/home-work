using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Cviceni1
{
    class Firma
    {
        private List<Faktura> faktury;
        public string Nazev { get; set; }
        public string Adresa { get; set; }
        public string ICO { get; set; }

        public Firma(string nazev, string adresa, string ico)
        {
            faktury = new List<Faktura>();
            Nazev = nazev;
            Adresa = adresa;
            ICO = ico;
        }

        public void PridatFakturu(Faktura faktura)
        {
            faktury.Add(faktura);
        }

        public double SpoctiNezaplacenouCastku()
        {
            double soucet = 0;
            foreach (Faktura faktura in faktury)
            {
                if (!faktura.Zaplaceno)
                {
                    soucet += faktura.Castka;
                }
            }
            return soucet;
        }
    }
}
