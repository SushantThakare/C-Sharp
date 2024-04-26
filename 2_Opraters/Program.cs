using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Opraters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 20;
            
            Console.WriteLine(i++);
            Console.WriteLine(i);
            Console.WriteLine(++i);
            i += 5;
            Console.WriteLine(i);
            i -= 7;
            Console.WriteLine(i);
            i /= 2;
            Console.WriteLine(i);
            bool result = i == j;
            Console.WriteLine(result);
            bool result2 = i != j;
            Console.WriteLine(result2);

            result =i<j;
            Console.WriteLine(result);
            result = i > j;
                Console.WriteLine(result);
          
            Console.ReadLine();
        }
    }
}
