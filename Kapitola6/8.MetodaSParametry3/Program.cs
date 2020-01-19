using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MetodaSParametry3
{
    class Program
    {
        static void Main(string[] args)
        {
            int vek1 = 32;
            string jmeno1 = "Karel";
            double vek2 = 33;
            string jmeno2 = "Anna";
            // Datové typy předávaných parametrů jsou v pořádku
            NarozeninovePrani(jmeno1, vek1);
            // Datové typy předávaných parametrů jsou špatně!
            // Metoda očekává string, int a my předáváme double
            NarozeninovePrani(jmeno2, vek2);
        }

        static void NarozeninovePrani(string jmeno, int vek)
        {
            Console.WriteLine("Vse nejlepsi {0} k {1}. narozeninam", jmeno, vek);
        }
    }
}
