using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    static class StaticConstructor
    {
        
        public static string name="Ritika";
        public static int id=10;
        static StaticConstructor()
        {
            Console.WriteLine("Static construuctor is called");
        }
        
    }
    public class Const
    {
        public int id1 = 10;
        public static int id2 = 10;
        static Const(){
            Console.WriteLine("Static constructor is called");
            }
        public Const()
        {
            Console.WriteLine("Instance constructor is called");
        }
        
        public void increment()
        {
            id1=id1+1;
            id2 = id2+1;
            Console.WriteLine("Normal field "+" " +(id1));
            Console.WriteLine("Static field "+ " " +(id2));
        }
        public static void meth()
        {
            Console.WriteLine("static method is called");
        }
    }
}
