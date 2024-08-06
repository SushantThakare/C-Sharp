using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_VarDynamicKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var o = new { id = 1,Name="Sushant" };
            //Console.WriteLine($" id= {o.id} Name= {o.Name}");

            //dynamic i = 10;
            //Console.WriteLine(i.GetType().Name);
            //i = "Sushant";
            //Console.WriteLine(i.GetType().Name);

            Student s = new Student();
            s.Print();

           // object o = new Student();
            //o.Print();

            var v = new Student();
            v.Print();

            dynamic d= new Student();
            d.Print();
            Console.ReadLine();
        }
    }

    class Student
    {
        public void Print()
        {
            Console.WriteLine("Print() Printed");
        }
    }
}
