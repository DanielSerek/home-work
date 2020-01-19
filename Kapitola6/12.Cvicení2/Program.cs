using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cvicení2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] uzivatelskaJmena = { "jan", "petr","LUCIE","jana" };
            Console.WriteLine("Jan: {0}", ExistujeJmeno(uzivatelskaJmena, "Jan"));
            Console.WriteLine("pEtR: {0}", ExistujeJmeno(uzivatelskaJmena, "pEtR"));
            Console.WriteLine("lucka: {0}", ExistujeJmeno(uzivatelskaJmena, "lucka"));
            Console.WriteLine("jan a: {0}", ExistujeJmeno(uzivatelskaJmena, "jan a"));
            Console.ReadKey();
        }

        static bool ExistujeJmeno(string[] jmena, string hledaneJmeno)
        {
            foreach (string jmeno in jmena)
            {
                if (jmeno.ToLower() == hledaneJmeno.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
