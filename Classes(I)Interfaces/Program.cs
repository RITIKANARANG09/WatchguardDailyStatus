using System;
using System.Runtime.CompilerServices;

namespace Interface
{
    class Oct10
    {
        interface IShape
        {
            float area();
            int this[int i] { get; set; }
        }
        public class Circle: IShape
        {
            private int r;
            List<int> z = new List<int>();
            public Circle(int r)
            {
                this.r=r;
            }
            public float area()
            {
                return (float)3.14 * r * r;
            }
            public int this[int i]
            {
                get {
                    if (i < 0 || i >= z.Count)
                    { throw new ArgumentOutOfRangeException("Index out of range"); }
                    else
                        return z[i];
                }
                set {
                    if (i < 0 || i >= z.Count)
                    { throw new ArgumentOutOfRangeException("i","Index out of range"); }
           
                        z[i] = value; }
            }
        }
        public static void Main(string[] args)
        {
            var c = new Circle(10);

            Console.WriteLine( c.area() );
            var c2= new Circle(20);
            c2[0] = 10;
            c2[1] = 20;
            Console.WriteLine(c2[0]);
            Console.WriteLine(c2[1]);
        }
    }
}
