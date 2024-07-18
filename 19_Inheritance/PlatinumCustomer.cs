using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    internal class PlatinumCustomer:Customer
    {
        //public int TicketAmount;

        public PlatinumCustomer()
        {
            Console.WriteLine("PlatinumCustomer() Constructor called");
            TicketAmount = 350;
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
            Console.WriteLine("Platinum Ticket Printed \n ");
        }
    }
}
