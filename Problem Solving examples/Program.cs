using System;

namespace Problem_Solving_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(4));
            printInt1(100);

            Console.WriteLine("\n");
            int num = 4;
            Console.WriteLine("The sequence of moves in Tower of Hanoi are :\n");
            towerOfHanoi(num - 1, 'A', 'C', 'B');

        }

        // Tower of Hanoi
        public static void towerOfHanoi(int num, char src, char dst, char temp)
        {
            if (num < 1)
            {
                return;
            }

            towerOfHanoi(num - 1, src, temp, dst);
            Console.WriteLine("Move " + num + " disk from peg " + src + " to peg " + dst);
            towerOfHanoi(num - 1, temp, dst, src);
        }

        // rekurzivni metoda
        public static int factorial(int i)
        {
            if (i <= 1)
            {
                return i;
            }
            return i * factorial(i - 1);
        }

        public static void printInt1(int number)
        {
            char digit = (char)(number % 10 + '0');
            number = number / 10;
            if (number != 0)
            {
                printInt1(number / 10);
            }
            Console.WriteLine("%c" + digit);
          
        }

        

    
    }
}
