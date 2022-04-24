using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Abstract class icinde tanimlanmis method");
        }

        public abstract void Method2(); // method bildirimi
    }

    public abstract class AbstractClass1 : AbstractClass2
    {
        public abstract void Method_1();
    }

    public abstract class AbstractClass2
    {
        public abstract void Method_2();
    }

    class DerivedClass2 : AbstractClass1
    {
        public override void Method_1()
        {
            Console.WriteLine("Method_1() tanimlandi");
        }

        public override void Method_2()
        {
            Console.WriteLine("Method_2() tanimlandi");
        }
    }
}


// Normal sınıflar içerisinde metot bildirimi yapılamazken, Abstract sınıflar içerisinde tıpkı arayüzler de olduğu gibi metot bildirimi yapılabilir.
// Bildirimi yapılan metotlar, Abstract sınıftan türeyen sınıflar içerisinde tanımlanmak zorundadır.
// Normal sınıflardan “new()” anahtar sözcüğü ile nesneler oluşturulabilir ancak Abstract sınıflar tamamen kalıtım amaçlı geliştirildiğinden Abstract sınıflardan nesne oluşturulamaz.

// Arayüzlerde sadece metot bildirimi yapılabilirken Abstract sınıflarda hem metot bildirimi yapılabilir hem de metot tanımlanabilir.
// Bir sınıfa sadece bir tane Abstract sınıf inherit edilebilir ancak aynı sınıfa birden fazla arayüz implement edilebilir.

// AbstractSinif_1‘e AbstractSinif_2 inherit edildiği için, AbstractSinif_1‘den türetilen bir sınıf hem AbstractSinif_1 içerisinde bildirimi yapılmış olan metodu
// (Metot_1()) hem de AbstractSinif_2 içerisinde bildirimi yapılmış olan metodu (Metot_2()) içermek zorundadır. (17-39 arasi)