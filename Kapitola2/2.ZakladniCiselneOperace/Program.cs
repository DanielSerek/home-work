namespace ZakladniCiselneOperace
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 4;
            float z = 4f;

            int soucet = x + y;
            int rozdil = x - y;
            int soucin = x * y;

            // Pokud dělíme dvě celá čísla tak je provedeno celočíselné dělení.
            int podilCeleCislo = x / y;  // Výsledek je 2
            int zbytePoCelociselnemDeleni = x % y; // Zbytek po celočíselném dělení je 2

            // Pokud je při dělení alespoň jedno číslo desetinné tak je i výsledek desetinné číslo
            float podilDesetinneCislo = x / z; // Výsledek je 2.5
            // Toto je špatně:
            // int podilSpatnyTyp = x / z;

            int vysledek1 = 2 * 3 + 5 * 4; // Výsledek je 26
            int vysledek2 = 2 * (3 + 5) * 4; // Výsledek je 64
            int vysledek3 = 2 + 18 / 2; // Výsledek je 11
            int vysledek4 = (2 + 18) / 2; // Výsledek je 10
        }
    }
}
