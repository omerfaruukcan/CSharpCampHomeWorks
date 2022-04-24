using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class DerivedClass : BaseClass
    {
        public override void Method2()
        {
            Console.WriteLine("Turetilmis class icerisinde tanimlanmis method2"); // abstract siniflar interface gibi bu sekilde kullanilabilir.
        }
    }
}
