using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTask
{
    public class stack
    {
        private readonly List<object> list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You cannot add a null object to the stack.");

            list.Add(obj);
        }

        public object Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("There are no elements in the stack yet. ");

            var toReturn = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);

            return toReturn;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new stack();

            int ini = 0;
            int max = 5;

            for(var i = ini; i < max; i++)
            {
                stack.Push(i);
            }

            for(var i = ini; i < max; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadLine();
        }
    }
}
