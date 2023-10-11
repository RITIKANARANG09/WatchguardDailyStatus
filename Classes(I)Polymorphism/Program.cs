using System;

namespace Poly
{
    public interface Vehicle
    {
        void GetVehicle();
        void ShowVehicle()
        {
            Console.WriteLine("ddf");
        }

    }

    public class Car : Vehicle
    {
        public void GetVehicle()
        {
            Console.WriteLine("got a vehicle ");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.ShowVehicle();
            //var s = new List<Vehicle>();
            //s.Add(new fourwheeler());
            //s.Add(new twoWheeler());
            //var can = new Canvas();
            //can.DrawShapes(s);
            ////
            //var s2 = new Text();
            //s2.Draw();
            //s2.types(); // will not display anything
            //s2.classname();
        }
    }
}