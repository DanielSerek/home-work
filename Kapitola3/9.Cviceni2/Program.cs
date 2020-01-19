using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Cviceni2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nejdříve vypíšeme kategorie jídelního lístku
            Console.WriteLine("*** Vitejte v nasi restauraci ***");
            Console.WriteLine("Vyberte prosim z nasledujici nabidky:");
            Console.WriteLine("1. Polevky");
            Console.WriteLine("2. Predkrmy");
            Console.WriteLine("3. Hlavni jidla");
            Console.WriteLine("4. Dezerty");
            Console.WriteLine("5. Napoje");
            Console.Write("Vybrana moznost (1..5): ");
            // Necháme uživatele vybrat z menu pomocí čísel 1..5
            // nechceme, aby musel vypisovat celé názvy. Jednak
            // by to bylo, pracé, ale především by se mohl snadno 
            // přepsat.
            int vybranaKategorie = Int32.Parse(Console.ReadLine());
            
            // Pomocí příkazu switch vyhodnotime vybranou kategorie
            // a vykonáme příslušný kód programu
            switch (vybranaKategorie)
            {
                case 1:
                    Console.WriteLine("POLEVKY: ");
                    Console.WriteLine("1. Domaci vyvar s nudlemi");
                    Console.WriteLine("2. Gulasova v chlebu");
                    break;
                case 2:
                    Console.WriteLine("PREDKRMY: ");
                    Console.WriteLine("1. Sunkova role s krenem");
                    Console.WriteLine("2. Topinka s pikantni smesi");
                    break;
                case 3:
                    Console.WriteLine("HLAVNI JIDLA: ");
                    Console.WriteLine("1. Kureci rizek s bramborem");
                    Console.WriteLine("2. Svickova s knedlikem");
                    Console.WriteLine("3. Knedlo zelo vepro");
                    break;
                case 4:
                    Console.WriteLine("DEZERTY: ");
                    Console.WriteLine("1. Zmrzlinovy pohar");
                    Console.WriteLine("2. Jablecny zavin");
                    break;
                case 5:
                    Console.WriteLine("NAPOJE: ");
                    Console.WriteLine("1. Sodovka");
                    Console.WriteLine("2. Mineralni voda");
                    Console.WriteLine("3. Jablecny dzus");
                    Console.WriteLine("4. Pivo 10°");
                    Console.WriteLine("5. Turecka kava");
                    break;
                default:
                    Console.WriteLine("Neznama volba");
                    break;
            }
            Console.ReadKey();
        }
    }
}
