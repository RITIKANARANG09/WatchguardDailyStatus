
using System;
using System.Security.Cryptography;
using System.Transactions;

namespace Classes
{
    public class PersonInfo
    {
        public string name;
        public int age;
       // public List<Order> orders;
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
    class Basic
    {

        public static void Main(string[] args)
        {
            /*PersonInfo values = new PersonInfo();
            values.intro("Ritika", 40);
            *//* values2 is a variable of type PersonInfo and is stored in stack but is empty i.e it 
            is not containing address/reference of actual object in heap bcs we haven't made it yet*/
            /*At run time, when you declare a variable of a reference type, the variable contains the
             value null until you explicitly create an instance of the class by using the new operator,
              or assign it an object of a compatible type that may have been created elsewhere*//*
            PersonInfo values2; // No error
                                //values2.age = 50;  // error
                         
            // without creating object
            //a)
            //var ob1 = values.info("Narang",40);
            //b)
            var ob2 = PersonInfo.info("Narang", 40);
            ob2.intro("Narang", 40);

            //referencing 2 objects to the same object
            var ob3 = ob2;
            ob3.print();
            ob2.age = 45;
            ob3.print();

            Customer customer = new Customer();
            Customer customer1 = new Customer("Ritika");
            Customer customer2 = new Customer(1, "Narang", 'a');
            //-------------- using class within another class------------------
            var order = new Order();
            customer.orders.Add(order);

            //object initializer  (instead of creating many constructors)
            PersonInfo customer3 = new PersonInfo
            {
                name = "ritika",
                age = 40
        };*/
            //------------- method overloading --------------------------
           // var obj = new MethodOverloading();
           /* Console.WriteLine(obj.x);
            Console.WriteLine(obj.y);
            obj.Method(10, 20);
            Console.WriteLine(obj.x);
            Console.WriteLine(obj.y);
            //obj.Method(new MethodOverloading(40, 50));
            Console.WriteLine(obj.x);
                Console.WriteLine(obj.y);*/

            //------------- readonly ----------------------------------------
           /* Customer obj2= new Customer();
            obj2.orders.Add(new Order());
            obj2.orders.Add(new Order());
            Console.WriteLine(obj2.orders.Count);
            //obj2.Prompt();
            Console.WriteLine(obj2.orders.Count);

            //------------- get,set (access modifier private) -----------------
            var prvt=new GetSetPrvt();
            //prvt.name;
            prvt.SetName("Ritika");
            Console.WriteLine(prvt.GetName());
            var prvt2=new GetSetPrvt();
            prvt.SetName("");
            Console.WriteLine(prvt2.GetName());
            
            //------------ indexer ---------------------------------------------
            var index = new Indexer();
            index["name"] = "RITIKA NARANG";
            Console.WriteLine(index["name"]);
            var index2=new Name();
            index2.name = "Ritika";
            Console.WriteLine(index2[0]);*/
            //--------------- get,set & indexer ----------------------------------

            var empInfo = new Employee("Ritika","Narang",1,"Software Engineer", 150000);
            //Console.WriteLine(empInfo[0]);   // error
            //after writing indexer in Employee class ------------
            // int
            Console.WriteLine(empInfo[0.01]); 
            Console.WriteLine(empInfo[0.02]);
            Console.WriteLine(empInfo[0.03]);
            Console.WriteLine(empInfo[0.04]);
            Console.WriteLine(empInfo[0.05]);
            // after modification
            empInfo[0.01] = 200;
            empInfo.id = 2;
            Console.WriteLine(empInfo["FirstName"]);
            Console.WriteLine(empInfo["LastName"]);
            Console.WriteLine(empInfo["id"]);
            Console.WriteLine(empInfo["Job"]);
            Console.WriteLine(empInfo["Salary"]);

            //-------------------- upcasting and downcasting -----------------------------
         /*   Text text = new Text();
            Shape s = text;
            s.width = 200;
            text.width = 100;
          
            Console.WriteLine(text.width);

            //-------------------- get set using properties -------------------

            var prop = new Properties("r");
            prop.Name="RITIKA";
            Console.WriteLine(prop.Name);
            Console.WriteLine(prop.Value); // int default value;
            //--------------- internal & protected internal access modifier -----------------------------------------------
            //Student s = new Student();

            var c = new Person(new DateTime(2001,09,19));
            //var dt = new DateTime(1999,09,09);
            Console.WriteLine( c.Age );*/

        }
    }
}