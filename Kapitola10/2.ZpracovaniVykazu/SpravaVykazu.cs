using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ZpracovaniVykazu
{
    public class SpravaVykazu
    {
        private const string NazevSouboruProjekty = "projekty.txt";
        private const string NazevSouboruZamestnanci = "zamestnanci.txt";
        private const string NazevSouboruVykazy = "vykazy.txt";
        
        public Dictionary<string,Projekt> Projekty { get; set; }
        public Dictionary<string,Zamestnanec> Zamestnanci { get; set; }
        public List<PolozkaVykazu> PolozkyVykazu { get; set; }

        public SpravaVykazu()
        {
            Projekty = new Dictionary<string, Projekt>();
            Zamestnanci = new Dictionary<string, Zamestnanec>();
            PolozkyVykazu = new List<PolozkaVykazu>();
        }

        public void ZpracovatVykazy()
        {
            Console.WriteLine("1. Načítání projektů - zahájeno");
            NacistProjekty();
            Console.WriteLine("1. Načítání projektů - dokončeno");

            Console.WriteLine("2. Načítání zaměstnanců - zahájeno");
            NacistZamestnance();
            Console.WriteLine("2. Načítání zaměstnanců - dokončeno");

            Console.WriteLine("3. Načítání výkazů - zahájeno");
            NacistVykazy();
            Console.WriteLine("3. Načítání výkazů - dokončeno");

            Console.WriteLine("! Výkazy byly úspěšně zpracovány !");
        }

        private void NacistProjekty()
        {
            StreamReader reader = new StreamReader(NazevSouboruProjekty);
            // Přeskočíme hlavičkový řádek souboru, protože neobsahuje data o konkrétním projektu
            string radek = reader.ReadLine();
            while ((radek = reader.ReadLine()) != null)
            {
                string[] hodnotyRadek = radek.Split(';');
                string kod = hodnotyRadek[0];
                string nazev = hodnotyRadek[1];
                int priorita = Int32.Parse(hodnotyRadek[2]);

                Projekt projekt = new Projekt(nazev, kod, priorita, new List<Zamestnanec>(), new List<PolozkaVykazu>());
                Projekty.Add(kod,projekt);
            }
            reader.Close();
        }

        private void NacistZamestnance()
        {
            StreamReader reader = new StreamReader(NazevSouboruZamestnanci);
            // Přeskočíme hlavičkový řádek souboru, protože neobsahuje data o konkrétním zaměstnanci
            string radek = reader.ReadLine();
            while ((radek = reader.ReadLine()) != null)
            {
                string[] hodnotyRadek = radek.Split(';');
                string kod = hodnotyRadek[0];
                string jmeno = hodnotyRadek[1];
                string prijmeni = hodnotyRadek[2];
                string pozice = hodnotyRadek[3];

                Zamestnanec zamestnanec = new Zamestnanec(jmeno,prijmeni,kod,pozice,
                    new List<Projekt>(),new List<PolozkaVykazu>());
                Zamestnanci.Add(kod,zamestnanec);
            }
            reader.Close();
        }

        private void NacistVykazy()
        {
            StreamReader reader = new StreamReader(NazevSouboruVykazy);
            // Přeskočíme hlavičkový řádek souboru, protože neobsahuje data o konkrétní položce výkazu
            string radek = reader.ReadLine();
            while ((radek = reader.ReadLine()) != null)
            {
                string[] hodnotyRadek = radek.Split(';');
                string kodZamestnanec = hodnotyRadek[0];
                string kodProjekt = hodnotyRadek[1];
                string[] strDatumVykazu = hodnotyRadek[2].Split('.');
                int den = Int32.Parse(strDatumVykazu[0]);
                int mesic = Int32.Parse(strDatumVykazu[1]);
                int rok = Int32.Parse(strDatumVykazu[2]);
                DateTime datumVykazu = new DateTime(rok, mesic, den);
                int pocetHodin = Int32.Parse(hodnotyRadek[3]);

                Zamestnanec zamestnanec = Zamestnanci[kodZamestnanec];
                Projekt projekt = Projekty[kodProjekt];

                PolozkaVykazu polozkaVykazu = new PolozkaVykazu(zamestnanec, projekt, datumVykazu, pocetHodin);
                PolozkyVykazu.Add(polozkaVykazu);
                projekt.PolozkyVykazu.Add(polozkaVykazu);
                zamestnanec.PolozkyVykazu.Add(polozkaVykazu);
                
                if (!projekt.Zamestnanci.Contains(zamestnanec))
                {
                    projekt.Zamestnanci.Add(zamestnanec);
                }

                if (!zamestnanec.Projekty.Contains(projekt))
                {
                    zamestnanec.Projekty.Add(projekt);
                }
            }
            reader.Close();
        }

        public void ReportCelkemHodin()
        {
            Console.WriteLine("*** Report - Hodiny celkem ***");
            int soucetHodin = 0;
            foreach(PolozkaVykazu polozkaVykazu in PolozkyVykazu)
            {
                soucetHodin += polozkaVykazu.PocetHodin;
            }
            Console.WriteLine("Celkový počet hodin: {0}", soucetHodin);
        }

        public void ReportProjektyCelkoveHodiny()
        {
            Console.WriteLine("*** Report - Projekty - celkové odpracované hodiny ***");
            foreach (Projekt projekt in Projekty.Values)
            {
                // Pro každý projekt spočteme součet odpracovaných hodin
                int soucetHodin = 0;
                foreach (PolozkaVykazu polozkaVykazu in projekt.PolozkyVykazu)
                {
                    soucetHodin += polozkaVykazu.PocetHodin;
                }
                Console.WriteLine("\tProjekt: {0}({1}) Pocet hodin: {2}", projekt.Nazev, projekt.Kod, soucetHodin);
            }
        }

        public void ReportZamestnanciCelkoveHodiny()
        {
            Console.WriteLine("*** Report - Zaměstnanci - celkové odpracované hodiny ***");
            foreach (Zamestnanec zamestnanec in Zamestnanci.Values)
            {
                // Pro každého zaměstnance spočteme součet odpracovaných hodin
                int soucetHodin = 0;
                foreach (PolozkaVykazu polozkaVykazu in zamestnanec.PolozkyVykazu)
                {
                    soucetHodin += polozkaVykazu.PocetHodin;
                }
                Console.WriteLine("\tZaměstnanec: {0} {1}({2}) Pocet hodin: {3}", zamestnanec.Jmeno,
                    zamestnanec.Prijmeni,zamestnanec.Kod, soucetHodin);
            }
        }

        public void ReportZamestnanec()
        {
            Console.WriteLine("*** Report - Zaměstnanec - detail ***");
            Console.WriteLine("Vyberte zaměstnance");

            List<Zamestnanec> zamestnanci = Zamestnanci.Values.ToList();
            for (int i = 0; i < zamestnanci.Count; i++)
            {
                Console.WriteLine("\t{0}. {1} {2}({3})", i+1,zamestnanci[i].Jmeno, zamestnanci[i].Prijmeni,zamestnanci[i].Kod);
            }
            Console.Write("Vaše volba: ");
            int volba = Int32.Parse(Console.ReadLine()) - 1;
            Zamestnanec zamestnanec = zamestnanci[volba];

            Console.WriteLine("\nReport - {0} {1} ({2}) - projekty:",zamestnanec.Jmeno,zamestnanec.Prijmeni,zamestnanec.Kod);
            foreach (Projekt projekt in zamestnanec.Projekty)
            {
                int soucet = 0;
                foreach (PolozkaVykazu polozkaVykazu in zamestnanec.PolozkyVykazu)
                {
                    if (polozkaVykazu.Projekt == projekt)
                    {
                        soucet += polozkaVykazu.PocetHodin;
                    }
                }

                Console.WriteLine("\t{0} ({1}): {2}",projekt.Nazev,projekt.Kod,soucet);
            }
        }

        public void ReportProjekt()
        {
            Console.WriteLine("*** Report - Projekt - detail ***");
            Console.WriteLine("Vyberte projekt");

            List<Projekt> projekty = Projekty.Values.ToList();
            for (int i = 0; i < projekty.Count; i++)
            {
                Console.WriteLine("\t{0}. {1} ({2})", i + 1, projekty[i].Nazev, projekty[i].Kod);
            }
            Console.Write("Vaše volba: ");
            int volba = Int32.Parse(Console.ReadLine()) - 1;
            Projekt projekt = projekty[volba];

            Console.WriteLine("\nReport - {0} ({1}) - zaměstnanci:", projekt.Nazev, projekt.Kod);
            foreach (Zamestnanec zamestnanec in projekt.Zamestnanci)
            {
                int soucet = 0;
                foreach (PolozkaVykazu polozkaVykazu in projekt.PolozkyVykazu)
                {
                    if (polozkaVykazu.Zamestnanec == zamestnanec)
                    {
                        soucet += polozkaVykazu.PocetHodin;
                    }
                }

                Console.WriteLine("\t{0} {1} ({2}): {3}", zamestnanec.Jmeno,zamestnanec.Prijmeni, zamestnanec.Kod, soucet);
            }
        }
    }
}
