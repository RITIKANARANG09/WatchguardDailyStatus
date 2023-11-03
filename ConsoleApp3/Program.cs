using System;
namespace ExtensionMethods
{
    public /*sealed*/ class Calculator
    {
        public int x, y;
        public string z;
        public Calculator(string z)
        {
            this.z = z;
        }
        public void add(int x,int y)
        {
            Console.WriteLine("Addition is :", x+y);
        }
        public void sub(int x, int y)
        {
            Console.WriteLine("Addition is :" , x - y);
        }
        public void print()
        {
            Console.WriteLine("Addition and subtraction calculator");
        }
        public void CountWords(string z)
        {
            string[] s = z.Split(' ');
            foreach (string s2 in s)
            {
                Console.WriteLine(s2);
            }
            Console.WriteLine("Function is called ");
        }
    }
    /*public class CalculatorInherit : Calculator
    {
        public CalculatorInherit(string z) : base(z)
        {
            this.z = z;
        }

        public void mult(int x,int y)
        {
            Console.WriteLine(x*y);
        }
        public void CountWords(string z)
        {
            string[] s = z.Split(' ');
            foreach (string s2 in s)
            {
                Console.WriteLine(s2);
            }
        }
    }*/
    public static class ExtensionClass
    {
        public static void CountWords(this Calculator ob,string z)
        {
            string[] s=z.Split(' ');
            foreach(string s2 in s)
            {
                Console.WriteLine(s2);
            }

            Console.WriteLine("Extension Function is called ");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //--------------------- with inheritance --------------------------------
            /*CalculatorInherit obj= new CalculatorInherit("Hello Ritika");
            Console.WriteLine(obj.z);
            obj.add(2, 4);
            obj.mult(2, 4);
            obj.CountWords("Ritika Narang");*/
            //--------------------- with extension methods --------------------------
            Calculator cal = new Calculator("rn");
            cal.CountWords("Hello Ritika");
        }
    }
}
