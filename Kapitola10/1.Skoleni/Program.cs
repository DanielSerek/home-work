using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Skoleni
{
    class Program
    {
        static void Main(string[] args)
        {
            SpravaSkoleni spravaSkoleni = new SpravaSkoleni();
            spravaSkoleni.NacistZamestnance();
            spravaSkoleni.NacistSkoleni();

            int volba = 0;
            while (volba != 3)
            {
                volba = ZobrazVyberMenu("Hlavní menu", new string[] { "Nové školení", "Seznam školení", "Ukončit program", "Vypsat ladící info" });
                switch (volba)
                {
                    case 1:
                        spravaSkoleni.NoveSkoleni();
                        break;
                    case 2:
                        Skoleni vybraneSkoleni = spravaSkoleni.VybratSkoleni();
                        if (vybraneSkoleni != null)
                        {
                            int volbaDetailSkoleni = 0;
                            while (volbaDetailSkoleni != 6)
                            {
                                spravaSkoleni.ZobrazDetailSkoleni(vybraneSkoleni);
                                if (vybraneSkoleni.Uzavreno)
                                {
                                    Console.WriteLine("! Školení je uzavřené a nelze s ním provést žádnou operaci. Pro návrat zpět stiskněte libovolnou klávsesu !");
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    volbaDetailSkoleni = ZobrazVyberMenu("Školení", new string[] { "Přihlásit studenta","Odhlásit studenta","Přiřadit lektora",
                                    "Odebrat lektora","Uzavřít školení","Zpět na hlavní menu"});
                                    switch (volbaDetailSkoleni)
                                    {
                                        case 1:
                                            spravaSkoleni.PrihlasitStudenta(vybraneSkoleni);
                                            break;
                                        case 2:
                                            spravaSkoleni.OdhlasitStudenta(vybraneSkoleni);
                                            break;
                                        case 3:
                                            spravaSkoleni.PriraditLektora(vybraneSkoleni);
                                            break;
                                        case 4:
                                            spravaSkoleni.OdebratLektora(vybraneSkoleni);
                                            break;
                                        case 5:
                                            spravaSkoleni.UzavritSkoleni(vybraneSkoleni);
                                            break;
                                    }
                                }
                            }
                        }
                        break;
                    case 4:
                        spravaSkoleni.VypisLadiciInfo();
                        break;
                }
            }
            Console.ReadKey();
        }

        static int ZobrazVyberMenu(string nadpis, string[] polozkyMenu)
        {
            int volba = 0;
            Console.WriteLine("* MENU - {0} *", nadpis);
            while (volba <= 0 || volba > polozkyMenu.Length + 1)
            {
                for (int i = 0; i < polozkyMenu.Length; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, polozkyMenu[i]);
                }
                Console.Write("Vase volba: ");
                volba = Int32.Parse(Console.ReadLine());
            }
            return volba;
        }
    }
}
