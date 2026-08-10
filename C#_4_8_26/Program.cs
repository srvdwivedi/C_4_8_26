using System;

namespace C__4_8_26
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John Doe");
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Id);
        }    
    }
}