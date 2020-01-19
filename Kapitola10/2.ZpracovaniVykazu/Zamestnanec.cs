using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ZpracovaniVykazu
{
    public class Zamestnanec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Kod { get; set; }
        public string Pozice { get; set; }
        
        public List<Projekt> Projekty { get; set; }
        public List<PolozkaVykazu> PolozkyVykazu { get; set; }

        public Zamestnanec(string jmeno, string prijmeni, string kod, string pozice, 
            List<Projekt> projekty, List<PolozkaVykazu> polozkyVykazu)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Kod = kod;
            Pozice = pozice;
            Projekty = projekty;
            PolozkyVykazu = polozkyVykazu;
        }

    }
}
