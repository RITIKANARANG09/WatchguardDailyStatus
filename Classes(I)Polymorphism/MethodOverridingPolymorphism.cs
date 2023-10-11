using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
        public class Vehicle
        {
            public virtual void draw()
        {
            Console.WriteLine("I am a vehicle");
        }
        }
        public class fourwheeler : Vehicle
        {
           public override void draw()
        {
            Console.WriteLine("I am a fourwheeler");
        }
        }
    public class twoWheeler : Vehicle
    {
        public override void draw()
        {
            Console.WriteLine("I am a twowheeler");
        }
    }
        
}
