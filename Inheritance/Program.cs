using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3] 
            {
                new Person { FirstName = "Busra" },
                new Customer { FirstName = "Omer Faruk" },
                new Student() {FirstName = "Hatice" }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    interface IPerson
    {

    }

    class Customer : Person, IPerson
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}

// Bir class sadece bir classi miras alabilir 2 tane alamaz fakat birden cok interfacesi alabilir.
// önce inheritance lar yazilir sonra interfaceler yazilir.
// class larin tek basina bi anlami vardir fakat interfacelerin yoktur.

// abstract classlarda inheritence kullanilir genelde, eger interface kullanilabiliyorsa genelde interface kullanilir

