using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_ObjectType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Type t1= typeof(int);
            //    Console.WriteLine($"{t1.Name}:{t1.Namespace}:{t1.FullName}");
            //    int i = 10;
            //    t1 = typeof(int);
            //    Console.WriteLine($"{t1.Name}:{t1.Namespace}:{t1.FullName}");
            //    t1 =i.GetType();
            //   Console.WriteLine($"{t1.Name}:{t1.Namespace}:{t1.FullName}");

            //    float f = 10.5f;
            //    t1 = typeof(float);
            //    Console.WriteLine($"{t1.Name}:{t1.Namespace}:{t1.FullName}");
            //    t1 =f.GetType();
            //    Console.WriteLine($"{t1.Name}:{t1.Namespace}:{t1.FullName}");
            //    string s = "Hello";
            //    t1 =typeof(string);
            //    Console.WriteLine($"{t1.Name}:{t1.Namespace}:{t1.FullName}");
            //    t1 =s.GetType();
            //    Console.WriteLine($"{t1.Name}:{t1.Namespace}:{t1.FullName}");
            //    bool b = true;
            //    t1=typeof(bool);
            //    Console.WriteLine($"{t1.Name}:{t1.Namespace}:{t1.FullName}");
            //    t1 =b.GetType();
            //    Console.WriteLine($"{t1.Name}:{t1.Namespace}:{t1.FullName}");
            //    Console.WriteLine();
            //    Student s1 = new Student();
            //    t1=s1.GetType();
            //    Console.WriteLine($"{t1.Name}:{t1.Namespace}:{t1.FullName}");





            //object i = 10;
            //object f = 10.5f;
            //object s = "Hello";
            //object b = true;
            //object s1 = new Student();

            //int i = 10; int j = 20 ;
            //Console.WriteLine($"{i+j}");
            //Console.WriteLine(i.ToString()+j.ToString());

            //double d = 10.5;
            //Console.WriteLine(d.ToString());

            //Student s1 = new Student()
            //{
            //    FirstName = "Sushant",
            //    LastName="Thakare"

            //};

            //Console.WriteLine(s1.ToString());


            //int i = 10; int j = 20;

            //if (i.Equals(j))
            //{
            //    Console.WriteLine($"{i} is equals to {j}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equals");
            //}

            //Student s1 = new Student() {FirstName="Sushant",LastName="Thakare"};
            //Student s2 = new Student() { FirstName = "Sushant", LastName = "Thakare" }; ;


            //if (s1.Equals(s2))
            //{
            //    Console.WriteLine($"{s1} is equals to {s2}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equals");
            //}

            int i = 10;
            int j = 20;
            Console.WriteLine($"{i.GetHashCode()}{j.GetHashCode()}");
            Console.WriteLine();
            string s1= "Sushant";
            string s2 = "Shifa";
            Console.WriteLine($"s1= {s1.GetHashCode()} s2= {s2.GetHashCode()}");

            Student s11= new Student() { FirstName = "Sushant", LastName = "Thakare"};
            Student s12= new Student() { FirstName = "Sushant", LastName = "Thakare"};
            Console.WriteLine($"s11= {s11.GetHashCode()} s12= {s12.GetHashCode()}");
            Console.ReadLine();

        }
    }

    public class Student
    {
        public string FirstName;
        public string LastName;

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public override bool Equals(object obj)
        {
            //Student s = (Student)obj;
            Student s = obj as Student;

            return this.FirstName.Equals(s.FirstName) && this.LastName.Equals(s.LastName); 
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
