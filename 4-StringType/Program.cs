using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _4_StringType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sushant";
            Console.WriteLine(name);
            name = "          Sushant";
            Console.WriteLine(name);
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            name = "\"Sushant\"";
            Console.WriteLine(name);
            name = "\'SUshant\'";
            Console.WriteLine(name);
            name = "\\Sushant\\";
            Console.WriteLine(name);
            name = "Sushant\tThakare";
            Console.WriteLine(name);
            name = "Sushant Thakare";
            Console.WriteLine(name);
            name = "Sushant\nThakare";
            Console.WriteLine(name);
            Console.WriteLine("Sushant Thakare");
            Console.WriteLine("Sushant\tThakare");

            string path = @"D:\1_V# CSharp\Git\B22CSharpDemos";
            Console.WriteLine(path);

            string FirstName = "Sushant";
            string LastName = "Thakare";
            string MiddleName = "Ashokrao";
            string FullName = FirstName + " " + LastName;
            Console.WriteLine(FullName);
            FullName = string.Concat(FirstName + " " + LastName);
            Console.WriteLine(FullName);
            FullName = string.Join(" ",FirstName,MiddleName,LastName);
            Console.WriteLine(FullName);
            FullName = string.Format("Full Name : {0} {1} {2} ", FirstName, MiddleName, LastName);
            Console.WriteLine(FullName);

            //Data Type Conversion
            Console.WriteLine("Data Type Conversion\n");
            int i = 10;
            int j = 10;
            int add = i + j;
            Console.WriteLine(add);

            string a = i.ToString();
            string b = j.ToString();
            Console.WriteLine(a+b);

            byte b1 = 10;
            short s1 = b1;
            Console.WriteLine(s1);

            float f1 = s1;
            Console.WriteLine(f1);

            int i1 =(int) f1;
            Console.WriteLine(i1);

            f1 = 234.45f;
            i1 = (int)f1;

            string s = "1000";
            i1 = Convert.ToInt32(s);
            Console.WriteLine(i1);

            i1 = int.Parse(s);
            Console.WriteLine(i1);

            s = "2000";
            bool bb = int.TryParse(s, out i1);
            Console.WriteLine($"status{bb} result {i1} ");
            s = "xyz";
            bool b2 = int.TryParse(s, out i1);
            Console.WriteLine($"status{b2} result {i1} ");

            Console.ReadLine();
        }
    }
}
