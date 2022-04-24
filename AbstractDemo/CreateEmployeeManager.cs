using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class CreateEmployeeManager
    {
        public EmployeeBaseManager employeeBaseManager;
        private string ayrac = new string('-', 20);
        private string firstName, lastName;
        private double salary;

        public void Create()
        {
            Console.Write("{0}\n<Create Employe Manager>\n{1}\n-> Employee FirstName: ", ayrac, ayrac);
            firstName = Console.ReadLine();
            Console.Write("-> Employee LastName: ");
            lastName = Console.ReadLine();
            Console.Write("-> Employee Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ayrac);
            employeeBaseManager.setInfo(firstName, lastName, salary);
        }

        public void getInfo()
        {
            employeeBaseManager.getInfo();
        }

        public void DoRaise()
        {
            employeeBaseManager.DoRaise();
            Console.WriteLine("{0}\n<Zam Uygulandı>\n{1}\n-> New Salary: {2} TL\n{3}", ayrac, ayrac, employeeBaseManager.getSalary(), ayrac);
        }

        public void DoRaise(double raiseRadio)
        {
            employeeBaseManager.DoRaise(raiseRadio);
            Console.WriteLine("{0}\n<Zam Uygulandı>\n{1}\n-> New Salary: {2} TL\n{3}", ayrac, ayrac, employeeBaseManager.getSalary(), ayrac);
        }
    }
}
