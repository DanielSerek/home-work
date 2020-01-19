using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TridaKonstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student pavel = new Student("Karel", "Novak", 1);
            Student petr = new Student("Jana", "Prochazkova", 1);
            Student anna = new Student("Josef", "Vyskocil", 2);
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
            /*  Klíčové slovo this reprezentuje objekt
                samotný, na kterém je metoda volána.
                V tomto případě je nutné jej použít, protože
                parametry metody (konstruktoru) se jmenují stejně
                jako proměnné v třídě Student   */

            /*  Pokud bychom jej nepouzili do proměnné jmeno 
                na instanci studenta by se nic neuložilo.
                Namísto toho by se do parametru jméno uložila
                jeho hodnota. Tedy by se vlastně nic nestalo. */

            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.rocnik = rocnik;

        }
    }
}
