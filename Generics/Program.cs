using System.Diagnostics.CodeAnalysis;


namespace T
{
    public class Generic<T>
    {
        public static T  sum(T one, T two)
        {
            T result = (dynamic)one / (dynamic)two;
            return result;
        }
        public static T compares(T one, T two)
        {
            T result = ((dynamic)one!)==((dynamic)two!);
            return result;
        }
    }
    class A
    {
        public static void Main(string[] args)
        {

            int result = Generic<int>.sum(2, 0);
            Console.WriteLine(result);
          /*  string result2 = Generic<string>.sum("a", "b");
            Console.WriteLine(result2);*/
        }
    }
}