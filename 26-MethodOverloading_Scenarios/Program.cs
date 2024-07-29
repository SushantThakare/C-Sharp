using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_MethodOverloading_Scenarios
{
    public class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Print();
            B b = new B();
            b.Print(10);
            b.Print();
            
            Console.ReadLine();

            
        }
    }

    public class A
    {
        public void Print()
        {
            Console.WriteLine("Print() Printed");
        }
    }

    public class B:A
    {
        public void Print(int a)
        {
            Console.WriteLine($"{a}:Print(int a) Printed");
        }
    }
}
