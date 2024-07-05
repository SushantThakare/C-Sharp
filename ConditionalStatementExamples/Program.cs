using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please Enter First Number");
            //int first = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter Second Number");
            //int second = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter Third Number");
            //int third = int.Parse(Console.ReadLine());

            //Console.WriteLine($"You Entered {first},{second},{third}\n");

            //Console.WriteLine("Press enter to find Greatest no among Three");
            #region nested if else 
            //if (first > second)
            //{
            //    if (first > third)
            //    {
            //        Console.WriteLine($"{first} is Greatest Number");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is Greatest Number");
            //    }
            //}
            //else if (second > first)
            //{


            //    {

            //        if (second > third)
            //        {
            //            Console.WriteLine($"{second} is Greatest Number");
            //        }
            //        else if (second == third)
            //        {
            //            Console.WriteLine($"{third} and {second} are greater.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{third} is Greatest Number");
            //        }
            //    }
            //}
            //else if (first == second && second == third)
            //{
            //    Console.WriteLine($"{first} , {second} and {third} are greater.");
            //}

            //else
            //{
            //    if (first > third)
            //    {
            //        Console.WriteLine($"{first} and {second} are greater.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is Greatest Number");
            //    }
            //}
            #endregion

            #region nested if else my 
            //if (first > second)
            //{

            //    if (first > third)
            //    {
            //        Console.WriteLine($"{first} is Greatest");
            //    }

            //    else
            //    {
            //        Console.WriteLine($"{third} is Greatest");
            //    }
            //}
            //else if (second > first)
            //{
            //    if (second > third) {
            //        Console.WriteLine($"{second} is greatest");
            //    }
            //    else if (second == third)
            //    { Console.WriteLine($" {second} and {third} are greatest"); }
            //    else
            //    {
            //        Console.WriteLine($"{third} is Greatest");
            //    }

            //}
            //else if (first > third)
            //{
            //    if (first == second)
            //    { 
            //        Console.WriteLine($"Both {second} and {first} are greatest");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is Greatest");
            //    }
            //}
            //else {
            //    if (first == second && second == third)
            //    {
            //        Console.WriteLine($"All {first},{second},{third} are Greatest ");
            //    };
            //}
            #endregion

            #region nested ternary oprator
            //int number = (first > second) ? ((first>third)?first:third) : ((second>third)?second:third);
            //Console.WriteLine($"{number} is greatest");
            #endregion

            #region Divisible 3 & 5

            //Console.WriteLine("please enter a number");
            //int num = int.Parse(Console.ReadLine());


            //if (num % 5 == 0 && num % 3 == 0)
            //{
            //    Console.WriteLine($"{num} is Divisible by ThreeFive");
            //}

            //else if (num% 3 == 0)
            //{
            //    Console.WriteLine($"{num} is Divisible by Three");
            //}


            //else if (num % 5 == 0)
            //{
            //    Console.WriteLine($"{num} is Divisible by Five");
            //}


            //else
            //{
            //    Console.WriteLine("Number is Even Number");
            //}
            #endregion

            #region even odd
            Console.WriteLine("please enter a number");
            int num = int.Parse(Console.ReadLine());

            string result = (num % 2 == 0) ? "True" : "False";
            Console.WriteLine(result);
            #endregion

            #region Grande 

            Console.WriteLine("please enter a grade ");
            char grade =char.Parse( Console.ReadLine().ToUpper());
            
            switch (grade)
            {
                case 'A':
                    Console.WriteLine($"{grade} : Distinction ");
                    break;
                case 'B':
                    Console.WriteLine($"{grade} : First Class ");
                    break;
                case 'C':
                    Console.WriteLine($"{grade} : Second Class ");
                    break;
                case 'F':
                    Console.WriteLine($"{grade} : Failed ");
                    break;
                default:
                    Console.WriteLine($"{grade} is Invalide");
                    break;
            }
            #endregion


            Console.ReadLine();
        }
    }
}
