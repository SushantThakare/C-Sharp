using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Exception_Handling_Scenario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = GetData();
            //Console.WriteLine(name);
            string name = GetData1();
            Console.WriteLine(name);
            Console.ReadLine();
        }

        static string GetData()
        {
            try
            {
                return "TRY";
            }

             catch
            {
                return "CATCH";
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }
        }

        static string GetData1()
        {
            string result = string.Empty;
            try
            {
                result = "TRY";
               // return result;
            }

            catch
            {
                result = "CATCH";
                //return result;
            }
            finally
            {
                result = "FINALLY";
                //Console.WriteLine("FINALLY");
            }
            return result;
        }

    }
}
