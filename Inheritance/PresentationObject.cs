using System;

namespace Inheritance
{

    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }

        public void dublicate()
        {
            Console.WriteLine("Object dublicate created");
        }
    }

}
