using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks; /*virtual = virtual,seal*/ /*override=abstract,virtual*/
/*1.A class from which it is not possible to create/derive a new class is known as a sealed class. 
 2.if you want to declare a method as sealed, then it has to be declared as virtual in its base class.
3. by default, every method is a sealed method because overriding is not possible unless the method 
is not declared as virtual in the parent class.
4.If we don’t allow subclasses to override the superclass method and ensure that all sub-classes use
the same superclass method logic then that method should be declared as sealed. 
5.The private method is not inherited whereas the sealed method is inherited but cannot be overridden in C#
 6.
*/
namespace Methods
{
    public  class SealedMethod
    {
       public virtual void name()
        {
            Console.WriteLine("base class");
        }
    }
    public class Child : SealedMethod
    {
        public sealed override void name()
        {
            Console.WriteLine("child class");
        }
    }
    public sealed class GrandChild:Child
    {
        public  /*override*/ void name()
        {
            Console.WriteLine("grandchild class");
        }
    }
    //error
   /* public class grandgrand:GrandChild
    {

    }*/
}
