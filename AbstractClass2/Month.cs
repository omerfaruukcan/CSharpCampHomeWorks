using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass2
{
    public abstract class Month
    {
        public int GunlerKacSaattir()
        {
            return 24;
        }

        public virtual int KacGundenOlusur()
        {
            return 31;
        }

        public abstract int YilinKacinciAyidir();
    }
}

// Eğer bir metot tüm türetilmiş sınıflarda aynı şekilde tanımlanıyorsa o metodu abstract sınıf içerisinde standart bir metot tanımlar gibi tanımlarız.

// Eğer bir metot bir çok türetilmiş sınıfta aynı şekilde tanımlanıyor iken sadece bir kaçında değişik şekilde tanımlanıyorsa o metot abstract sınıf içerisinde virtual olarak tanımlanır.

// Eğer bir metot tüm türetilmiş sınıflarda farklı şekilde tanımlanıyorsa o metodun abstract sınıf içerisinde sadece bildirimi yapılır.