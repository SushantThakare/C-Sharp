using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.print();
            cal.print(10);
            int i = 20;
            cal.print(ref i);
            int result;
            cal.print(50,2,out result);
            cal.print(10,20);
            cal.print("Sushant");
            cal.print("Sushant",1);
            cal.print(1,"Sushant");

            short s = 10;
            int i1 = 10;
            cal.print(10);
            cal.print(s);
            Console.ReadLine();
        }
    }
}
