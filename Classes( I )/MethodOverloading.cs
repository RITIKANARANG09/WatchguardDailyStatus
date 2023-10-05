using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class MethodOverloading
    {
        public int x;
        public int y;
        public MethodOverloading() { }
        public MethodOverloading(int x,int y) { this.x = x;
            this.y = y;
        }
        public void Method(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Method(MethodOverloading obj)
        {
            this.x = obj.x;
            this.y = obj.y;
        }
    }
}
