using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Cviceni3
{
    class ZOO
    {
        private List<Zvire> zvirata;

        public ZOO()
        {
            zvirata = new List<Zvire>();
        }

        public void PridatZvire()
        {
            Console.WriteLine("ZADANI NOVEHO ZVIRETE");
            Console.Write("Nazev: ");
            string nazev = Console.ReadLine();
            Console.Write("Vek: ");
            int vek = Int32.Parse(Console.ReadLine());
            Console.Write("Vaha: ");
            double vaha = Double.Parse(Console.ReadLine());

            Zvire zvire = new Zvire(nazev, vek, vaha);
            zvirata.Add(zvire);
        }

        public void VypisZvirat()
        {
            Console.WriteLine("VYPIS ZVIRAT");
            foreach (Zvire zvire in zvirata)
            {
                zvire.VypisPopis();
            }
        }

        public void SmazatZvire()
        {
            Console.WriteLine("SMAZANI ZVIRETE");
            int indexKeSmazani = VybratIndexZvirete();
            if (indexKeSmazani >= 0)
            {
                Console.WriteLine("Zvire {0} bylo smazano", zvirata[indexKeSmazani].Nazev);
            }
        }

        public void UpravitZvire()
        {
            Console.WriteLine("UPRAVA ZVIRETE");
            int indexUpravit = VybratIndexZvirete();
            if (indexUpravit >= 0)
            {
                Zvire zvire = zvirata[indexUpravit];
                Console.WriteLine("Aktualni nazev: {0}\n Chcete upravit? A/N", zvire.Nazev);
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Novy nazev: ");
                    zvire.Nazev = Console.ReadLine();
                }
                Console.WriteLine("Aktualni vek: {0}\n Chcete upravit? A/N", zvire.Vek);
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Novy vek: ");
                    zvire.Vek = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("Aktualni vaha: {0}\n Chcete upravit? A/N", zvire.Vaha);
                if (Console.ReadLine().ToLower() == "a")
                {
                    Console.Write("Nova vaha: ");
                    zvire.Vaha = Double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Uprava dokoncena");
            }
        }

        public int VybratIndexZvirete()
        {
            for (int i = 0; i < zvirata.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, zvirata[i].Nazev);
            }
            Console.Write("Poradove cislo pro smazani: ");
            int index = Int32.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < zvirata.Count)
            {
                return index;
            }
            else
            {
                Console.WriteLine("Spatne poradove cislo!");
                return -1;
            }
        }
    }
}
