using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Cviceni3
{
    class Program
    {
        static void Main(string[] args)
        {
            ZOO zoo = new ZOO();

            int volbaMenu = 0;
            do
            {
                Console.WriteLine("HLAVNI MENU");
                Console.WriteLine("\t 1. Pridat zvire");
                Console.WriteLine("\t 2. Vypsat zvirata");
                Console.WriteLine("\t 3. Smazat zvire");
                Console.WriteLine("\t 4. Upravit zvire");
                Console.WriteLine("\t 5. Ukoncit program");
                volbaMenu = Int32.Parse(Console.ReadLine());

                switch (volbaMenu)
                {
                    case 1:
                        zoo.PridatZvire();
                        break;
                    case 2:
                        zoo.VypisZvirat();
                        break;
                    case 3:
                        zoo.SmazatZvire();
                        break;
                    case 4:
                        zoo.UpravitZvire();
                        break;
                }

            } while (volbaMenu != 5);
        }
    }
}
