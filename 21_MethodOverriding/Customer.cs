using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MethodOverriding
{
    public class Customer
    {
        public string FirstName;
        public string LastName;

        public Customer(string fn, string ln)
        {
            FirstName= fn;
            LastName= ln;
        }

        public virtual void print()
        {
            Console.WriteLine($"{FirstName} {LastName} is a Normal Customer.");
        }
    }
}
