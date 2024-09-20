using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_GenericCollectionClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            // List<int> numbers = new List<int>();
            // numbers.Add(10);
            // numbers.Add(20);
            // numbers.Add(30);
            // numbers.Add(40);
            // numbers.Add(50);
            // Console.WriteLine($" total numbers:- {numbers.Count}");
            // foreach(int items in numbers)
            // {
            //     Console.Write($"{items} ");
            // }
            // Console.WriteLine("\n----------------");

            // List<int> temp = new List<int>() {60,70};
            // numbers.AddRange(temp);
            //foreach(int items in numbers)
            // {
            //     Console.Write($"{items} ");
            // }
            //Console.WriteLine("\n-------------");
            // numbers.Add(80);
            // foreach (int items in numbers)
            // {
            //     Console.Write($"{items} ");
            // }
            // Console.WriteLine("\n-------------");

            // numbers.Insert(1, 15);
            // foreach (int items in numbers)
            // {
            //     Console.Write($"{items} ");
            // }
            // Console.WriteLine("\n-------------");
            // bool b1 = numbers.Contains(40);
            // Console.WriteLine($"30 exits: {b1}");
            // Console.WriteLine("-------------");
            // bool b2 =numbers.Remove(15);
            // foreach(int items in numbers)
            // {
            //     Console.Write($"{items} ");
            // }
            // Console.WriteLine($"\n15 Removed = {b2}");
            // Console.WriteLine("-------------");
            // numbers.RemoveAt(1);
            // numbers.RemoveRange(1,3);
            // foreach (int items in numbers)
            // {
            //     Console.Write($"{items} ");
            // }
            // Console.WriteLine("\n-------------");
            #endregion List

            #region Dictionary
            //Dictionary<int,string> students = new Dictionary<int, string>();
            //students.Add(1, "Sushant");
            //students.Add(2, "Seth");
            //students.Add(3, "Vrushabh");
            //students.Add(4, "Divya");

            //Console.WriteLine($"Total no of Students:- {students.Count}");

            //foreach(KeyValuePair<int,string> items in students)
            //{
            //    Console.WriteLine($"Key:- {items.Key} Value:-{items.Value}");
            //}

            //bool b1 = students.ContainsKey(1);
            //Console.WriteLine($"Contains 1 key ? {b1}");
            //bool b2 = students.ContainsValue("Seth");
            //Console.WriteLine($"Contains Seth :- {b2}");
            //string s = students[3];
            //Console.WriteLine(s );
            #endregion

            #region Stack<>
            //Stack<string> names= new Stack<string>();
            //names.Push("Sushant");
            //names.Push("Shifa");
            //names.Push("Malani");
            //Console.WriteLine($"Total number Of names {names.Count}");
            //string name = names.Pop();
            //Console.WriteLine(name);
            //Console.WriteLine($"Total number Of names {names.Count}");
            //name = names.Peek();
            //Console.WriteLine(name);
            //Console.WriteLine($"Total number Of names {names.Count}");
            #endregion Stack<>

            #region Queue<>
            Queue<string> names = new Queue<string>();
            names.Enqueue("Sushant");
            names.Enqueue("Shifa");
            names.Enqueue("Malani");
            Console.WriteLine($"Total numbers of names {names.Count}");

            string name = names.Dequeue();
            Console.WriteLine(name);
            Console.WriteLine($"Total numbers of names {names.Count}");
            name = names.Peek();
            Console.WriteLine(name);
            Console.WriteLine($"Total numbers of names{names.Count}");
            #endregion Queue<>
            Console.ReadLine();
        }
    }
}
