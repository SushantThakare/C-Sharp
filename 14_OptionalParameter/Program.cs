using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_OptionalParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add(30, 70);

            add(b:50);

            sum(10, c:10);
            Console.ReadLine();
        }

        public static void add([Optional] int a,int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void sum (int a , [Optional]int b, int c)
        {
            Console.WriteLine($"{a} + {b} + {c} = {a+b+c}");
        }
    }
}
