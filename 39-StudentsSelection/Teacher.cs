using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_StudentsSelection
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }

        public Students[] Students { get; set; }

        public Teacher(Students[] st)
        {
            Students = st;
        }

        public void StudentPrint()
        {
            if (Students !=null && Students.Length > 0)
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    Console.WriteLine(Students[i].Name + " "+ Students[i].RollNumber);
                }
            }else
            {
                Console.WriteLine("Not exit");
            }
        }
    }
}
