using System;
namespace St
{
    /*interface Detail
    {
        string Name { get; }
    }*/
    public class Student
    {
        public string Name;
        public int rollno;
        //public Address add;
        public Student()
        {
            //add=new Address();
            Console.WriteLine("base class");
        }

    }
    public class Address:Student
    {
        public int Houseno;
        public string colonyName;
        public Address() { Console.WriteLine("derived class"); }
    }
    public class Teacher
    {

    }
    public class Program
    {
        public static void Main(string[] args)
        {
           /* Student obj = new Student();
            obj.Name = "RITIKA";
            obj.rollno = 20;
            obj.add.Houseno = 6;
            obj.add.colonyName = "ABCD";
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.rollno);
            Console.WriteLine(obj.add.Houseno);
            Console.WriteLine(obj.add.colonyName);*/
           Student s=new Student();
            Student s2=new Address();
            Address a=new Address();
        }
    }
}