using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Contructors
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var order = new Order(1, "laptop");
             var order1= new Order(2, "book");

            customer.Id = 1;
            customer.Name = "Sarvesh";
            customer.Orders.Add(order);
            customer.Orders.Add(order1);

            foreach(var item in customer.Orders)
            {
                Console.WriteLine(item.OrderId);
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


        }
    }
}
