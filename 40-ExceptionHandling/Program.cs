using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pla input Numerator");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Pla input Numerator");
            //int Den = int.Parse(Console.ReadLine());
            try
            {

                Console.WriteLine("Pla input Numerator");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Pla input Numerator");
                int Den = int.Parse(Console.ReadLine());

                Divide(num, Den);
            }
            //catch (FormatException ex) { Console.WriteLine($"FormatException{ex.Message}\n"); }
            //catch (OverflowException ex) { Console.WriteLine($"OverflowException{ex.Message}\n"); }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException.GetType().Name,ex.InnerException.Message);
            }
           

            Console.ReadLine();
        }

        static void Divide(int a, int b)
        {


            try
            {
                int C = a / b;

                Console.WriteLine($"A / B = {C}");
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                // Console.WriteLine(ex.StackTrace);
               File.WriteAllText($"Logs/app/errors.txt", $"{ex.Message}\n");
                //Console.WriteLine("The Denominator Cannot be Zero");
            }
            finally
            {
                Console.WriteLine("Division Operation Completed");

            }


        }
    }
}
