using Constructor;
using System;
/*1.Default
 2.Parameterized
3.Copy
4.Static
5.Private
6.Internal
7.Protected
*/
/* STATIC CONSTRUCTOR
 * 1.it will be invoked only once, irrespective of the number of class instances. It will be called automatically before the first instance is created
 * 2.it’s parameterless with no access modifier (compile error)
 * 3.A class can have only one static constructor.
It can access only static members of a class
 * 
 
 */
namespace Constructors
{ 
    //---------------- Default constructors --------------------------------
    /*If we do not create constructor the class will automatically call default constructor when an object is created.*/
    //---------------- Parameterless constructor ----------------------------
    //-------------- copy constructor --------------------------------------
    public class Copy { 
    public string firstName;
    public string lastName;
    public string position;
    public int salary;
    public Copy()
    {

    }
        //------------------------ Copy constructor
        /// *The constructor which creates an object by copying variables from another object is called a copy constructor.*/

        public Copy(Copy employee)
    {
        firstName = employee.firstName;
        lastName = employee.lastName;
        position = employee.position;
        salary = employee.salary;
    }

}   
   
    /*-------------------------- private constructor -------------------------------------------*/
    /*When a constructor is created with a private specifier, it is not possible for other classes to derive from this class, neither is it possible to create an instance of this class. They are usually used in classes that contain static members only. 
     internal instances(nested class),public constructor are psbl
    class can have multiple private and public constructors
     */
    public class Counter
    {
        public string name;
        private Counter()   //private constrctor declaration
        {
            //inside it will not run 
        }
        public Counter(string name)
        {
            this.name = name;
            Console.WriteLine("Hello" + name);
        }
        public static int currentview;
        public static int visitedCount()
        {
            return ++currentview;
        }
    }
    class User
    {
       
     // Static Constructor
     /*
      can have only one static constructor
     don't use access modifier

      */
        static User()
        {
            Console.WriteLine("I am Static Constructor");
        }
        // Default Constructor
        public User()
        {
            Console.WriteLine("I am Default Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Both Static and Default constructors will invoke for the first instance
            /*User user = new User();
            // Only the Default constructor will invoke
            User user1 = new User();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();*/
            //------------- copy -----------------
            /* Copy emp = new Copy();
             Copy emp1 = new Copy(emp);

             Console.WriteLine("Enter your first name:");
             emp1.firstName = Convert.ToString(Console.ReadLine());
             Console.WriteLine("Enter your last name:");
             emp1.lastName = Convert.ToString(Console.ReadLine());
             Console.WriteLine("Enter your position:");
             emp1.position = Convert.ToString(Console.ReadLine());
             Console.WriteLine("Enter your salary:");
             emp1.salary = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("First Name:" + emp1.firstName);
             Console.WriteLine("Last Name:" + emp1.lastName);
             Console.WriteLine("Position:" + emp1.position);
             Console.WriteLine("Salary:" + emp1.salary);*/
            /*-------------------- static constructor -----------------------------*/
            // befor initializing the value of fields,static constructor has initialized the value.
            /*  Console.WriteLine(StaticConstructor.name);
              Console.WriteLine(StaticConstructor.id);
              // after creating the constructor
              Console.WriteLine(StaticConstructor.name);
              Console.WriteLine(StaticConstructor.id);*/
            Const.meth();
            Const obj = new Const();
            Const.meth();
            Const obj2 = new Const();
            Const obj3 = new Const();
            Const obj4 = new Const();
            obj.increment();
            obj2.increment();
            Const.meth();
            obj3.increment();
            obj4.increment();
            Const.meth();
            /*-------------------- private constructor --------------------------*/
            // Counter aCounter = new Counter();   // Error
            /*Counter c = new Counter("RITIKA");
            Console.WriteLine("-------Private constructor ----------");
            Console.WriteLine();
            Counter.currentview = 500;
            Counter.visitedCount();
            Counter.visitedCount();
            Console.WriteLine("Now the view count is: {0}", Counter.currentview);
            Console.ReadLine();*/
        }
    }
}