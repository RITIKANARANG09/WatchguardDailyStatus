using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Emp
    {
        public string name;
        public static int rn=4;
        public Emp(string name)
        {
            this.name = name;
            //this.rn = rn;   // error
            Console.WriteLine(name);
            Console.WriteLine(Emp.rn);
            print();
        }
        public static void print()
        {
            Console.WriteLine("in static methods");
        }
    }
    
}
