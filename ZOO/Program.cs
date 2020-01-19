using System;
using System.Collections.Generic;


namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ZOO zoo = new ZOO();  //Volání konstruktoru 
            int volbaMenu = 0;
            Console.WriteLine("VITEJTE V ZOO");

            do
            {
                Console.WriteLine("\nHLAVNI MENU");
                Console.WriteLine("\t 1. Menu Zvirata");
                Console.WriteLine("\t 2. Menu Zamestnanci");
                Console.WriteLine("\t 3. Statistika");
                Console.WriteLine("\t 4. Ukoncit program");
                volbaMenu = Int32.Parse(Console.ReadLine());

                switch (volbaMenu)
                {
                    case 1: //MENU ZVIRATA
                        do
                        {
                            Console.WriteLine("\nMENU ZVIRATA");
                            Console.WriteLine("\t 1. Pridat zvire");
                            Console.WriteLine("\t 2. Vypsat zvirata");
                            Console.WriteLine("\t 3. Smazat zvire");
                            Console.WriteLine("\t 4. Upravit zvire");
                            Console.WriteLine("\t 5. Vyhledej zvire");
                            Console.WriteLine("\t 6. Zpet");
                            volbaMenu = Int32.Parse(Console.ReadLine());

                            switch (volbaMenu)
                            {
                                case 1:
                                    zoo.PridatZvire();
                                    break;
                                case 2:
                                    zoo.VypisZvirat();
                                    break;
                                case 3:
                                    zoo.SmazatZvire();
                                    break;
                                case 4:
                                    zoo.UpravitZvire();
                                    break;
                                case 5:
                                    zoo.VyhledejZvirata();
                                    break;
                            }
                        }
                        while (volbaMenu != 6);
                        break;
                    case 2: // MENU ZAMESTNANCI
                        do
                        {
                            Console.WriteLine("\nMENU ZAMESTNANCI");
                            Console.WriteLine("\t 1. Pridat zamestnance");
                            Console.WriteLine("\t 2. Vypsat zamestnance");
                            Console.WriteLine("\t 3. Smazat zamestnance");
                            Console.WriteLine("\t 4. Upravit zamestnance");
                            Console.WriteLine("\t 5. Zpet");
                            volbaMenu = Int32.Parse(Console.ReadLine());

                            switch (volbaMenu)
                            {
                                case 1:
                                    zoo.PridatZamestnance();
                                    break;
                                case 2:
                                    zoo.VypisZamestnancu();
                                    break;
                                case 3:
                                    zoo.SmazatZamestnance();
                                    break;
                                case 4:
                                    zoo.UpravitZamestnance();
                                    break;
                            }
                        }
                        while (volbaMenu != 5);
                        break;
                    case 3:
                        {
                            zoo.Statistika();
                            break;
                        }
                } 

            }
            while (volbaMenu != 4);
        }
    }

    class Zvire
    {
        public string Nazev { get; set; }
        public int Vek { get; set; }
        public double Vaha { get; set; }

        public Zvire(string nazev, int vek, double vaha)
        {
            Nazev = nazev;
            Vek = vek;
            Vaha = vaha;
        }

        public void VypisPopis()
        {
            Console.WriteLine($"Název: {Nazev}\t\t věk: {Vek}\t vaha: {Vaha}");
        }
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }
        public string JobPosition { get; set; }

        public Employee(string jmeno, string prijmeni, DateTime narozeniny, int plat, string pozice)
        {
            FirstName = jmeno;
            Surname = prijmeni;
            Birthday = narozeniny;
            Salary = plat;
            JobPosition = pozice;
        }

        public void VypisZamestnancu()
        {
            string date = Birthday.ToShortDateString();
            Console.WriteLine($"Jmeno: {FirstName}\tPrijmeni: {Surname}\tNarozeniny: {date}\tPlat: {Salary}\tPozice: {JobPosition}");
        }
    }

    class ZOO
    {
        private List<Zvire> zvirata; // lokální proměnná typu List, typ seznamu je 'zvíře' - viz.název třídy a proměnná se jmenuje zvířata
        private List<Employee> zamestnanci;

        public ZOO()   // metoda ZOO, do proměnné zvířata je uložen nový seznam typu 'zvíře'
        {
            zvirata = new List<Zvire>();
            zamestnanci = new List<Employee>();
        }

        public void PridatZvire()
        {
            Console.WriteLine("\nZADANI NOVEHO ZVIRETE");
            Console.Write("Nazev: ");
            string nazev = Console.ReadLine();
            Console.Write("Vek: ");
            int vek = Int32.Parse(Console.ReadLine());
            Console.Write("Vaha: ");
            double vaha = Double.Parse(Console.ReadLine());

            Zvire zvire = new Zvire(nazev, vek, vaha); // definice nové instance zvire s parametry
            zvirata.Add(zvire); // vložení nové instance do seznamu
        }

        public void PridatZamestnance()
        {
            Console.WriteLine("\nPRIDANI NOVEHO ZAMESTNANCE");
            Console.Write("Jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Prijmeni: ");
            string prijmeni = Console.ReadLine();
            Console.Write("Narozeniny: ");
            DateTime narozeniny = DateTime.Parse(Console.ReadLine());
            Console.Write("Plat: ");
            int plat = Int32.Parse(Console.ReadLine());
            Console.Write("Pozice: ");
            string pozice = Console.ReadLine();


            Employee employee = new Employee(jmeno, prijmeni, narozeniny, plat, pozice);
            zamestnanci.Add(employee);
        }

        public void SmazatZvire()
        {
            Console.WriteLine("\nSMAZANI ZVIRETE");
            for (int i = 0; i < zvirata.Count; i++)
            {
                Console.WriteLine($"{i + 1} zvire: {zvirata[i].Nazev}");
            }
            Console.WriteLine("\nZVOLTE CISLO ZVIRETE, KTERE CHCETE SMAZAT");
            int indexSmazat = Int32.Parse(Console.ReadLine());
            if(indexSmazat > 0 && indexSmazat <= zvirata.Count)
            {
                zvirata.RemoveAt(indexSmazat - 1);
                Console.WriteLine("Zvire bylo smazano.");
            }
            else
            {
                Console.WriteLine("Neexistujici cislo zvirete");
            }
        }


        public void SmazatZamestnance()
        {
            Console.WriteLine("\nSMAZANI ZAMESTNANCE");
            for (int i = 0; i < zamestnanci.Count; i++)
            {
                Console.WriteLine($"{i + 1} zamestnanec: {zamestnanci[i].FirstName} {zamestnanci[i].Surname}");
            }
            Console.WriteLine("\nZVOLTE CISLO ZAMESTNANCE, KTEREHO CHCETE SMAZAT");
            int indexSmazat = Int32.Parse(Console.ReadLine());
            if (indexSmazat > 0 && indexSmazat <= zamestnanci.Count)
            {
                zamestnanci.RemoveAt(indexSmazat - 1);
                Console.WriteLine("Zamestanec byl smazan.");
            }
            else
            {
                Console.WriteLine("Neexistujici cislo zamestnance");
            }
        }


        public void UpravitZvire()
        {
            Console.WriteLine("\nUPRAVA ZVIRETE");
            for (int i = 0; i < zvirata.Count; i++)
            {
                Console.WriteLine($"{i + 1} zvire: {zvirata[i].Nazev}");
            }
            Console.WriteLine("\nZVOLTE CISLO ZVIRETE, KTERE CHCETE UPRAVIT");
            int indexUpravit = Int32.Parse(Console.ReadLine());
            if (indexUpravit > 0 && indexUpravit <= zvirata.Count)
            {
                Zvire zvire = zvirata[indexUpravit - 1];
                Console.Write($"Aktuální jméno - {zvire.Nazev}. Chcete upravit jmeno zvirete? A/N: ");
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Novy nazev: ");
                    zvire.Nazev = Console.ReadLine();
                }
                Console.Write($"Aktuální věk - {zvire.Vek}. Chcete upravit vek zvirete? A/N: ");
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Novy nazev: ");
                    zvire.Vek = Int32.Parse(Console.ReadLine());
                }
                Console.Write($"Aktuální vaha - {zvire.Vaha}. Chcete upravit vek zvirete? A/N: ");
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Novy nazev: ");
                    zvire.Vaha = Double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Uprava dokoncena.");
            }
            else
            {
                Console.WriteLine("Neexistujici cislo zvirete");
            }
        }

        public void VyhledejZvirata()
        {
            Console.WriteLine("VYHLEDEJ ZVIRATA");
            Console.Write("Zadej libovolny retezec k vyhledavani: ");
            string vyhledej = Console.ReadLine();
            
            for (int i = 0; i < zvirata.Count; i++)
            {
                if(zvirata[i].Nazev.Contains(vyhledej))
                {
                    Console.WriteLine($"Nazev: {zvirata[i].Nazev}\tVek: {zvirata[i].Vek}\tVaha: {zvirata[i].Vaha}");
                }
            }
        }

        public void Statistika()
        {
            Console.WriteLine("\nSTATISTIKA");
            Console.WriteLine($"Celkovy pocet zvirat v evidenci je: {zvirata.Count}");
            Console.WriteLine($"Celkovy pocet zamestnancu v evidenci je: {zamestnanci.Count}");
            int soucetMezd = 0;
            for (int i = 0; i < zamestnanci.Count; i++)
            {
                soucetMezd += zamestnanci[i].Salary;
            }
            Console.WriteLine($"Soucet mezd vsech zamestnancu je: {soucetMezd}");

        }


        public void UpravitZamestnance()
        {
            Console.WriteLine("\nUPRAVA ZAMESTNANCE");
            for (int i = 0; i < zamestnanci.Count; i++)
            {
                Console.WriteLine($"{i + 1}. zamestnanec: {zamestnanci[i].FirstName} {zamestnanci[i].Surname}");
            }
            Console.WriteLine("\nZVOLTE CISLO ZAMESTNANCE, KTEREHO CHCETE UPRAVIT");
            int indexUpravit = Int32.Parse(Console.ReadLine());
            if (indexUpravit > 0 && indexUpravit <= zamestnanci.Count)
            {
                Employee employee = zamestnanci[indexUpravit - 1];
                Console.Write($"Aktuální jméno - {employee.FirstName} {employee.Surname}. Chcete upravit jmeno zamestnance? A/N: ");
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Nove jmeno: ");
                    employee.FirstName = Console.ReadLine();

                    Console.Write("Nove prijmeni: ");
                    employee.Surname = Console.ReadLine();
                }
                Console.Write($"Aktuální narozeniny - {employee.Birthday}. Chcete upravit narozeniny? A/N: ");
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Nove narozeniny: ");
                    employee.Birthday = DateTime.Parse(Console.ReadLine());
                }
                Console.Write($"Aktuální plat - {employee.Salary}. Chcete upravit plat zamestnance? A/N: ");
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Novy plat: ");
                    employee.Salary = Int32.Parse(Console.ReadLine());
                }
                Console.Write($"Aktuální pozice - {employee.JobPosition}. Chcete upravit pozici zamestnance? A/N: ");
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Nova pozice: ");
                    employee.JobPosition = Console.ReadLine();
                }
                Console.WriteLine("Uprava dokoncena.");
            }
            else
            {
                Console.WriteLine("Neexistujici cislo zamestnance");
            }
        }


        public void VypisZvirat()
        {
            Console.WriteLine("\nVYPIS ZVIRAT");
            foreach (Zvire zvire in zvirata)
            {
                zvire.VypisPopis();
            }
        }

        public void VypisZamestnancu()
        {
            Console.WriteLine("\nVYPIS ZAMESTNANCU");
            foreach (Employee employee in zamestnanci)
            {
                employee.VypisZamestnancu();
            }
        }

    }
}
