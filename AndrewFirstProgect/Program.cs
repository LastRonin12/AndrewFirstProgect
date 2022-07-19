using System;

namespace AndrewFirstProgect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programm started again");
            int n = 6;
            Console.WriteLine($"n={n}");
            int[] ar = { 1,2,3,4,5,6 };
            for (int i = 0; i < n; i++)
            {
                if (ar[i]% 2 == 0)
                {
                    Console.WriteLine($"ar={ar[i]}");
                }                

            }
        }
    }
}
