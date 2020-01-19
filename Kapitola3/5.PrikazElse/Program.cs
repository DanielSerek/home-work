using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PrikazElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ukázka syntaxe příkazu else

            if (logický výraz) 
            {
                Kód, který se vykoná, pokud je logický výraz 
                vyhodnocen jako pravdivý
            }
            else
            {
                Kód, který se vykoná, pokud je logický výraz 
                vyhodnocen jako nepravdivý
            }
            */

            // Výpis podle zadaného věku s použitím příkazu else
            Console.Write("Zadejte svuj vek: ");
            int vek = Int32.Parse(Console.ReadLine());
            if (vek >= 18)
            {
                Console.WriteLine("Jste dospely");
            }
            else
            {
                Console.WriteLine("Nejste dospely");
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
            else
            {
                Console.WriteLine("To je skoda. Pizzu si nemuzete objednat");
            }

            // Pomocník s rozhodnutím co dělat ve volném čase
            Console.WriteLine("Mate penize? (ano/ne)");
            string mamPenize = Console.ReadLine();
            if (mamPenize == "ano")
            {
                Console.WriteLine("Hraji v kine zajimavy film? (ano/ne)");
                string zajimavyFilm = Console.ReadLine();
                if (zajimavyFilm == "ano")
                {
                    Console.WriteLine("Doporucuji jit do kina na film");
                }
                else
                {
                    Console.WriteLine("Doporucuji si pustit oblibeny film doma");
                }
            }
            else
            {
                Console.WriteLine("Je venku hezky? (ano/ne)");
                string hezkePocasi = Console.ReadLine();
                if (hezkePocasi == "ano")
                {
                    Console.WriteLine("Doporucuji jit se projit do parku");
                }
                else
                {
                    Console.WriteLine("Doporucuji si precist nejakou peknou knihu");
                }
            }
            Console.ReadKey();
        }
    }
}
