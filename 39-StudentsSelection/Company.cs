using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_StudentsSelection
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }

        public void Details()
        {
            Console.WriteLine($"CompanyId : {CompanyId} Name : {Name} ");
        }

        public School School { get; set; }

        public Company(School sc)
        {
            School = sc;
        }

        public void CompanyPrint()
        {
            Console.WriteLine($"CompanyId : {School.SchoolId} Name : {School.Name} ");
        }



    }
}
