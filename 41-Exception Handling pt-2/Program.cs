using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Exception_Handling_pt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Plz Input Numerator");
            try
            {
                int num, den;
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Plz Input Denominator");
                    if (int.TryParse(Console.ReadLine(), out den))
                    {
                        Division(num, den);
                    }
                    else
                    {
                        Console.WriteLine("Input denominator is incorrect");
                    }
                }
                else
                {
                    Console.WriteLine("Input Numerator is Incorrect");
                }

            }
            catch(MyCustomException ex)
            {
                Console.WriteLine($"Main() MyCustomException catch block : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" outer catch 1 exception {ex.GetType().Name}, {ex.Message}");//will show outer catch exception info
                Console.WriteLine($"outer catch 2" +
                    $" exception{ex.InnerException.GetType().Name}, {ex.InnerException.Message}");//will show inner exception 
            }


            Console.ReadLine();
        }


        //static void Division(int i , int j)
        //{
        //    if (j != 0)
        //    {
        //        int k = i / j;
        //        Console.WriteLine($"Division of  {i} / {j} = {k}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Plz Input Denominator Greater than Zero");
        //    }
        //    Console.WriteLine("Division Operation Completed");
        //}

        static void Division(int i, int j)
        {
            try
            {
                //if(j == 0)
                //{
                //    throw new Exception("Denominator is zero");
                //}
                int k = i / j;
                Console.WriteLine($"Division of  {i} / {j} = {k}");
            }
            catch (Exception ex)
            {
                // Console.WriteLine($" main() catch block {ex.Message}");
                //  throw new Exception("Denominator is zero");
                // throw;
                //File.WriteAllText(@"error/logs.txt", ex.Message);
                //throw;will throw original exception info // but here it is throwing null
                //throw new DirectoryNotFoundException("inner Catch exception", ex);//will throw new exception which is directory not found
                //and will shoe message inner catch exception.

                throw new MyCustomException("Product Quantity are not Available");
            }

            Console.WriteLine("Division Operation Completed");
        }
    }

    class MyCustomException : Exception
    {
        public MyCustomException(string msg) : base(msg)
        {

        }
    }

}
