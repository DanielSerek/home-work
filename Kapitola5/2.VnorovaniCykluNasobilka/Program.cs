using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.VnorovaniCykluNasobilka
{
    class Program
    {
        static void Main(string[] args)
        {
            int odpoved;
            int spravneOdpovedi = 0;
            bool konec = false;
            for (int i = 1; i <= 10; i++)
            {
                // V každém běhu vnějšího cyklu se 10x vykoná vnořený cyklus. 
                for (int j = 1; j <= 10; j++)
                {
                    // Vypisujeme násobky čísla na jeden řádek
                    Console.Write("Kolik je {0} * {1}? ", i, j);
                    odpoved = Int32.Parse(Console.ReadLine());

                    if (odpoved == i * j)
                    {
                        Console.Write("Spravna odpoved!");
                        spravneOdpovedi++;
                    }
                    else
                    {
                        konec = true;
                        break;
                    }
                }
                if (konec == true)
                {
                    break;
                }
                // Odřádkujeme, abychom násobky dalšího čísla vypsali na samostatný řádek
                Console.WriteLine();
            }
            Console.WriteLine("Pocet spravnych odpovedi: {0}", spravneOdpovedi);
            Console.ReadKey();
        }
    }
}
