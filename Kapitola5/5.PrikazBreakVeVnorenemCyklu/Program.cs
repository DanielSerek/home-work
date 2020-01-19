using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PrikazBreakVeVnorenemCyklu
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                // V každém běhu vnějšího cyklu se 10x vykoná vnořený cyklus. 
                for (int j = 1; j <= 10; j++)
                {
                    // Vypisujeme násobky čísla na jeden řádek
                    Console.Write("{0} ", i * j);
                    // Prikaz break ukonci pouze ten cyklus ve kterem je zavolan
                    break;
                    Console.WriteLine("Toto jiz vypsano nebude");
                }
                // Odřádkujeme, abychom násobky dalšího čísla vypsali na samostatný řádek
                Console.WriteLine();
            }
            Console.ReadKey();

            // Násobilka s ukončením obou cyklů
            Console.Write("Maximum vypisu nasobilky: ");
            int maximum = Int32.Parse(Console.ReadLine());
            // Pomocná proměnná pro ukončení vnějšího cyklu
            bool ukonceniVypisu = false;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} ", i * j);
                    if ((i * j) >= maximum)
                    {
                        // Nastavíme pomocnou proměnnou a ve vnějším cyklu
                        // kontrolujeme zdali jej nemáme ukončit
                        ukonceniVypisu = true;
                        break;
                    }
                }
                if (ukonceniVypisu == true)
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
