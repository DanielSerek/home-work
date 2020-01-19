using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TridaMetoda
{
    class Program
    {
        static void Main(string[] args)
        {
            Student pavel = new Student("Pavel", "Novak", 1);
            Student petr = new Student("Petr", "Prochazka", 1);
            Student anna = new Student("Anna", "Vyskocilova", 2);

            pavel.PredstavitSe();
            anna.PredstavitSe();
            petr.PredstavitSe();
            Console.ReadKey();

            Console.WriteLine("Pavel(4): {0}", pavel.ZhodnotitZnamku(4));
            Console.WriteLine("Petr(5): {0}", petr.ZhodnotitZnamku(5));
            Console.WriteLine("Anna(3): {0}", anna.ZhodnotitZnamku(3));
            Console.WriteLine("Anna(5): {0}", anna.ZhodnotitZnamku(5));
            Console.ReadKey();
        }
    }

    class Student
    {
        string jmeno;
        string prijmeni;
        int rocnik;

        // Konstruktor třídy Student
        public Student(string jmeno, string prijmeni, int rocnik)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.rocnik = rocnik;
        }

        public void PredstavitSe()
        {
            Console.WriteLine("Jmenuji se: {0} {1} a studuji v {2}. rocniku", jmeno, prijmeni, rocnik);
        }

        public string ZhodnotitZnamku(int znamka)
        {
            if((znamka < 1)||(znamka > 5))
            {
                return "Takovou znamku neumim zhodnotit.";
            }
            // Všimněte si, že v metodě používáme jak proměnnou znamka (parametr metody)
            // tak i proměnnou rocnik ze třídy Student
            if(rocnik > 1)
            {
                if (znamka < 5)
                {
                    return "Hlavni je ze to neni petka";
                }
                else
                {
                    return "To je spatne, ale vzdycky se da neco delat a zlepsit se";
                }
            }
            else
            {
                return "Zatim jsem v prvnim rocniku, jeste se rozkoukavam";
            }
        }
    }
}
