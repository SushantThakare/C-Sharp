using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s= new Student()
            {
                RollNumber = 1,
                Name="Sushant"
            };

            s.AddEnquiry();
            Console.ReadLine();
        }
    }
}
