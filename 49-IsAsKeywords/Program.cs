using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_IsAsKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C = new SilverCustomer();
            C.Print();
            Customer C1 = new GoldCustomer();
            C1.Print();

            SilverCustomer C2 = (SilverCustomer)C;
            C2.Print();
            //GoldCustomer C3 = (GoldCustomer)C1;
            //C3.Print();//possible

            //GoldCustomer C3 = (GoldCustomer)C;
            //C3.Print();//not possible
            //bool b1 = C is GoldCustomer;
            //Console.WriteLine(b1);
            //if (b1)
            //{
            //    GoldCustomer C3 = (GoldCustomer)C;
            //    C3.Print();
            //}
            //else
            //{
            //    Console.WriteLine("//not possible");
            //}
            GoldCustomer C3 =C as GoldCustomer;//if type caste not possible it returns null
            if (C3 != null)
            {
                C3.Print();
            }

            Console.ReadLine();
        }
    }

    public abstract class Customer
    {
        public abstract void Print();

    }
    public class SilverCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("SilverCustomer print() Called");
        }
    }

    public class GoldCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("GoldCustomer Print() Called");
        }
    }
}
