using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach (KeyValuePair<int, string> kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            var cities = new Dictionary<string, string>()
            {
                { "UK", "London, Manchester, Birmingham" },
                { "USA", "Chicago, New York, Washington" },
                { "India", "Mumbai, New Delhi, Pune" }
            };

            Console.WriteLine(cities["UK"]);
            Console.WriteLine(cities["USA"]);

            foreach (var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("-----------------------");

            cities["UK"] = "Liverpool, Bristol";
            cities["USA"] = "Los Angeles, Boston";
            cities.Remove("UK");
            cities.Clear();

            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("-----------------------");

            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Omer Faruk", 24);

            for (int i = 0; i < myDictionary.Values.Length; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", myDictionary.Keys[i], myDictionary.Values[i]);
            }
        }

        class MyDictionary<K, V>
        {
            K[] keys;
            V[] values;

            public MyDictionary()
            {
                keys = new K[0];
                values = new V[0];
            }

            public void Add(K key, V value)
            {
                K[] tempArrayKey = keys;
                V[] tempArrayValue = values;

                keys = new K[keys.Length + 1];
                values = new V[values.Length + 1];

                for (int i = 0; i < tempArrayKey.Length; i++)
                {
                    keys[i] = tempArrayKey[i];
                }

                keys[keys.Length - 1] = key;

                for (int i = 0; i < tempArrayValue.Length; i++)
                {
                    values[i] = tempArrayValue[i];
                }

                values[values.Length - 1] = value;
            }

            public K[] Keys
            {
                get { return keys; }
            }

            public V[] Values
            {
                get { return values; }
            }
        }
    }
}
