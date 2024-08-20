using _39_StudentsSelection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Selection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Composition

            //School s = new School()
            //{
            //    SchoolId = 1,
            //    Name = "BPS",
            //};
            //s.Details();

            //s.Company=new Company()
            //{
            //    CompanyId = 1,
            //    Name="TCS"
            //};

            //s.Company.Details();

            //Aggregation

            //School s = new School()
            //{
            //    SchoolId = 1,
            //    Name = "BPS",
            //};
            //Company c = new Company(s);
            //c.CompanyPrint();

            Students[] students=new Students[]
            {
                new Students(){RollNumber=1,Name="Sushnt"}
            };
            Teacher t = new Teacher(students);
            t.StudentPrint();

            Console.ReadLine();
        }
    }
}
