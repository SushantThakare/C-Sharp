using _30_MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_MathLibraryClient2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To my Calculator App");
            Calculator c1 = new Calculator();
            c1.add(10,20);
            Console.WriteLine("Thankyou for using calculator app");
            Console.ReadLine();
        }
    }
}
