using _38_CompanyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_CompanyLibraryClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Employee e = new Employee() { EmployeeId=1,Name="Sushant",
            //        City="Nagpur",Experience=2};
            //    e.Details();
            //    e.Company = new Company() { CompanyId = 2, Name="CG" };
            //    e.Company.Details();
            //    //Console.WriteLine($"CompanyId {e.Company.CompanyId} Name={e.Company.Name}");

            //    Company co = new Company()
            //    {
            //        CompanyId = 1,
            //        Name="TCS"
            //    };
            //    co.Details();

            //co.Employees = new Employee[] 
            //{
            //new Employee(){EmployeeId=2,Name="Vrushabh",City="Ytl",Experience=3}, 
            //new Employee(){EmployeeId=3,Name="Roshni",City="Ytl",Experience=1}, 
            //new Employee(){EmployeeId=4,Name="Shifa",City="Wardha",Experience=2}, 
            //};
            //for(int i = 0; i < co.Employees.Length; i++)
            //{
            //    co.Employees[i].Details();
            //}
            Employee e1 = new Employee()
            {
                EmployeeId = 2,
                Name = "Vrushabh",
                City = "Ytl",
                Experience = 3
            };
            Employee e2 = new Employee()
            {
                EmployeeId = 3,
                Name = "Roshni",
                City = "Ytl",
                Experience = 1
            };
            Employee e3 = new Employee()
            {
                EmployeeId = 4,
                Name = "Shifa",
                City = "Wardha",
                Experience = 2
            };
            Employee e4 = new Employee()
            {
                EmployeeId = 5,
                Name = "Sushant",
                City = "Ytl",
                Experience = 4
            };

            Employee[] employee = new Employee[] { e1, e2, e3,e4 };

            Company c = new Company(employee);
            c.AllEmployees();

            string name1 = c[2];
           Console.WriteLine(name1);

            c[2] = "Seth";
            name1 = c[2];
            Console.WriteLine(name1);

            Employee ee1 = c["Roshni"];
            Console.WriteLine($"{ee1.EmployeeId} : {ee1.Name} : {ee1.Experience} : {ee1.City}");
            //PromotionCriteria pc = PromotionLogic;
            Predicate<Employee> pc = PromotionLogic;
            c.Promote(pc);
            //PromotionCriteria pc1 = PromotionLogic2;
            Predicate<Employee> pc1 = PromotionLogic2;
            c.Promote(pc1);
            Console.ReadLine();
        }

        //call Back Function because it gets called from Library
        static bool PromotionLogic(Employee e)
        {
            return e.City == "Ytl";
        }

        //call Back Function because it gets called from Library
        static bool PromotionLogic2(Employee e)
        {
            return e.Name.StartsWith("S");
        }

    
    }
}
