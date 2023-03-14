using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit = float.Parse(Console.ReadLine());
            float celsius = FtoC(fahrenheit);
            Console.WriteLine($"{fahrenheit}F = {celsius:f2}C");
        }

        private static float FtoC(float fahrenheit)
        {
            float celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
