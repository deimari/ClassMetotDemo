using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customerList;
        public CustomerManager()
        {
            customerList = new List<Customer>();
        }
        public void Add(Customer customer)
        {
            customerList.Add(customer);
            Console.WriteLine(customer.Name + " " + customer.LastName + " added");
        }
        public void Remove(Customer customer)
        {
            customerList.Remove(customer);
            Console.WriteLine(customer.Name + " " + customer.LastName + " removed");
        }
        public void ListCustomers()
        {
            foreach (Customer customer in customerList)
            {
                Console.WriteLine("==================================");
                Console.WriteLine("Customer id: "  + customer.Id);
                Console.WriteLine("Customer name: " + customer.Name);
                Console.WriteLine("Customer lastname:  " + customer.LastName);
                Console.WriteLine("==================================");
            }
        }
    }
}
