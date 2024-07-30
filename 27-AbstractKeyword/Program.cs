using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_AbstractKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SilverCustomer sc = new SilverCustomer();
            sc.ShowsTiming();
            sc.PrintTicket();
            Console.WriteLine();

            GoldCustomer gc = new GoldCustomer();
            gc.ShowsTiming();
            gc.PrintTicket();
            Console.WriteLine();

           

            Console.ReadLine();
        }
    }
}
