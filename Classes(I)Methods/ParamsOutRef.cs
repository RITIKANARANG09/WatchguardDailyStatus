using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.The params keyword is useful when we are not sure about the number of arguments to send as a parameter.
 2.In c#, during method declaration, only one params keyword is allowed, and no additional parameters are permitted after the params keyword in a method declaration.
3.We can send arguments of the specified type as a comma-separated list or an array to the declared parameter. If we are not sending any arguments to the defined parameter, then the length of params list will become a zero.
4.In c#, out keyword is used to pass arguments to the method as a reference type. The out keyword same as the ref keyword, but the only difference is out doesn’t require a variable to be initialized before we pass it as an argument to the method. Still, the variable must be initialized in called method before it returns a value to the calling method.
5.The out parameter in c# is also useful to return more than one value from the methods in the c# programming language.
6.Using the ref keyword, we can pass parameters reference-type. It’s mandatory to initialize the variable value before passing it as an argument to the method in the c# programming language.



 */
namespace Methods
{
    public  class ParamsOutRef
    {
        public int multiply(ref int x,ref int y)
        {
            return x = x * y;
        }
        public void divide(out int x,out int y)
        {
            x = 10;
            y = 20;
            x = x * 10;
            y = y * 10;
        }
        public void arr(int a,int b,params int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
