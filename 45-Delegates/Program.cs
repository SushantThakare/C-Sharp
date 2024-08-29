using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _45_Delegates
{
    public delegate void PrintDelegate(string a);
    public delegate string GetNameDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            // PrintA("Sushant");
            //PrintDelegate pd = new PrintDelegate(PrintA);
            //pd("Sushant");
            // GetNameDelegate gn = GetName;

            //PrintDelegate pd1 = PrintA;
            //PrintDelegate pd2 = PrintB;
            //PrintDelegate pd3 = PrintC;
            //PrintDelegate pd = pd1+pd2+pd3-pd2;
            //pd("Sushant");
            // Console.WriteLine(GetName());

            PrintDelegate pd = PrintA;
            pd += PrintB;
            pd += PrintC;
            pd("Sushant");
            Console.ReadLine();
        }

        static void PrintA(string a)
        {
            Console.WriteLine($"Hello {a}");
        }

        static void PrintB(string a)
        {
            Console.WriteLine($"Good {a}");
        }

        static void PrintC(string a)
        {
            Console.WriteLine($"Morning {a}");
        }

        static string GetName()
        {
            return "Sushant";
        }
    }
}
