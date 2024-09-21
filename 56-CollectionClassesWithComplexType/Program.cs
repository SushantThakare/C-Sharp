using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_CollectionClassesWithComplexType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students s1 = new Students() { RollNumber = 1, City = "Pune" };
            Students s2 = new Students() { RollNumber = 2, City = "Mumbai" };
            Students s3 = new Students() { RollNumber = 3, City = "Satara" };
            Students s4 = new Students() { RollNumber = 4, City = "Nagpur" };
            Students s5 = new Students() { RollNumber = 5, City = "Yavatmal" };
            #region List
            //List<Students> students = new List<Students>();
            //students.Add(s1);
            //students.Add(s2);
            //students.Add(s3);
            //students.Add(s4);
            //students.Add(s5);

            //Console.WriteLine($"Total no of items :- {students.Count}");
            ////foreach(var item in students)
            ////{
            ////    Console.WriteLine($"RollNumber:- {item.RollNumber} City:- {item.City}");
            ////}

            //foreach (Students item in students)
            //{
            //   // Console.WriteLine(item);does not work
            //    Console.WriteLine($"RollNumber:- {item.RollNumber} City:- {item.City}");
            //}
            #endregion List

            #region Dictionary 

            Dictionary<int,Students> students= new Dictionary<int, Students>();
            students.Add(1, s1);
            students.Add(2, s2);
            students.Add(3, s3);
            students.Add(4, s4);
            students.Add(5, s5);

            Students s = students[1];
            Console.WriteLine($"RollNumber : {s.RollNumber} City : {s.City}");


            Console.WriteLine("*** all students ***");
            foreach (KeyValuePair<int,Students> items in students)
            {
                Console.WriteLine(items.Key);
               // Console.WriteLine(items.Value);does not work
               Students ss = items.Value;
                Console.WriteLine($"RollNumber : {ss.RollNumber} City : {ss.City}");
            }
            #endregion Dictionary 
            Console.ReadLine();
        }
    }

    public class Students
    {
        public int RollNumber { get; set; }
        public string City { get; set; }
    }
}
