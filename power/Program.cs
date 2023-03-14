using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Въведи b: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine($"Степен: {PowerOf(a, p)}");
        }

        private static double PowerOf(int a, int p)
        {
            double result = Math.Pow(a, p);
            return result;
        }
    }
}
