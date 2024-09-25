using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today1 = DateTime.Now;
            Console.WriteLine(today1);
            Console.WriteLine($"Date : {today1.ToShortDateString()}");
            Console.WriteLine($"Time : {today1.ToShortTimeString()}");
            Console.WriteLine($" long date: {today1.ToLongDateString()}");
            Console.WriteLine($" long Time: {today1.ToLongTimeString()}");
            Console.WriteLine($"Year : {today1.Year}");
            Console.WriteLine($"{today1.ToString("dddd")}");


            DateTime today2 = DateTime.Today;
            Console.WriteLine(today2);
            //Customer c1 = new Customer()
            //{
            //    Id = 1,
            //    FirstName = "Sushant",
            //    LastName = "Thakare",
            //};

            //c1.Details();

            Console.ReadLine(); 
        }
    }

    public struct Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Details()
        {
            Console.WriteLine($"Id: {Id}  FirstName: {FirstName}  LastName: {LastName}");
        }

    }
}
