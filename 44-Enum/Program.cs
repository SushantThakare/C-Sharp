using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Enum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.RollNumber = 1;
            s1.Name = "Sus";
            s1.Gender = EnumGender.Male;
            s1.Subject = EnumSubject.Science;
            Console.WriteLine($"RollNumber : {s1.RollNumber} Name : {s1.Name} Gender: {s1.Gender} Subject : {s1.Subject}");

            Student s2 = new Student();
            s2.RollNumber = 2;
            s2.Name = "Roshni";
            s2.Gender = EnumGender.Female;
            s2.Subject = EnumSubject.Marathi;
            //s2.Gender = 2;// for integral type example
            Console.WriteLine($"RollNumber : {s2.RollNumber} Name : {s2.Name} Gender: {s2.Gender} Subject : {s2.Subject}"  );

            Student s3 = new Student();
            s3.RollNumber = 3;
            s3.Name = "Kiran";
            s3.Gender = EnumGender.Unknown;
            s3.Subject = EnumSubject.Mathematics;
            Console.WriteLine($"RollNumber : {s3.RollNumber} Name : {s3.Name} " +
                $"Gender: {s3.Gender} Subject : {s3.Subject}" );

            Type t = Enum.GetUnderlyingType(typeof(EnumGender));
            Console.WriteLine($"GetUnderlyingType {t.Name}");
            Console.WriteLine();

            string[] name = Enum.GetNames(typeof(EnumGender));
            for( int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{name[i]} \t");
            }
            Console.WriteLine();
            int[] values = (int[])Enum.GetValues(typeof(EnumGender));
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"{values[i]} \t");
            }
            Console.ReadLine();
        }

        //static string GetGender( int incomingGender) for integral type example
        //{
        //    switch (incomingGender)
        //    {
        //        case 1: return "Male";
        //        case 2: return "Female";
        //        default: return "Invalid Gender";
        //    }

        //}
    }
}
