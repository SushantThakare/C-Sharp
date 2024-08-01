using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Interfaces
{
    public interface IA
    {
        void Print();
        void printA();
    }

    public interface IB
    {
        void Print();
        void printB();
    }

    public class A : IA, IB
    {
         void IA.Print()
        {
            Console.WriteLine("IA:Print()");
        }
        void IB.Print()
        {
            Console.WriteLine("IB:Print()");
        }
        public void printA()
        {
            Console.WriteLine("IA:PrintA()");
        }

        public void printB()
        {
            Console.WriteLine("IB:PrintB()");
        }
    }


}
