using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1, FirstName = "Omer Faruk", LastName = "CAN", City = "Istanbul"}; // parametresiz kullanim

            Customer customer2 = new Customer(); // parametresiz kullanim
            customer2.Id = 2;

            Customer customer3 = new Customer(3, "Busra", "CAN", "Catalca"); // parametreli kullanim
            Console.WriteLine(customer3.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Constructor calisti");
        }

        public Customer(int id, string firstName, string lastName, string city) // parametreli consturctor
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
