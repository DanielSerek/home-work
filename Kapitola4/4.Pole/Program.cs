using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Zadejte 1. cislo: ");
            int cislo1 = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte 2. cislo: ");
            int cislo2 = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte 3. cislo: ");
            int cislo3 = Int32.Parse(Console.ReadLine());
            int soucet = cislo1 + cislo2 + cislo3;
            Console.WriteLine("Soucet cisel je {0}", soucet);
            Console.ReadKey();
            
            // Pole do kterého lze vložit 3 celá čísla. 
            // Indexy pole ke kterým lze přistoupit jsou 0..2
            int[] poleCisel = new int[3];
            // Pole do kterého lze vložit 5 řetězců. 
            // Indexy pole ke kterým lze přistoupit jsou 0..4
            string[] poleRetezcu = new string[5];
            
            int[] pole = new int[3];
            pole[0] = 100;
            pole[1] = 200;
            pole[2] = 300;

            string[] poleJmen = new string[4];
            poleJmen[0] = "Karel";
            // Není nutné vyplnit všechna místa v poli. Pokud 
            // na index 1 nic nevložíme tak tam bude uložen
            // prázdný řetězec ""
            poleJmen[2] = "Jana";
            poleJmen[3] = "Lucie";

            Console.WriteLine("pole[0]: {0}", pole[0]);
            Console.WriteLine("pole[1]: {0}", pole[1]);
            Console.WriteLine("pole[2]: {0}", pole[2]);

            Console.WriteLine("poleJmen[0]: {0}", poleJmen[0]);
            Console.WriteLine("poleJmen[2]: {0}", poleJmen[2]);
            Console.WriteLine("poleJmen[3]: {0}", poleJmen[3]);
            Console.ReadKey();
            

            int[] poleInt = new int[2];
            poleInt[0] = 7123;
            byte[] poleByte = new byte[2];
            poleByte[0] = 10;
            float[] poleFloat = new float[2];
            poleFloat[0] = 3.14f;
            string[] poleString = new string[2];
            poleString[0] = "Pavel";
            bool[] poleBoolean = new bool[2];
            poleBoolean[0] = true;

            Console.WriteLine("poleInt[0] = {0}", poleInt[0]);
            Console.WriteLine("poleInt[1] = {0}", poleInt[1]);

            Console.WriteLine("poleByte[0] = {0}", poleByte[0]);
            Console.WriteLine("poleByte[1] = {0}", poleByte[1]);

            Console.WriteLine("poleFloat[0] = {0}", poleFloat[0]);
            Console.WriteLine("poleFloat[1] = {0}", poleFloat[1]);

            Console.WriteLine("poleString[0] = {0}", poleString[0]);
            Console.WriteLine("poleString[1] = {0}", poleString[1]);

            Console.WriteLine("poleBoolean[0] = {0}", poleBoolean[0]);
            Console.WriteLine("poleBoolean[1] = {0}", poleBoolean[1]);
            Console.ReadKey();
        }
    }
}
