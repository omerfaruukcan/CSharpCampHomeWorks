using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Musteri Eklendi: " + customer.Name);
        }

        public void GetList(Customer[] customers)
        {
            Console.WriteLine("-- Musteri Listesi --");

            for (int i = 1; i <= customers.Length; i++)
            {
                foreach (var customer in customers)
                {
                    Console.WriteLine(i + "." + customer.Name);
                    i++;
                }
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Musteri Silindi: " + customer.Name);
        }
    }
}
