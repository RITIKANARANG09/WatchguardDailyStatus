using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

/* 1.A method is a code block that contains a series of statements. 
 * 2.A method without the body is known as Abstract Method vs default method
 3.you cannot create an instance of an abstract class.This is because,
if it will allow us to create an instance of the abstract class, then using the instance you can call the abstract class abstract methods which do not 
have a body and this is the reason why it is not allowing us to create an instance of the abstract class in C#.     
   4.  Because it is not a fully implemented class as its abstract methods cannot be executed.
If the compiler allows us to create the object for an abstract class, we can invoke the abstract method using that object which cannot be executed by C
 5.if a class is non-abstract then it contains only non-abstract methods 
but if a class is abstract then it contains both abstract and non-abstract methods in C#.  
6.we can create a reference for the abstract class in C#. But we cannot create an instance of an abstract class in C#.
7.if class is not abstract gives error
8. abstract class can have constructors vs interface can have static constructor
 */
namespace Methods
{
    public abstract class parent
    {
        public void add(int x, int y)
        {
            Console.WriteLine("sum is : " + x+y);
        }
     /*   public string name;
        public parent(string name)
        {
            this.name=name;
        }*/
        public void sub(int x, int y)
        {
            Console.WriteLine("sub is : " + x + y);
        }
        public abstract void mul(int x, int y);
        public abstract void div(int x, int y);
    }
    public class child:parent
    {
        public override void mul(int x,int y)
        {
            Console.WriteLine("mul is : " + x*y);
        }
        public override void div(int x,int y)
        {
            Console.WriteLine("div is : " + x%y);
        }
        public void remainder(int x,int y)
        {
            Console.WriteLine("remainder is : " + x%y);
        }
    }
    
}