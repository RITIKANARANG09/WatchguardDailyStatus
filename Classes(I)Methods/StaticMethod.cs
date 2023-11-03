using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
     public class Emp
    {
        public string name;
        public static int rn=4;
        public Emp(string name)
        {
            Console.WriteLine("instance constructor is called ");
            this.name = name;
            //this.rn = rn;   // error
            Console.WriteLine(name);
            Console.WriteLine(rn);
            //print();
        }
        static Emp()
        {
            Console.WriteLine("static constructor is called ");
        }
        public static  void print()
        {
            Console.WriteLine("in static methods from base class");
        }
    }
    public class Emp1 : Emp
    {
        public Emp1(string name) : base(name)
        {
        }

        public void print()
        {
            Console.WriteLine("hello from derived class");
        }
    }
    
}
