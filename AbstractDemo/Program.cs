using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateEmployeeManager employee1 = new CreateEmployeeManager();
            employee1.employeeBaseManager = new EmployeeManager();
            employee1.Create();
            employee1.getInfo();

            CreateEmployeeManager engineer1 = new CreateEmployeeManager();
            engineer1.employeeBaseManager = new EngineerManager();
            engineer1.Create();
            engineer1.getInfo();

            engineer1.DoRaise();
        }
    }

}
