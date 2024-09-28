using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using Separate Method
            //Calculator c1 = new Calculator();
            //Predicate<int> pd1 =c1.even;
            //bool b1 = pd1(15);
            //Console.WriteLine(b1);
            #endregion Using Separate Method

            #region Using Anonoymous Method
            //Predicate<int> del1 = delegate (int num)
            //    {
            //        return num % 2 == 0;

            //    };
            //bool b2=del1(20);
            //Console.WriteLine(b2);

            //Console.WriteLine(del1(21));

            #endregion Using Anonoymous Method

            #region Using Lambda Expression
            Predicate<int> del2 = num => num % 2 == 0;
            Console.WriteLine(del2(20));
            Action<string> ac = s =>
            {
                Console.WriteLine($"Name : {s}");
            };
            ac("Sushant");
            Console.WriteLine();
            Action<string, string> ac2 = (fn, ln) => Console.WriteLine($"FirstName: {fn}  LastName: {ln}");
            ac2("Sushant", "Thakare");
            Action<string, string> ac3 = (fn, ln) =>
            {
                string s = fn + ln;
                Console.WriteLine(s);
            };
            ac3("se", "th");

            Func<string> f = () => "Hello World" ;
            Console.WriteLine(f());   

            Func<string, string, string> f2 = (fn, ln) =>
            {
                string s = fn + " " + ln;
                return s;
            };
            Console.WriteLine(f2("Sushant", "Thakare"));
            #endregion Using Lambda Expression

            Console.ReadLine();
        }

    }

    public class Calculator
    {
        public bool even(int num)
        {
            return (num % 10 == 0);
        }
    }
}
