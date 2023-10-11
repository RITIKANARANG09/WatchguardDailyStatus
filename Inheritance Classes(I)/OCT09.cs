using System;
namespace Inheritance
{

    public class Student
    {
        private string name { get; set; }
        protected int age { get; set; }
        internal int id { get; set; }
        protected int marks { get; set; }
    }
    public class Student1 : Student
    {
        public void fxn()
        {
            var student1 = new Student1();
            //student1.name = "r";                      //error
            Student student2 = new Student1();
            student2.age = 20;
            student1.age = 20;
            Console.WriteLine(student1.age);
        }          // will work }
    //------------ constructor inheritance ----------------------------
        public class Teacher
    {
        //public Teacher() { Console.WriteLine("Teacher role"); }
        private string Name;
        public Teacher(string name) {
            Console.WriteLine("Name is {0} : ",name);
        }
    }
    public class Teacher2:Teacher 
        
    {
        public Teacher2(string name) : base(name) { Console.WriteLine("new Teacher role : {0}",name); }
    }
        //-------------- upcasting and downcasting -----------------------

    public class Info {
        public static void Main(string[] args)
        {
            var student = new Student();
            /* student.name = "RITIKA"; // error
             student.age = 20; //error
             Console.WriteLine(student.name, student.age); //error*/
            
            //----------
            Teacher2 teacher = new Teacher2("rn");

        } 
       }
    }
    
}