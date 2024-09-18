using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;

            //string s = "sushant";
            //string u = s.ToUpper();
            //Console.WriteLine(u);

            //u = s.ToLower();
            //Console.WriteLine(u);

            //u = s.ToCapitalCase();
            //Console.WriteLine(u);

            //string s2 = "vrushsbh";
            //string u2 = s2.ToCapitalCase();
            //Console.WriteLine(u2);

            //BMW b = new BMW();
            //b.print("A");
            
            //AUDI a= new AUDI();
            //a.print("B");

            A a = new A();
            a.PrintA();

            Console.ReadLine();
        }
    }

    public static class StringHelper
    {
        public static string ToCapitalCase(this string name)
        {
            string result = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                if (i == 0)
                {
                    result += name[i].ToString().ToUpper();
                }
                else
                {
                    result += name[i].ToString().ToLower();
                }
            }
            return result;
        }
    }

    public interface ICar
    {

    }
    public class BMW:ICar
    {
        //public void print()
        //{
        //    Console.WriteLine($"BMW : Print() : {GetType().Name}");
        //}
    }

    public class AUDI: ICar
    {
        //public void print()
        //{
        //    Console.WriteLine($" Print() : {GetType().Name}");
        //}
    }

    public static class CarHelper
    {
        public static void print(this ICar o,string s)
        {
            Console.WriteLine($"{s}: {o.GetType().Name}");
        }
    }

    public class A
    {
        public void Print()
        {
            Console.WriteLine("Print() called");
        }
    }

    public static class AHelper
    {
        public static void PrintA(this A a)
        {
            Console.WriteLine("PrintA() Called of A class");
        }
    }
}
