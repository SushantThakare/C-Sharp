using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Inheritance
{
    public class Customer
    {
        public string Name = "Customer";
        public int TicketAmount;
        public Customer()
        {
            Console.WriteLine("Customer () Constructor called");
        }

        public Customer(string n)
        {
            Console.WriteLine($"public Customer(string n) Constructor called : {n}");
        }

        public void ShowsTiming()
        {
            Console.WriteLine("*** All Shows Available ***");
        }
        public void GetTicketAmount()
        {
            Console.WriteLine($"Ticket Amount is:-{TicketAmount}");
        }

    }
}
