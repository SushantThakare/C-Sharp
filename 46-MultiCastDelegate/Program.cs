using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_MultiCastDelegate
{
    internal class Program
    {
        public delegate string PrintDelegate();
        static void Main(string[] args)
        {
            PrintDelegate pd = PrintA;
            pd += PrintB;
            pd += PrintC;
            //string name = pd();
            //Console.WriteLine(name);

            Delegate[] delegates = pd.GetInvocationList();
            for (int i = 0; i < delegates.Length; i++)
            {
                try
                {
                    var name = delegates[i].DynamicInvoke();
                    Console.WriteLine(name);
                }
                catch
                {
                    Console.WriteLine("Exception");
                }
            }
            Console.ReadLine();
        }

        static string PrintA()
        {
            return "PrintA()";
        }

        static string PrintB()
        {
            throw new Exception("Intentionally exception thrown ");
            return "PrintB()";
        }

        static string PrintC()
        {
            return "PrintC()";
        }
    }
}
