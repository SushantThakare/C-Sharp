using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class GoldCustomer:Customer
    {
        //public int TicketAmount;

        public GoldCustomer()
        {
            Console.WriteLine("GoldCustomer() Constructor called");
            TicketAmount = 250;
        }

        //public void ShowsTiming()
        //{
        //    Console.WriteLine("*** All Shows Available ***");
        //}
        //public void GetTicketAmount()
        //{
        //  Console.WriteLine($"Ticket Amount is:-{TicketAmount}");
        //}
        public void PrintTicket()
        {
            Console.WriteLine("Gold Ticket Printed \n ");
        }
    }
}
