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
            // Připravíme si testovací data - studijní obory
            List<StudijniObor> obory = new List<StudijniObor>();
            obory.Add(new StudijniObor("Informacni technologie"));
            obory.Add(new StudijniObor("Automatizace ve vyrobe"));
            obory.Add(new StudijniObor("Elektrotechnika"));

            EvidencePrihlasek evidence = new EvidencePrihlasek(obory);

            // Hlavní menu aplikace
            int volbaHlavniMenu = 0;
            do
            {
                try
                {
                    // Vypíšeme hlavní menu aplikace
                    Console.WriteLine("\nHLAVNI MENU");
                    Console.WriteLine("\t1. Nova prihlaska");
                    Console.WriteLine("\t2. Vyhledani prihlasky");
                    Console.WriteLine("\t3. Vypis prihlasek");
                    Console.WriteLine("\t4. Konec programu");
                    Console.Write("\tVase volba: ");
                    volbaHlavniMenu = Int32.Parse(Console.ReadLine());
                    // Vybereme, kterou operaci provést
                    switch (volbaHlavniMenu)
                    {
                        // Vytvoření nové přihlášky
                        case 1:
                            evidence.VytvoritPrihlasku();
                            break;
                        // Vyhledání přihlášky podle kódu
                        case 2:
                            Console.Write("Zadejte kod hledane prihlasky: ");
                            string kod = Console.ReadLine();
                            Prihlaska prihlaska = evidence.VyhledejPrihlasku(kod);
                            if (prihlaska != null)
                            {
                                Console.WriteLine("Prihlaska nalezena: ");
                                prihlaska.VypisInformace();
                            }
                            else
                            {
                                Console.WriteLine("Prihlaska s kodem {0} nebyla nalezena", kod);
                            }
                            break;
                        // Výpis přihlášek podle studijního oboru
                        case 3:
                            StudijniObor obor = evidence.VybratObor();
                            List<Prihlaska> prihlasky = evidence.VyhledejPrihlasku(obor);
                            if (prihlasky.Count > 0)
                            {
                                foreach (Prihlaska p in prihlasky)
                                {
                                    Console.WriteLine("NALEZENE PRIHLASKY: ");
                                    p.VypisInformace();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nebyly nalezeny zadne prihlasky");
                            }
                            break;
                        // Aplikace bude ukončena, neprovedeme žádnou operaci
                        case 4:
                            break;
                        // Zadána volba mimo rozsah menu
                        default:
                            Console.WriteLine("Neznama volba");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Doslo k chybe pri volbe moznosti z menu.");
                    Console.WriteLine("Text chyby: {0}", e.Message);
                    volbaHlavniMenu = 0;
                }
            // Volba 4 = ukončení programu
            } while (volbaHlavniMenu != 4);
        }
    }
}
