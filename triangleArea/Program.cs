using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи а: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Въведи h: ");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine($"Лице: {Area(a,h)}");
        }
        static float Area(float a, float h)
        {
            float area = (a * h) / 2;
            return area;
        }
    }
}
