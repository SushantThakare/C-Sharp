using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_GenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {//    public delegate bool Predicate<in T>(T obj);
         // Predicate<int> pd = Method1;
         //  bool b1 = pd(10);
         //bool b2= pd(20);
         // Console.WriteLine($"{b1} {b2}");

            // Predicate<string> pd1 = Method2;
            // bool b3 = pd1("Sushant");
            // Console.WriteLine(b3);
            // bool b4 = pd1("Susha");
            // Console.WriteLine(b4);
            // //    public delegate void Action<in T>(T obj);
            // Action<string> ac = Print;
            //ac("Shifa");
            // Action<string,string,int> ac2 = Print1;
            // ac2("Sushant", "Shifa", 143);
            // Action ac3= Print2;
            // ac3();

            //    Func<string, int> fc = printA;
            //    int i = fc("Sushant");
            //    Console.WriteLine(i);

            //    Func<int, int, int> fc2 = Add;
            //    i = fc2(10, 30);
            //    Console.WriteLine(i);
            //    Func<int, int, int> fc3 = delegate (int a, int b)
            //{
            //    return a + b;
            //};
            //    i = fc3(10, 50);
            //    Console.WriteLine(i);

            //Predicate<string> p = delegate (string s)
            //{
            //    return s.Length > 3 ? true : false;
            //};
            //bool b = p("om");
            //Console.WriteLine(b);
            //b = p("seth");
            //Console.WriteLine(b);

            //Action<string, string> ac = delegate (string s1, string s2)
            //{
            //    Console.WriteLine($"{s1},{s2}");
            //};
            //ac("Sushant", "Shifa");

            Func<string, string, string> fc = delegate (string s1, string s2)
            {
                return s1 + s2;
            };
            string s = fc("SUS", "HANT");
            Console.WriteLine(s);
            Console.ReadLine();
        }

        static bool Method1(int i)
        {
            return i % 2 == 0 ? true : false;
        }

        static bool Method2(string s)
        {
            return s.Length == 5 ? true : false;
        }

        static void Print(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
        static void Print1(string s1, string s2, int i)
        {
            Console.WriteLine($"{s1}:{s2}:{i}");
        }

        static void Print2()
        {
            Console.WriteLine("print2() called");
        }

        static int printA(string s)
        {
            return s.Length;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
