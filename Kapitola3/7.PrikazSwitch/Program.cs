using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PrikazSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Syntaxe příkazu switch
            
             switch (proměnná nebo výraz)
             {
                case hodnota1:
                     Příkazy provedené pokud výraz odpovídá hodnotě 1    
                    break;
                case hodnota2:
                     Příkazy provedené pokud výraz odpovídá hodnotě 2    
                    break;
                ...  
                ...  
                ...
                case hodnotaN:
                     Příkazy provedené pokud výraz odpovídá hodnotě 3
                    break;
                  
                default: (nepovinný – není nutné jej vždy uvést)
                     Příkazy provedené pokud výraz neodpovídal ani jedné hodnotě u case
                    break;
             }
             */

            // Ukázka použití příkazu switch
            Console.Write("Zadejte prvni cislo: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte druhe cislo: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte pozadovanou operaci ( + - * / ): ");
            string operace = Console.ReadLine();

            switch (operace)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                    break;
                case "/":
                    Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
                    break;
                default:
                    Console.WriteLine("Byla zadana neznama operace.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
