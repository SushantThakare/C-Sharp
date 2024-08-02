using _30_MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_MathLibraryClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To my Calculator App");
            Calculator c1 = new Calculator();
            Console.WriteLine("plz enter first number");
            int First= int.Parse(Console.ReadLine());
            Console.WriteLine("plz enter Second number");
            int Second = int.Parse(Console.ReadLine());
            c1.add(First,Second);
            Console.WriteLine("Thankyou for using calculator app");
            Console.ReadLine();
        }
    }

    public class X
    {
        void PrintX()
        {
            //A a = new A();
           //a.PrintA();
            Console.WriteLine("PrintX()");
        }
    }

   //// public class Y:A
   // {
   //     void PrintY()
   //     {
   //         A a = new A();
   //         //base.PrintA();
   //         Console.WriteLine("PrintX()");
   //     }
   // }
}
