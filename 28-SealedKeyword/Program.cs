using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_SealedKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.print();
            Customer c2 = new Silver();
            c2.print();
            Customer c3 = new AdvancedSilver();
            c3.print();
            Console.ReadLine();
        }
    }

}
