using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Cviceni2
{
    class Prihlaska
    {
        // Celkový počet vytvořených objektů typu Prihlaska
        private static int vytvorenoPrihlasek = 0;

        public string Kod { get; private set; }
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }
        public DateTime DatumNarozeni { get; private set; }
        public StudijniObor Obor { get; private set; }

        public Prihlaska(string jmeno, string prijmeni, DateTime datumNarozeni, StudijniObor obor)
        {
            // Při každém vytvoření nového objektu typu Prihlaska zvýšíme čítač na základě
            // kterého generuje unikátní kódy přihlášek
            vytvorenoPrihlasek++;
            Kod = String.Format("prihlaska_{0}", vytvorenoPrihlasek);

            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            Obor = obor;
        }

        public void VypisInformace()
        {
            Console.WriteLine("PRIHLASKA - {0} {1}", Jmeno, Prijmeni);
            Console.WriteLine("Datum narozeni: {0}.{1}.{2}", DatumNarozeni.Year, DatumNarozeni.Month, DatumNarozeni.Day);
            Console.WriteLine("Obor: {0}", Obor.Nazev);
            Console.WriteLine("Kod: {0}", Kod);
        }
    }
}
