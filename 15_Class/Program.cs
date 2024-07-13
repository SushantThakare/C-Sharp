using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students s1 = new Students();
            s1.RollNumber = 1;
            s1.Name = "Sushant";
            s1.City = "Nagpur";
            s1.print();
            //Console.WriteLine($"RollNUmber:{s1.RollNumber} Name : {s1.Name} City : {s1.City}");


            Students s2 = new Students();
            s2.RollNumber = 1;
            s2.Name = "Sumit";
            s2.City = "Yavatmal";
            s2.print();
            //Console.WriteLine($"RollNUmber:{s2.RollNumber} Name : {s2.Name} City : {s2.City}");

            Circle c1 = new Circle();
            c1.radius = 5;
           // c1.pi = 3.14f;
            c1.calculate();

            Circle c2 = new Circle();
            c2.radius = 10;
            //c2.pi = 3.14f;
            c2.calculate();
            Console.WriteLine($"pi :- {Circle.pi}");
            Console.ReadLine();
        }
    }

    class Students
    {
        public int RollNumber;
        public string Name;
        public string City;

        public void print()
        {
            Console.WriteLine($"RollNUmber:{RollNumber} Name : {Name} City : {City}");
        }

    }

}
