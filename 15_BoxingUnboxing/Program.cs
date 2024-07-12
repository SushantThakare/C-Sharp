using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine(i);
            //Boxing
            object obj = i;
            Console.WriteLine(obj);
            //UnBoxing
            int j = (int)obj;
            Console.WriteLine(j);



            Console.ReadLine();
        }
    }
}
