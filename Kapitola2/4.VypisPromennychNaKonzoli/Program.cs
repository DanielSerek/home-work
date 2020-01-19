using System;

namespace VypisPromennychNaKonzoli
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 4;
            float z = 4;

            int soucet = x + y;
            Console.WriteLine("10 + 4 =");
            Console.WriteLine(soucet);
            
            int rozdil = x - y;
            Console.WriteLine("10 - 4 =");
            Console.WriteLine(rozdil);
            
            int soucin = x * y;
            Console.WriteLine("10 * 4 =");
            Console.WriteLine(soucin);

            int podilCeleCislo = x / y;
            Console.WriteLine("10 / 4 =");
            Console.WriteLine(podilCeleCislo);
            
            int zbytekPoCelociselnemDeleni = x % y;
            Console.WriteLine("10 % 4 =");
            Console.WriteLine(zbytekPoCelociselnemDeleni);

            float podilDesetinneCislo = x / z;
            Console.WriteLine("10 / 4.0 =");
            Console.WriteLine(podilDesetinneCislo);

            // Na závěr počkáme až uživatel stiskne klávesu
            Console.ReadKey();

             
 
            // Výpis bez odřádkování
            int prvniCislo = 7;
            int druheCislo = 3;
            int soucetDvouCisel = prvniCislo + druheCislo;
            Console.Write("7 + 3 = ");
            // Po vypsání výsledku odřádkujeme pro případ, že bychom vypisovali další informace
            Console.WriteLine(soucetDvouCisel);
            Console.ReadKey();
            
            // Výpis s dosazením hodnot do řetězce
            int cislo1 = 7;
            int cislo2 = 3;
            int soucetCisel = cislo1 + cislo2;
            Console.WriteLine("{0} + {1} = {2}", cislo1, cislo2, soucetCisel);
            Console.ReadKey();

            // Výpis bez odřádková a bez dosazení
            int a = 7;
            int b = 3;
            int soucetAB = a + b;
            Console.Write(a);
            Console.Write(" + ");
            Console.Write(b);
            Console.Write(" = ");
            // Poslední výpis uděláme pomoci WriteLine, abychom odřádkovali
            Console.WriteLine(soucetAB);
            Console.ReadKey();
        }
    }
}
