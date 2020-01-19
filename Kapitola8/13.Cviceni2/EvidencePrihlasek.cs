using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Cviceni2
{
    class EvidencePrihlasek
    {
        public List<StudijniObor> Obory { get; private set; }
        public List<Prihlaska> Prihlasky { get; private set; }

        public EvidencePrihlasek(List<StudijniObor> obory)
        {
            Obory = obory;
            Prihlasky = new List<Prihlaska>();
        }

        /*
         * Postupně vyzve uživatele k zadání údajů do přihlášky a uloží ji.
         * Zadávané údaje: jméno, příjmenu, datum narození studenta, studijní obor.
         */ 
        public void VytvoritPrihlasku()
        {
            try
            {
                Console.WriteLine("\nNOVA PRIHLASKA");
                Console.Write("\tJmeno: ");
                string jmeno = Console.ReadLine();
                Console.Write("\tPrijmeni: ");
                string prijmeni = Console.ReadLine();
                Console.Write("\tDatum narozeni(rok): ");
                int datumRok = Int32.Parse(Console.ReadLine());
                Console.Write("\tDatum narozeni(mesic): ");
                int datumMesic = Int32.Parse(Console.ReadLine());
                Console.Write("\tDatum narozeni(den): ");
                int datumDen = Int32.Parse(Console.ReadLine());

                StudijniObor obor = VybratObor();
                DateTime datumNarozeni = new DateTime(datumRok, datumMesic, datumDen);

                // Ověření, zdali přihlášky se stejnými údaji již neexistuje
                if (!ExistujePrihlaska(jmeno, prijmeni, datumNarozeni, obor))
                {
                    Prihlasky.Add(new Prihlaska(jmeno, prijmeni, datumNarozeni, obor));
                    Console.WriteLine("Prihlaska byla uspesne vytvorena");
                }
                else
                {
                    Console.WriteLine("Prihlaska se zadanymi udaji jiz existuje");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Doslo k chybe pri vytvareni prihlasky.");
                Console.WriteLine("Text chyby: {0}", e.Message);
            }
        }

        /*
         * Vypíše číslovaný seznam všech evidovaných studijních oborů a
         * nechá uživatele zadat číslo vybraného oboru. Metoda vrací
         * index oboru z kolekce Obory.
         */ 
        public StudijniObor VybratObor()
        {
            Console.WriteLine("\tVyberte studijni obor: ");
            StudijniObor obor = null; ;
            for (int i = 0; i < Obory.Count; i++)
            {
                Console.WriteLine("\t\t{0}. {1}", i + 1, Obory[i].Nazev);
            }
            obor = Obory[Int32.Parse(Console.ReadLine())-1];
            return obor;
        }

        /*
         * Vrací true/false podle toho zdali již existuje přihláška s danými údaji.
         */ 
        private bool ExistujePrihlaska(string jmeno, string prijmeni, DateTime datumNarozeni, StudijniObor obor)
        {
            foreach (Prihlaska prihlaska in Prihlasky)
            {
                if (prihlaska.Jmeno == jmeno && prihlaska.Prijmeni == prijmeni && prihlaska.DatumNarozeni == datumNarozeni && prihlaska.Obor == obor)
                {
                    return true;
                }
            }
            return false;
        }

        /*
         * Najde a vrátí přihlášku s daným kódem. Pokud taková
         * přihláška neexistuje, tak vrátí null.
         */ 
        public Prihlaska VyhledejPrihlasku(string kod)
        {
            foreach (Prihlaska prihlaska in Prihlasky)
            {
                if (prihlaska.Kod == kod)
                {
                    return prihlaska;
                }
            }
            return null;
        }

        /*
         * Najde a vrátí seznam přihlášek s daným oborem. Pokud není
         * žádná nalezena pak je vrácena prázdná kolekce.
         */ 
        public List<Prihlaska> VyhledejPrihlasku(StudijniObor obor)
        {
            List<Prihlaska> nalezenePrihlasky = new List<Prihlaska>();
            foreach (Prihlaska prihlaska in Prihlasky)
            {
                if (prihlaska.Obor == obor)
                {
                    nalezenePrihlasky.Add(prihlaska);
                }
            }
            return nalezenePrihlasky;
        }
    }
}
