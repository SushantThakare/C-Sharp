using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_AbstractKeyword
{
   public abstract class Customer
    {
        public  void ShowsTiming()
        {
            Console.WriteLine("*** All Shows Available ***");
        }

        public abstract void PrintTicket(); 
    }
}
