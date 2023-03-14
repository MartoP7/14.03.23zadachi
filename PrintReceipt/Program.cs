using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PrintReceipt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RHeader();
            RBody();
            RFooter();
        }

        private static void RFooter()
        {
            Console.WriteLine("------------------------------\n\u00A9 SoftUni");
        }

        private static void RBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }

        private static void RHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
    }
}
