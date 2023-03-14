using System;

namespace IntSign
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Въведи число: ");
            int a = int.Parse(Console.ReadLine());

            PrintSign(a);

        }
        static void PrintSign(int a)
        {
            if (a > 0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }
            else if (a < 0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
