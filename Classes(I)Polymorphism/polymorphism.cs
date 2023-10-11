using System;

namespace Poly
{
    public abstract class Shape
    {
        public abstract void Draw();
        public void classname()
        {
            Console.WriteLine("Classname is shape ");
        }
        public void types() { }
            
    }
    public class Text : Shape
    {
                public int FontSize { get; set; }
        public int FontName { get; set; }
        public override void Draw()
        {
            Console.WriteLine("first enter text now ");
        }
    }
    
}
