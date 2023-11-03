using System;

namespace Inheritance
{
    internal partial class Program
    {
        public class Text : PresentationObject
        {
            public int fontName { get; set; }
            public int fontSize { get; set; }

            public void AddHyperlink(string url)
            {
                Console.WriteLine("Added a link " + url);

            }
        }

    }
}

