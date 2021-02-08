using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, Name = "Ahmet", LastName = "adasdasd" };
            Customer customer2 = new Customer { Id = 2, Name = "Mehmet", LastName = "sadasda" };
            Customer customer3 = new Customer { Id = 3, Name = "Veli", LastName = "dasdasd" };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.ListCustomers();
            customerManager.Remove(customer2);
            customerManager.ListCustomers();
        }
    }
}
