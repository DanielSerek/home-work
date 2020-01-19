using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Cviceni1
{
    class Faktura
    {
        public string ICOOdberatele { get; set; }
        public string Kod { get; set; }
        public double Castka { get; set; }
        public bool Zaplaceno { get; set; }
        
        public Faktura(string icoOdberatele, string kod, double castka, bool zaplaceno)
        {
            ICOOdberatele = icoOdberatele;
            Kod = kod;
            Castka = castka;
            Zaplaceno = zaplaceno;
        }
    }
}
