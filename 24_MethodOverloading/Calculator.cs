using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_MethodOverloading
{
   public class Calculator
    {
        public void print()
        {
            Console.WriteLine("print() called");
        }
        //public int print()//not possible 
        //{
        //    Console.WriteLine("print() called");
        //    return 10;
        //}
        public void print(int num)
        {
            Console.WriteLine("print(int num) called");
        }

        public void print(short num)
        {
            Console.WriteLine("print(short num) called");
        }

        public void print(ref int num)
        {
            Console.WriteLine("print(ref int num) called");
        }

        public void print(int a,int b,out int result)
        {
            result = a * b;   
            Console.WriteLine($"print(int a,int b,out int result) called. result:- {result}");
        }


        public void print(int num1,int num2)
        {
            Console.WriteLine("print(int num1,int num2) called");
        }
        public void print(string name)
        {
            Console.WriteLine("print(string name) called");
        }
        public void print(string name,int num)
        {
            Console.WriteLine("print(string name,int num) called");
        }
        public void print(int num,string name)
        {
            Console.WriteLine("print(int num,string name) called");
        }

    }
}
