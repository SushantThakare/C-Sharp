using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoopingStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int start = 1;
            //while(start <= 11)
            //{
            //    Console.WriteLine("Sushant");
            //    start++;
            //}

            //int start = 1;
            //do
            //{
            //    Console.WriteLine("Susshant");
            //    start++;
            //} while (start <= 5);

            //for(int start = 1; start <= 5; start++)
            //{
            //    Console.WriteLine("Sushant");
            //}

            //for(int start = 1; start <= 10; start++)
            //{

            //    if (start == 9)
            //    {
            //        //break;
            //        continue;
            //    }
            //    Console.WriteLine(start);
            //}

            //for (int start =1;start <= 10; start++)
            //{
            //    Console.WriteLine(start);
            //    if (start == 5)
            //    {
            //        start = 10;
            //    }

            //}

            //for(int first = 5; first > 0; first--)
            //{
            //    for (int second = 1; second <= first; second++)
            //    {
            //        Console.Write("**\t");
            //    }
            //    Console.WriteLine("");
            //}


            //for(int i = 1; i <= 10; i++)
            //{

            //    if (i == 2)
            //    {
            //        continue;
            //    }
            //    if (i == 2)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //int[] fees = new int[5];
            //Console.WriteLine($"Size of array is {fees.Length}");
            //fees[0] = 15000;
            //fees[1] = 20000;
            //fees[2] = 55000;
            //fees[3] = 35000;
            //fees[4] = 45000;
            //for(int i = 0; i < fees.Length; i++)
            //{
            //    Console.WriteLine($"{fees[i]}");
            //}


            //string[] names = new string[] { "Sushant", "Vrushabh", "Pravin" };
            //for(int i=0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i] );
            //}


            //int[] numbers = new int[] { 1, 2, 4, 6, 8, 15,9, 14 };
            //Console.WriteLine("Original Items:-");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine("\n Reverse Items:-");
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}


            //numbers = new int[] { 22, 16, 16, 14, 9 };

            //int highest = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{

            //    for(int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[j] > highest)
            //        {
            //            highest= numbers[j];
            //        }
            //    }

            //    for (int k = numbers.Length-1; k>=0;k--)
            //    {
            //        if (numbers[k] > highest)
            //        {
            //            highest = numbers[k];
            //        }
            //    }
            //}
            //Console.WriteLine($"\nHighest Number is :-{highest}");


            //Console.WriteLine("Write Your Name");
            //string name = Console.ReadLine();
            //string reverseName = string.Empty;
            //for(int i = name.Length - 1; i >= 0; i--)
            //{
            //    reverseName += name[i];
            //}
            //Console.WriteLine($"Your Name {name}\n Reverse Name :- {reverseName}");

            //Console.WriteLine("Write Your Sentence");
            //string sentence = Console.ReadLine();
            //string[] word = sentence.Split(' ');
            //for (int i = word.Length - 1; i >= 0; i--) 
            //{
            //    Console.WriteLine(word[i]);

            //}


            //Console.WriteLine("Write Comma Separated Numbers");
            //string input = Console.ReadLine();
            //string[] number = input.Split(',');
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}


            //for (int i = 5; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("**\t");
            //    }
            //    Console.WriteLine();
            //}


            //*****
            // ***
            //  *
            //  *
            // ***
            //*****
            //Output of =>


            //// Upper part including the middle line
            //for (int i = 0; i < 3; i++)
            //{
            //    // Print leading spaces
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Print asterisks
            //    for (int k = 0; k < 5 - 2 * i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Lower part excluding the middle line (since it's already printed)
            //for (int i = 1; i < 3; i++)
            //{
            //    // Print leading spaces
            //    for (int j = 2; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Print asterisks
            //    for (int k = 0; k < 1 + 2 * i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}






            //for (int i = 1; i <= target; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine( i);
            //    }
            //};

            //Console.WriteLine("Please Enter Any Number");
            //int number = int.Parse(Console.ReadLine());

            //int numSize = number / 2;
            //int[] numStorage= new int[numSize];
            //int counter = 2;
            //for (int i = 0; i < numSize; i++,counter+=2)
            //{
            //    numStorage[i] = counter;
            //}

            //for (int i = 0;i < numStorage.Length;i++)
            //{
            //    Console.WriteLine(numStorage[i]);
            //}


            //MultiDimensional Array 
            int[,] multi = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"*");
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                }
                Console.WriteLine();

            }






            Console.ReadLine();
        }
    }
}
