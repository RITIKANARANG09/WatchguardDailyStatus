using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Oct11
    {
        public static void Main(String[] args)
        {
            //-------------------------- abstract method/abstract class ----------------------------
            //var p1 = new parent(); // error
            var c1 = new child();
            c1.add(1, 2);
            c1.mul(1, 2);
            c1.div(1, 2);
            c1.sub(1, 2);
            c1.remainder(1, 2);
            parent p1 = c1; // reference
            p1.sub(1, 2);
            p1.add(1, 2);
            p1.mul(1, 2);
            p1.div(1, 2);
            //p1.remainder(1, 2); // error
            //---------------------------- sealed class -------------------------------------------
            var p2 = new SealedMethod();
            var c2 = new Child();
            var gc1= new GrandChild();
            p2.name();
            c2.name();
            gc1.name();
            SealedMethod s3 = gc1;
            s3.name();
            //---------------------------- ParamsInOut ------------------------------------------
            var x=new ParamsOutRef();
            int a = 10;
            int b= 20;
            int c;
            int d;
            var arrays=new int[] {4,5,6,7,8};
            //x.multiply(ref d, ref b);  // error
            x.multiply(ref a,ref b);
            x.divide(out c,out d);
            x.divide(out b, out d);
            x.arr(a, b, arrays);

        }
    }
}
