﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);


        }
    }
}