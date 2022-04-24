using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    abstract class EmployeeBaseManager
    {
        private string firstName, lastName, status;
        private double salary;
        private int annualPermit;
        private string ayrac = new string('-', 20);

        public void getInfo()
        {
            if (annualPermit > 0)
            {
                Console.WriteLine("{0}\n<Abstract Company Employee>\n{1}\n> FirstName: {2}\n-> LastName: {3}\n-> Status: {4}\n->" +
                    "Salary: {5} TL\n-> AnnualPermit: {6}\n {7}", ayrac, ayrac, firstName, lastName, status, salary, annualPermit, ayrac);
            }
            else
            {
                Console.WriteLine("{0}\n<Employe Not Found>\n{1}\n-> Sistem üzerinde getirmek istediğiniz kullanıcıların bilgisine erişemedim.\n{2}", ayrac, ayrac, ayrac);
            }
        }

        public void setInfo(string firstName, string lastName, double salary)
        {
            if (firstName.Length >= 3 && lastName.Length >= 2)
            {
                if (salary > 2500)
                {
                    this.firstName = firstName;
                    this.lastName = lastName;
                    this.salary = salary;
                    if (salary > 3000 && salary < 4000)
                    {
                        this.status = "Deneyimli " + status;
                        this.annualPermit = 20;
                    }
                    else if (salary > 4000 && salary < 5000)
                    {
                        this.status = "Kıdemli " + status;
                        this.annualPermit = 24;
                    }
                    else if (salary > 5000)
                    {
                        this.status = "Uzman " + status;
                        this.annualPermit = 30;
                    }
                    else
                        this.annualPermit = 14;
                }
                else
                {
                    Console.WriteLine("{0}\n<ERROR BRO>\n{1}\n-> Çalışanlara minimum 2500 TL vermeniz gerekmektedir. Çalışan Oluşturulamadı.\n{2}", ayrac, ayrac, ayrac);
                }
            }
            else
            {
                Console.WriteLine("{0}\n<ERROR BRO>\n{1}\n-> Çalışan isim uzunluğu ya da soy isim uzunluğu yeterli uzunlukta gözükmüyor.\n{2}", ayrac, ayrac, ayrac);
            }
        }

        public double getSalary()
        {
            return salary;
        }

        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public abstract void DoRaise();
        public abstract void DoRaise(double raiseRadio);
    }
}
