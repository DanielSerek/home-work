using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Cviceni2
{
    class ZOO
    {
        private List<Zvire> zvirata;   // Vytvoření privátní proměnné zvířata, která obsahuje seznam objektů Zvire

        public ZOO()    // Proč je potřeba vytvořit novou metodu ZOO, nemůžu vytvořit objekty zvířata přímo ve třídě?
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

            Zvire zvire = new Zvire(nazev, vek, vaha);     // Vytvoření nového objektu Zvire
            zvirata.Add(zvire);    // Přidání nové položky do listu
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
            for (int i = 0; i < zvirata.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, zvirata[i].Nazev);
            }
            Console.Write("Poradove cislo pro smazani: ");
            int indexSmazat = Int32.Parse(Console.ReadLine()) - 1;
            if (indexSmazat >= 0 && indexSmazat < zvirata.Count)
            {
                Console.WriteLine("Zvire: {0} smazano", zvirata[indexSmazat].Nazev);
                zvirata.RemoveAt(indexSmazat);
            }
            else
            {
                Console.WriteLine("Spatne cislo. Zvire nebylo smazano");
            }
        }
    }
}
