using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();

            e[3] = 5;
            Console.WriteLine(e[3]);
            Console.ReadLine();
        }
    }

    class Employee
    {
        private int[] Age = new int[3];

        public int this[int index]
        {


            set
            {
                if (index >= 0 && index < Age.Length)
                {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine($"Value Is Invalid {value} -> Check the indexer Value");
                    }
                }
                else
                {
                    Console.WriteLine($"Your value cannot be Zero or Smaller Than Zero");
                }
            }

            get
            {
                if (index >= 0 && index < Age.Length)
                {
                    return Age[index];
                }
                else
                {
                   Console.WriteLine($"Index out of bounds: {index}. Valid indices are 0 to {Age.Length - 1}.");
                    return -1;
                }
            }

        }
      


}
    }
