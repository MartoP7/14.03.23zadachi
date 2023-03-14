using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char running = 'Y';
            while (running == 'Y')

            {   Console.Write("Вид/int,char,string/: ");
                string type = Console.ReadLine().ToLower();

                if (type == "int")
                {
                    Console.WriteLine("Въведете две числа с разделител 'SPACE'");
                    List<int> intL = Console.ReadLine().Split().Select(int.Parse).ToList();
                    int biggest = intL.Max();
                    Console.WriteLine(biggest);
                }
                else if (type == "char")
                {
                    Console.WriteLine("Въведете две букви с разделител 'SPACE'");
                    List<char> charL = Console.ReadLine().Split().Select(char.Parse).ToList();
                    int biggest = charL.Max();
                    Console.WriteLine(((char)biggest));
                }
                else if (type == "string")
                {
                    Console.WriteLine("Въведете две думи с разделител 'SPACE'");
                    List<string> stringL = Console.ReadLine().Split().ToList();
                    string biggest = stringL.Max();
                    Console.WriteLine(biggest);
                }
                else
                {
                    Console.WriteLine("Err: Not a type");
                    return;
                }

                Console.WriteLine("Do you want to continue?(Y/N)");
                running = char.Parse(Console.ReadLine().ToUpper());
                Console.Clear();
            }

        }
    }
}
