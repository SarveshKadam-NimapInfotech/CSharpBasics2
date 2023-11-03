using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");

            }
            catch (Exception)
            {

                Console.WriteLine("conversion failed");
            }

            int number;
            if(int.TryParse("abc", out number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("coverstion failed");
            }
        }
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(10, 20));
            Console.WriteLine(calculator.Add(10, 20, 30, 40));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 2, 5, }));

        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                //point.Move(new Point(40, 50));
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is ar ({0}, {1})", point.X, point.Y);

            }
            catch (Exception)
            {

                Console.WriteLine("an unexpected error occured.");

            }

        }
    }
}
