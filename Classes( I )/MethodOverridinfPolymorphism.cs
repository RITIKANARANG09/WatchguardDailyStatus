using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
        public class Vehicle
        {
            public void draw()
        {
            Console.WriteLine("I am a vehicle");
        }
        }
        public class fourwheeler : Vehicle
        {
           public void draw()
        {
            Console.WriteLine("I am a fourwheeler");
        }
        }
    public class twoWheeler : Vehicle
    {
        public void draw()
        {
            Console.WriteLine("I am a twowheeler");
        }
    }
        
}
