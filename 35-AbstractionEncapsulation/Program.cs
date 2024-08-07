using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_AbstractionEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You can insert new Student Data.


            //Student s1 = new Student()
            //{
            //    RollNumber = 1,
            //    Name = "Sushant",
            //    Gender = "Male"
            //};

            //Student s1 = new Student()
            //{
            //    RollNumber = 0,
            //    Name = "",
            //    Gender = null
            //};
            //if (s1.InValid())
            //{
            //    s1.Insert();//We can insert data
            //}
            //else
            //{
            //    Console.WriteLine("Please Input Valid Input");
            //}

            Student s1 = new Student(1,"Sushant","Male");
            
            s1.Insert();

            Console.ReadLine();
        }
    }
    public class Student
    {
        private int RollNumber;
        private string Name;
        private string Gender;

        public Student(int rn,string nm,string g)
        {
            RollNumber = rn;
            Name = nm;
            Gender = g;
        }

        private bool IsValid()
        {
            //Checks input is valid or not.
            if (RollNumber > 0 && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Gender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Insert()
        {

            if (IsValid())
            {
                //logic for insert data in database.
                Console.WriteLine($"RollNumber: {RollNumber} Name: {Name} Gender: {Gender}");
                Console.WriteLine("New Student Inserted Successfully.");
            }
            else
            {
                Console.WriteLine("Plz enter Valid Data.");
            }
        }

    }
}
