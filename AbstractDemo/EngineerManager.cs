using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class EngineerManager : EmployeeBaseManager
    {
        public EngineerManager()
        {
            setStatus("Engineer");
        }
        public override void DoRaise()
        {
            double salary = getSalary();
            double raise = salary + 250;
            setSalary(raise);
        }

        public override void DoRaise(double raiseRadio)
        {
            double salary = getSalary();
            double raise = salary + (salary * raiseRadio) + (salary % 2);
            setSalary(raise);
        }
    }
}
