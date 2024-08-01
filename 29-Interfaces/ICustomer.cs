using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interfaces
{
    public interface ICustomer
    {
        void ShowsTiming();
      
    }
    public interface ICustomerV1:ICustomer
    {
        void PrintTicket();
    }

    public class SilverCustomer : ICustomerV1
    {
        public void PrintTicket()
        {
            Console.WriteLine(" SilverCustomer : PrintTicket()");
        }

        public void ShowsTiming()
        {
            Console.WriteLine(" SilverCustomer : ShowsTiming()");
        }
    }

    public class GoldCustomer :ICustomerV1
    {
        public void PrintTicket()
        {
            Console.WriteLine(" GoldCustomer : PrintTicket()");
        }

        public void ShowsTiming()
        {
            Console.WriteLine(" GoldCustomer : ShowsTiming()");
        }
    }
}
