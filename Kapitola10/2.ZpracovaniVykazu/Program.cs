using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ZpracovaniVykazu
{
    class Program
    {
        static void Main(string[] args)
        {
            SpravaVykazu spravaVykazu = new SpravaVykazu();
            spravaVykazu.ZpracovatVykazy();

            int volba = 0;
            while (volba != 6)
            {
                volba = ZobrazVyberMenu("Hlavní menu", new string[] { "Projekty - celkové odpracované hodiny",
                    "Zaměstnanci - celkové odpracované hodiny", "Hodiny celkem","Projekt - detail","Zaměstnanec - detail",
                    "Ukončit program" });
                switch (volba)
                {
                    case 1:
                        spravaVykazu.ReportProjektyCelkoveHodiny();
                        break;
                    case 2:
                        spravaVykazu.ReportZamestnanciCelkoveHodiny();
                        break;
                    case 3:
                        spravaVykazu.ReportCelkemHodin();
                        break;
                    case 4:
                        spravaVykazu.ReportProjekt();
                        break;
                    case 5:
                        spravaVykazu.ReportZamestnanec();
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
