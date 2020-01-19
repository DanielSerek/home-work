using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Cviceni2
{
    class Program
    {
        static void Main(string[] args)
        {
            ZOO zoo = new ZOO();               // Proč musím použít toto? Je to vytvoření nového prázdného objektu ZOO?

            int volbaMenu = 0;
            do
            {
                Console.WriteLine("HLAVNI MENU");
                Console.WriteLine("\t 1. Pridat zvire");
                Console.WriteLine("\t 2. Vypsat zvirata");
                Console.WriteLine("\t 3. Smazat zvire");
                Console.WriteLine("\t 4. Ukoncit program");
                volbaMenu = Int32.Parse(Console.ReadLine());

                switch (volbaMenu)
                {
                    case 1:
                        zoo.PridatZvire();     // Použití metody PridatZvire na objektu zoo
                        break;
                    case 2:
                        zoo.VypisZvirat();
                        break;
                    case 3:
                        zoo.SmazatZvire();
                        break;
                }

            } while (volbaMenu != 4);
        }
    }
}
