using System;

namespace _2.MetodaNavratovaHodnota
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seznamZnamek = ZiskejZnamky();
            Console.WriteLine("Zadane znamky: ");

            for (int i = 0; i < seznamZnamek.Length; i++)
            {
                Console.Write("{0} ", seznamZnamek[i]);
            }
            Console.ReadKey();
        }



        static int [] ZiskejZnamky()
        {
            Console.Write("Zadejte pocet zadavanych znamek: ");
            int pocetZnamek = Int32.Parse(Console.ReadLine());
            int[] znamky = new int[pocetZnamek];
            for (int i = 0; i < pocetZnamek; i++)
            {
                Console.Write("{0}. znamka: ", i + 1);
                znamky[i] = Int32.Parse(Console.ReadLine());
            }
            return znamky;
        }
    }
}
