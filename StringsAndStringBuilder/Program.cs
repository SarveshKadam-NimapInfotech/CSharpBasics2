using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------String--------------------------------

            //var fullName = "Sarvesh Kadam ";
            //Console.WriteLine("Trim: '{0}'", fullName.Trim());
            //Console.WriteLine("ToUpper: '{0}'",fullName.Trim().ToUpper());

            //var index = fullName.IndexOf(' ');
            //var firstName = fullName.Substring(0, index);
            //var lastName = fullName.Substring(index + 1);
            //Console.WriteLine("First Name:" + firstName);
            //Console.WriteLine("Last Name:" + lastName);

            //var names = fullName.Split(' ');
            //Console.WriteLine("First Name:" + names[0]);
            //Console.WriteLine("Last Name:" + names[1]);

            //Console.WriteLine(fullName.Replace("Kadam","kd"));

            //if(String.IsNullOrEmpty(" ".Trim())) 
            //    Console.WriteLine("Invalid");

            //if (String.IsNullOrWhiteSpace(" "))
            //    Console.WriteLine("Invalid");

            //var str = "25";
            //var age = Convert.ToByte(str);
            //Console.WriteLine(age);

            //float price = 29.95f;
            //Console.WriteLine(price.ToString("C0"));

            //-----------------------------StringBuilder-----------------------

            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('-', 10));


            Console.WriteLine(builder);

            Console.WriteLine("First Char:" + builder[0]);


        }
    }
}
