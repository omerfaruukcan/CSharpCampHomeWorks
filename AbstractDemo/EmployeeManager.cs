using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class EmployeeManager : EmployeeBaseManager
    {
        public EmployeeManager()
        {
            setStatus("Beden iscisi");
        }

        public override void DoRaise()
        {
            double salary = getSalary();
            double raise = salary + 50;
            setSalary(raise);
        }

        public override void DoRaise(double raiseRadio)
        {
            double salary = getSalary();
            double raise = salary + (salary * raiseRadio);
            setSalary(raise);
        }
    }
}
