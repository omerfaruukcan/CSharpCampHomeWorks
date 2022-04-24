using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface newlenemez
            // IPersonManager personManager = new IPersonManager();

            IPersonManager customer = new CustomerManager();
            IPersonManager employee = new EmployeeManager();
            IPersonManager intern = new InternManager();

            customer.Add();
            customer.Update();
            employee.Add();
            employee.Update();
            intern.Add();
            intern.Update();

            Console.WriteLine("-------------------");

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customer);
            projectManager.Update(customer);
            projectManager.Add(employee);
            projectManager.Update(employee);
            projectManager.Add(intern);
            projectManager.Update(intern);

            Console.WriteLine("-------------------");

            projectManager.Add(new CustomerManager());
            projectManager.Update(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Update(new EmployeeManager());
            projectManager.Add(new InternManager());
            projectManager.Update(new InternManager());

        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    // inherits eger class olursa, implements interface olursa
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // musteri ekleme kodlari
            Console.WriteLine("Musteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Guncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // personel ekleme kodlari
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Guncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");        
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Guncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
