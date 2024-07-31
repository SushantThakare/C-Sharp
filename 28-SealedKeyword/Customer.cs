using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_SealedKeyword
{
    public  class Customer
    {
        public virtual void print()
        {
            Console.WriteLine("Customer print() called");
        }
    }

    public class Silver:Customer
    {
        public override void print()
        {
           Console.WriteLine("Silver print() called");
        }
       
    }

    public class AdvancedSilver:Silver
    {
        public override void print()
        {

            Console.WriteLine("AdvancedSilver print() called");
        }
    }
}
