using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ConditionalStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            i = 30;


            switch (i)
            {
                case 10:
                    Console.WriteLine($"{i} is Ten");
                    break;
                    case 20:
                    Console.WriteLine($"{i} is Twenty");
                    break;
                    case 30:
                    Console.WriteLine($"{i} is thirty");
                        break;
                default:
                    Console.WriteLine("Not Match");
                        break;
            }

            //if (i == 10)
            //{
            //    Console.WriteLine($"{i} is Ten");
            //}
            //else if (i == 20)
            //{
            //    Console.WriteLine($"{i} is Twenty");
            //}
            //else if(i==30)
            //{
            //    Console.WriteLine($"{i} is Thirty");
            //}
            //else
            //{
            //    Console.WriteLine($"{i} is not Ten Twenty or Thirty");
            //}


            //string result = (i == 10) ? "Ten" : "Not Ten";
            //Console.WriteLine($"{i} is {result}");
            //if (i == 10)
            //{
            //    Console.WriteLine($"{i} is Ten");
            //}
            //else {
            //    Console.WriteLine($"{i} is not Ten");
            //}

            Console.ReadLine();
        }
    }
}
