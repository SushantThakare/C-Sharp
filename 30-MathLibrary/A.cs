using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_MathLibrary
{
    internal class A
    {
       protected void PrintA()
        {
            Console.WriteLine("PrintA()");
        }
        void print()
        {
            PrintA();
        }
    }
    internal class B:A
    {
        private void PrintB()
        {
            A a = new A();
            //a.print();
           //a.PrintA();
            base.PrintA();
        }
    }

    public class C
    {
        private void PrintC()
        {
            A a = new A();
            
            //a.print();
            //a.PrintA();
        }
    }
}
