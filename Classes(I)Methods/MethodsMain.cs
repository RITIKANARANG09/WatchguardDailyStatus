//using Classes_I_Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Oct11
    {
        private const bool V = false;

        public static void Main(String[] args)
        {
            //-------------------------- abstract method/abstract class ----------------------------
            //var p1 = new parent(); // error
            /* var c1 = new child();
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
             //p1.remainder(1, 2); // error*/
            //---------------------------- sealed class -------------------------------------------
            var p2 = new SealedMethod();
            var c2 = new Child();
            GrandChild gc1 = new GrandChild();
            p2.name2();
            c2.name2();
            gc1.name2();
            //gc1.name();
            SealedMethod s3 = gc1;
            s3.name2();
            SealedMethod a = new Child();
            a.name2();
            a = gc1;
            a.name2();
            Child b = new GrandChild();
            b.name2();
            var gc2= new GrandChild();
            gc2.name2();
            //---------------------------- ParamsInOut ------------------------------------------
            /*var x=new ParamsOutRef();
            int a = 10;
            int b= 20;
            int c;
            int d;
            var arrays=new int[] {4,5,6,7,8};
            //x.multiply(ref d, ref b);  // error
            x.multiply(ref a,ref b);
            x.divide(out c,out d);
            x.divide(out b, out d);
            x.arr(a, b, arrays);*/
            //------------------------------- static method --------------------------
            /* Emp e = new Emp("ritika");
             Console.WriteLine(e.name);
             Console.WriteLine(Emp.rn);
             Emp.rn = 20;
             // Emp.print();
             Console.WriteLine(Emp.rn);
             Emp e2 = new Emp("Narang");
             Emp.print();
             bool refe;
             if (object.ReferenceEquals(e, e2)) refe = true;
             else refe = false;
             Console.WriteLine(refe);
             Emp1 e3 = new Emp1("hello");*/
            // Emp1.print();

        }
    }
}
