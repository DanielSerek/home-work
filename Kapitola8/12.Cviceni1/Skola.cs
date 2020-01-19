using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cviceni1
{
    class Skola
    {
        public List<Ucitel> Ucitele { get; set; }
        public List<Ucebna> Ucebny { get; set; }
        public List<Trida> Tridy { get; set; }
        public List<Predmet> Predmety { get; set; }

        public Skola(List<Ucitel> ucitele, List<Ucebna> ucebny, List<Trida> tridy, List<Predmet> predmety)
        {
            Ucitele = ucitele;
            Ucebny = ucebny;
            Tridy = tridy;
            Predmety = predmety;
        }
    }
}
