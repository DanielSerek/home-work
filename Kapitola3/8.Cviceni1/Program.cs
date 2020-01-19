using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Cviceni1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Administrátorské údaje. Nechceme aby je bylo v programu možné změnit,
            // proto používáme konstanty. Není to samozřejmě nutné, ale proč si nepřipomenout
            // jak definovat konstanty když je poměrně příhodný okamžik
            const string loginAdmin = "admin";
            const string passwordAdmin = "csharp";

            Console.WriteLine("Vitejte v programu na procviceni podminek");
            Console.Write("Uzivatelske jmeno: ");
            string login = Console.ReadLine();
            Console.Write("Heslo: ");
            string password = Console.ReadLine();
            
            if (login == loginAdmin && password == passwordAdmin)
            {
                // Uživatel zadal správné jméno a heslo administrátora
                Console.WriteLine("Jste prihlasen jako administrator");
            }
            else if (login == loginAdmin && password != passwordAdmin)
            {
                // Uživatel zadal jméno administrátora, ale zadal špatné heslo
                Console.WriteLine("Neplatne prihlasovaci udaje administratora");
            }
            else
            {
                // Uživatel zadal libovolnou jinou kombinaci jména a hesla
                Console.WriteLine("Jste prihlasen jako uzivatel");
            }
            Console.ReadKey();
        }
    }
}
