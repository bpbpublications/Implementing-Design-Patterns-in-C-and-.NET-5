using System;

namespace _1.ChapterOne1._43
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization in C# 9.0
            Customer customer = new();
            customer.Name = "John";

            //Initialization in previous versions
            Customer customerTwo = new Customer();
            customerTwo.Name = "Paul";
        }
    }

    class Customer
    {
        public string Name { get; set; }
    }
}
