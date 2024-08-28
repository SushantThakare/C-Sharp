using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Enum
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        //public string Gender { get; set; }
        public EnumGender Gender { get; set; }
        public EnumSubject Subject { get; set; }

    }
    public enum EnumGender
    {
        Male=100, Female,Unknown
    }

    public enum EnumSubject 
    {
        Marathi,
        Hindi,
        Mathematics,
        Science,
        GK
    }
}
