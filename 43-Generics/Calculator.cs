using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Generics
{
    internal class Calculator
    {
        #region using method Overloading
        //public bool AreEquals(int a , int b)
        //{
        //    return a.Equals(b);
        //}

        //public bool AreEquals(string a, string b)
        //{
        //    return a.Equals(b);
        //}

        //public bool AreEquals(float a, float b)
        //{
        //    return a.Equals(b);
        //}
        #endregion using method Overloading

        //public bool AreEquals(object a, object b)
        //{
        //    return a.Equals(b);
        //}

        public bool AreEquals<T>(T a , T b)
        {
            return a.Equals(b);
        }

        public void Add<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+d2);
        }
    }
}
