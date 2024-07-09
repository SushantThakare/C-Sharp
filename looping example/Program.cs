using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace looping_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Plz enter your number");
            //int i = int.Parse(Console.ReadLine());
            //for (int row = 1; row <= i; row++)
            //{

            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}
            //Console.WriteLine("Please enter your no");
            //int number = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(number + " x " + i + " = " + number*i );
            //}


            //int j = 1;
            //while (j < 1)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}
            //Console.WriteLine("Loop Ends");

            //int f = 1;
            //do
            //{
            //    Console.WriteLine(f);
            //    f++;
            //}
            //while (f < 1);
            //Console.WriteLine("Loop Ends");

            //int i ;
            //for ( i=0 ; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("--------------------");
            //Console.WriteLine(i);


            //int j = 0 ;
            //do
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}
            //while (j < 10);
            //      Console.WriteLine("--------------------");
            //Console.WriteLine(j);


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Hello");

            //    for (int j = 0; j < 3; j++) 
            //    Console.WriteLine("Hey");

            //}
            //Console.WriteLine("Loop Terminates");

            //Console.WriteLine("plz enter your no ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0 && number != null)
            //{
            //    for (int row = 1; row <= number; row++)
            //    {
            //        for (int col = 1; col <= row; col++)
            //        {
            //            Console.Write("* ");
            //        }
            //        Console.WriteLine();
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Your input is invalid");
            //}
            //Console.WriteLine("plz enter your no ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0 && number != null)
            //{
            //    for (int row = 1; row <= number; row++)
            //    {
            //        for (int col = 1; col <= number; col++)
            //        {
            //            Console.Write("* ");
            //        }
            //        Console.WriteLine();
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Your input is invalid");
            //}

            //Console.WriteLine("plz enter your no ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0 && number != null)
            //{
            //    for (int row = 1; row <= number; row++)
            //    {
            //        for (int col = number; col >= row; col--)
            //        {
            //            Console.Write("* ");
            //        }
            //        Console.WriteLine();
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Your input is invalid");
            //}

            //Console.WriteLine("plz enter your no ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0 && number != null)
            //{
            //   for(int row=0; row< 2*number;row++)
            //    {
            //        int totalColsInRows = row > number ? 2 * number - row : row;

            //        for(int col = 0;col< totalColsInRows; col++)
            //         {
            //            Console.Write("* ");
            //        }
            //        Console.WriteLine();
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Your input is invalid");
            //}


            //Console.WriteLine("plz enter your no ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0 && number != null)
            //{
            //    for (int row = 0; row < 2 * number; row++)
            //    {
            //        int totalColsInRows = row > number ? 2 * number - row : row;

            //        int Spaces = number-totalColsInRows;

            //        for(int s = 0; s < Spaces; s++)
            //        {
            //            Console.Write(s);
            //        }

            //        for (int col = 0; col < totalColsInRows; col++)
            //        {
            //            Console.Write("* ");
            //        }
            //        Console.WriteLine();
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Your input is invalid");
            //}

            //Console.WriteLine("plz enter your no ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0 && number != null)
            //{
            //   for(int row = 1; row <= number; row++)
            //    {
            //        for(int space = 0; space < number-row; space++)
            //        {
            //            Console.Write("  ");
            //        }
            //        for(int col = row; col >= 1; col--)
            //        {
            //            Console.Write(col + " ");
            //        }
            //        for (int col = 2; col <= row; col++)
            //        {
            //            Console.Write(col + " ");
            //        }
            //        Console.WriteLine();
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Your input is invalid");
            //}


            //Console.WriteLine("plz enter your no ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0 && number != null)
            //{
            //    for (int row = 1; row < 2*number ; row++)
            //    {
            //        int logic = row > number ? 2 * number - row : row;

            //        for (int space = 0; space < number - logic; space++)
            //        {
            //            Console.Write("  ");
            //        }
            //        for (int col = logic; col >= 1; col--)
            //        {
            //            Console.Write(col + " ");
            //        }
            //        for (int col = 2; col <= logic; col++)
            //        {
            //            Console.Write(col + " ");
            //        }
            //        Console.WriteLine();
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Your input is invalid");
            //}


            Console.WriteLine("plz enter your no ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number != null)
            {
                int originalnumber = number;
                number = 2 * number  ;
                for (int row = 0; row <= number ; row++)
                {
                    for(int col=0; col <= number ; col++)
                    {
                        int logic = originalnumber - Math.Min(Math.Min(row, col), Math.Min(number - row, number - col));
                       
                        Console.Write(logic + " ");
                    }
                    Console.WriteLine();

                }

            }
            else
            {
                Console.WriteLine("Your input is invalid");
            }


            Console.ReadLine();
        }
    }
}
