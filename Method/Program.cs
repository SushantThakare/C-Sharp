using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printA();

            printB("Sushant");//Sushant Value is a method Argument.

            string name = "Sumit";
            printB(name);//name is a method Argument.

            printC("Sushant", "Thakare");

            string fn = "Sumit";
            string ln = "Rokade";
            printC(fn, ln);

            string fullName = printD("Vrushabh", "Kawale");
            Console.WriteLine(fullName);

            printE(true);
            printE(false);

            int[] number = new int[] { 10, 20, 30 };
            printF(number);

            printF(null);
           

            Console.ReadLine();
        }

        static void printA()
        {
            Console.WriteLine("Method printA() Is Printed");
        }

        static void printB(string name)
        {
            Console.WriteLine($"Hello:{name}");
        }

        static void printC(string fn,string ln)
        {
            Console.WriteLine($"Hello:{fn} {ln}");
        }

        static string printD(string fn , string ln)
        {
            return fn +" " +ln;
        }

        static void printE(bool isConfirmed)
        {
            if (!isConfirmed)
            {
                Console.WriteLine($"PrintE()is not {isConfirmed}");
                return;
            }
            Console.WriteLine($"PrintE(){isConfirmed}");
        }

        static void printF(int[] numbers)
        {
            if (numbers!=null && numbers.Length > 0)
            {
                int sum = 0;
                for(int i = 0; i < numbers.Length; i++)
                {
                  sum+= numbers[i];
                }
                Console.WriteLine($"Sum of Array is{sum}");
            }
            else
            {
                Console.WriteLine("N0 Numbers To Add");
            }
        }
       
    }
}
