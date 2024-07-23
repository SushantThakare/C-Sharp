using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_MultipleClass_Inheritance_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();a.print();
            B b = new B();b.print();
            C c = new C();c.print();
            D d = new D();d.print();
           

            Console.ReadLine();
        }
    }
}
