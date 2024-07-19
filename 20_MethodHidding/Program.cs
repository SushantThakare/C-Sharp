using _20_MethodHidding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer();
            //c1.Print();
            //c1.PrintA();
            //Console.WriteLine();

            //SilverCustomer sc = new SilverCustomer();
            //sc.Print();
            //sc.PrintA();
            //sc.PrintB();
            //Console.WriteLine();

            //Customer c2 = new SilverCustomer();
            //c2.Print();
            //c2.PrintA();
            //((SilverCustomer)c2).PrintB();

            A a1 = new A();
            a1.Print();
            Console.WriteLine();
            B b1 = new B();
            b1.Print();
            Console.WriteLine();
            C c1 = new C();
            c1.Print();
            Console.WriteLine();
            Console.WriteLine();


            A a2 = new B();
            a2.Print();
            Console.WriteLine();
            A a3 = new C();
            a3.Print();

            Console.ReadLine();
        }

        public class A
        {
            public void Print()
            {
                Console.WriteLine("A");
            }
        }

        public class B : A
        {
            new public void Print()
            {
                Console.WriteLine("B");
            }
        }
        public class C : B
        {
            new public void Print()
            {
                Console.WriteLine("C");
            }
        }
    }
}
