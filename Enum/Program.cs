// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// value type
// non primitive in nature
/* by default value assigned to them is int and starts from 0 and incremented in that way
 but we can also initialize them as we want them to*/
//enum vs constants -> more cleared way
/*enum? used to represent collection of named constants having a datatype that intializes 
 a variable and in that variable value of constants can be assigned */
//can't initialize it to float 
/*const int startday = 0;
string start = "Monday";
start = "Sunday";*/
using System;
enum Vehicle
{
    car = 07,
    bus,
    train,
    scooty,
    bike,
    auto
}
/*enum Color
{
    Red,
    Green = 10,
    Blue
}*/

namespace Enumm
{
    class Program
    {
        static void Main(string[] args)
        {
           //Vehicle fourW = Vehicle.car;
            Vehicle twoW = Vehicle.bike | Vehicle.scooty; // will display sum of both
            Console.WriteLine(" two wheelers are : {0}",twoW);
            //Enum.GetNames(twoW);
           /* Console.WriteLine(twoW);
            var a = (Vehicle)3;
            Console.WriteLine(a);
            var b = (Vehicle)40;
            Console.WriteLine(b);
            bool tW =(fourW & Vehicle.auto)==Vehicle.auto;
            Console.WriteLine($"Is auto a four wheeler ?{tW} ");
            Console.WriteLine($"TwoWheelers are : {fourW}");*/
            //Vehicle[] values = (Vehicle[])Enum.GetValues(typeof(Vehicle));

            /*foreach (Vehicle value in Enum.GetValues(typeof(Vehicle)))
            {
                if ((fourW & value) == value )
                {
                    Console.WriteLine(value);
                }
            }*/
            /*Console.WriteLine(StringFromColor(Color.Red));
            Console.WriteLine(StringFromColor(Color.Green));
            Console.WriteLine(StringFromColor(Color.Blue));*/
        }
        /*static string StringFromColor(Color c)
        {
            switch (c)
            {
                case Color.Red:
                    return $"Red = {(int)c}";
                case Color.Green:
                    return $"Green = {(int)c}";
                case Color.Blue:
                    return $"Blue = {(int)c}";
                default:
                    return "Invalid color";
            }
        }*/
        //string[] a = new List<String>();
    }
}

