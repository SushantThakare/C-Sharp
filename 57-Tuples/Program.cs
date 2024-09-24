using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int, int> t1 = new Tuple<int, int, int>(10,11,12);
            Console.WriteLine(t1.Item2);

            Tuple<int, int, int, int, int, int, int> t2 = new Tuple<int, int, int, int, int, int, int>
                (1, 2, 3, 4, 5, 6, 7);
            Console.WriteLine(t2.Item3);
            Console.WriteLine(t2.Item7);

            Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>> t3 = 
                new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>
               (1, 2, 3, 4, 5, 6, 7,t1);
            Console.WriteLine(t3.Item2);
            Console.WriteLine(t3.Rest.Item1);//rest we use to access t1 items
            Console.WriteLine(t3.Rest);//rest we use to access t1 items

            var result = GetDetails();
            Console.WriteLine($"RollNumber : {result.Item2}  Name : {result.Item1} " +
                $" City : {result.Item3}");

            Console.ReadLine();

          
        }

        static Tuple<int, string, string> GetDetails()
        {
            Tuple<int, string, string> details  = new Tuple<int, string, string>(1, "Sushant", "Ytl");
            return details;
        }
    }
}
