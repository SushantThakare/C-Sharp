using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.RollNumber = 1;//Assigning/setting/write
            //s1.Name = "Sushant";
            //s1.PassMarks = 35;
            //Console.WriteLine($"RollNumber: {s1.RollNumber}\n" +
            //    $"Name: {s1.Name}\nPassMarks: {s1.PassMarks}");//Read/get/fetch
            //Student s1 = new Student();
            //s1.SetRollNumber(1);//Assigning/setting/write
            //s1.SetName("Sushant");


            //Console.WriteLine($"RollNumber: {s1.GetRollNumber()} Name:{s1.GetName()} " +
            //    $"PassMarks:{s1.GetPassMarks()}");//Read/get/fetch

            Student s = new Student();
            s.RollNumber = 5;
            s.Name = "Sushant";
            
            Console.WriteLine(s.RollNumber +" "+ s.Name + " " +s.PassMarks);

            Console.ReadLine();
        }
    }
    //class Student
    //{
    //    private int _rollNumber;
    //    private string _name;
    //    private int _passMarks = 35;

    //    public void SetRollNumber(int rollNumber)
    //    {
    //        if (rollNumber > 0)
    //        {
    //            _rollNumber = rollNumber;
    //        }
    //        else
    //        {
    //           _rollNumber = 0;
    //            Console.WriteLine("Roll Number can not be Negative");
    //        }
    //    }

    //    public int GetRollNumber()
    //    {
    //        return _rollNumber;
    //    }

    //    public void SetName(string name)
    //    {

    //        _name = name;

    //    }
    //    public string GetName()
    //    {
    //        return  !string.IsNullOrEmpty(_name) ? _name : "No Name Provided";
    //    }



    //    public int  GetPassMarks()
    //    {
    //        return _passMarks;
    //    }
    //}

    class Student
    {
        private int _rollNumber;
        private string _name;
        private int _passMarks = 35;

        public int RollNumber
        {
            get
            {
                return _rollNumber;
            }

            set
            {

                if (value > 0)
                {
                    _rollNumber = value;
                }
                else
                {
                    _rollNumber = 0;
                    Console.WriteLine("Roll Number can not be Negative");
                }
            }
        }

        public string Name
        {
            get
            {
                return !string.IsNullOrEmpty(_name) ? _name : "plz input valid Name";
            }

            set { 
             _name = value;
            }
        }

        public int PassMarks
        {
            get
            {
                return _passMarks;
            }
        }
    }

}
