using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrikazElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kompletní ukázka syntaxe příkazů if, else if, else

            if (logický výraz 1) 
            {
                Kód, který se vykoná, pokud je logický výraz 1
                vyhodnocen jako pravdivý
            }
            else if (logický výraz 2)
            {
                Kód, který se vykoná, pokud je logický výraz 1
                vyhodnocen jako nepravdivý a zároveň je logický 
                výraz 2 vyhodnocen jako pravdivý
            }
            else if (logický výraz 3)
            {
                Kód, který se vykoná, pokud jsou logický výrazy 1 a 2
                vyhodnoceny jako nepravdivé a zároveň je logický 
                výraz 3 vyhodnocen jako pravdivý
            }
            ...
            ...
            ...
            else if (logický výraz N)
            {
                Příkazů else if může být 0..N
            }
            else
            {
                Pokud je definován příkaz else, tak se tento kód
                vykoná právě tehdy když jsou všechny výše uvedené
                logické výrazy vyhodnoceny jako nepravdivé
            }
            */

            // Zhodnocení znalostí cizích jazyků
            Console.Write("Kolik znate cizich jazyku? ");
            int pocetJazyku = Int32.Parse(Console.ReadLine());
            if (pocetJazyku == 0)
            {
                Console.WriteLine("Bylo by dobre se zacit ucit, alespon jeden cizi jazyk.");
            }
            else if (pocetJazyku == 1)
            {
                Console.WriteLine("Neni to spatne, ale doporucuji se zacit ucit dalsi.");
            }
            else if (pocetJazyku == 2)
            {
                Console.WriteLine("Velmi dobre! Cizi jazyky vam ocividne jdou");
            }
            else if ((pocetJazyku == 3) || (pocetJazyku == 4))
            {
                // Všimněte si možnosti využití logického operátoru ||
                // Tento kód se vykoná pokud je pravdivý logický výraz pocetJazyku == 3 
                // nebo pokud je pravdivý logický výraz pocetJazyku == 4
                Console.WriteLine("Vynikajici!");
            }
            else if (pocetJazyku > 4)
            {
                Console.WriteLine("Neuveritelne!");
            }
            else
            {
                Console.WriteLine("To se mi nejak nezda.");
            }
            Console.ReadKey();
        }
    }
}
