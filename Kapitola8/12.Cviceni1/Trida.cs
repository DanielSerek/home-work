using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cviceni1
{
    class Trida
    {
        public string Nazev { get; set; }
        public int Rocnik { get; set; }
        public List<Zak> Zaci { get; set; }
        public Ucitel TridniUcitel { get; set; }

        public Trida(string nazev, int rocnik, List<Zak> zaci, Ucitel tridniUcitel)
        {
            Nazev = nazev;
            Rocnik = rocnik;
            Zaci = zaci;
            TridniUcitel = tridniUcitel;
        }
    }
}
