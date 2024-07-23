using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_MultipleClass_Inheritance_Problem
{
    public class A
    {
        public virtual void print()
        {
            Console.WriteLine("A");
        }
    }

    public class B : A
    {
        public override void print()
        {
            Console.WriteLine("B");
        }
    }

    public class C : A
    {
        public override void print()
        {
            Console.WriteLine("C");
        }
    }

    public class D : B
    {
      
    }
}
