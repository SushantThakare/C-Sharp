using System;
public partial class Student : A, IStudent
{
    public int RollNumber { get; set; }
    public string Name { get; set; }

    public Student()
    {
        printA();
    }
    partial void printA();

}







interface IStudent
{
    void print();
}

public class A
{

}
class B
{

}

