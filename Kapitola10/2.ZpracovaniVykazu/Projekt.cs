using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ZpracovaniVykazu
{
    public class Projekt
    {
        public string Nazev { get; set; }
        public string Kod { get; set; }
        public int Priorita { get; set; }

        public List<Zamestnanec> Zamestnanci { get; set; }
        public List<PolozkaVykazu> PolozkyVykazu { get; set; }

        public Projekt(string nazev, string kod, int priorita, 
            List<Zamestnanec> zamestnanci, List<PolozkaVykazu> polozkyVykazu)
        {
            Nazev = nazev;
            Kod = kod;
            Priorita = priorita;
            Zamestnanci = zamestnanci;
            PolozkyVykazu = polozkyVykazu;
        }
    }
}
