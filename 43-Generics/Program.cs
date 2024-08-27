using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator c1 = new Calculator();
            //bool b1 = c1.AreEquals(20, 20);
            //Console.WriteLine(b1);

            //bool b2 = c1.AreEquals(20, 21);
            //Console.WriteLine(b2);

            //bool b3 = c1.AreEquals("abc","abc");
            //Console.WriteLine(b3);

            //bool b4 = c1.AreEquals(20.4f, 21.4f);
            //Console.WriteLine(b2);

            //bool b5 = c1.AreEquals("s", 21.4f);//with obj type possible 
            //Console.WriteLine(b2);

            //Calculator c1= new Calculator();
            //bool b1 = c1.AreEquals<int>(10, 20);
            //Console.WriteLine(b1);

          
            //bool b2 = c1.AreEquals<string>("S", "S");
            //Console.WriteLine(b2);

            //b2 = c1.AreEquals(10, 19);
            //Console.WriteLine(b2);

            //c1.Add(10, 20);
            //c1.Add<string>("S", "T");
            //c1.Add(27.6f, 22.4f);

            Student<int,string> s1 = new Student<int,string>();
            s1.Name = "Sushant";
            s1.RollNumber = 1;
            string r1 =s1.Details();
            Console.WriteLine(r1);
            
           

            Console.ReadLine();
        }
    }
}
