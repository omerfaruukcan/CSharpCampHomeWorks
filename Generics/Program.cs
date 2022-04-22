using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Istanbul");
            sehirler.Add("Kutahya");
            Console.WriteLine(sehirler.Count);

            MyList<int> plakalar = new MyList<int>();
            plakalar.Add(34);
            plakalar.Add(43);
            Console.WriteLine(plakalar.Count);
        }
    }

    class MyList<T>
    {
        T[] aray;
        T[] tempArray;

        public MyList()
        {
            aray = new T[0];
        }

        public void Add(T item)
        {
            tempArray = aray;
            aray = new T[tempArray.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                aray[i] = tempArray[i];
            }

            aray[aray.Length - 1] = item;
        }

        public int Count
        {
            get { return aray.Length; }
        }

    }
}
