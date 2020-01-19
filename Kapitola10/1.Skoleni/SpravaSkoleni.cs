using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Skoleni
{
    public class SpravaSkoleni
    {
        public List<Lektor> Lektori { get; set; }
        public List<Student> Studenti { get; set; }
        public List<Skoleni> SeznamSkoleni { get; set; }

        // Lektory a studenty budeme načítat metodou NacistZamestnance, 
        // proto je nepředáváme parametrem konstruktoru. 
        // Školení budeme načítat metodou NacistSkoleni, proto je také nepředáváme
        // parametrem konstruktoru
        public SpravaSkoleni()
        {
            Lektori = new List<Lektor>();
            Studenti = new List<Student>();
            SeznamSkoleni = new List<Skoleni>();
        }

        /* Předpokládáme, že soubor skoleni.txt existuje a obsahuje data
         * v očekávaném formátu. Nestandardní situace jako např. chybějící údaje
         * nebo neexistující soubor neošetřujeme.
         */
        public void NacistSkoleni()
        {
            StreamReader reader = new StreamReader("skoleni.txt");
            // Přeskočíme první řádek souboru
            reader.ReadLine();
            string radek = "";
            while ((radek = reader.ReadLine()) != null)
            {
                // Přečteme informace o školení, které jsou vždy na řádku, 
                // který následuje po řádku obsahujícím řetězec SKOLENI
                string[] informaceSkoleni = radek.Split(';');
                string nazev = informaceSkoleni[0];
                string popis = informaceSkoleni[1];

                string[] pocatecniDatumSlozky = informaceSkoleni[2].Split('.');
                DateTime pocatecniDatum = new DateTime(Int32.Parse(pocatecniDatumSlozky[2]), Int32.Parse(pocatecniDatumSlozky[1]), Int32.Parse(pocatecniDatumSlozky[0]));

                string[] koncoveDatumSlozky = informaceSkoleni[3].Split('.');
                DateTime koncoveDatum = new DateTime(Int32.Parse(koncoveDatumSlozky[2]), Int32.Parse(koncoveDatumSlozky[1]), Int32.Parse(koncoveDatumSlozky[0]));

                int doporucenyPocetUcastniku = Int32.Parse(informaceSkoleni[4]);

                bool skoleniUzavreno = false;
                if (informaceSkoleni[5] == "ANO")
                {
                    skoleniUzavreno = true;
                }
                // Přeskočíme řádek na kterém očekáváme, že musí být řetězec LEKTORI
                reader.ReadLine();
                List<Lektor> lektori = new List<Lektor>();
                while ((radek = reader.ReadLine()) != "STUDENTI")
                {
                    // Dokud nenarazíme na řádek s řetězcem STUDENTI, tak čteme lektory
                    lektori.Add(NajdiLektoraPodleKodu(radek));
                }

                List<Student> studenti = new List<Student>();
                while ((radek = reader.ReadLine()) != "HODNOCENI")
                {
                    // Dokud nenarazíme na řádek s řetězcem HODNOCENI, tak čteme studenty
                    studenti.Add(NajdiStudentaPodleKodu(radek));
                }
                Dictionary<Student, int> hodnoceni = new Dictionary<Student, int>();
                while (true)
                {
                    // Dokud nenarazíme na řádek s řetězcem SKOLENI, tak čteme hodnocení
                    radek = reader.ReadLine();
                    if (radek == null || radek == "SKOLENI")
                        break;
                    string[] hodnotyHodnoceni = radek.Split(';');
                    hodnoceni.Add(NajdiStudentaPodleKodu(hodnotyHodnoceni[0]), Int32.Parse(hodnotyHodnoceni[1]));
                }
                /*
                 * Vytvoříme instanci Skoleni. Ta v sobě bude mít informaci kteří studenti a lektoři se školení účastní.
                 * Zároveň jednotlivým studentům a lektorům přiřadíme informaci o výše vytvořeném školení
                 * Toto se nám bude hodit ve chvíli, kdy budeme chtít jednoduše získat pro daného studenta nebo lektora seznam jeho školení
                 */
                Skoleni skoleni = new Skoleni(nazev, popis, pocatecniDatum, koncoveDatum, studenti, lektori, hodnoceni, doporucenyPocetUcastniku, skoleniUzavreno);
                foreach (Student student in studenti)
                {
                    student.Skoleni.Add(skoleni);
                }
                foreach (Lektor lektor in lektori)
                {
                    lektor.VyucovanaSkoleni.Add(skoleni);
                }
                SeznamSkoleni.Add(skoleni);
            }
            reader.Close();
        }

        /*
         * Metoda najde student na základě jeho zaměstnaneckého kódu
         */
        public Student NajdiStudentaPodleKodu(string kod)
        {
            foreach (Student student in Studenti)
            {
                if (student.Kod == kod)
                {
                    return student;
                }
            }
            return null;
        }

        /*
         * Metoda najde lektora na základě jeho zaměstnaneckého kódu
         */
        public Lektor NajdiLektoraPodleKodu(string kod)
        {
            foreach (Lektor lektor in Lektori)
            {
                if (lektor.Kod == kod)
                {
                    return lektor;
                }
            }
            return null;
        }

        /* Předpokládáme, že soubor zamestnanci.txt existuje a obsahuje data
         * v očekávaném formátu. Nestandardní situace jako např. chybějící údaje
         * nebo neexistující soubor neošetřujeme.
         */
        public void NacistZamestnance()
        {
            StreamReader reader = new StreamReader("zamestnanci.txt");
            // Přeskočíme první řádek, protože obsahuje hlavičku a nechceme na základě
            // něj vytvářet studenta nebo lektora
            string radek = reader.ReadLine();
            while ((radek = reader.ReadLine()) != null)
            {
                string[] hodnoty = radek.Split(';');
                string kod = hodnoty[0];
                string jmeno = hodnoty[1];
                string prijmeni = hodnoty[2];
                string nazevPozice = hodnoty[3];
                bool jeLektorem = false;
                if (hodnoty[4].ToLower() == "ano")
                {
                    jeLektorem = true;
                }

                if (jeLektorem)
                {
                    Lektor lektor = new Lektor(jmeno, prijmeni, kod, nazevPozice);
                    Lektori.Add(lektor);
                }
                else
                {
                    Student student = new Student(jmeno, prijmeni, kod, nazevPozice);
                    Studenti.Add(student);
                }
            }
            reader.Close();
        }

        /*
         * Vypíše pomocné ladící informace - aktuální data o školeních, studentech a lektorech na konzoli.
         */
        public void VypisLadiciInfo()
        {
            Console.WriteLine("********** Správa školení **********");

            Console.WriteLine("Počet lektorů: {0} Počet studentů: {1}", Lektori.Count, Studenti.Count);

            Console.WriteLine("\n***** Lektoři *****\n");
            foreach (Lektor lektor in Lektori)
            {
                Console.WriteLine("{0} {1}", lektor.Jmeno, lektor.Prijmeni);
                Console.WriteLine("\tKód: {0}", lektor.Kod);
                Console.WriteLine("\tNázev pozice: {0}", lektor.NazevPozice);
            }

            Console.WriteLine("\n***** Studenti *****\n");
            foreach (Student student in Studenti)
            {
                Console.WriteLine("{0} {1}", student.Jmeno, student.Prijmeni);
                Console.WriteLine("\tKód: {0}", student.Kod);
                Console.WriteLine("\tNázev pozice: {0}", student.NazevPozice);
            }

            Console.WriteLine("\n***** Skoleni *****\n");
            foreach (Skoleni skoleni in SeznamSkoleni)
            {
                Console.WriteLine("Název školení: {0}", skoleni.Nazev);
                Console.WriteLine("\tUzavreno: {0}", skoleni.Uzavreno);
                Console.WriteLine("\tPopis: {0}", skoleni.Popis);
                Console.WriteLine("\tDoporučený počet účastníků: {0}", skoleni.DoporucenyPocetUcastniku);
                Console.WriteLine("\tDatum konání: {0} - {1}", skoleni.PocatecniDatum.ToShortDateString(), skoleni.KoncoveDatum.ToShortDateString());
                Console.WriteLine("\tLektori:");
                foreach (Lektor lektor in skoleni.Lektori)
                {
                    Console.WriteLine("\t\t{0} {1} ({2})", lektor.Jmeno, lektor.Prijmeni, lektor.Kod);
                }

                Console.WriteLine("\tStudenti:");
                foreach (Student student in skoleni.Studenti)
                {
                    if (skoleni.Uzavreno)
                    {
                        Console.WriteLine("\t\t{0} {1} ({2}) - {3}%", student.Jmeno, student.Prijmeni, student.Kod, skoleni.HodnoceniStudentu[student]);
                    }
                    else
                    {
                        Console.WriteLine("\t\t{0} {1} ({2})", student.Jmeno, student.Prijmeni, student.Kod);
                    }
                }
            }
        }

        /*
         * Postupně od uživatele načte informace a vytvoří nové školení a uloží jej do seznamu školení
         */
        public void NoveSkoleni()
        {
            Console.WriteLine("*** Vytvoření nového školení ***");
            Console.Write("Název:");
            string nazev = Console.ReadLine();
            Console.Write("Popis:");
            string popis = Console.ReadLine();
            Console.Write("Doporučený počet účastníků:");
            int doporucenyPocetUcastniku = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Počáteční datum:");
            Console.Write("\tDen:");
            int pocDatDen = Int32.Parse(Console.ReadLine());
            Console.Write("\tMesic:");
            int pocDatMes = Int32.Parse(Console.ReadLine());
            Console.Write("\tRok:");
            int pocDatRok = Int32.Parse(Console.ReadLine());
            DateTime pocatecniDatum = new DateTime(pocDatRok, pocDatMes, pocDatDen);

            Console.WriteLine("Koncové datum:");
            Console.Write("\tDen:");
            int konDatDen = Int32.Parse(Console.ReadLine());
            Console.Write("\tMesic:");
            int konDatMes = Int32.Parse(Console.ReadLine());
            Console.Write("\tRok:");
            int konDatRok = Int32.Parse(Console.ReadLine());
            DateTime koncoveDatum = new DateTime(konDatRok, konDatMes, konDatDen);

            Skoleni noveSkoleni = new Skoleni(nazev, popis, pocatecniDatum, koncoveDatum,
                new List<Student>(), new List<Lektor>(), new Dictionary<Student, int>(), doporucenyPocetUcastniku, false);
            SeznamSkoleni.Add(noveSkoleni);

            UlozitSkoleni();
            Console.WriteLine("! Školení bylo úspěšně vytvořeno !");
        }

        /*
         * Uloží aktuální data o školeních do souboru skoleni.txt
         */
        public void UlozitSkoleni()
        {
            StreamWriter writer = new StreamWriter("skoleni.txt");
            foreach (Skoleni skoleni in SeznamSkoleni)
            {
                writer.WriteLine("SKOLENI");
                // String.Format Funguje obdobně jako Console.WriteLine kde na daná místa doplní parametry
                string pocatecniDatum = String.Format("{0}.{1}.{2}", skoleni.PocatecniDatum.Day, skoleni.PocatecniDatum.Month, skoleni.PocatecniDatum.Year);
                string koncoveDatum = String.Format("{0}.{1}.{2}", skoleni.KoncoveDatum.Day, skoleni.KoncoveDatum.Month, skoleni.KoncoveDatum.Year);
                string uzavreno = "NE";
                if (skoleni.Uzavreno)
                {
                    uzavreno = "ANO";
                }
                // Zapsání řádku se základními informace o školení
                writer.WriteLine("{0};{1};{2};{3};{4};{5}", skoleni.Nazev, skoleni.Popis, pocatecniDatum, koncoveDatum, skoleni.DoporucenyPocetUcastniku, uzavreno);
                // Zapsání seznamu lektorů 
                writer.WriteLine("LEKTORI");
                foreach (Lektor lektor in skoleni.Lektori)
                {
                    writer.WriteLine(lektor.Kod);
                }
                // Zapsání seznamu studentů
                writer.WriteLine("STUDENTI");
                foreach (Student student in skoleni.Studenti)
                {
                    writer.WriteLine(student.Kod);
                }
                // Zapsání hodnocení studentů ve formátu KOD_ZAMESTNANCE;PROCENTUALNI_HODNOCENI
                writer.WriteLine("HODNOCENI");
                foreach (Student student in skoleni.HodnoceniStudentu.Keys)
                {
                    writer.WriteLine("{0};{1}", student.Kod, skoleni.HodnoceniStudentu[student]);
                }
            }
            writer.Close();
        }

        /*
         * Zobrazí číslovaný seznam všech školení a nechá uživatele jedno vybrat.
         * Pokud vybere pořadové číslo 0 nebo zadá číslo mimo rozsah pak vrátí null.
         */
        public Skoleni VybratSkoleni()
        {
            Console.WriteLine("*** Seznam školení ***");
            for (int i = 0; i < SeznamSkoleni.Count; i++)
            {
                string stav = "otevřené";
                if (SeznamSkoleni[i].Uzavreno)
                {
                    stav = "uzavřené";
                }
                Console.WriteLine("{0}. {1} - {2}", i + 1, SeznamSkoleni[i].Nazev, stav);
            }
            Console.WriteLine("0. Zpět");
            Console.Write("Vaše volba: ");
            int volba = Int32.Parse(Console.ReadLine()) - 1;
            if (volba >= 0 && volba < SeznamSkoleni.Count)
            {
                return SeznamSkoleni[volba];
            }
            else
            {
                return null;
            }
        }

        /*
         * Výpiše na konzoli detailní informace o školení. Pokud je školení uzavřené, pak
         * vypíše i hodnocení jednotlivých studentů
         */ 
        public void ZobrazDetailSkoleni(Skoleni skoleni)
        {
            string stav = "Otevřené";
            if (skoleni.Uzavreno)
            {
                stav = "Uzavřené";
            }

            Console.WriteLine("*** Detail Skoleni ***\n");
            Console.WriteLine("Název školení: {0}", skoleni.Nazev);
            Console.WriteLine("\tStav: {0}", stav);
            Console.WriteLine("\tPopis: {0}", skoleni.Popis);
            Console.WriteLine("\tDoporučený počet účastníků: {0}", skoleni.DoporucenyPocetUcastniku);
            Console.WriteLine("\tDatum konání: {0} - {1}", skoleni.PocatecniDatum.ToShortDateString(), skoleni.KoncoveDatum.ToShortDateString());
            Console.WriteLine("\tLektori:");

            foreach (Lektor lektor in skoleni.Lektori)
            {
                Console.WriteLine("\t\t{0} {1} ({2})", lektor.Jmeno, lektor.Prijmeni, lektor.Kod);
            }

            Console.WriteLine("\tStudenti:");
            foreach (Student student in skoleni.Studenti)
            {
                if (skoleni.Uzavreno)
                {
                    Console.WriteLine("\t\t{0} {1} ({2}) - {3}%", student.Jmeno, student.Prijmeni, student.Kod, skoleni.HodnoceniStudentu[student]);
                }
                else
                {
                    Console.WriteLine("\t\t{0} {1} ({2})", student.Jmeno, student.Prijmeni, student.Kod);
                }
            }
        }

        /*
         * Nechá uživatele vybrat a přihlásit na školení studenta ze seznamu studentů,
         * kteří se mohou přihlásit na školení.
         */ 
        public void PrihlasitStudenta(Skoleni skoleni)
        {
            // Vytvoříme si seznam studentů, kteří ještě na školení nejsou přihlášení
            // a mohou se tedy přihlásit
            List<Student> studenti = new List<Student>();
            foreach (Student student in Studenti)
            {
                if (!skoleni.Studenti.Contains(student))
                {
                    studenti.Add(student);
                }
            }

            Console.WriteLine("*** Přihlášení studenta na školení ***");
            // Zobrazíme seznam studentů, které je možné přihlásit na školení a necháme
            // uživatele vybrat, kterého chce přihlásit.
            for (int i = 0; i < studenti.Count; i++)
            {
                Console.WriteLine("{0}. {1} {2} ({3})", i + 1, studenti[i].Jmeno, studenti[i].Prijmeni, studenti[i].Kod);
            }
            Console.WriteLine("0. Zpět");
            Console.Write("Přihlásit studenta:");
            int volba = Int32.Parse(Console.ReadLine()) - 1;
            if (volba >= 0 && volba < studenti.Count)
            {
                skoleni.Studenti.Add(studenti[volba]);
                UlozitSkoleni();
                Console.WriteLine("! Student byl úspěšně přihlášen na školení !");
            }
        }

        /*
         * Nechá uživatele vybrat a odhlásit ze školení studenta, který je již na školení přihlášen
         */
        public void OdhlasitStudenta(Skoleni skoleni)
        {
            Console.WriteLine("*** Odhlášení studenta ze školení ***");
            // Zobrazíme seznam studentů, které je možné odhlásit ze školení a necháme
            // uživatele vybrat, kterého chce odhlásit.
            for (int i = 0; i < skoleni.Studenti.Count; i++)
            {
                Console.WriteLine("{0}. {1} {2} ({3})", i + 1, skoleni.Studenti[i].Jmeno, skoleni.Studenti[i].Prijmeni,
                    skoleni.Studenti[i].Kod);
            }
            Console.WriteLine("0. Zpět");
            Console.Write("Odhlásit studenta:");
            int volba = Int32.Parse(Console.ReadLine()) - 1;
            if (volba >= 0 && volba < skoleni.Studenti.Count)
            {
                skoleni.Studenti.Remove(skoleni.Studenti[volba]);
                UlozitSkoleni();
                Console.WriteLine("! Student byl úspěšně odhlášen ze školení !");
            }
        }

        /*
         * Nechá uživatele vybrat a přiřadit na školení lektora ze seznamu lektorů,
         * kteří mohou na školení učit.
         */
        public void PriraditLektora(Skoleni skoleni)
        {
            // Vytvoříme si seznam lektorů, kteří ještě nejsou přiřazeni na toto školení
            // a mohou tedy být přiřazeni
            List<Lektor> lektori = new List<Lektor>();
            foreach (Lektor lektor in Lektori)
            {
                if (!skoleni.Lektori.Contains(lektor))
                {
                    lektori.Add(lektor);
                }
            }

            Console.WriteLine("*** Přiřazení lektora na školení ***");
            // Zobrazíme seznam lektorů, které je možné přiřadit na školení a necháme
            // uživatele vybrat, kterého chce přiřadit.
            for (int i = 0; i < lektori.Count; i++)
            {
                Console.WriteLine("{0}. {1} {2} ({3})", i + 1, lektori[i].Jmeno, lektori[i].Prijmeni, lektori[i].Kod);
            }
            Console.WriteLine("0. Zpět");
            Console.Write("Přiřadit lektora:");
            int volba = Int32.Parse(Console.ReadLine()) - 1;
            if (volba >= 0 && volba < lektori.Count)
            {
                skoleni.Lektori.Add(lektori[volba]);
                UlozitSkoleni();
                Console.WriteLine("! Lektor byl úspěšně přihlášen na školení !");
            }
        }

        /*
         * Nechá uživatele vybrat a odebrat ze školení lektora, který je již na školení přiřazen
         */
        public void OdebratLektora(Skoleni skoleni)
        {
            Console.WriteLine("*** Odebrání lektora ze školení ***");
            // Zobrazíme seznam lektorů, které je možné odebrat ze školení a necháme
            // uživatele vybrat, kterého chce odebrat.
            for (int i = 0; i < skoleni.Lektori.Count; i++)
            {
                Console.WriteLine("{0}. {1} {2} ({3})", i + 1, skoleni.Lektori[i].Jmeno, skoleni.Lektori[i].Prijmeni,
                    skoleni.Lektori[i].Kod);
            }
            Console.WriteLine("0. Zpět");
            Console.Write("Odebrat lektora:");
            int volba = Int32.Parse(Console.ReadLine()) - 1;
            if (volba >= 0 && volba < skoleni.Lektori.Count)
            {
                skoleni.Lektori.Remove(skoleni.Lektori[volba]);
                UlozitSkoleni();
                Console.WriteLine("! Lektor byl úspěšně odebrán ze školení !");
            }
        }

        /*
         * Postupně vyzve k zadání hodnocení jednotlivých studentů. Po ohodnocení
         * všech studentů nastaví školení jako uzavřené.
         */ 
        public void UzavritSkoleni(Skoleni skoleni)
        {
            Console.WriteLine("*** Uzavření školení ***");
            Console.WriteLine("Vyplňte hodnocení jednotlivých studentů");
            foreach(Student student in skoleni.Studenti)
            {
                Console.Write("{0} {1} ({2}): ",student.Jmeno,student.Prijmeni,student.Kod);
                int hodnoceni = Int32.Parse(Console.ReadLine());
                skoleni.HodnoceniStudentu[student] = hodnoceni;
            }
            skoleni.Uzavreno = true;
            UlozitSkoleni();
            Console.WriteLine("! Školení bylo úspěšně uzavřeno !");
        }
    }
}
