using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract class lardan nesne olusturulamaz
            //BaseClass baseClass = new BaseClass();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method1();
            derivedClass.Method2();
        }
    }
}
