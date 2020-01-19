using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Kolekce
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření nového listu, který může obsahovat celá čísla
            List<int> listCisel = new List<int>();
            // Vytvoření nového listu, který může obsahovat řetězce
            List<string> listRetezcu = new List<string>();
            // Vytvoření nového listu, který může obsahovat objekty typu Auto
            List<Auto> listAut = new List<Auto>();

            // Přidání prvků do listu
            listCisel.Add(100);
            listCisel.Add(200);
            listCisel.Add(300);

            listRetezcu.Add("Pavel");
            listRetezcu.Add("Anna");

            Auto auto1 = new Auto("Modre auto");
            Auto auto2 = new Auto("Cervene auto");
            Auto auto3 = new Auto("Zelene auto");
            Auto auto4 = new Auto("Cerne auto");

            listAut.Add(auto1);
            listAut.Add(auto2);
            listAut.Add(auto4);
            
            // Zjištění zdali list obsahuje daný prvek
            Console.Write("listCisel.Contains(101): ");
            Console.WriteLine(listCisel.Contains(101));
            Console.Write("listAut.Contains(auto2): ");
            Console.WriteLine(listAut.Contains(auto2));
            Console.Write("listAut.Contains(auto3): ");
            Console.WriteLine(listAut.Contains(auto3));

            // Výpis počtu prvků v listu
            Console.Write("listRetezcu.Count: ");
            Console.WriteLine(listRetezcu.Count);
            
            // Získání prvku z listu pomocí indexu
            int prvniCislo = listCisel[0];
            string druhyRetezec = listRetezcu[1];


            // Odstranění prvku z listu
            listAut.Remove(auto1);
            listCisel.Remove(100);

            // Odstranění prvku na daném indexu
            listAut.RemoveAt(0);
            listCisel.RemoveAt(1);

            // Ukázka použití cyklu ve spojení s listem
            Console.WriteLine("Vypis cisel");
            foreach (int cislo in listCisel)
            {
                Console.WriteLine(cislo);
            }

            Console.WriteLine("Vypis aut");
            for (int i = 0; i < listAut.Count; i++)
            {
                Console.WriteLine(listAut[i].Nazev);
            }

            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Nazev { get; set; }

        public Auto(string nazev)
        {
            Nazev = nazev;
        }
    }
}
