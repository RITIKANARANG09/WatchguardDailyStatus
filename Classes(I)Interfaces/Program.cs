using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
// interface don't have constructors
// classes can inherit multiple interfaces
// interfaces are like cotracts where we don't know what type of implementation would be there but we know
//interface is for achieving abstraction
// interface are of 2 types : implicit and explicit
//explicit means defining particular function to a particular class only
//Interface members must be implemented with the public modifier; otherwise, the compiler will give compile-time errors.
//Explicit implementation is useful when class is implementing multiple interfaces
// don't use public with explicit interface
//By default, members of an interface are abstract and public.
//can't contain fields,method declaration and access modifiers
//it doesn't have constructors 

namespace Interface
{
    interface Ishape
    {
      

        void Area();
        public int Area2(int x, int y)
        {
            return x * y;
        }
    }
    interface Iradius
    {
        void size();
    }
    interface Ilength
    {
        void size();
    }
    class circle : Ishape,Iradius,Ilength
    {
        void Iradius.size()
        {
            Console.WriteLine("it has radius");
        }
        void Ilength.size() { Console.WriteLine("it has no length and breadth"); }
        public void Area()
        {
            Console.WriteLine("circle area");
        }

    }
    class Oct10
    {

        public static void Main(string[] args)
        {
            //implicit interface
            circle c = new circle();
            c.Area();
            //c.size(); //error
            //c.Area2(2,4); //error while in abstract it will not give error
            Ishape o = new circle();
            o.Area2(2, 3);
            o.Area();
            //explicit interface
            Ishape s = new circle();
            s.Area();
            s.Area2(2,3);
            //s.size(); //error
            Iradius x = new circle();
            x.size();
        }
    }
}

/*using System;
using System.Runtime.CompilerServices;
// interface don't have constructors
// classes can inherit multiple interfaces
// interfaces are like cotracts where we don't know what type of implementation would be there but we know
//interface is for achieving abstraction
// interface are of 2 types : implicit and explicit
//explicit means defining particular function to a particular class only

namespace Interface
{
    public abstract class Shape
    {
        public abstract void  Area();
        public int Area2(int x, int y)
        {
            return x * y;
        }
    }
    class circle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("area");
        }

    }
    class Oct10
    {

        public static void Main(string[] args)
        {
            circle c = new circle();
            c.Area();
            c.Area2(2, 4);
            Shape o = new circle();
            o.Area2(2, 3);
            o.Area();
        }
    }
}*/
