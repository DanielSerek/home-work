using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 8, 6, 4, 21 };
            int[] b = new int[a.Length];
            b = move(a);

            Console.ReadLine();
        }

        static int[] move(int[] arr)
        {
            int size = arr.Length;
            int[]x = new int[size];

            //Console.WriteLine(arr[^1]);  // This is because [^0] doesn't work 
            for (int i = 0; i < size; i++)
            {
                x[i]=arr[^(i + 1)]; 

                foreach (int num in x)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            return x;
        }
    }
}
