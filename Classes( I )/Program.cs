using System;
using System.Transactions;

namespace Classes
{
    public class PersonInfo
    {
        public string name;
        public int age;
        public void intro(string name,int age)
        {
            this.name = name;
            this.age = age;
            bool ans = (this.name == name);
            Console.WriteLine(ans);
            Console.WriteLine("Hello {0}, your age is {1}",name,age);
        }
        public void print()
        {
            Console.WriteLine("Hello {0}, your age is {1}",name,age);
        }
        public static PersonInfo info(string str,int age)
        {
            PersonInfo helper= new PersonInfo();
            helper.name = str;
            helper.age = age;
            return helper;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            PersonInfo values = new PersonInfo();
            values.intro("Ritika", 40);
            /* values2 is a variable of type PersonInfo and is stored in stack but is empty i.e it 
            is not containing address/reference of actual object in heap bcs we haven't made it yet*/
      /*At run time, when you declare a variable of a reference type, the variable contains the
       value null until you explicitly create an instance of the class by using the new operator,
        or assign it an object of a compatible type that may have been created elsewhere*/
            PersonInfo values2; // No error
                                //values2.age = 50;  // error

            // without creating object
            //a)
            //var ob1 = values.info("Narang",40);
            //b)
            var ob2=PersonInfo.info("Narang", 40);
            ob2.intro("Narang", 40);

            //referencing 2 objects to the same object
            var ob3 = ob2;
            ob3.print();
            ob2.age = 45;
            ob3.print();


        }
    }
}