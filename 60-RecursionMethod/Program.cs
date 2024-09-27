using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_RecursionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 5;//5*4*3*2*1=120
            //int factorial = 1;

            //for(int i = num; i> 0; i--)
            //{
            //    factorial *= i;

            //}
            //Console.WriteLine(factorial);
            //factorial(5);
            Console.WriteLine(factorial(8));

            //Fibonacci series = 1 1 2 3 5 8 13 21
            int FirstNumber = 1;
            int SecondNumber = 2;
            List<int> num = new List<int>();
            num.Add(FirstNumber);
            num.Add(SecondNumber);
            for (int i = 0; i <= 10; i++)
            {
              
               int ThirstNumber = FirstNumber + SecondNumber;
                num.Add(ThirstNumber);
                FirstNumber = SecondNumber;
                SecondNumber = ThirstNumber;    
            }
            foreach(int items in num)
            {
                Console.WriteLine($"{items} ");
            }
            Console.ReadLine();


        }
        static int factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * factorial(num - 1);
        }
    }
}
