using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
