using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
        public class Animal
        {
            protected  void sound()
            {
                Console.WriteLine("Diff types of sounds of animals");
            }
        }
        public class Snake : Animal
        {

        public Snake()
        {
            /*Animal a= new Dog();
            a.sound();
            Snake snake= new Snake();
                snake.sound();*/
        }
            public  void sound()
            {
                Console.WriteLine("Hiss");
            }
            public void Move()
            {
                Console.WriteLine("Crawl");
            }
        }

        public class Dog : Animal
        {
            public overr void sound()
            {
                Console.WriteLine("Bark");
            }
            public void Move()
            {
                Console.WriteLine("yes");
            }
        }
}
