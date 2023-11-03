using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal partial class Program
    {       
        static void Main(string[] args)
        {
            var person = new person(new DateTime(1996, 09, 21));
            person.Name = "Sarvesh";
            person.Surname = "Kadam";
            Console.WriteLine($"Name : {person.Name} {person.Surname}, Age : " +person.Age);

        }
    }
}
