using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer c = new Customer("Vrushabh","Kawale");
            //c.print();
            //Console.WriteLine();
            //SilverCustomer sc = new SilverCustomer("Sushant","Thakare");
            //sc.print();
            //Console.WriteLine();
            //Customer c1 = new SilverCustomer("Akash","Polkar");
            //c1.print();
            //Console.WriteLine();
            //Customer c2 = new GoldCustomer("Pravin", "Namane");
            //c2.print();
            //Console.WriteLine();

            Customer[] customers = new Customer[]
            {
             new Customer("Vrushabh","Kawale"),
             new SilverCustomer("Sushant","Thakare"),
             new GoldCustomer("Pravin", "Namane"),
             new AdvancedSilverCustomer("Shifa","Malani")
            };

            for(int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine(i);
                customers[i].print();
              
            }
            Console.ReadLine();
        }
    }
}
