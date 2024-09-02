using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_ConstReadOnlyKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.RollNumber = 10;
            s1.Name = "Sushant";
            //s1.CompanyName = "V#";
            //Student.CompanyName = "V";
            Console.WriteLine($"RollNumber : {s1.RollNumber}\t Name : {s1.Name}\t " +
                $"CompanyName : {Student.CompanyName}");

            Student s2 = new Student();
            s2.RollNumber = 11;
            s2.Name = "Seth";
            //s2.CompanyName = "V#";
            Console.WriteLine($"RollNumber : {s2.RollNumber}\t Name : {s2.Name} \t" +
               $"CompanyName : {Student.CompanyName}");

            Console.ReadLine();
        }
    }

    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }

        //public static string CompanyName
        //{ get { return "V#"; } set { } }

       // public const string CompanyName = "V#";
        public readonly string CompanyName = "V#";

        public Student()
        {
            CompanyName = "V#";
        }
    }
}
