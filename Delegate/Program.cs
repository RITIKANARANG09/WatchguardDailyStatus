using System;
public delegate void Calculation(int a, int b);
namespace Delegate
{
    class Q
    {
        public static void addition(int a, int b)
        {
            Console.WriteLine("Addition : {0}", a + b);
        }
        public static void subtraction(int a, int b)
        {
            Console.WriteLine("Subtraction : {0}", a - b);
        }
        public static void multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication : {0}", a * b);
        }
        public static void division(int a, int b)
        {
            Console.WriteLine("Division : {0}", a / b);
        }
    }

    class P:Q
    {
        
        public static void Main(String[] args)
        {
            Calculation c = new Calculation(addition);
            c.Invoke(20,20);
            c = subtraction;
            c(20,20);
            c = multiplication;
            c(20, 20);
            c = division;
            c.Invoke(20, 20);
        }
        
    }
}