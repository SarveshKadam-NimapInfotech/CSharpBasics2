using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is goin to be a really really really really really really really long text.";
            var summary = UtilityString.SummarizeText(sentence, 25);
            Console.WriteLine(summary);

        }

        
    }
}
