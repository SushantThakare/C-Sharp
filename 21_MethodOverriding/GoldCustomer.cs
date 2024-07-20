using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MethodOverriding
{
    internal class GoldCustomer:Customer
    {
        public GoldCustomer(string fn,string ln):base(fn, ln) 
        {
          
        }

        public override void print()
        {
            Console.WriteLine($"{FirstName} {LastName} is a Gold Customer.");
        }
    }
}
