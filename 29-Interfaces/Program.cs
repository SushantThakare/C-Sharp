using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ICustomerV1 c1 = new SilverCustomer();
            // c1.ShowsTiming();
            // c1.PrintTicket();
            // c1=new GoldCustomer();
            // c1.ShowsTiming();
            // c1.PrintTicket();
            // Console.WriteLine();
            // SilverCustomer c2 = new SilverCustomer();
            // c2.ShowsTiming();

            //ICustomer c3 = new GoldCustomer();
            // c3.ShowsTiming();

            //ICustomerV1[] customer = new ICustomerV1[2];
            //customer[0] = new SilverCustomer();
            //customer[1] = new GoldCustomer();

            //for(int i=0; i < customer.Length; i++)
            //{
            //    customer[i].ShowsTiming();
            //    customer[i].PrintTicket();
            //}

            A a = new A();
            a.printA();
            a.printB();
            //a.Print();
            ((IA)a).Print();
            ((IB)a).Print();
            Console.WriteLine();
            IA ia = new A();
            ia.printA();
            ia.Print();
            IB ib = new A();
            ib.printB();
            ib.Print();

            Console.ReadLine();
        }
    }
}
