using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_YeildKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach(int items in GetEven(num))
            {
                Console.WriteLine(items);
            }

            Console.ReadLine();
        }

        static IEnumerable<int> GetEven(List<int> numbers)
        {
            //List<int> result = new List<int>();
            foreach (int items in numbers)
            {
                if (items%2 == 0)
                {
                    yield return items;
                    //result.Add(items);
                }
               
            }
           // return result;
        }
    }
   
}
