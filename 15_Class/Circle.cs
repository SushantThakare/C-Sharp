using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Class
{
    internal class Circle
    {
       public  int radius;
        public static float pi=3.14f;

        public void calculate()
        {
            Console.WriteLine($"Area of Circle = {pi * radius * radius}");
        }
    }
}
