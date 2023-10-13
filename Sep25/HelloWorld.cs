// See// https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World Ritika!");
using System;
namespace HelloWorld
{
    //ANOTHER CLASS
    /*public class Vehicle
    {
        public string Name;
        public string vehicleName()
        {
            Console.WriteLine("Your vehicle name is ");
            return Name;
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            // HELLO WORLD//
            //Console.WriteLine(" Hello RITIKA ");

            //OVERFLOWING//
            /*checked
            {
                int maxInt = int.MaxValue;  // The maximum value for an integer
                int overflowedInt = maxInt + 1;  // This will cause an overflow
                Console.WriteLine("Maximum Integer Value: " + maxInt);
                Console.WriteLine("Overflowed Integer Value: " + overflowedInt);
            }*/

            //CONVERSION//
            /*1.
            string booleanval = "false";
            bool val2 = Convert.ToBoolean(booleanval);
            Console.WriteLine(val2);*/

            /*2.
            string value = "1234";
            //int numVal = (int)value; // will give error bcs of non compatible types
            Byte numVal=Convert.ToByte(value); //use try and catch
            try
            { Ritika
                string value = "1234";
                Byte numVal = Convert.ToByte(value);
                Console.WriteLine(numVal);  

            }
            catch ( Exception)
            {
                Console.WriteLine("This can't be converted");
            }
            */

            //CLASS
           /* var vehicle = new Vehicle();
            vehicle.Name = "Car";
            Console.WriteLine(vehicle.vehicleName());*/
        }
    }
}