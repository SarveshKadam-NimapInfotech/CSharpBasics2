using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    public class UtilityString
    {
        public static string SummarizeText(string text, int maxLength)
        {
            if(text.Length < maxLength)
            {
                return text;
            }

            var words = text.Split(' ');
            var totalwords = 0;
            var list = new List<String>();

            foreach(var word in words)
            {
                list.Add(word);

                totalwords += word.Length + 1;
                if (totalwords > maxLength)
                    break;
                
            }

            return String.Join(" ", list) + "...";

        }
    }
}
