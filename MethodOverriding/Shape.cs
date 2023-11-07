using System;

namespace MethodOverriding
{
    
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }

    }
    public class Retangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
    public class Shape
    {
        public virtual void Draw()
        {

        }

    }
    
}
