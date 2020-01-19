using System;

namespace _4.PlatnostPromennych
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
        }

        static void SectiCisla()
        {
            // Nelze použít proměnné, které nebyly předány do metody
            // nebo nebyly v metodě definovány!
            int soucet = x + y;
            return soucet;
        }
    }
}
