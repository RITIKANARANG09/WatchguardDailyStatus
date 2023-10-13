using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
        public class Vehicles
        {
            public virtual void draw()
        {
            Console.WriteLine("I am a vehicle");
        }
        }
        public class fourwheeler : Vehicles
        {
           public override void draw()
        {
            Console.WriteLine("I am a fourwheeler");
        }
        }
    public class twoWheeler : Vehicles
    {
        public override void draw()
        {
            Console.WriteLine("I am a twowheeler");
        }
    }
        
}
