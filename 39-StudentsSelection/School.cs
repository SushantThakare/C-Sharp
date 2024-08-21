using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_StudentsSelection
{
    public class School
    {
        public int SchoolId { get; set; }
        public string Name { get; set; }

        public void Details()
        {
            Console.WriteLine($"CompanyId : {SchoolId} Name : {Name} ");
        }
        public Company Company { get; set; }

       
    }
}
