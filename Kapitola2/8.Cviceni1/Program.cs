using System;

namespace Cviceni1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vyzveme uživatele, aby zadal své jméno a věk
            Console.Write("Zadejte vase jmeno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte vas vek: ");

            // Nezapomeneme provést konverzi z řetězce na číslo. 
            // Mohli bychom také použít zápis Int32.Parse(Console.ReadLine())
            int vek = int.Parse(Console.ReadLine());

            // Vyzveme uživatele, aby zadal jméno své kamarádky a její věk
            Console.Write("Zadejte jmeno kamaradky: ");
            string jmenoKamaradky = Console.ReadLine();
            Console.Write("Zadejte vek kamaradky: ");
            int vekKamaradky = int.Parse(Console.ReadLine());

            // Pro procvičení sčítání řetězců si připravíme výsledek, který vypíšeme 
            // jako řetězec, který vytvoříme postupným sčítáním jednotlivých částí
            int rozdilVeku = vek - vekKamaradky;
            string zpravaRozdil = "Rozdil ve veku " + jmeno + " a " + jmenoKamaradky + " je " + rozdilVeku.ToString();
            Console.WriteLine(zpravaRozdil);
            Console.ReadKey();
        }
    }
}
