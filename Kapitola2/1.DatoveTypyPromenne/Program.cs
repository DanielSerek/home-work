namespace DatoveTypyPromenne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Toto je jednořádkový komentář

            /*
             * To je víceřádkový komentář
             * To je víceřádkový komentář
             * To je víceřádkový komentář
             */

            /*
             * Deklarace proměnných. Přiřazení hodnot pomocí symbolu =
             */ 
            byte pocetTestu = 7;
            int pocetObyvatel = 10580456;
            float slevaProPartnery = 11.5f;
            string jmenoStudenta = "Pavel";

            /*
             * Vhodné pojmenování proměnných a ukázky přiřazování hodnot
             */
            //int 1cislo = 7555; // Toto je špatně. Název proměnné nesmí začínat číslicí
            byte pocetDeti = 3; // Všimněte si, že druhé slovo začíná velkým písmenem
            float celkovemzdovenakladyoddeleni = 180900f; // Toto je špatně čitelné
            float celkoveMzdoveNakladyOddeleni = 180900f; // Vhodnější název proměnné

            // Definujeme proměnnou, ale zatím jsme ji nepřiřadili hodnotu
            int pocetZamestnancu;
            // Do již existující proměnné přiřadíme hodnotu
            pocetZamestnancu = 36;
            // Hodnotu proměnné můžeme v průběhu programu měnit
            pocetZamestnancu = 39;
            // Proměnná pocetZamestnancu je typu int (celé číslo). Toto je tedy špatně:
            // pocetZamestnancu = 35.4f;
            // Proměnná byla již definována s typem int. Toto je tedy špatně:
            // float pocetZamestnancu = 39.5;

            /*
             * Konstanty
             */ 
            // Definujeme konstantu, její hodnotu nelze během programu měnit
            const float koeficient = 1.75f;
            // Toto je špatně:
            //koeficient = 2.1;

        }
    }
}
