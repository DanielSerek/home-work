using System;
using System.Collections.Generic;
using System.Text;

namespace Třídy
{
    class Trida
    {
        public string Nazev { get; set; }
        public int Rocnik { get; set; }
        public List<Zak> Zaci { get; set; }
        public Ucitel TridniUcitel { get; set; }

        public Trida(string nazev, int rocnik, List<Zak> zaci, Ucitel ucitel)
        {
            Nazev = nazev;
            Rocnik = rocnik;
            Zaci = zaci;
            TridniUcitel = TridniUcitel;
        }
    }
}
