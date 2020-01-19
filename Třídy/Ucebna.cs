using System;
using System.Collections.Generic;
using System.Text;

namespace Třídy
{
    class Ucebna
    {
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public int Kapacita { get; set; }

        public Ucebna(string nazev, string popis, int kapacita)
        {
            Nazev = nazev;
            Popis = popis;
            Kapacita = kapacita;
        }
    }
}
