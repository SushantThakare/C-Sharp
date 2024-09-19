using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _54_CollectionClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region array
            //int[] numbers= new int[3];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //for(int i = 0;i< numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region ArrayList
            //ArrayList numbers = new ArrayList();
            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);
            //numbers.Add(40);
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.WriteLine("***FOREEACH: Original Collection ***");
            ////for (int i = 0; i < numbers.Count; i++)
            ////{
            ////    Console.BackgroundColor = ConsoleColor.Magenta;
            ////    Console.Write($"{numbers[i]} ");
            ////}
            //foreach(int item in numbers)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();

            //ICollection temp = new ArrayList() { 50,60,70,"hello"};
            //numbers.AddRange(temp);
            //Console.WriteLine("***FOREEACH: After AddRange() Original Collection ***");
            ////for (int i = 0; i < numbers.Count; i++)
            ////{
            ////    Console.BackgroundColor = ConsoleColor.Magenta;
            ////    Console.Write($"{numbers[i]} ");
            ////}
            //foreach(object item in numbers)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //numbers.Add(15);
            //Console.WriteLine("*** After Add(15) Original Collection ***");
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.BackgroundColor = ConsoleColor.Magenta;
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();

            //numbers.Insert(1, 15);
            //numbers.Insert(3, 25);
            //Console.WriteLine("*** After Insert(1,15) Original Collection ***");
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.BackgroundColor = ConsoleColor.Magenta;
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();
            //numbers.Remove(15);//removes exact given value 
            //numbers.RemoveAt(0);//removes index value 
            //numbers.RemoveRange(0, 4);//0 to 4 all index will removed
            //ICollection temp2 = new ArrayList() { 16, 17, 18, 19 };
            //numbers.InsertRange(2, temp2);
            //Console.WriteLine("*** After  ICollection temp2 Original Collection ***");
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.BackgroundColor = ConsoleColor.Magenta;
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();

            //bool b1 = numbers.Contains(21);
            //Console.WriteLine($"21: {b1}");
            //bool b2 = numbers.Contains(19);
            //Console.WriteLine($"19: {b2}");
            #endregion

            #region Hashtable
            //Hashtable students = new Hashtable();
            //students.Add(1, "Sushant");
            //students.Add(2, "Seth");
            //Console.WriteLine("*** All Items ***");

            //foreach (DictionaryEntry item in students)
            //{
            //    Console.WriteLine($"Key: {item.Key} : value : {item.Value}");
            //}

            //bool b1 = students.ContainsKey(3);
            //Console.WriteLine(b1);
            //b1 = students.ContainsValue("Sushant");
            //Console.WriteLine(b1);
            //var value = students[1];
            //Console.WriteLine(value);
            #endregion

            #region Stack
            //Stack visitedSites = new Stack();
            //visitedSites.Push("Google.com");
            //visitedSites.Push("Google.com/Facebook.com");
            //visitedSites.Push("Google.com/Facebook.com/Friends");
            //visitedSites.Push("Google.com/Facebook.com/Friends/Users");
            //visitedSites.Push("Google.com/Facebook.com/Friends/Users/Sushant");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");

            ////peek does not removes previous item and returns last item

            //var site = visitedSites.Peek();
            //Console.WriteLine($"returned:- {site}");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");
            //site = visitedSites.Peek();
            //Console.WriteLine($"returned:- {site}");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");
            //site = visitedSites.Peek();
            //Console.WriteLine($"returned:- {site}");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");
            //site = visitedSites.Peek();
            //Console.WriteLine($"returned:- {site}");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");
            //site = visitedSites.Peek();
            //Console.WriteLine($"returned:- {site}");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");


            ////pop removes previous item and returns last item
            //Console.WriteLine("pop");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");
            //var sites = visitedSites.Pop();
            //Console.WriteLine($"returned:- {sites}");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");
            //sites = visitedSites.Pop();
            //Console.WriteLine($"returned:- {sites}");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");
            //sites = visitedSites.Pop();
            //Console.WriteLine($"returned:- {sites}");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");
            //sites = visitedSites.Pop();
            //Console.WriteLine($"returned:- {sites}");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");
            //sites = visitedSites.Pop();
            //Console.WriteLine($"returned:- {sites}");
            //Console.WriteLine($"Number of items :- {visitedSites.Count}");

            #endregion

            #region Queue
            Queue BankToken = new Queue();
            BankToken.Enqueue("Sushant");
            BankToken.Enqueue("Akshay");
            BankToken.Enqueue("Seth");
            BankToken.Enqueue("Sumit");

            Console.WriteLine($" Total no of Tokens:- {BankToken.Count}");

            //peek returns first element but does not remove any element,so it return only first element all the time.
            Console.WriteLine("Peek");
            var Tokens = BankToken.Peek();
            Console.WriteLine($"Dequeue() : {Tokens}");
            Console.WriteLine($" Total no of Tokens:- {BankToken.Count}");
            Tokens = BankToken.Peek();
            Console.WriteLine($"Dequeue() : {Tokens}");
            Console.WriteLine($" Total no of Tokens:- {BankToken.Count}");
            Tokens = BankToken.Peek();
            Console.WriteLine($"Dequeue() : {Tokens}");
            Console.WriteLine($" Total no of Tokens:- {BankToken.Count}");
            Tokens = BankToken.Peek();
            Console.WriteLine($"Dequeue() : {Tokens}");
            Console.WriteLine($" Total no of Tokens:- {BankToken.Count}");

            //Dequeue return first element and remove first element
            Console.WriteLine("Dequeue");
            var Token = BankToken.Dequeue();
            Console.WriteLine($"Dequeue() : {Token}");
            Console.WriteLine($" Total no of Tokens:- {BankToken.Count}");
            Token = BankToken.Dequeue();
            Console.WriteLine($"Dequeue() : {Token}");
            Console.WriteLine($" Total no of Tokens:- {BankToken.Count}");
             Token = BankToken.Dequeue();
            Console.WriteLine($"Dequeue() : {Token}");
            Console.WriteLine($" Total no of Tokens:- {BankToken.Count}");
             Token = BankToken.Dequeue();
            Console.WriteLine($"Dequeue() : {Token}");
            Console.WriteLine($" Total no of Tokens:- {BankToken.Count}");

           
            #endregion

            Console.ReadLine();
        }
    }
}
