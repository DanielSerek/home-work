using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VnorovaniCyklusPrumery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slouží pro vyhodnocení zdali má program pokračovat výpočtem průměru dalšího studenta
            string dalsiStudent;
            do
            {
                double soucetZnamek = 0;
                int pocetZnamek = 0;
                int zadanaZnamka = 0;

                do
                {
                    Console.WriteLine("Zadejte znamku studenta(pokud chcete zadavani ukoncit, zadejte nulu): ");
                    zadanaZnamka = Int32.Parse(Console.ReadLine());
                    // Pokud je zadaná 0 tak nezvyšujeme počet zadaných čísel
                    if (zadanaZnamka != 0)
                    {
                        soucetZnamek += zadanaZnamka;
                        pocetZnamek += 1;
                    }
                    // Cyklus skončí když uživatel zadá 0
                } while (zadanaZnamka != 0);
                // Vypočteme aritmetický průměr
                double prumer = soucetZnamek / pocetZnamek;
                Console.WriteLine("Aritmeticky prumer = {0}", prumer);
                // Pokud uživatel bude chtít vypočíst další průměr tak musí zadat písmeno A
                Console.WriteLine("Chcete vypocist prumer dalsiho studenta? (A/N)");
                dalsiStudent = Console.ReadLine();
            } while (dalsiStudent == "A");
            
        }
    }
}
