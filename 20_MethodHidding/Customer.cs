using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MethodHidding
{
    public class Customer
    {
        public void Print()
        {
            Console.WriteLine("Customer Print() method called");
        }
        public void PrintA()
        {
            Console.WriteLine("Customer PrintA() method called");
        }
    }

    public class SilverCustomer:Customer
    {
        new public void Print()
        {
            Console.WriteLine("SilverCustomer Print() method called");
        }

        //new public void PrintA()
        //{
        //    Console.WriteLine("SilverCustomer PrintA() method called");
        //}
         public void PrintB()
        {
            Console.WriteLine("SilverCustomer PrintB() method called");
        }
    }
}
