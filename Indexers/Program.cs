using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Sarvesh";
            Console.WriteLine(cookie["name"]);
        }
    }
}
