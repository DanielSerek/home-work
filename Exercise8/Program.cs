using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "This is a test";
            string q = "esa";

            Console.WriteLine($"The first string: {input}");
            Console.WriteLine($"The second string: {q}");


            Console.WriteLine("The position is: {0}", input.IndexOf(q));

        }
    }
}
