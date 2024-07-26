using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OpratorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int i = 10;
            //// int j = i;
            // int j = 10;
            // if(i==j)
            // {
            //     Console.WriteLine($"{i}:{j} Are equal");
            // }
            // else
            // {
            //     Console.WriteLine($"{i}:{j} Not are equal");
            // }

            // string s = "Sushant";
            // string st = "Sushant";
            // //string st= s;
            // if (st == s)
            // {
            //     Console.WriteLine($"{s}:{st} Are equal");
            // }
            // else
            // {
            //     Console.WriteLine($"{s}:{st} Not are equal");
            // }

          Student s1 = new Student(1,"Sushant","Thakare");

            Student s2 =new Student(1, "Sushant", "Thakare");

           
            if (s1 == s2)
            {
                Console.WriteLine($"s1:s2 Are equal");
            }
            else
            {
                Console.WriteLine($"s1:s2 Not are equal");
            }


            Student s3 = new Student(1, "Sushant", "Thakare");

            Student s4 = new Student(2, "Shifabano", "Malani");

            Student s5 = s3 + s4;
            Console.WriteLine($"{s5.RollNumber}  {s5.FirstName} {s5.LastName}");
            Console.ReadLine();
        }
    }
}
