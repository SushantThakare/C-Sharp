using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class SilverCustomer:Customer
    {
        //public int TicketAmount;

        public string name = "silver customer";
        //public SilverCustomer()
        //{
        //    Console.WriteLine("SilverCustomer() Constructor called");
        //    TicketAmount = 150;
        //    Console.WriteLine($"Name from current class {this.Name}");
        //    Console.WriteLine($"Name from current class {base.Name}");

        //}
        public SilverCustomer(string name) :base(name)
        {
            Console.WriteLine($"Inside public SilverCustomer(string name) : {name}");
        }


        //public void ShowsTiming()
        //{
        //    Console.WriteLine("*** All Shows Available ***");
        //}

        //public void GetTicketAmount()
        //{
        //    Console.WriteLine($"Ticket Amount is:-{TicketAmount}");
        //}
        public void PrintTicket()
        {
            Console.WriteLine("Silver Ticket Printed \n ");
        }
    }
}
