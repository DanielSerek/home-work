using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PrikazIf
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ukázka syntaxe příkazu if

            if (logický výraz) 
            {
                Kód, který se vykoná, pokud je logický výraz 
                vyhodnocen jako pravdivý
            }
            */

            // Ukázka základního použití příkazu if
            
            int x = 4;
            int y = 5;
            
            if (x > y)
            {
                Console.WriteLine("Tento text nebude vypsan");
            }

            if (x < y)
            {
                Console.WriteLine("Tento text bude vypsan");
            }
            
            // Výpis podle zadaného věku
            Console.Write("Zadejte svuj vek: ");
            int vek = Int32.Parse(Console.ReadLine());
            if (vek >= 18)
            {
                Console.WriteLine("Jste dospely");
            }
            if (vek < 18)
            {
                Console.WriteLine("Nejste dospely");
            }
            Console.ReadKey();
            
            // Jednoduchá kalkulačka
            Console.Write("Zadejte prvni cislo : ");
            int cislo1 = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte druhe cislo : ");
            int cislo2 = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte + nebo - : ");
            string operace = Console.ReadLine();
            if (operace == "+")
            {
                Console.WriteLine("{0} + {1} = {2}", cislo1, cislo2, cislo1 + cislo2);
            }
            if (operace == "-")
            {
                Console.WriteLine("{0} - {1} = {2}", cislo1, cislo2, cislo1 - cislo2);
            }
            Console.ReadKey();

            // Pizzerie
            Console.WriteLine("Kolik mate u sebe penez?");
            int penize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kolik stoji vase oblibena pizza?");
            int cenaPizzy = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ma pizzerie otevreno? (ano/ne)");
            string pizzerieOtevreno = Console.ReadLine();

            if ((penize >= cenaPizzy) && (pizzerieOtevreno == "ano"))
            {
                Console.WriteLine("Skvele. Muzete si objednat vasi oblibenou pizzu");
            }
            // Mohlo by být zapsáno i jiným způsobem. My jsme zvolili negaci předchozího výrazu
            if (!((penize >= cenaPizzy) && (pizzerieOtevreno == "ano")))
            {
                Console.WriteLine("To je skoda. Pizzu si nemuzete objednat");
            }
        }
    }
}
