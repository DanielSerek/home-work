using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Cviceni1
{
    class Evidence
    {
        private Dictionary<string, Firma> firmy;

        public Evidence()
        {
            firmy = new Dictionary<string, Firma>();
        }

        public void PridatFakturu(Faktura faktura)
        {
            if (!firmy.ContainsKey(faktura.ICOOdberatele))
            {
                throw new Exception("Firma s ICO: {0} ke ktere faktura nalezi, neexistuje v evidenci.");
            }
            Firma firma = firmy[faktura.ICOOdberatele];
            firma.PridatFakturu(faktura);
        }

        public void PridatFirmu(Firma firma)
        {
            firmy.Add(firma.ICO, firma);
        }

        public void VypisDluznychFirem()
        {
            Console.WriteLine("Vypis dluznych firem:");
            foreach (Firma firma in firmy.Values)
            {
                double dluznaCastka = firma.SpoctiNezaplacenouCastku();
                if (dluznaCastka > 0)
                {
                    Console.WriteLine("{0} ({1}) {2}", firma.Nazev, firma.ICO, firma.Adresa);
                    Console.WriteLine("\tCelkova castka: {0}", dluznaCastka);
                }
            }
        }
    }
}
