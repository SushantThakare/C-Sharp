using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _52_ReflectionClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Early Binding
            //Customer c1 = new Customer();
            //c1.Print();
            //Console.ReadLine();

            //Late Binding
            Assembly assembly = Assembly.GetExecutingAssembly();// gives assembly
            Type customer = assembly.GetType("_52_ReflectionClass.Customer");//will give class
            if (customer != null)
            {
                object c = Activator.CreateInstance(customer);//creates object for Customer class.
                if (c != null)
                {
                    MethodInfo print = customer.GetMethod("Print");//creates Methods 
                    if (print != null)
                    {
                        print.Invoke(c, null);//calls methods.
                    }
                    else { Console.WriteLine("There is no method to call"); }

                    MethodInfo printC = customer.GetMethod("PrintC");
                    if (printC != null)
                    {
                        printC.Invoke(c, new object[] { "Sushant", "Thakare" });
                    }
                    else { Console.WriteLine("There is no method to call"); }

                    MethodInfo printD = customer.GetMethod("PrintD", BindingFlags.NonPublic
                        | BindingFlags.Instance);//for private method.
                    if (printD != null)
                    {
                        printD.Invoke(c, null);
                    }
                    else { Console.WriteLine("There is no method to call"); }

                }
                else
                {
                    Console.WriteLine("No Instance is Created");
                }

                MethodInfo printB = customer.GetMethod("PrintB");//creates Methods 
                if (printB != null)
                {
                    printB.Invoke(null, null);//calls static methods.
                }
                else { Console.WriteLine("There is no method to call"); }

                Console.WriteLine("All Methods");
                MethodInfo[] methods = customer.GetMethods();
                for(int i = 0; i< methods.Length; i++)
                {
                    Console.WriteLine(methods[i].Name);
                }

                Console.WriteLine("Properties");
                PropertyInfo[] properties= customer.GetProperties();
                for(int i = 0; i < properties.Length; i++)
                {
                    Console.WriteLine($"{properties[i].Name} : {properties[i].PropertyType}");
                }
            }
            else
            {
                Console.WriteLine("no type is created");
            }


            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int CustomerId { get; set; }
        public  string Name { get; set; }
        public void Print()
        {
            Console.WriteLine("Print() Called");
        }

        public static void PrintB()
        {
            Console.WriteLine("PrintB() Called");
        }

        public static void PrintC(string fn, string ln)
        {
            Console.WriteLine($"PrintC() Called: {fn} {ln}");
        }

        private void PrintD()
        {
            Console.WriteLine("PrintD() Called");
        }
    }
}
