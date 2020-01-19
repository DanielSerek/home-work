using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cviceni1
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
