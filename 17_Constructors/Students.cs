using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Constructors
{
    public class Students
    {
        public int RollNumber;
        public string FirstName;
        public string LastName;
        public static string CourseName;

        public Students()
        {
            Console.WriteLine("Student() Constructor Called");

            RollNumber = 1;
            FirstName = "Sushant";
            LastName = "Thakare";
            //CourseName = "DotNet";
        }

        public Students(int rn,string fn,string ln)
        {

            RollNumber = rn;
            FirstName = fn;
            LastName = ln;
            Console.WriteLine("Parameterized constructor called");
        }

        static Students()
        {
            Console.WriteLine("Student() Static Constructor Called");
            CourseName = "DotNet";
        }
        public Students(Students s)
        {
            this.RollNumber = s.RollNumber;
            this.FirstName = s.FirstName;
            this.LastName = s.LastName;
        }

        public void Details()
        {
            Console.WriteLine($"RollNumber:- {RollNumber} FirstName:- {FirstName} LastName:- {LastName}" +
                $" CourseName:- {CourseName}");
        }

        public void Initialize(int rn, string fn, string ln)
        {
            RollNumber = rn;
            FirstName = fn;
            LastName = ln;
        }
    }
}
