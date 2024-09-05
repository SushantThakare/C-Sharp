using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_StringAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string intro = "My ";
            intro += "Name ";
            intro += "Is ";
            intro += "Sushant";
            Console.WriteLine(intro);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hi ");
            sb.Append("My self barik");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
