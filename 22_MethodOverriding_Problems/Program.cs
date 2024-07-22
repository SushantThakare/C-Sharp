using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_MethodOverriding_Problems
{
        internal class Program
        {
            static void Main(string[] args)
            {
                A a=new A(); a.Print();
                A a1=new B(); a1.Print();
                A a2=new C(); a2.Print();//late binding of virtual
                B b=new C(); b.Print();
                Console.ReadLine();
            }
        }
}
