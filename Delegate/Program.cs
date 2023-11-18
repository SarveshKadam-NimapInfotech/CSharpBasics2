using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Calculation(int a, int b);
    public class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is : {0}", result);
        }

        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction result is : {0}", result);
        }

        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is : {0}", result);
        }

        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is : {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.Addition);

            obj(10, 50);

            obj = Subtraction;
            obj(60, 40);

            obj = Multiplication;
            obj(40, 8);

            obj = Division;
            obj(72, 9);

            Console.WriteLine("Multicast Delegate :");

            obj += Subtraction;
            obj += Multiplication;
            obj += Division;

            obj(250, 50);


        }
    }
}


