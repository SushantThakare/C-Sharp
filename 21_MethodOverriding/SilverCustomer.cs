using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _21_MethodOverriding
{
    public class SilverCustomer : Customer
    {
        public SilverCustomer(string fn, string ln) : base(fn, ln)
        {

        }

        public override void print()
        {
            Console.WriteLine($"{FirstName} {LastName} is a Silver Customer.");
        }

      
    }
    public class AdvancedSilverCustomer : SilverCustomer
    {
        public AdvancedSilverCustomer(string fn, string ln) : base(fn, ln)
        {

        }
        public override void print()
        {
            Console.WriteLine($"{FirstName} {LastName} is a Advanced-Silver Customer.");
        }
    }
}
