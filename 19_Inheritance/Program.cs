using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
        //    SilverCustomer sc1 = new SilverCustomer();
        //    sc1.ShowsTiming();
        //    sc1.GetTicketAmount();
        //    sc1.PrintTicket();

        //    GoldCustomer gc1 = new GoldCustomer();
        //    gc1.ShowsTiming();
        //    gc1.GetTicketAmount();
        //    gc1.PrintTicket();

        //    PlatinumCustomer pc1 = new PlatinumCustomer();
        //    pc1.ShowsTiming();
        //    pc1.GetTicketAmount();
        //    pc1.PrintTicket();

        //    Customer c = new SilverCustomer();
            //SilverCustomer sc=(SilverCustomer)new Customer(); not possible run time error

            //constructor based:-
            //Customer c1 =new Customer();
            //Console.WriteLine();
            Customer c2= new SilverCustomer("Silver");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
