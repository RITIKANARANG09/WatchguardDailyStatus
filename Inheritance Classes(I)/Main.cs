using System;
using System.Security.Cryptography.X509Certificates;
namespace Inheritance
{

   
    //------------ constructor inheritance ----------------------------
     public class A
    {
        public void name()
        {
            Console.WriteLine("hello class A");
        }
    }
    public class  B:A
    {
        public B()
        {
            B b = new B();
            b.name();
            A a=new A();
            a.name();
        }
    }
    public class Info {
        public static void Main(string[] args)
        {
            //base,new,abstract/virtual no instance
            Animal a = new Animal();
            Animal s = new Snake();
            Animal d = new Dog();
            d.sound(); // method of animal
            // after overriding
            d.sound(); // method of dog
            // d.Move(); // error
            // why upcasting ?
            var lists = new List<Animal>() { 
            d,s
            };
            
            foreach(var index in lists)
                index.sound();
            // to remove d.Move() error , will do downcasting
            Dog nd = (Dog)d;
            nd.Move();
            // downcasting without upcasting
            //Snake ns = (Snake)s;    // error

            /*Animal animal = new Snake();
            if (animal is Snake snake)
            {
                snake.Move();
            }
            var obj = new object();
            var owlObj = obj as Snake;
            if (owlObj != null)
            {
                owlObj.Fly();
            }*/
        } 
       }
    }
    
