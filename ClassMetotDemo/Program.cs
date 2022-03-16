using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Omer Faruk";
            customer1.SurName = "CAN";
            customer1.MusteriNo = 12345;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Busra";
            customer2.SurName = "CAN";
            customer2.MusteriNo = 54321;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Hatice";
            customer3.SurName = "CAN";
            customer3.MusteriNo = 159753;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);

            Console.WriteLine("------------------------------");

            customerManager.Add(customer2);

            Console.WriteLine("------------------------------");

            customerManager.Add(customer3);

            Console.WriteLine("------------------------------");

            customerManager.GetList(customers);

            Console.WriteLine("------------------------------");

            customerManager.Delete(customer1);

            Console.WriteLine("------------------------------");

            customerManager.Delete(customer2);

            Console.WriteLine("------------------------------");

            customerManager.Delete(customer3);
        }
    }
}
