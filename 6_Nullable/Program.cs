using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sushant";
            Console.WriteLine(name);
            name = null;
            Console.WriteLine(name);
            int? age = null;
            bool? b = null;

            //int? a = 10;
            //int b1 = (int)a;
            //Console.WriteLine($" a:{a} b : {b1}");

            int? a = null;
            int b1 = a ?? 50;
            Console.WriteLine($" a:{a} b : {b1}");

            string email = "Sushant@gmail.com";
            string emailToUpper = email.ToUpper();
            Console.WriteLine($"Email {email} emailToUpper : {emailToUpper} \n " );

            string Email = null;
            string EmailToUpper = Email?.ToUpper();
            Console.WriteLine($"Email {Email} emailToUpper : {EmailToUpper}");
            Console.ReadLine();
        }
    }
}
