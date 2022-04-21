using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Ali";

            Customer customer = new Customer();
            customer.CreditCardNumber = "1";
            customer.FirstName = "Ahmet";

            Person person = new Person();
            person.FirstName = "CAN";

            Person person1 = customer;
            person1.FirstName = "Omer";

            Console.WriteLine(person.FirstName);
            Console.WriteLine(customer.CreditCardNumber);
            Console.WriteLine(((Customer)person1).CreditCardNumber);
            Console.WriteLine("--------------------------");

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            personManager.Add(customer);
            personManager.Add(person);
            personManager.Add(person1);
        }
    }

    // Base class
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) // Person vererek Employee ve Customer i da dahil etmis olduk.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
