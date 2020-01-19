using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ZpracovaniVykazu
{
    public class PolozkaVykazu
    {
        public Zamestnanec Zamestnanec { get; set; }
        public Projekt Projekt { get; set; }
        public DateTime Datum { get; set; }
        public int PocetHodin { get; set; }

        public PolozkaVykazu(Zamestnanec zamestnanec, Projekt projekt, DateTime datum, int pocetHodin)
        {
            Zamestnanec = zamestnanec;
            Projekt = projekt;
            Datum = datum;
            PocetHodin = pocetHodin;
        }
    }
}
