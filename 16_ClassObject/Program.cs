using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ClassObject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();
            s1.Name = "Sushant";
            s1.RollNUmber = 1;
            s1.City = "Yavatmal";
            //Student.Country = "India";
            s1.Print();

            Student s2 = new Student();
            s2.Create(5, "Santosh", "Nagpur");
            //Student.Country = "India";
            s2.Print();

            Student s3 = new Student();
            s3.Create(5, "Farin", "Washington");
            Student.Country = "USA";
            s3.Print();


            // World w = new World();
            Console.WriteLine($" NoOFCountries:- {World.NoOFCountries},NoOFContinents:-  {World.NoOFContinents}");

            //Products.ProductID = 1;
            //Products.ProductName = "Shirts";
            //Products.print2();


            Console.ReadLine();
        }

        class Student
        {
            public int RollNUmber;
            public string Name;
            public string City;
            public static string Country = "India";


            public void Print()
            {
                Console.WriteLine($"RollNumber:-{RollNUmber} Name:-{Name} City:-{City} Country :-{Country}");
                printA();
            }

            public void Create(int RollNUmber, string Name, string City)
            {
                this.RollNUmber = RollNUmber;
               this.Name = Name;
                this.City = City;
            }
            public static void printA()
            {
                Console.WriteLine("Static printA Method Called");
                //Not Allowed instance member in static
                //print();
                //Console.WriteLine($"RollNumber:-{RollNUmber} Name:-{Name} City:-{City} Country :-{Country}");

                //non static method can be called by cr3ating obj
                //Student s= new Student();
                //s.Create(1, "Kishor", "Pune");
            }
        }

        static class World
        {
            public static int NoOFCountries = 290;
            public static int NoOFContinents = 7;
        }
        class Products
        {
            public static int ProductID;
            public static string ProductName;

            public static void print2()
            {
                Console.WriteLine($"Product ID :- {ProductID} ProductName:- {ProductName} ");
            }
        }
    }
}
