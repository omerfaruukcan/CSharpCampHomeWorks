using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer() 
            {
                Id = 1, 
                FirstName = "Omer Faruk",
                LastName = "CAN", 
                Address = "Istanbul"
            };

            Student student = new Student()
            {
                Id = 1,
                FirstName = "Busra",
                LastName = "CAN",
                Departmant = "Health "
            };

            personManager.Add(customer);
            personManager.Add(student);

            Console.WriteLine("----------------------------");

            CustomerManager customerManager = new CustomerManager();
            SqlServerCustomerDal sqlServerCustomerDal = new SqlServerCustomerDal();

            customerManager.Add(sqlServerCustomerDal);
            customerManager.Add(new OracleCustomerDal());

            Console.WriteLine("----------------------------");

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
