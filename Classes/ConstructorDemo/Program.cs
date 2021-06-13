using System;

namespace ConstructorDemo
{


    class Program
    {
        static void Main(string[] args)
        {
            // classic way to create class instance
            Customer customer1 = new Customer();

            // better way to declare variables/create instance
            var customer2 = new Customer();
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.Name);

            // passing values to constructor
            var customer3 = new Customer(1, "John Moorey");

            
            var order = new Order();
            customer3.Orders.Add(order);

        }
    }
}
